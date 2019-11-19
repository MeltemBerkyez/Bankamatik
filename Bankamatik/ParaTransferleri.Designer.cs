namespace Bankamatik
{
    partial class ParaTransferleri
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
            this.label1 = new System.Windows.Forms.Label();
            this.IBANpnl = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.HESAPpnl = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_HesapTutar = new System.Windows.Forms.TextBox();
            this.txt_HesapNo = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.IBANpnl.SuspendLayout();
            this.HESAPpnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(50, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "YAPMAK İSTEDİĞİNİZ İŞLEMİ SEÇİN";
            // 
            // IBANpnl
            // 
            this.IBANpnl.Controls.Add(this.button1);
            this.IBANpnl.Controls.Add(this.label3);
            this.IBANpnl.Controls.Add(this.textBox1);
            this.IBANpnl.Controls.Add(this.maskedTextBox1);
            this.IBANpnl.Controls.Add(this.label2);
            this.IBANpnl.Location = new System.Drawing.Point(16, 64);
            this.IBANpnl.Name = "IBANpnl";
            this.IBANpnl.Size = new System.Drawing.Size(272, 197);
            this.IBANpnl.TabIndex = 3;
            this.IBANpnl.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(219, 44);
            this.button1.TabIndex = 5;
            this.button1.Text = "GONDER";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(22, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "TUTAR";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 94);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(219, 20);
            this.textBox1.TabIndex = 3;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskedTextBox1.Location = new System.Drawing.Point(22, 41);
            this.maskedTextBox1.Mask = "TR 00 0000 0000 0000 0000 0000 00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(219, 23);
            this.maskedTextBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(19, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 1;
            this.label2.Tag = "";
            this.label2.Text = "IBAN";
            // 
            // HESAPpnl
            // 
            this.HESAPpnl.Controls.Add(this.button2);
            this.HESAPpnl.Controls.Add(this.label4);
            this.HESAPpnl.Controls.Add(this.txt_HesapTutar);
            this.HESAPpnl.Controls.Add(this.txt_HesapNo);
            this.HESAPpnl.Controls.Add(this.label5);
            this.HESAPpnl.Location = new System.Drawing.Point(329, 64);
            this.HESAPpnl.Name = "HESAPpnl";
            this.HESAPpnl.Size = new System.Drawing.Size(284, 197);
            this.HESAPpnl.TabIndex = 4;
            this.HESAPpnl.Visible = false;
            this.HESAPpnl.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(34, 131);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(233, 44);
            this.button2.TabIndex = 10;
            this.button2.Text = "GONDER";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(34, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "TUTAR";
            // 
            // txt_HesapTutar
            // 
            this.txt_HesapTutar.Location = new System.Drawing.Point(34, 99);
            this.txt_HesapTutar.Name = "txt_HesapTutar";
            this.txt_HesapTutar.Size = new System.Drawing.Size(233, 20);
            this.txt_HesapTutar.TabIndex = 8;
            // 
            // txt_HesapNo
            // 
            this.txt_HesapNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_HesapNo.Location = new System.Drawing.Point(34, 46);
            this.txt_HesapNo.Mask = "                          00000000000";
            this.txt_HesapNo.Name = "txt_HesapNo";
            this.txt_HesapNo.Size = new System.Drawing.Size(233, 23);
            this.txt_HesapNo.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(31, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 17);
            this.label5.TabIndex = 6;
            this.label5.Tag = "";
            this.label5.Text = "HESAP NO";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(100, 27);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(45, 17);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "EFT";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(167, 27);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(67, 17);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "HAVALE";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // ParaTransferleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 266);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.HESAPpnl);
            this.Controls.Add(this.IBANpnl);
            this.Controls.Add(this.label1);
            this.Name = "ParaTransferleri";
            this.Text = "ParaTransferleri";
            this.Load += new System.EventHandler(this.ParaTransferleri_Load);
            this.IBANpnl.ResumeLayout(false);
            this.IBANpnl.PerformLayout();
            this.HESAPpnl.ResumeLayout(false);
            this.HESAPpnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel IBANpnl;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel HESAPpnl;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_HesapTutar;
        private System.Windows.Forms.MaskedTextBox txt_HesapNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}