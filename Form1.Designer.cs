namespace HesapMakinesi
{
    partial class HesapMakinesi
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btntoplam = new System.Windows.Forms.Button();
            this.brncikar = new System.Windows.Forms.Button();
            this.btnbolum = new System.Windows.Forms.Button();
            this.btncarpma = new System.Windows.Forms.Button();
            this.lblsayi1 = new System.Windows.Forms.Label();
            this.lblsayi2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtsayi1 = new System.Windows.Forms.TextBox();
            this.txtsayi2 = new System.Windows.Forms.TextBox();
            this.lblcevap = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btntoplam
            // 
            this.btntoplam.Location = new System.Drawing.Point(247, 36);
            this.btntoplam.Name = "btntoplam";
            this.btntoplam.Size = new System.Drawing.Size(52, 54);
            this.btntoplam.TabIndex = 0;
            this.btntoplam.Text = "+";
            this.btntoplam.UseVisualStyleBackColor = true;
            this.btntoplam.Click += new System.EventHandler(this.btntoplam_Click);
            // 
            // brncikar
            // 
            this.brncikar.Location = new System.Drawing.Point(305, 36);
            this.brncikar.Name = "brncikar";
            this.brncikar.Size = new System.Drawing.Size(52, 54);
            this.brncikar.TabIndex = 1;
            this.brncikar.Text = "-";
            this.brncikar.UseVisualStyleBackColor = true;
            this.brncikar.Click += new System.EventHandler(this.brncikar_Click);
            // 
            // btnbolum
            // 
            this.btnbolum.Location = new System.Drawing.Point(305, 96);
            this.btnbolum.Name = "btnbolum";
            this.btnbolum.Size = new System.Drawing.Size(52, 54);
            this.btnbolum.TabIndex = 2;
            this.btnbolum.Text = "/";
            this.btnbolum.UseVisualStyleBackColor = true;
            this.btnbolum.Click += new System.EventHandler(this.btnbolum_Click);
            // 
            // btncarpma
            // 
            this.btncarpma.Location = new System.Drawing.Point(247, 96);
            this.btncarpma.Name = "btncarpma";
            this.btncarpma.Size = new System.Drawing.Size(52, 54);
            this.btncarpma.TabIndex = 3;
            this.btncarpma.Text = "X";
            this.btncarpma.UseVisualStyleBackColor = true;
            this.btncarpma.Click += new System.EventHandler(this.btncarpma_Click);
            // 
            // lblsayi1
            // 
            this.lblsayi1.AutoSize = true;
            this.lblsayi1.Location = new System.Drawing.Point(12, 36);
            this.lblsayi1.Name = "lblsayi1";
            this.lblsayi1.Size = new System.Drawing.Size(39, 13);
            this.lblsayi1.TabIndex = 4;
            this.lblsayi1.Text = "Sayı 1:";
            // 
            // lblsayi2
            // 
            this.lblsayi2.AutoSize = true;
            this.lblsayi2.Location = new System.Drawing.Point(12, 77);
            this.lblsayi2.Name = "lblsayi2";
            this.lblsayi2.Size = new System.Drawing.Size(39, 13);
            this.lblsayi2.TabIndex = 5;
            this.lblsayi2.Text = "Sayı 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sonuç:";
            // 
            // txtsayi1
            // 
            this.txtsayi1.Location = new System.Drawing.Point(57, 33);
            this.txtsayi1.Name = "txtsayi1";
            this.txtsayi1.Size = new System.Drawing.Size(95, 20);
            this.txtsayi1.TabIndex = 7;
            // 
            // txtsayi2
            // 
            this.txtsayi2.Location = new System.Drawing.Point(57, 70);
            this.txtsayi2.Name = "txtsayi2";
            this.txtsayi2.Size = new System.Drawing.Size(95, 20);
            this.txtsayi2.TabIndex = 8;
            // 
            // lblcevap
            // 
            this.lblcevap.AutoSize = true;
            this.lblcevap.Location = new System.Drawing.Point(80, 168);
            this.lblcevap.Name = "lblcevap";
            this.lblcevap.Size = new System.Drawing.Size(10, 13);
            this.lblcevap.TabIndex = 9;
            this.lblcevap.Text = "-";
            // 
            // HesapMakinesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(518, 277);
            this.Controls.Add(this.lblcevap);
            this.Controls.Add(this.txtsayi2);
            this.Controls.Add(this.txtsayi1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblsayi2);
            this.Controls.Add(this.lblsayi1);
            this.Controls.Add(this.btncarpma);
            this.Controls.Add(this.btnbolum);
            this.Controls.Add(this.brncikar);
            this.Controls.Add(this.btntoplam);
            this.Name = "HesapMakinesi";
            this.Text = "Hesap Makinesi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btntoplam;
        private System.Windows.Forms.Button brncikar;
        private System.Windows.Forms.Button btnbolum;
        private System.Windows.Forms.Button btncarpma;
        private System.Windows.Forms.Label lblsayi1;
        private System.Windows.Forms.Label lblsayi2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtsayi1;
        private System.Windows.Forms.TextBox txtsayi2;
        private System.Windows.Forms.Label lblcevap;
    }
}

