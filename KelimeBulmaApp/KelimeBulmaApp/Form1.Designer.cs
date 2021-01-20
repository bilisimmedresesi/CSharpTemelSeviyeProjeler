namespace KelimeBulmaApp
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
            this.rcMetin = new System.Windows.Forms.RichTextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtBulKarakter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rcMetin
            // 
            this.rcMetin.Location = new System.Drawing.Point(2, 12);
            this.rcMetin.Name = "rcMetin";
            this.rcMetin.Size = new System.Drawing.Size(449, 105);
            this.rcMetin.TabIndex = 0;
            this.rcMetin.Text = "Plug into a wireless print server. If your printer has a USB port, you can plug i" +
    "n a wireless print server, a small box into which you can connect your printer. " +
    "...";
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(193, 121);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 1;
            this.btnFind.Text = "Bul";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtBulKarakter
            // 
            this.txtBulKarakter.Location = new System.Drawing.Point(110, 123);
            this.txtBulKarakter.Name = "txtBulKarakter";
            this.txtBulKarakter.Size = new System.Drawing.Size(77, 20);
            this.txtBulKarakter.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bulunacak Metin";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 172);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBulKarakter);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.rcMetin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rcMetin;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtBulKarakter;
        private System.Windows.Forms.Label label1;
    }
}

