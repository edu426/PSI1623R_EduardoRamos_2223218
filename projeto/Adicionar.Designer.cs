namespace projeto
{
    partial class Adicionar
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
            this.btnJogo = new Guna.UI2.WinForms.Guna2Button();
            this.btnDesejo = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(315, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "O que adicionar?";
            // 
            // btnJogo
            // 
            this.btnJogo.CheckedState.Parent = this.btnJogo;
            this.btnJogo.CustomImages.Parent = this.btnJogo;
            this.btnJogo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnJogo.ForeColor = System.Drawing.Color.White;
            this.btnJogo.HoverState.Parent = this.btnJogo;
            this.btnJogo.Location = new System.Drawing.Point(203, 243);
            this.btnJogo.Name = "btnJogo";
            this.btnJogo.ShadowDecoration.Parent = this.btnJogo;
            this.btnJogo.Size = new System.Drawing.Size(180, 45);
            this.btnJogo.TabIndex = 2;
            this.btnJogo.Text = "Jogo";
            this.btnJogo.Click += new System.EventHandler(this.btnJogo_Click);
            // 
            // btnDesejo
            // 
            this.btnDesejo.CheckedState.Parent = this.btnDesejo;
            this.btnDesejo.CustomImages.Parent = this.btnDesejo;
            this.btnDesejo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDesejo.ForeColor = System.Drawing.Color.White;
            this.btnDesejo.HoverState.Parent = this.btnDesejo;
            this.btnDesejo.Location = new System.Drawing.Point(417, 243);
            this.btnDesejo.Name = "btnDesejo";
            this.btnDesejo.ShadowDecoration.Parent = this.btnDesejo;
            this.btnDesejo.Size = new System.Drawing.Size(180, 45);
            this.btnDesejo.TabIndex = 3;
            this.btnDesejo.Text = "Desejo";
            this.btnDesejo.Click += new System.EventHandler(this.btnDesejo_Click_1);
            // 
            // Adicionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDesejo);
            this.Controls.Add(this.btnJogo);
            this.Controls.Add(this.label1);
            this.Name = "Adicionar";
            this.Text = "Adicionar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnJogo;
        private Guna.UI2.WinForms.Guna2Button btnDesejo;
    }
}