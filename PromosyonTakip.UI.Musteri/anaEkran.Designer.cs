namespace PromosyonTakip.UI.Musteri
{
    partial class anaEkran
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
            this.gpMusteriBilgileri = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTcKimlikNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIsim = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoyisim = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDogumTarih = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMeslek = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.chkEpostaOnay = new System.Windows.Forms.CheckBox();
            this.txtEposta = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.chkSmsOnay = new System.Windows.Forms.CheckBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.hediyePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.gpMusteriBilgileri.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpMusteriBilgileri
            // 
            this.gpMusteriBilgileri.Controls.Add(this.button2);
            this.gpMusteriBilgileri.Controls.Add(this.btnKaydet);
            this.gpMusteriBilgileri.Controls.Add(this.chkSmsOnay);
            this.gpMusteriBilgileri.Controls.Add(this.chkEpostaOnay);
            this.gpMusteriBilgileri.Controls.Add(this.cmbCinsiyet);
            this.gpMusteriBilgileri.Controls.Add(this.txtDogumTarih);
            this.gpMusteriBilgileri.Controls.Add(this.label7);
            this.gpMusteriBilgileri.Controls.Add(this.label8);
            this.gpMusteriBilgileri.Controls.Add(this.label4);
            this.gpMusteriBilgileri.Controls.Add(this.label5);
            this.gpMusteriBilgileri.Controls.Add(this.txtTelefon);
            this.gpMusteriBilgileri.Controls.Add(this.txtEposta);
            this.gpMusteriBilgileri.Controls.Add(this.txtMeslek);
            this.gpMusteriBilgileri.Controls.Add(this.label6);
            this.gpMusteriBilgileri.Controls.Add(this.txtSoyisim);
            this.gpMusteriBilgileri.Controls.Add(this.label3);
            this.gpMusteriBilgileri.Controls.Add(this.txtIsim);
            this.gpMusteriBilgileri.Controls.Add(this.label2);
            this.gpMusteriBilgileri.Controls.Add(this.txtTcKimlikNo);
            this.gpMusteriBilgileri.Controls.Add(this.label1);
            this.gpMusteriBilgileri.Location = new System.Drawing.Point(447, 12);
            this.gpMusteriBilgileri.Name = "gpMusteriBilgileri";
            this.gpMusteriBilgileri.Size = new System.Drawing.Size(291, 426);
            this.gpMusteriBilgileri.TabIndex = 0;
            this.gpMusteriBilgileri.TabStop = false;
            this.gpMusteriBilgileri.Text = "Müşteri Bilgileri";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC Kimlik Numara";
            // 
            // txtTcKimlikNo
            // 
            this.txtTcKimlikNo.Location = new System.Drawing.Point(103, 55);
            this.txtTcKimlikNo.Name = "txtTcKimlikNo";
            this.txtTcKimlikNo.Size = new System.Drawing.Size(176, 20);
            this.txtTcKimlikNo.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "İsim";
            // 
            // txtIsim
            // 
            this.txtIsim.Location = new System.Drawing.Point(103, 81);
            this.txtIsim.Name = "txtIsim";
            this.txtIsim.Size = new System.Drawing.Size(176, 20);
            this.txtIsim.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Soyisim";
            // 
            // txtSoyisim
            // 
            this.txtSoyisim.Location = new System.Drawing.Point(103, 107);
            this.txtSoyisim.Name = "txtSoyisim";
            this.txtSoyisim.Size = new System.Drawing.Size(176, 20);
            this.txtSoyisim.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Doğum Tarihi";
            // 
            // txtDogumTarih
            // 
            this.txtDogumTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDogumTarih.Location = new System.Drawing.Point(103, 133);
            this.txtDogumTarih.MaxDate = new System.DateTime(2000, 12, 31, 0, 0, 0, 0);
            this.txtDogumTarih.MinDate = new System.DateTime(1980, 1, 1, 0, 0, 0, 0);
            this.txtDogumTarih.Name = "txtDogumTarih";
            this.txtDogumTarih.Size = new System.Drawing.Size(176, 20);
            this.txtDogumTarih.TabIndex = 3;
            this.txtDogumTarih.Value = new System.DateTime(2000, 12, 31, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Cinsiyet";
            // 
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.FormattingEnabled = true;
            this.cmbCinsiyet.Location = new System.Drawing.Point(103, 159);
            this.cmbCinsiyet.Name = "cmbCinsiyet";
            this.cmbCinsiyet.Size = new System.Drawing.Size(176, 21);
            this.cmbCinsiyet.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Meslek";
            // 
            // txtMeslek
            // 
            this.txtMeslek.Location = new System.Drawing.Point(103, 186);
            this.txtMeslek.Name = "txtMeslek";
            this.txtMeslek.Size = new System.Drawing.Size(176, 20);
            this.txtMeslek.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 215);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "E-mail Adres";
            // 
            // chkEpostaOnay
            // 
            this.chkEpostaOnay.AutoSize = true;
            this.chkEpostaOnay.Location = new System.Drawing.Point(103, 239);
            this.chkEpostaOnay.Name = "chkEpostaOnay";
            this.chkEpostaOnay.Size = new System.Drawing.Size(167, 17);
            this.chkEpostaOnay.TabIndex = 7;
            this.chkEpostaOnay.Text = "E-mail bildirimi  almak istiyorum";
            this.chkEpostaOnay.UseVisualStyleBackColor = true;
            // 
            // txtEposta
            // 
            this.txtEposta.Location = new System.Drawing.Point(103, 212);
            this.txtEposta.Name = "txtEposta";
            this.txtEposta.Size = new System.Drawing.Size(176, 20);
            this.txtEposta.TabIndex = 6;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(103, 262);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(176, 20);
            this.txtTelefon.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Telefon";
            // 
            // chkSmsOnay
            // 
            this.chkSmsOnay.AutoSize = true;
            this.chkSmsOnay.Location = new System.Drawing.Point(103, 289);
            this.chkSmsOnay.Name = "chkSmsOnay";
            this.chkSmsOnay.Size = new System.Drawing.Size(162, 17);
            this.chkSmsOnay.TabIndex = 9;
            this.chkSmsOnay.Text = "SMS bildirimi  almak istiyorum";
            this.chkSmsOnay.UseVisualStyleBackColor = true;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(103, 312);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(176, 21);
            this.btnKaydet.TabIndex = 10;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(103, 340);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(176, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "İptal";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // hediyePanel
            // 
            this.hediyePanel.Location = new System.Drawing.Point(13, 12);
            this.hediyePanel.Name = "hediyePanel";
            this.hediyePanel.Size = new System.Drawing.Size(428, 426);
            this.hediyePanel.TabIndex = 1;
            // 
            // anaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 450);
            this.Controls.Add(this.hediyePanel);
            this.Controls.Add(this.gpMusteriBilgileri);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "anaEkran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Promosyon Müşteri Takip Ekranı";
            this.gpMusteriBilgileri.ResumeLayout(false);
            this.gpMusteriBilgileri.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpMusteriBilgileri;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.CheckBox chkSmsOnay;
        private System.Windows.Forms.CheckBox chkEpostaOnay;
        private System.Windows.Forms.ComboBox cmbCinsiyet;
        private System.Windows.Forms.DateTimePicker txtDogumTarih;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtEposta;
        private System.Windows.Forms.TextBox txtMeslek;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSoyisim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIsim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTcKimlikNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel hediyePanel;
    }
}