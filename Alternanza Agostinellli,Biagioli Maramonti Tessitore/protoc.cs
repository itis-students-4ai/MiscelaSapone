using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace comm_arduino
{
	public class protoc
	{
		static Packet pack;

		// caratteri speciali
		public const byte STX = 0xA5;
		public const byte ACK = 0x5A;

		public const byte P_LEN = 2;	// posizione del len bye nel pacchetto
		public const byte P_DATA = 3;	// posizione del payload nel pacchetto

		// tipi di pacchetto SET
		const byte SET_MODE = 0x01;	// modalità del sistema 0: stop; 1: on;
		const byte SET_TEMP = 0x02;	// tempeatura
		const byte SET_MOT = 0x03;	// movimentazione
		const byte SET_TIME = 0x04;	// durata

		// tipi di pacchetto GET
		const byte GET_TEMP = 0x12;	// richiesta temperatura
		const byte GET_ERR = 0x15;	// richiesta eventuali errori

		// tempi
		public const int ACK_TOUT = 50;	// 50 ms per ricevere l'ack
		public const int DATA_TOUT = 100;	// 100 ms per ricevere il pacchetto

		// costruttore
		public protoc()
		{

		}

		#region Costruzione Pacchetti ...
		// Costruzione pacchetto SET_MOTOR
		public static Packet SetMotor(byte n_motor, short step)
		{
			pack = new Packet();
			byte k = 0;
			pack.msg[k++] = STX;
			pack.msg[k++] = SET_MOT;
			pack.msg[k++] = 3;
			pack.msg[k++] = n_motor;
			pack.msg[k++] = (byte) (step >> 8);
			pack.msg[k++] = (byte) (step & 0xFF);
			pack.msg[k++] = Check( pack.msg, k);	// spazio per il checksum
			pack.msg_len = k;
									  
			return pack;
		}

		// Costruzione pacchetto SET_TEMP
		public static Packet SetTemp(ushort temp)
		{
			pack = new Packet();
			byte k = 0;
			pack.msg[k++] = STX;
			pack.msg[k++] = SET_TEMP;
			pack.msg[k++] = 2;
			pack.msg[k++] = (byte) (temp >> 8);
			pack.msg[k++] = (byte) temp;
			pack.msg[k++] = Check(pack.msg, k);	// spazio per il checksum
			pack.msg_len = k;

			return pack;
		}

		// Costruzione pacchetto SET_TIME (time in sec)
		public static Packet SetTime(byte time)
		{
			pack = new Packet();
			byte k = 0;
			pack.msg[k++] = STX;
			pack.msg[k++] = SET_TIME;
			pack.msg[k++] = 2;
			pack.msg[k++] = (byte)(time >> 8);		// parte alta 
			pack.msg[k++] = (byte)(time & 0xFF);	// parte bassa

			pack.msg[k++] = Check(pack.msg, k);		// spazio per il checksum
			pack.msg_len = k;

			return pack;
		}

		// Costruzione pacchetto SET_MODE (mode: 0 = OFF, 1=ON)
		public static Packet SetMode(byte mode)
		{
			pack = new Packet();
			byte k = 0;
			pack.msg[k++] = STX;
			pack.msg[k++] = SET_TIME;
			pack.msg[k++] = 1;
			pack.msg[k++] = mode;	

			pack.msg[k++] = Check(pack.msg, k);	// spazio per il checksum
			pack.msg_len = k;

			return pack;
		}
 
		// Costruzione pacchetto GET_TEMP (mode: 0 = OFF, 1=ON)
		public static Packet GetTemp()
		{
			pack = new Packet();
			byte k = 0;
			pack.msg[k++] = STX;
			pack.msg[k++] = GET_TEMP;
			pack.msg[k++] = 0;
			pack.msg[k++] = Check(pack.msg, k);	// spazio per il checksum
			pack.msg_len = k;

			return pack;
		}
		#endregion 

		// calcolo del checksum del pacchetto
		public static byte Check(byte[] v, byte len)
		{
			byte chk = 0;
			for (int i = 0; i < len; i++)
				chk += v[i];

			return chk; 
		}
	}




}
