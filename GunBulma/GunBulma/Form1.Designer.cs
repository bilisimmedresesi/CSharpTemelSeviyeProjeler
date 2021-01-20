namespace GunBulma
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
            this.dtTarih = new System.Windows.Forms.DateTimePicker();
            this.lbResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtTarih
            // 
            this.dtTarih.Location = new System.Drawing.Point(12, 18);
            this.dtTarih.Name = "dtTarih";
            this.dtTarih.Size = new System.Drawing.Size(247, 20);
            this.dtTarih.TabIndex = 0;
            this.dtTarih.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dateTimePicker1_KeyDown);
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Location = new System.Drawing.Point(17, 55);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(35, 13);
            this.lbResult.TabIndex = 1;
            this.lbResult.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 100);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.dtTarih);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtTarih;
        private System.Windows.Forms.Label lbResult;
    }
}

