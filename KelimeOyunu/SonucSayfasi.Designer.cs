
namespace KelimeOyunu
{
    partial class SonucSayfasi
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
            this.baslikLbl = new System.Windows.Forms.Label();
            this.sonucisimLbl = new System.Windows.Forms.Label();
            this.puanLbl = new System.Windows.Forms.Label();
            this.artansureLbl = new System.Windows.Forms.Label();
            this.sonuckaydetBtn = new System.Windows.Forms.Button();
            this.oyunzamaniLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // baslikLbl
            // 
            this.baslikLbl.AutoSize = true;
            this.baslikLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.baslikLbl.ForeColor = System.Drawing.Color.MidnightBlue;
            this.baslikLbl.Location = new System.Drawing.Point(66, 27);
            this.baslikLbl.Name = "baslikLbl";
            this.baslikLbl.Size = new System.Drawing.Size(187, 52);
            this.baslikLbl.TabIndex = 1;
            this.baslikLbl.Text = "SONUÇ";
            // 
            // sonucisimLbl
            // 
            this.sonucisimLbl.AutoSize = true;
            this.sonucisimLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sonucisimLbl.ForeColor = System.Drawing.Color.MidnightBlue;
            this.sonucisimLbl.Location = new System.Drawing.Point(187, 119);
            this.sonucisimLbl.Name = "sonucisimLbl";
            this.sonucisimLbl.Size = new System.Drawing.Size(92, 39);
            this.sonucisimLbl.TabIndex = 2;
            this.sonucisimLbl.Text = "İSİM";
            // 
            // puanLbl
            // 
            this.puanLbl.AutoSize = true;
            this.puanLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.puanLbl.ForeColor = System.Drawing.Color.MidnightBlue;
            this.puanLbl.Location = new System.Drawing.Point(175, 190);
            this.puanLbl.Name = "puanLbl";
            this.puanLbl.Size = new System.Drawing.Size(117, 39);
            this.puanLbl.TabIndex = 3;
            this.puanLbl.Text = "PUAN";
            // 
            // artansureLbl
            // 
            this.artansureLbl.AutoSize = true;
            this.artansureLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.artansureLbl.ForeColor = System.Drawing.Color.MidnightBlue;
            this.artansureLbl.Location = new System.Drawing.Point(175, 249);
            this.artansureLbl.Name = "artansureLbl";
            this.artansureLbl.Size = new System.Drawing.Size(249, 39);
            this.artansureLbl.TabIndex = 4;
            this.artansureLbl.Text = "ARTAN SÜRE";
            // 
            // sonuckaydetBtn
            // 
            this.sonuckaydetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sonuckaydetBtn.ForeColor = System.Drawing.Color.MidnightBlue;
            this.sonuckaydetBtn.Location = new System.Drawing.Point(172, 373);
            this.sonuckaydetBtn.Name = "sonuckaydetBtn";
            this.sonuckaydetBtn.Size = new System.Drawing.Size(190, 58);
            this.sonuckaydetBtn.TabIndex = 5;
            this.sonuckaydetBtn.Text = "SONUCU KAYDET";
            this.sonuckaydetBtn.UseVisualStyleBackColor = true;
            this.sonuckaydetBtn.Click += new System.EventHandler(this.sonuckaydetBtn_Click);
            // 
            // oyunzamaniLbl
            // 
            this.oyunzamaniLbl.AutoSize = true;
            this.oyunzamaniLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.oyunzamaniLbl.ForeColor = System.Drawing.Color.MidnightBlue;
            this.oyunzamaniLbl.Location = new System.Drawing.Point(106, 313);
            this.oyunzamaniLbl.Name = "oyunzamaniLbl";
            this.oyunzamaniLbl.Size = new System.Drawing.Size(256, 38);
            this.oyunzamaniLbl.TabIndex = 6;
            this.oyunzamaniLbl.Text = "OYUN ZAMANI";
            // 
            // SonucSayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 468);
            this.Controls.Add(this.oyunzamaniLbl);
            this.Controls.Add(this.sonuckaydetBtn);
            this.Controls.Add(this.artansureLbl);
            this.Controls.Add(this.puanLbl);
            this.Controls.Add(this.sonucisimLbl);
            this.Controls.Add(this.baslikLbl);
            this.Name = "SonucSayfasi";
            this.Text = "SonucSayfasi";
            this.Load += new System.EventHandler(this.SonucSayfasi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label baslikLbl;
        private System.Windows.Forms.Label sonucisimLbl;
        private System.Windows.Forms.Label puanLbl;
        private System.Windows.Forms.Label artansureLbl;
        private System.Windows.Forms.Button sonuckaydetBtn;
        private System.Windows.Forms.Label oyunzamaniLbl;
    }
}