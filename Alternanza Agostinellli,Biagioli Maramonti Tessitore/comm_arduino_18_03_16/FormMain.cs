using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace comm_arduino
{
	public partial class FormMain : Form
	{

		Packet pack;
    	CommIO comm;
 
		public FormMain()
		{
			InitializeComponent();
			comm = new CommIO();
		}

		// Impostazioni base
		private void FormMain_Load(object sender, EventArgs e)
		{
			if ( comm.n_port > 0)
			{
				for (int i = 0; i < comm.n_port; i++)
					cb_port.Items.Add(comm.ports[i]);
				cb_port.SelectedIndex = 0;
			}

			btn_comm.Enabled = comm.n_port > 0;
 		}


		private void btn_comm_Click(object sender, EventArgs e)
		{
			if (comm.is_open)
			{
				comm.Stop();
			}
			else
			{
				comm.Start(cb_port.SelectedIndex);
				
			}

			if (comm.is_open)
				btn_comm.Text = "Close port";
			else
				btn_comm.Text = "Open port";
		}

		private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
		{
			comm.Stop();
		}


		private void btn_send_Click(object sender, EventArgs e)
		{
			pack = protoc.SetTemp(450);
			bool res = comm.MakeRequest(pack);

			ShowResult(pack.err);
			if (!res)
				return;

			// elabora il risultato ... 

		}

		private void base_time_Tick(object sender, EventArgs e)
		{
			 // Richieste periodiche al sistema
		}

		// prova una richiesta dati
		private void btn_REQ_Click(object sender, EventArgs e)
		{
			pack = protoc.GetTemp();
			bool res = comm.MakeRequest(pack);
			ShowResult(pack.err);
			if (!res)
				return;

			// elabora la temperatura
			float t = (pack.res[3] * 0x100 + pack.res[4]) / 10f;
			lab_msg.Text = String.Format("ricevuto {0}", t); ;

		}

		void ShowResult(int err_idx)
		{
			lab_msg.Text = CommIO.err_str[err_idx];
		}







	}
}
