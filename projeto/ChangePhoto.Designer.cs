namespace projeto
{
    partial class ChangePhoto
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePhoto));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.txtfFoto = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnCon = new Guna.UI2.WinForms.Guna2Button();
            this.close = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // txtfFoto
            // 
            this.txtfFoto.BorderRadius = 5;
            this.txtfFoto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtfFoto.DefaultText = "";
            this.txtfFoto.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtfFoto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtfFoto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtfFoto.DisabledState.Parent = this.txtfFoto;
            this.txtfFoto.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtfFoto.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtfFoto.FocusedState.Parent = this.txtfFoto;
            this.txtfFoto.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtfFoto.HoverState.Parent = this.txtfFoto;
            this.txtfFoto.Location = new System.Drawing.Point(26, 33);
            this.txtfFoto.Name = "txtfFoto";
            this.txtfFoto.PasswordChar = '\0';
            this.txtfFoto.PlaceholderText = "URL da foto";
            this.txtfFoto.SelectedText = "";
            this.txtfFoto.ShadowDecoration.Parent = this.txtfFoto;
            this.txtfFoto.Size = new System.Drawing.Size(289, 36);
            this.txtfFoto.TabIndex = 2;
            // 
            // btnCon
            // 
            this.btnCon.BorderRadius = 5;
            this.btnCon.CheckedState.Parent = this.btnCon;
            this.btnCon.CustomImages.Parent = this.btnCon;
            this.btnCon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCon.ForeColor = System.Drawing.Color.White;
            this.btnCon.HoverState.Parent = this.btnCon;
            this.btnCon.Location = new System.Drawing.Point(341, 33);
            this.btnCon.Name = "btnCon";
            this.btnCon.ShadowDecoration.Parent = this.btnCon;
            this.btnCon.Size = new System.Drawing.Size(116, 36);
            this.btnCon.TabIndex = 3;
            this.btnCon.Text = "Confirmar";
            this.btnCon.Click += new System.EventHandler(this.btnCon_Click);
            // 
            // close
            // 
            this.close.Image = ((System.Drawing.Image)(resources.GetObject("close.Image")));
            this.close.Location = new System.Drawing.Point(456, 12);
            this.close.Name = "close";
            this.close.ShadowDecoration.Parent = this.close;
            this.close.Size = new System.Drawing.Size(14, 18);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close.TabIndex = 16;
            this.close.TabStop = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // ChangePhoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 107);
            this.Controls.Add(this.close);
            this.Controls.Add(this.btnCon);
            this.Controls.Add(this.txtfFoto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangePhoto";
            this.Text = "ChangePhoto";
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2TextBox txtfFoto;
        private Guna.UI2.WinForms.Guna2Button btnCon;
        private Guna.UI2.WinForms.Guna2PictureBox close;
    }
}