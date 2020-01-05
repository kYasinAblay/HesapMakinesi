namespace intro_HesapMakinesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnKompleSil = new System.Windows.Forms.Button();
            this.btnDokuz = new System.Windows.Forms.Button();
            this.btnSonyazdiginSayiyiSil = new System.Windows.Forms.Button();
            this.btnYedi = new System.Windows.Forms.Button();
            this.btnSekiz = new System.Windows.Forms.Button();
            this.btnDort = new System.Windows.Forms.Button();
            this.btnUc = new System.Windows.Forms.Button();
            this.btnCarpma = new System.Windows.Forms.Button();
            this.btnAlti = new System.Windows.Forms.Button();
            this.btnIki = new System.Windows.Forms.Button();
            this.btnSifir = new System.Windows.Forms.Button();
            this.btnToplama = new System.Windows.Forms.Button();
            this.btnVirgul = new System.Windows.Forms.Button();
            this.btnCikarma = new System.Windows.Forms.Button();
            this.btnBes = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnTamsayiPN = new System.Windows.Forms.Button();
            this.btnBolme = new System.Windows.Forms.Button();
            this.btnBir = new System.Windows.Forms.Button();
            this.btnEsittir = new System.Windows.Forms.Button();
            this.txtSayi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnKompleSil
            // 
            this.btnKompleSil.Location = new System.Drawing.Point(144, 75);
            this.btnKompleSil.Margin = new System.Windows.Forms.Padding(4);
            this.btnKompleSil.Name = "btnKompleSil";
            this.btnKompleSil.Size = new System.Drawing.Size(47, 43);
            this.btnKompleSil.TabIndex = 0;
            this.btnKompleSil.Text = "C";
            this.btnKompleSil.UseVisualStyleBackColor = true;
            this.btnKompleSil.Click += new System.EventHandler(this.KarakterIslem);
            // 
            // btnDokuz
            // 
            this.btnDokuz.Location = new System.Drawing.Point(144, 126);
            this.btnDokuz.Margin = new System.Windows.Forms.Padding(4);
            this.btnDokuz.Name = "btnDokuz";
            this.btnDokuz.Size = new System.Drawing.Size(47, 43);
            this.btnDokuz.TabIndex = 1;
            this.btnDokuz.Text = "9";
            this.btnDokuz.UseVisualStyleBackColor = true;
            this.btnDokuz.Click += new System.EventHandler(this.sayiYaz);
            // 
            // btnSonyazdiginSayiyiSil
            // 
            this.btnSonyazdiginSayiyiSil.Location = new System.Drawing.Point(89, 75);
            this.btnSonyazdiginSayiyiSil.Margin = new System.Windows.Forms.Padding(4);
            this.btnSonyazdiginSayiyiSil.Name = "btnSonyazdiginSayiyiSil";
            this.btnSonyazdiginSayiyiSil.Size = new System.Drawing.Size(47, 43);
            this.btnSonyazdiginSayiyiSil.TabIndex = 2;
            this.btnSonyazdiginSayiyiSil.Text = "CE";
            this.btnSonyazdiginSayiyiSil.UseVisualStyleBackColor = true;
            this.btnSonyazdiginSayiyiSil.Click += new System.EventHandler(this.KarakterIslem);
            // 
            // btnYedi
            // 
            this.btnYedi.Location = new System.Drawing.Point(35, 126);
            this.btnYedi.Margin = new System.Windows.Forms.Padding(4);
            this.btnYedi.Name = "btnYedi";
            this.btnYedi.Size = new System.Drawing.Size(47, 43);
            this.btnYedi.TabIndex = 3;
            this.btnYedi.Text = "7";
            this.btnYedi.UseVisualStyleBackColor = true;
            this.btnYedi.Click += new System.EventHandler(this.sayiYaz);
            // 
            // btnSekiz
            // 
            this.btnSekiz.Location = new System.Drawing.Point(89, 126);
            this.btnSekiz.Margin = new System.Windows.Forms.Padding(4);
            this.btnSekiz.Name = "btnSekiz";
            this.btnSekiz.Size = new System.Drawing.Size(47, 43);
            this.btnSekiz.TabIndex = 4;
            this.btnSekiz.Text = "8";
            this.btnSekiz.UseVisualStyleBackColor = true;
            this.btnSekiz.Click += new System.EventHandler(this.sayiYaz);
            // 
            // btnDort
            // 
            this.btnDort.Location = new System.Drawing.Point(35, 176);
            this.btnDort.Margin = new System.Windows.Forms.Padding(4);
            this.btnDort.Name = "btnDort";
            this.btnDort.Size = new System.Drawing.Size(47, 43);
            this.btnDort.TabIndex = 5;
            this.btnDort.Text = "4";
            this.btnDort.UseVisualStyleBackColor = true;
            this.btnDort.Click += new System.EventHandler(this.sayiYaz);
            // 
            // btnUc
            // 
            this.btnUc.Location = new System.Drawing.Point(144, 226);
            this.btnUc.Margin = new System.Windows.Forms.Padding(4);
            this.btnUc.Name = "btnUc";
            this.btnUc.Size = new System.Drawing.Size(47, 43);
            this.btnUc.TabIndex = 6;
            this.btnUc.Text = "3";
            this.btnUc.UseVisualStyleBackColor = true;
            this.btnUc.Click += new System.EventHandler(this.sayiYaz);
            // 
            // btnCarpma
            // 
            this.btnCarpma.Location = new System.Drawing.Point(199, 176);
            this.btnCarpma.Margin = new System.Windows.Forms.Padding(4);
            this.btnCarpma.Name = "btnCarpma";
            this.btnCarpma.Size = new System.Drawing.Size(47, 43);
            this.btnCarpma.TabIndex = 7;
            this.btnCarpma.Text = "*";
            this.btnCarpma.UseVisualStyleBackColor = true;
            this.btnCarpma.Click += new System.EventHandler(this.IslemSec);
            // 
            // btnAlti
            // 
            this.btnAlti.Location = new System.Drawing.Point(144, 176);
            this.btnAlti.Margin = new System.Windows.Forms.Padding(4);
            this.btnAlti.Name = "btnAlti";
            this.btnAlti.Size = new System.Drawing.Size(47, 43);
            this.btnAlti.TabIndex = 8;
            this.btnAlti.Text = "6";
            this.btnAlti.UseVisualStyleBackColor = true;
            this.btnAlti.Click += new System.EventHandler(this.sayiYaz);
            // 
            // btnIki
            // 
            this.btnIki.Location = new System.Drawing.Point(89, 226);
            this.btnIki.Margin = new System.Windows.Forms.Padding(4);
            this.btnIki.Name = "btnIki";
            this.btnIki.Size = new System.Drawing.Size(47, 43);
            this.btnIki.TabIndex = 9;
            this.btnIki.Text = "2";
            this.btnIki.UseVisualStyleBackColor = true;
            this.btnIki.Click += new System.EventHandler(this.sayiYaz);
            // 
            // btnSifir
            // 
            this.btnSifir.Location = new System.Drawing.Point(35, 277);
            this.btnSifir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSifir.Name = "btnSifir";
            this.btnSifir.Size = new System.Drawing.Size(101, 43);
            this.btnSifir.TabIndex = 10;
            this.btnSifir.Text = "0";
            this.btnSifir.UseVisualStyleBackColor = true;
            this.btnSifir.Click += new System.EventHandler(this.sayiYaz);
            // 
            // btnToplama
            // 
            this.btnToplama.Location = new System.Drawing.Point(199, 277);
            this.btnToplama.Margin = new System.Windows.Forms.Padding(4);
            this.btnToplama.Name = "btnToplama";
            this.btnToplama.Size = new System.Drawing.Size(47, 43);
            this.btnToplama.TabIndex = 11;
            this.btnToplama.Text = "+";
            this.btnToplama.UseVisualStyleBackColor = true;
            this.btnToplama.Click += new System.EventHandler(this.IslemSec);
            // 
            // btnVirgul
            // 
            this.btnVirgul.Location = new System.Drawing.Point(144, 277);
            this.btnVirgul.Margin = new System.Windows.Forms.Padding(4);
            this.btnVirgul.Name = "btnVirgul";
            this.btnVirgul.Size = new System.Drawing.Size(47, 43);
            this.btnVirgul.TabIndex = 12;
            this.btnVirgul.Text = ",";
            this.btnVirgul.UseVisualStyleBackColor = true;
            this.btnVirgul.Click += new System.EventHandler(this.sayiYaz);
            // 
            // btnCikarma
            // 
            this.btnCikarma.Location = new System.Drawing.Point(199, 226);
            this.btnCikarma.Margin = new System.Windows.Forms.Padding(4);
            this.btnCikarma.Name = "btnCikarma";
            this.btnCikarma.Size = new System.Drawing.Size(47, 43);
            this.btnCikarma.TabIndex = 13;
            this.btnCikarma.Text = "-";
            this.btnCikarma.UseVisualStyleBackColor = true;
            this.btnCikarma.Click += new System.EventHandler(this.IslemSec);
            // 
            // btnBes
            // 
            this.btnBes.Location = new System.Drawing.Point(89, 176);
            this.btnBes.Margin = new System.Windows.Forms.Padding(4);
            this.btnBes.Name = "btnBes";
            this.btnBes.Size = new System.Drawing.Size(47, 43);
            this.btnBes.TabIndex = 14;
            this.btnBes.Text = "5";
            this.btnBes.UseVisualStyleBackColor = true;
            this.btnBes.Click += new System.EventHandler(this.sayiYaz);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(35, 75);
            this.btnSil.Margin = new System.Windows.Forms.Padding(4);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(47, 43);
            this.btnSil.TabIndex = 15;
            this.btnSil.Text = "←";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.KarakterIslem);
            // 
            // btnTamsayiPN
            // 
            this.btnTamsayiPN.Location = new System.Drawing.Point(199, 75);
            this.btnTamsayiPN.Margin = new System.Windows.Forms.Padding(4);
            this.btnTamsayiPN.Name = "btnTamsayiPN";
            this.btnTamsayiPN.Size = new System.Drawing.Size(47, 43);
            this.btnTamsayiPN.TabIndex = 16;
            this.btnTamsayiPN.Tag = "+-";
            this.btnTamsayiPN.Text = "+\r\n-\r\n";
            this.btnTamsayiPN.UseVisualStyleBackColor = true;
            this.btnTamsayiPN.Click += new System.EventHandler(this.KarakterIslem);
            // 
            // btnBolme
            // 
            this.btnBolme.Location = new System.Drawing.Point(199, 126);
            this.btnBolme.Margin = new System.Windows.Forms.Padding(4);
            this.btnBolme.Name = "btnBolme";
            this.btnBolme.Size = new System.Drawing.Size(47, 43);
            this.btnBolme.TabIndex = 17;
            this.btnBolme.Text = "/";
            this.btnBolme.UseVisualStyleBackColor = true;
            this.btnBolme.Click += new System.EventHandler(this.IslemSec);
            // 
            // btnBir
            // 
            this.btnBir.Location = new System.Drawing.Point(35, 226);
            this.btnBir.Margin = new System.Windows.Forms.Padding(4);
            this.btnBir.Name = "btnBir";
            this.btnBir.Size = new System.Drawing.Size(47, 43);
            this.btnBir.TabIndex = 18;
            this.btnBir.Text = "1";
            this.btnBir.UseVisualStyleBackColor = true;
            this.btnBir.Click += new System.EventHandler(this.sayiYaz);
            // 
            // btnEsittir
            // 
            this.btnEsittir.Location = new System.Drawing.Point(255, 75);
            this.btnEsittir.Margin = new System.Windows.Forms.Padding(4);
            this.btnEsittir.Name = "btnEsittir";
            this.btnEsittir.Size = new System.Drawing.Size(85, 245);
            this.btnEsittir.TabIndex = 19;
            this.btnEsittir.Text = "=";
            this.btnEsittir.UseVisualStyleBackColor = true;
            this.btnEsittir.Click += new System.EventHandler(this.btnEsittir_Click);
            // 
            // txtSayi
            // 
            this.txtSayi.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSayi.Location = new System.Drawing.Point(35, 36);
            this.txtSayi.Margin = new System.Windows.Forms.Padding(4);
            this.txtSayi.MaxLength = 22;
            this.txtSayi.Name = "txtSayi";
            this.txtSayi.ReadOnly = true;
            this.txtSayi.Size = new System.Drawing.Size(305, 31);
            this.txtSayi.TabIndex = 20;
            this.txtSayi.Text = "0";
            this.txtSayi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSayi.TextChanged += new System.EventHandler(this.txtSayi_TextChanged);
            this.txtSayi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSayi_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 331);
            this.Controls.Add(this.txtSayi);
            this.Controls.Add(this.btnEsittir);
            this.Controls.Add(this.btnBir);
            this.Controls.Add(this.btnBolme);
            this.Controls.Add(this.btnTamsayiPN);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnBes);
            this.Controls.Add(this.btnCikarma);
            this.Controls.Add(this.btnVirgul);
            this.Controls.Add(this.btnToplama);
            this.Controls.Add(this.btnSifir);
            this.Controls.Add(this.btnIki);
            this.Controls.Add(this.btnAlti);
            this.Controls.Add(this.btnCarpma);
            this.Controls.Add(this.btnUc);
            this.Controls.Add(this.btnDort);
            this.Controls.Add(this.btnSekiz);
            this.Controls.Add(this.btnYedi);
            this.Controls.Add(this.btnSonyazdiginSayiyiSil);
            this.Controls.Add(this.btnDokuz);
            this.Controls.Add(this.btnKompleSil);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "  Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnKompleSil;
		private System.Windows.Forms.Button btnDokuz;
		private System.Windows.Forms.Button btnSonyazdiginSayiyiSil;
		private System.Windows.Forms.Button btnYedi;
		private System.Windows.Forms.Button btnSekiz;
		private System.Windows.Forms.Button btnDort;
		private System.Windows.Forms.Button btnUc;
		private System.Windows.Forms.Button btnCarpma;
		private System.Windows.Forms.Button btnAlti;
		private System.Windows.Forms.Button btnIki;
		private System.Windows.Forms.Button btnSifir;
		private System.Windows.Forms.Button btnToplama;
		private System.Windows.Forms.Button btnVirgul;
		private System.Windows.Forms.Button btnCikarma;
		private System.Windows.Forms.Button btnBes;
		private System.Windows.Forms.Button btnSil;
		private System.Windows.Forms.Button btnTamsayiPN;
		private System.Windows.Forms.Button btnBolme;
		private System.Windows.Forms.Button btnBir;
		private System.Windows.Forms.Button btnEsittir;
		private System.Windows.Forms.TextBox txtSayi;
	}
}

