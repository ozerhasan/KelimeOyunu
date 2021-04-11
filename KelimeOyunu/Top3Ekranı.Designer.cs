
namespace KelimeOyunu
{
    partial class Top3Ekranı
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
            this.top3baslikLbl = new System.Windows.Forms.Label();
            this.top1Lbl = new System.Windows.Forms.Label();
            this.top2Lbl = new System.Windows.Forms.Label();
            this.top3Lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // top3baslikLbl
            // 
            this.top3baslikLbl.AutoSize = true;
            this.top3baslikLbl.BackColor = System.Drawing.SystemColors.Control;
            this.top3baslikLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.top3baslikLbl.ForeColor = System.Drawing.Color.MidnightBlue;
            this.top3baslikLbl.Location = new System.Drawing.Point(74, 33);
            this.top3baslikLbl.Name = "top3baslikLbl";
            this.top3baslikLbl.Size = new System.Drawing.Size(154, 52);
            this.top3baslikLbl.TabIndex = 0;
            this.top3baslikLbl.Text = "TOP 3";
            // 
            // top1Lbl
            // 
            this.top1Lbl.AutoSize = true;
            this.top1Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.top1Lbl.ForeColor = System.Drawing.Color.MidnightBlue;
            this.top1Lbl.Location = new System.Drawing.Point(12, 123);
            this.top1Lbl.Name = "top1Lbl";
            this.top1Lbl.Size = new System.Drawing.Size(96, 36);
            this.top1Lbl.TabIndex = 1;
            this.top1Lbl.Text = "TOP1";
            // 
            // top2Lbl
            // 
            this.top2Lbl.AutoSize = true;
            this.top2Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.top2Lbl.ForeColor = System.Drawing.Color.MidnightBlue;
            this.top2Lbl.Location = new System.Drawing.Point(12, 191);
            this.top2Lbl.Name = "top2Lbl";
            this.top2Lbl.Size = new System.Drawing.Size(105, 36);
            this.top2Lbl.TabIndex = 2;
            this.top2Lbl.Text = "TOP 2";
            // 
            // top3Lbl
            // 
            this.top3Lbl.AutoSize = true;
            this.top3Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.top3Lbl.ForeColor = System.Drawing.Color.MidnightBlue;
            this.top3Lbl.Location = new System.Drawing.Point(12, 256);
            this.top3Lbl.Name = "top3Lbl";
            this.top3Lbl.Size = new System.Drawing.Size(96, 36);
            this.top3Lbl.TabIndex = 3;
            this.top3Lbl.Text = "TOP3";
            // 
            // Top3Ekranı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(344, 384);
            this.Controls.Add(this.top3Lbl);
            this.Controls.Add(this.top2Lbl);
            this.Controls.Add(this.top1Lbl);
            this.Controls.Add(this.top3baslikLbl);
            this.Name = "Top3Ekranı";
            this.Text = "Top3Ekranı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label top3baslikLbl;
        private System.Windows.Forms.Label top1Lbl;
        private System.Windows.Forms.Label top2Lbl;
        private System.Windows.Forms.Label top3Lbl;
    }
}