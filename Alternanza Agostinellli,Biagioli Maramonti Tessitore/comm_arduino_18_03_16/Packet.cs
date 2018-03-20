using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace comm_arduino
{
	public class Packet
	{
		const byte DIMP = 16;		// dimensione massima di un pacchetto

		public byte[] msg;			// richiesta
		public byte msg_len;
		public byte err;			// errore
		public byte[] res;			// risposta
		public byte res_len;
		public byte n_rep;

		public Packet()
		{
			msg = new byte[DIMP];
			msg_len = 0;
			res = new byte[DIMP];
			res_len = 0;
			err = 0;
			n_rep = 0; 
		}
	}
}
