using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.IO.Ports;
using System.Diagnostics;

namespace comm_arduino
{
	public enum IO_Status
	{
		SEND,
		WAIT_ACK,
		RECEIVE,
		RETRY,
		END
	}

	// class di cominicazione seriale
	public class CommIO
	{
		public const byte E_OK = 0;
		public const byte E_BUSY = 1;
		public const byte E_TOUT = 2;
		public const byte E_CHECK = 3;

		public static string [] err_str = new string[] 
		{
									  "OK",
									  "COMM IS BUSY",
									  "TIMEOUT",
									  "CHECKSUM ERROR",
		};

		public bool ready;
		public Packet io_pack;		// reference ad un oggetto Packet passato dal client
		SerialPort port;
		public bool is_open = false;
		
		public string[] ports;
		public int n_port = 0;

		public CommIO()
		{
			ports = SerialPort.GetPortNames();
			n_port = ports.Length;
			port = new SerialPort();
		}

		public bool Stop()
		{
			// era aperta
			if (port.IsOpen)
			{
				port.Close();
 				is_open = false;
  			}
			return is_open;
 		}

		public bool Start(int idx)
		{
 			// era chiusa
			port.PortName = ports[idx];
			port.BaudRate = 38400;
			port.Open();

			Thread.Sleep(150);

			is_open =  port.IsOpen;
			io_pack = null;
			return is_open;
		}

		// Versione bloccante della richiesta
 		// Se c'è già una comunicazione in corso la richiesta fallisce
		// Altrimenti si resta in attesa della risposta con o senza successo
		public bool MakeRequest(Packet pack)
		{
			if (io_pack != null)	// comunicazione in corso
			{
				pack.err = E_BUSY;
				return false;
			}
			io_pack = pack;

			// attiva il processo di trasmissione
			return SendReceive();
		}
	

   		// timer del sistema 
		bool SendReceive()
		{
			Stopwatch sw = new Stopwatch();
			int in_idx = 0;
			int in_len = 0xFF;
 			IO_Status io_stat = IO_Status.SEND;
			
			do
			{
 				// c'è un pacchetto da spedire?
				switch (io_stat)
				{
					case IO_Status.SEND:

						// inizia trasmissione
						port.DiscardInBuffer();
						port.Write(io_pack.msg, 0, io_pack.msg_len);
						io_pack.n_rep++;
						io_pack.err = 0;
						in_idx = 0;
						in_len = 0xFF;
						io_stat = IO_Status.WAIT_ACK;
						sw.Start();			// start orologio
						break;

					case IO_Status.WAIT_ACK:

						if (port.BytesToRead > 0)
						{
							byte ch = (byte)port.ReadByte();

							if (ch == protoc.ACK)
							{
								sw.Stop();

								// se il pacchetto non aspetta risposta termina
								if ((io_pack.msg[1] & 0xF0) == 0)
								{
									io_stat = IO_Status.END;
									break;
								}

								// passa in attesa dati
								in_idx = 0;
								io_stat = IO_Status.RECEIVE;
								sw.Start();
							}
							break;
						}

						// timeout in ricezione?
						if (sw.ElapsedMilliseconds > protoc.ACK_TOUT) // timeout
						{
							io_stat = IO_Status.RETRY;
							break;
						}
						Thread.Sleep(10);
						break;

					case IO_Status.RECEIVE:

						if ( port.BytesToRead > 0 )
						{
							byte ch = (byte)port.ReadByte();

							if (in_idx == 2)
								in_len = ch + 3;

							io_pack.res[in_idx++] = ch;
							if (in_idx == in_len + 1)
							{
								sw.Stop();
								if (ch != protoc.Check(io_pack.res, (byte)(in_len)))
									io_pack.err = E_CHECK;

								io_stat = IO_Status.END;
  							}
							break;
						}

						// timeout in ricezione?
						if (sw.ElapsedMilliseconds > protoc.DATA_TOUT)
						{
							io_stat = IO_Status.RETRY;
							break;
						}
						Thread.Sleep(10);
						break;

					case IO_Status.RETRY:

						sw.Stop();

						if (io_pack.n_rep == 3)	// tre tentativi falliti
						{
							io_pack.err = E_TOUT;
							io_stat = IO_Status.END;
							break;
						}

						io_stat = IO_Status.SEND;	// riprova
						break;

					case IO_Status.END:

						bool res = io_pack.err == 0;
						io_pack = null;
						return res;
 				}

			} while (true);

		}

	}
}
