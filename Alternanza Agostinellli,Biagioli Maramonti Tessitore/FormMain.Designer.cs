namespace interfaccia_grafica
{
    partial class FormMain
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Liberare le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.text_tmp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.text_durata = new System.Windows.Forms.TextBox();
            this.text_mov = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_REQ = new System.Windows.Forms.Button();
            this.btn_tmp_obb = new System.Windows.Forms.Button();
            this.text_temp = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_STOP = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_mov = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_tmp_imp = new System.Windows.Forms.Button();
            this.text_tempo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_port = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_comm = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lab_msg = new System.Windows.Forms.TextBox();
            this.btn_AVVIA = new System.Windows.Forms.Button();
            this.timer_durata = new System.Windows.Forms.Timer(this.components);
            this.timer_GetTemp = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // text_tmp
            // 
            this.text_tmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_tmp.Location = new System.Drawing.Point(30, 117);
            this.text_tmp.Name = "text_tmp";
            this.text_tmp.Size = new System.Drawing.Size(105, 49);
            this.text_tmp.TabIndex = 0;
            this.text_tmp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.text_tmp.TextChanged += new System.EventHandler(this.text_tmp_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "OBIETTIVO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "% DI MOVIMENTAZIONE";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "IMPOSTATA";
            // 
            // text_durata
            // 
            this.text_durata.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.text_durata.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_durata.Location = new System.Drawing.Point(46, 117);
            this.text_durata.Name = "text_durata";
            this.text_durata.Size = new System.Drawing.Size(92, 49);
            this.text_durata.TabIndex = 7;
            this.text_durata.Text = "0";
            this.text_durata.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_mov
            // 
            this.text_mov.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_mov.Location = new System.Drawing.Point(30, 123);
            this.text_mov.Name = "text_mov";
            this.text_mov.Size = new System.Drawing.Size(171, 47);
            this.text_mov.TabIndex = 8;
            this.text_mov.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.text_mov.TextChanged += new System.EventHandler(this.text_mov_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btn_REQ);
            this.groupBox1.Controls.Add(this.btn_tmp_obb);
            this.groupBox1.Controls.Add(this.text_temp);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.text_tmp);
            this.groupBox1.Enabled = false;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(511, 285);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TEMPERATURA";
            // 
            // btn_REQ
            // 
            this.btn_REQ.Location = new System.Drawing.Point(271, 188);
            this.btn_REQ.Name = "btn_REQ";
            this.btn_REQ.Size = new System.Drawing.Size(109, 37);
            this.btn_REQ.TabIndex = 7;
            this.btn_REQ.Text = "Richiesta";
            this.btn_REQ.UseVisualStyleBackColor = true;
            // 
            // btn_tmp_obb
            // 
            this.btn_tmp_obb.Location = new System.Drawing.Point(30, 188);
            this.btn_tmp_obb.Name = "btn_tmp_obb";
            this.btn_tmp_obb.Size = new System.Drawing.Size(78, 37);
            this.btn_tmp_obb.TabIndex = 6;
            this.btn_tmp_obb.Text = "INVIA";
            this.btn_tmp_obb.UseVisualStyleBackColor = true;
            this.btn_tmp_obb.Click += new System.EventHandler(this.btn_tmp_obb_Click);
            // 
            // text_temp
            // 
            this.text_temp.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_temp.Location = new System.Drawing.Point(271, 117);
            this.text_temp.Name = "text_temp";
            this.text_temp.Size = new System.Drawing.Size(109, 49);
            this.text_temp.TabIndex = 5;
            this.text_temp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(266, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 25);
            this.label9.TabIndex = 4;
            this.label9.Text = "ATTUALE";
            // 
            // btn_STOP
            // 
            this.btn_STOP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_STOP.BackColor = System.Drawing.Color.Red;
            this.btn_STOP.Location = new System.Drawing.Point(885, 594);
            this.btn_STOP.Name = "btn_STOP";
            this.btn_STOP.Size = new System.Drawing.Size(114, 67);
            this.btn_STOP.TabIndex = 14;
            this.btn_STOP.Text = "STOP";
            this.btn_STOP.UseVisualStyleBackColor = false;
            this.btn_STOP.Click += new System.EventHandler(this.btn_STOP_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox2.Controls.Add(this.btn_mov);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.text_mov);
            this.groupBox2.Enabled = false;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(12, 303);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(511, 285);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "MOVIMENTAZIONE";
            // 
            // btn_mov
            // 
            this.btn_mov.Location = new System.Drawing.Point(30, 196);
            this.btn_mov.Name = "btn_mov";
            this.btn_mov.Size = new System.Drawing.Size(94, 32);
            this.btn_mov.TabIndex = 9;
            this.btn_mov.Text = "INVIA";
            this.btn_mov.UseVisualStyleBackColor = true;
            this.btn_mov.Click += new System.EventHandler(this.btn_mov_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.AutoSize = true;
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.btn_tmp_imp);
            this.groupBox3.Controls.Add(this.text_tempo);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.text_durata);
            this.groupBox3.Enabled = false;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(563, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(511, 285);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "TEMPI";
            // 
            // btn_tmp_imp
            // 
            this.btn_tmp_imp.Location = new System.Drawing.Point(46, 201);
            this.btn_tmp_imp.Name = "btn_tmp_imp";
            this.btn_tmp_imp.Size = new System.Drawing.Size(75, 34);
            this.btn_tmp_imp.TabIndex = 9;
            this.btn_tmp_imp.Text = "INVIA";
            this.btn_tmp_imp.UseVisualStyleBackColor = true;
            this.btn_tmp_imp.Click += new System.EventHandler(this.btn_tmp_imp_Click);
            // 
            // text_tempo
            // 
            this.text_tempo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.text_tempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_tempo.Location = new System.Drawing.Point(303, 117);
            this.text_tempo.Name = "text_tempo";
            this.text_tempo.Size = new System.Drawing.Size(99, 49);
            this.text_tempo.TabIndex = 8;
            this.text_tempo.Text = "0";
            this.text_tempo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(299, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 25);
            this.label8.TabIndex = 6;
            this.label8.Text = "CORRENTE";
            // 
            // cb_port
            // 
            this.cb_port.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_port.FormattingEnabled = true;
            this.cb_port.Location = new System.Drawing.Point(40, 95);
            this.cb_port.Name = "cb_port";
            this.cb_port.Size = new System.Drawing.Size(143, 32);
            this.cb_port.TabIndex = 15;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox4.Controls.Add(this.btn_comm);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.cb_port);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.Black;
            this.groupBox4.Location = new System.Drawing.Point(563, 303);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(511, 285);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "PORTA SERIALE";
            // 
            // btn_comm
            // 
            this.btn_comm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_comm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_comm.ForeColor = System.Drawing.Color.Black;
            this.btn_comm.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_comm.Location = new System.Drawing.Point(40, 159);
            this.btn_comm.Name = "btn_comm";
            this.btn_comm.Size = new System.Drawing.Size(353, 69);
            this.btn_comm.TabIndex = 19;
            this.btn_comm.Text = "OPEN";
            this.btn_comm.UseVisualStyleBackColor = true;
            this.btn_comm.Click += new System.EventHandler(this.b_serial_port_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(261, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "BAUD RATE";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(266, 95);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(127, 35);
            this.textBox1.TabIndex = 17;
            this.textBox1.Text = "38400";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "COM";
            // 
            // lab_msg
            // 
            this.lab_msg.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lab_msg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_msg.Location = new System.Drawing.Point(0, 680);
            this.lab_msg.Name = "lab_msg";
            this.lab_msg.Size = new System.Drawing.Size(1100, 24);
            this.lab_msg.TabIndex = 6;
            this.lab_msg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_AVVIA
            // 
            this.btn_AVVIA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_AVVIA.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_AVVIA.ForeColor = System.Drawing.Color.Black;
            this.btn_AVVIA.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_AVVIA.Location = new System.Drawing.Point(738, 594);
            this.btn_AVVIA.Name = "btn_AVVIA";
            this.btn_AVVIA.Size = new System.Drawing.Size(125, 67);
            this.btn_AVVIA.TabIndex = 11;
            this.btn_AVVIA.Text = "AVVIA";
            this.btn_AVVIA.UseVisualStyleBackColor = false;
            this.btn_AVVIA.Click += new System.EventHandler(this.btn_AVVIA_Click);
            // 
            // timer_durata
            // 
            this.timer_durata.Interval = 1000;
            this.timer_durata.Tick += new System.EventHandler(this.timer_durata_Tick);
            // 
            // timer_GetTemp
            // 
            this.timer_GetTemp.Interval = 2000;
            this.timer_GetTemp.Tick += new System.EventHandler(this.timer_GetTemp_Tick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1100, 704);
            this.Controls.Add(this.lab_msg);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btn_AVVIA);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_STOP);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormMain";
            this.Text = " ";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_tmp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox text_durata;
        private System.Windows.Forms.TextBox text_mov;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_STOP;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox text_temp;
        private System.Windows.Forms.ComboBox cb_port;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_comm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lab_msg;
        private System.Windows.Forms.Button btn_tmp_obb;
        private System.Windows.Forms.Button btn_tmp_imp;
        private System.Windows.Forms.Button btn_mov;
        private System.Windows.Forms.Button btn_AVVIA;
        private System.Windows.Forms.Button btn_REQ;
        private System.Windows.Forms.Timer timer_durata;
        private System.Windows.Forms.TextBox text_tempo;
        private System.Windows.Forms.Timer timer_GetTemp;
    }
}

