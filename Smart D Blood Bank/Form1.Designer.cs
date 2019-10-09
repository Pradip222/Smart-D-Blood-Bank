namespace Smart_D_Blood_Bank
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblExit = new System.Windows.Forms.Label();
            this.lblBank = new System.Windows.Forms.Label();
            this.paneltake = new System.Windows.Forms.Panel();
            this.txtPquan = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.BtnSubmitP = new System.Windows.Forms.Button();
            this.txtPblood = new System.Windows.Forms.TextBox();
            this.txtPin = new System.Windows.Forms.TextBox();
            this.txtPaddress = new System.Windows.Forms.TextBox();
            this.txtPname = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnSubmitD = new System.Windows.Forms.Button();
            this.txtDstatus = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtDweight = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtDemail = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtDmobile = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDHB = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDBgrp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtDaddress = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDname = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.paneltake.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.lblExit);
            this.panel1.Controls.Add(this.lblBank);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.BackColor = System.Drawing.Color.MintCream;
            this.lblExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblExit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblExit.Location = new System.Drawing.Point(762, 9);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(26, 25);
            this.lblExit.TabIndex = 1;
            this.lblExit.Text = "X";
            this.lblExit.Click += new System.EventHandler(this.LblExit_Click);
            // 
            // lblBank
            // 
            this.lblBank.AutoSize = true;
            this.lblBank.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBank.ForeColor = System.Drawing.Color.Snow;
            this.lblBank.Location = new System.Drawing.Point(249, 23);
            this.lblBank.Name = "lblBank";
            this.lblBank.Size = new System.Drawing.Size(210, 49);
            this.lblBank.TabIndex = 0;
            this.lblBank.Text = "Blood Bank";
            this.lblBank.Click += new System.EventHandler(this.LblBank_Click);
            // 
            // paneltake
            // 
            this.paneltake.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.paneltake.Controls.Add(this.txtPquan);
            this.paneltake.Controls.Add(this.label18);
            this.paneltake.Controls.Add(this.BtnSubmitP);
            this.paneltake.Controls.Add(this.txtPblood);
            this.paneltake.Controls.Add(this.txtPin);
            this.paneltake.Controls.Add(this.txtPaddress);
            this.paneltake.Controls.Add(this.txtPname);
            this.paneltake.Controls.Add(this.label7);
            this.paneltake.Controls.Add(this.label4);
            this.paneltake.Controls.Add(this.label6);
            this.paneltake.Controls.Add(this.label5);
            this.paneltake.Controls.Add(this.label3);
            this.paneltake.Controls.Add(this.label1);
            this.paneltake.Dock = System.Windows.Forms.DockStyle.Left;
            this.paneltake.Font = new System.Drawing.Font("Calibri Light", 10F, System.Drawing.FontStyle.Bold);
            this.paneltake.Location = new System.Drawing.Point(0, 100);
            this.paneltake.Name = "paneltake";
            this.paneltake.Size = new System.Drawing.Size(385, 514);
            this.paneltake.TabIndex = 1;
            this.paneltake.Paint += new System.Windows.Forms.PaintEventHandler(this.Paneltake_Paint);
            // 
            // txtPquan
            // 
            this.txtPquan.Location = new System.Drawing.Point(128, 301);
            this.txtPquan.Name = "txtPquan";
            this.txtPquan.Size = new System.Drawing.Size(231, 28);
            this.txtPquan.TabIndex = 13;
            this.txtPquan.TextChanged += new System.EventHandler(this.TextBox14_TextChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(36, 310);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(72, 21);
            this.label18.TabIndex = 12;
            this.label18.Text = "Quantity";
            this.label18.Click += new System.EventHandler(this.Label18_Click);
            // 
            // BtnSubmitP
            // 
            this.BtnSubmitP.Font = new System.Drawing.Font("Calibri", 12.2F, System.Drawing.FontStyle.Bold);
            this.BtnSubmitP.Location = new System.Drawing.Point(157, 358);
            this.BtnSubmitP.Name = "BtnSubmitP";
            this.BtnSubmitP.Size = new System.Drawing.Size(100, 41);
            this.BtnSubmitP.TabIndex = 11;
            this.BtnSubmitP.Text = "Submit";
            this.BtnSubmitP.UseVisualStyleBackColor = true;
            this.BtnSubmitP.Click += new System.EventHandler(this.BtnSubmitP_Click);
            // 
            // txtPblood
            // 
            this.txtPblood.Location = new System.Drawing.Point(128, 263);
            this.txtPblood.Name = "txtPblood";
            this.txtPblood.Size = new System.Drawing.Size(231, 28);
            this.txtPblood.TabIndex = 10;
            this.txtPblood.TextChanged += new System.EventHandler(this.TxtPblood_TextChanged);
            // 
            // txtPin
            // 
            this.txtPin.Location = new System.Drawing.Point(128, 225);
            this.txtPin.Name = "txtPin";
            this.txtPin.Size = new System.Drawing.Size(231, 28);
            this.txtPin.TabIndex = 9;
            // 
            // txtPaddress
            // 
            this.txtPaddress.Location = new System.Drawing.Point(128, 187);
            this.txtPaddress.Name = "txtPaddress";
            this.txtPaddress.Size = new System.Drawing.Size(231, 28);
            this.txtPaddress.TabIndex = 8;
            // 
            // txtPname
            // 
            this.txtPname.Location = new System.Drawing.Point(128, 149);
            this.txtPname.Name = "txtPname";
            this.txtPname.Size = new System.Drawing.Size(231, 28);
            this.txtPname.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "Blood Group";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(112, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(218, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "Enter Patient Details";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(41, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 21);
            this.label6.TabIndex = 4;
            this.label6.Text = "Pincode";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 21);
            this.label5.TabIndex = 3;
            this.label5.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(133, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Give to Patient";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.BtnSubmitD);
            this.panel2.Controls.Add(this.txtDstatus);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.txtDweight);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.txtDemail);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.txtDmobile);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.txtDHB);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.txtDBgrp);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtAge);
            this.panel2.Controls.Add(this.txtDaddress);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.txtDname);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(391, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(409, 514);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel2_Paint);
            // 
            // BtnSubmitD
            // 
            this.BtnSubmitD.Font = new System.Drawing.Font("Calibri", 12.2F, System.Drawing.FontStyle.Bold);
            this.BtnSubmitD.Location = new System.Drawing.Point(193, 444);
            this.BtnSubmitD.Name = "BtnSubmitD";
            this.BtnSubmitD.Size = new System.Drawing.Size(100, 41);
            this.BtnSubmitD.TabIndex = 14;
            this.BtnSubmitD.Text = "Submit";
            this.BtnSubmitD.UseVisualStyleBackColor = true;
            this.BtnSubmitD.Click += new System.EventHandler(this.BtnSubmitD_Click);
            // 
            // txtDstatus
            // 
            this.txtDstatus.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtDstatus.Location = new System.Drawing.Point(115, 401);
            this.txtDstatus.Name = "txtDstatus";
            this.txtDstatus.Size = new System.Drawing.Size(258, 28);
            this.txtDstatus.TabIndex = 28;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label17.Location = new System.Drawing.Point(43, 412);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(54, 21);
            this.label17.TabIndex = 27;
            this.label17.Text = "Status";
            // 
            // txtDweight
            // 
            this.txtDweight.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtDweight.Location = new System.Drawing.Point(115, 365);
            this.txtDweight.Name = "txtDweight";
            this.txtDweight.Size = new System.Drawing.Size(258, 28);
            this.txtDweight.TabIndex = 26;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label16.Location = new System.Drawing.Point(43, 375);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(60, 21);
            this.label16.TabIndex = 25;
            this.label16.Text = "Weight";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(89, 57);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(208, 29);
            this.label15.TabIndex = 11;
            this.label15.Text = "Enter Donar Details";
            this.label15.Click += new System.EventHandler(this.Label15_Click);
            // 
            // txtDemail
            // 
            this.txtDemail.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtDemail.Location = new System.Drawing.Point(115, 329);
            this.txtDemail.Name = "txtDemail";
            this.txtDemail.Size = new System.Drawing.Size(258, 28);
            this.txtDemail.TabIndex = 24;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(43, 338);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 21);
            this.label14.TabIndex = 23;
            this.label14.Text = "Email";
            // 
            // txtDmobile
            // 
            this.txtDmobile.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtDmobile.Location = new System.Drawing.Point(115, 293);
            this.txtDmobile.Name = "txtDmobile";
            this.txtDmobile.Size = new System.Drawing.Size(258, 28);
            this.txtDmobile.TabIndex = 22;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(43, 301);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 21);
            this.label13.TabIndex = 21;
            this.label13.Text = "Mobile";
            // 
            // txtDHB
            // 
            this.txtDHB.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtDHB.Location = new System.Drawing.Point(115, 257);
            this.txtDHB.Name = "txtDHB";
            this.txtDHB.Size = new System.Drawing.Size(258, 28);
            this.txtDHB.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(12, 264);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 21);
            this.label12.TabIndex = 19;
            this.label12.Text = "Himoglobin";
            // 
            // txtDBgrp
            // 
            this.txtDBgrp.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtDBgrp.Location = new System.Drawing.Point(115, 221);
            this.txtDBgrp.Name = "txtDBgrp";
            this.txtDBgrp.Size = new System.Drawing.Size(258, 28);
            this.txtDBgrp.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(110, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Take From Donar";
            // 
            // txtAge
            // 
            this.txtAge.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtAge.Location = new System.Drawing.Point(115, 185);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(258, 28);
            this.txtAge.TabIndex = 17;
            // 
            // txtDaddress
            // 
            this.txtDaddress.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtDaddress.Location = new System.Drawing.Point(115, 149);
            this.txtDaddress.Name = "txtDaddress";
            this.txtDaddress.Size = new System.Drawing.Size(258, 28);
            this.txtDaddress.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(51, 116);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 21);
            this.label11.TabIndex = 11;
            this.label11.Text = "Name";
            // 
            // txtDname
            // 
            this.txtDname.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtDname.Location = new System.Drawing.Point(115, 113);
            this.txtDname.Name = "txtDname";
            this.txtDname.Size = new System.Drawing.Size(258, 28);
            this.txtDname.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(36, 153);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 21);
            this.label10.TabIndex = 12;
            this.label10.Text = "Address";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(4, 227);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 21);
            this.label8.TabIndex = 14;
            this.label8.Text = "Blood Group";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(37, 190);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 21);
            this.label9.TabIndex = 13;
            this.label9.Text = "Age";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 614);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.paneltake);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Bank";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.paneltake.ResumeLayout(false);
            this.paneltake.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblBank;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Panel paneltake;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPblood;
        private System.Windows.Forms.TextBox txtPin;
        private System.Windows.Forms.TextBox txtPaddress;
        private System.Windows.Forms.TextBox txtPname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDBgrp;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtDaddress;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDname;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDmobile;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtDHB;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtDemail;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtPquan;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button BtnSubmitP;
        private System.Windows.Forms.TextBox txtDstatus;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtDweight;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button BtnSubmitD;
    }
}

