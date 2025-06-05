namespace projeto
{
    partial class Whislist
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
            this.picBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lbln1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // picBox1
            // 
            this.picBox1.Location = new System.Drawing.Point(12, 12);
            this.picBox1.Name = "picBox1";
            this.picBox1.ShadowDecoration.Parent = this.picBox1;
            this.picBox1.Size = new System.Drawing.Size(72, 114);
            this.picBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox1.TabIndex = 1;
            this.picBox1.TabStop = false;
            // 
            // lbln1
            // 
            this.lbln1.AutoSize = true;
            this.lbln1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbln1.Location = new System.Drawing.Point(358, 210);
            this.lbln1.Name = "lbln1";
            this.lbln1.Size = new System.Drawing.Size(85, 30);
            this.lbln1.TabIndex = 4;
            this.lbln1.Text = "Nome1";
            // 
            // Whislist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbln1);
            this.Controls.Add(this.picBox1);
            this.Name = "Whislist";
            this.Text = "Whislist";
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox picBox1;
        private System.Windows.Forms.Label lbln1;
    }
}