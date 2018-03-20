namespace comm_arduino
{
	partial class FormMain
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.btn_comm = new System.Windows.Forms.Button();
			this.cb_port = new System.Windows.Forms.ComboBox();
			this.btn_send = new System.Windows.Forms.Button();
			this.base_time = new System.Windows.Forms.Timer(this.components);
			this.lab_msg = new System.Windows.Forms.Label();
			this.btn_REQ = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btn_comm
			// 
			this.btn_comm.Location = new System.Drawing.Point(31, 38);
			this.btn_comm.Margin = new System.Windows.Forms.Padding(4);
			this.btn_comm.Name = "btn_comm";
			this.btn_comm.Size = new System.Drawing.Size(125, 43);
			this.btn_comm.TabIndex = 0;
			this.btn_comm.Text = "Open Comm";
			this.btn_comm.UseVisualStyleBackColor = true;
			this.btn_comm.Click += new System.EventHandler(this.btn_comm_Click);
			// 
			// cb_port
			// 
			this.cb_port.FormattingEnabled = true;
			this.cb_port.Location = new System.Drawing.Point(164, 48);
			this.cb_port.Margin = new System.Windows.Forms.Padding(4);
			this.cb_port.Name = "cb_port";
			this.cb_port.Size = new System.Drawing.Size(128, 24);
			this.cb_port.TabIndex = 1;
			// 
			// btn_send
			// 
			this.btn_send.Location = new System.Drawing.Point(31, 113);
			this.btn_send.Margin = new System.Windows.Forms.Padding(4);
			this.btn_send.Name = "btn_send";
			this.btn_send.Size = new System.Drawing.Size(100, 39);
			this.btn_send.TabIndex = 3;
			this.btn_send.Text = "Test Send";
			this.btn_send.UseVisualStyleBackColor = true;
			this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
			// 
			// base_time
			// 
			this.base_time.Interval = 20;
			this.base_time.Tick += new System.EventHandler(this.base_time_Tick);
			// 
			// lab_msg
			// 
			this.lab_msg.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.lab_msg.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.lab_msg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lab_msg.Location = new System.Drawing.Point(0, 421);
			this.lab_msg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lab_msg.Name = "lab_msg";
			this.lab_msg.Size = new System.Drawing.Size(583, 29);
			this.lab_msg.TabIndex = 4;
			this.lab_msg.Text = "PROVA";
			this.lab_msg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btn_REQ
			// 
			this.btn_REQ.Location = new System.Drawing.Point(31, 160);
			this.btn_REQ.Margin = new System.Windows.Forms.Padding(4);
			this.btn_REQ.Name = "btn_REQ";
			this.btn_REQ.Size = new System.Drawing.Size(100, 39);
			this.btn_REQ.TabIndex = 5;
			this.btn_REQ.Text = "Test REQ";
			this.btn_REQ.UseVisualStyleBackColor = true;
			this.btn_REQ.Click += new System.EventHandler(this.btn_REQ_Click);
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(583, 450);
			this.Controls.Add(this.btn_REQ);
			this.Controls.Add(this.lab_msg);
			this.Controls.Add(this.btn_send);
			this.Controls.Add(this.cb_port);
			this.Controls.Add(this.btn_comm);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "FormMain";
			this.Text = "Form1";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
			this.Load += new System.EventHandler(this.FormMain_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btn_comm;
		private System.Windows.Forms.ComboBox cb_port;
		private System.Windows.Forms.Button btn_send;
		private System.Windows.Forms.Timer base_time;
		private System.Windows.Forms.Label lab_msg;
		private System.Windows.Forms.Button btn_REQ;
	}
}

