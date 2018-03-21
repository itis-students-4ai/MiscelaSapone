using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using comm_arduino;



namespace interfaccia_grafica
{
    public partial class FormMain : Form
    {
        Packet pack;
		
		int io_time = 0;
        int durata = 0;
		CommIO comm;
    
        public FormMain()
        {
            InitializeComponent();
            comm = new CommIO();
        }

        private void b_serial_port_Click(object sender, EventArgs e)
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
            {
                btn_comm.Text = "Close port";
                groupBox1.Enabled = true;
                groupBox2.Enabled = true;
                groupBox3.Enabled = true;

                
            }
            else
            {
                btn_comm.Text = "Open port";
                groupBox1.Enabled = false;
                groupBox2.Enabled = false;
                groupBox3.Enabled = false;
            }
        }


        private void FormMain_Load(object sender, EventArgs e)
        {
            {
                if (comm.n_port > 0)
                {
                    for (int i = 0; i < comm.n_port; i++)
                        cb_port.Items.Add(comm.ports[i]);
                    cb_port.SelectedIndex = 0;
                }

                btn_comm.Enabled = comm.n_port > 0;
            }

        }

        //Handler Set temperatura
        private void text_tmp_TextChanged(object sender, EventArgs e)
        {
            byte tmp = Convert.ToByte(text_tmp.Text);
            pack = protoc.SetTemp(tmp);
        }

        //Handler Set movimentazione
        private void text_mov_TextChanged(object sender, EventArgs e)
        {
            byte mov = Convert.ToByte(text_mov.Text);
            pack = protoc.SetMotor(2, mov);
        }


        //Handler bottone invia temperatura obiettiva
        private void btn_tmp_obb_Click(object sender, EventArgs e)
        {
            bool res = comm.MakeRequest(pack);

            ShowResult(pack.err);
            if (!res)
                return;

            // elabora il risultato ...
        }

        //Visualizza messaggio
        void ShowResult(int err_idx)
        {
            lab_msg.Text = CommIO.err_str[err_idx];
        }

        //Handler bottone richiesta temperatura attuale
        /*private void btn_REQ_Click(object sender, EventArgs e)
        {
            pack = protoc.GetTemp();
            bool res = comm.MakeRequest(pack);
            ShowResult(pack.err);
            if (!res)
                return;

            // elabora la temperatura
            float t = (pack.res[3] * 0x100 + pack.res[4]) / 10f;
            lab_msg.Text = "Ricevuto"; 
            text_temp.Text = String.Format("{0}", t*10); 
        }*/

        //Hanler bottone invia movimentazione
        private void btn_mov_Click(object sender, EventArgs e)
        {
            bool res = comm.MakeRequest(pack);

            ShowResult(pack.err);
            if (!res)
                return;

            // elabora il risultato ...
        }

        //Handler bottone AVVIA
        private void btn_AVVIA_Click(object sender, EventArgs e)
        {
            timer_durata.Start();
            timer_GetTemp.Start();
            durata = Convert.ToInt32(text_durata.Text);

            //blocco bottone
            btn_AVVIA.Enabled = false;
            btn_AVVIA.BackColor = Color.DarkSeaGreen;
        }

        //Handler bottone STOP
        private void btn_STOP_Click(object sender, EventArgs e)
        {

        }

        private void timer_durata_Tick(object sender, EventArgs e)
        {
            io_time += 1;
            
            if(io_time <= durata)
                text_tempo.Text = Convert.ToString(io_time);
        }

        private void btn_tmp_imp_Click(object sender, EventArgs e)
        {
            byte drt = Convert.ToByte(text_durata.Text);
            pack = protoc.SetTime(drt);

            durata = Convert.ToInt32(text_durata.Text);
        }

        private void timer_GetTemp_Tick(object sender, EventArgs e)
        {
            pack = protoc.GetTemp();
            bool res = comm.MakeRequest(pack);
            ShowResult(pack.err);
            if (!res)
                return;

            // elabora la temperatura
            float t = (pack.res[3] * 0x100 + pack.res[4]) / 10f;
            lab_msg.Text = "Ricevuto";
            text_temp.Text = String.Format("{0}", t * 10); 
        }

        

    }

}

       

    

