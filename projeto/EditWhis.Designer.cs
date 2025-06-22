namespace projeto
{
    partial class EditWhis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditWhis));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.close = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnApagar = new Guna.UI2.WinForms.Guna2Button();
            this.btnCon = new Guna.UI2.WinForms.Guna2Button();
            this.txtImage = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNome = new Guna.UI2.WinForms.Guna2TextBox();
            this.picGame = new Guna.UI2.WinForms.Guna2PictureBox();
            this.txtPreco = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGame)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // close
            // 
            this.close.Image = ((System.Drawing.Image)(resources.GetObject("close.Image")));
            this.close.Location = new System.Drawing.Point(410, 18);
            this.close.Name = "close";
            this.close.ShadowDecoration.Parent = this.close;
            this.close.Size = new System.Drawing.Size(14, 18);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close.TabIndex = 36;
            this.close.TabStop = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.BorderRadius = 5;
            this.btnApagar.CheckedState.Parent = this.btnApagar;
            this.btnApagar.CustomImages.Parent = this.btnApagar;
            this.btnApagar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnApagar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnApagar.ForeColor = System.Drawing.Color.White;
            this.btnApagar.HoverState.Parent = this.btnApagar;
            this.btnApagar.Location = new System.Drawing.Point(16, 256);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.ShadowDecoration.Parent = this.btnApagar;
            this.btnApagar.Size = new System.Drawing.Size(180, 45);
            this.btnApagar.TabIndex = 35;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // btnCon
            // 
            this.btnCon.BorderRadius = 5;
            this.btnCon.CheckedState.Parent = this.btnCon;
            this.btnCon.CustomImages.Parent = this.btnCon;
            this.btnCon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCon.ForeColor = System.Drawing.Color.White;
            this.btnCon.HoverState.Parent = this.btnCon;
            this.btnCon.Location = new System.Drawing.Point(233, 256);
            this.btnCon.Name = "btnCon";
            this.btnCon.ShadowDecoration.Parent = this.btnCon;
            this.btnCon.Size = new System.Drawing.Size(180, 45);
            this.btnCon.TabIndex = 34;
            this.btnCon.Text = "Confirmar Mudanças";
            this.btnCon.Click += new System.EventHandler(this.btnCon_Click);
            // 
            // txtImage
            // 
            this.txtImage.BorderRadius = 5;
            this.txtImage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtImage.DefaultText = "";
            this.txtImage.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtImage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtImage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtImage.DisabledState.Parent = this.txtImage;
            this.txtImage.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtImage.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtImage.FocusedState.Parent = this.txtImage;
            this.txtImage.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtImage.HoverState.Parent = this.txtImage;
            this.txtImage.Location = new System.Drawing.Point(164, 131);
            this.txtImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtImage.Name = "txtImage";
            this.txtImage.PasswordChar = '\0';
            this.txtImage.PlaceholderText = "";
            this.txtImage.SelectedText = "";
            this.txtImage.ShadowDecoration.Parent = this.txtImage;
            this.txtImage.Size = new System.Drawing.Size(224, 36);
            this.txtImage.TabIndex = 33;
            // 
            // txtNome
            // 
            this.txtNome.BorderRadius = 5;
            this.txtNome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNome.DefaultText = "";
            this.txtNome.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNome.DisabledState.Parent = this.txtNome;
            this.txtNome.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNome.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNome.FocusedState.Parent = this.txtNome;
            this.txtNome.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNome.HoverState.Parent = this.txtNome;
            this.txtNome.Location = new System.Drawing.Point(164, 71);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNome.Name = "txtNome";
            this.txtNome.PasswordChar = '\0';
            this.txtNome.PlaceholderText = "";
            this.txtNome.SelectedText = "";
            this.txtNome.ShadowDecoration.Parent = this.txtNome;
            this.txtNome.Size = new System.Drawing.Size(224, 36);
            this.txtNome.TabIndex = 32;
            // 
            // picGame
            // 
            this.picGame.Location = new System.Drawing.Point(24, 61);
            this.picGame.Name = "picGame";
            this.picGame.ShadowDecoration.Parent = this.picGame;
            this.picGame.Size = new System.Drawing.Size(122, 160);
            this.picGame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picGame.TabIndex = 30;
            this.picGame.TabStop = false;
            // 
            // txtPreco
            // 
            this.txtPreco.BorderRadius = 5;
            this.txtPreco.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPreco.DefaultText = "";
            this.txtPreco.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPreco.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPreco.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPreco.DisabledState.Parent = this.txtPreco;
            this.txtPreco.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPreco.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPreco.FocusedState.Parent = this.txtPreco;
            this.txtPreco.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPreco.HoverState.Parent = this.txtPreco;
            this.txtPreco.Location = new System.Drawing.Point(164, 185);
            this.txtPreco.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.PasswordChar = '\0';
            this.txtPreco.PlaceholderText = "";
            this.txtPreco.SelectedText = "";
            this.txtPreco.ShadowDecoration.Parent = this.txtPreco;
            this.txtPreco.Size = new System.Drawing.Size(224, 36);
            this.txtPreco.TabIndex = 37;
            // 
            // EditWhis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 344);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.close);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnCon);
            this.Controls.Add(this.txtImage);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.picGame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditWhis";
            this.Text = "EditWhis";
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGame)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2PictureBox close;
        private Guna.UI2.WinForms.Guna2Button btnApagar;
        private Guna.UI2.WinForms.Guna2Button btnCon;
        private Guna.UI2.WinForms.Guna2TextBox txtImage;
        private Guna.UI2.WinForms.Guna2TextBox txtNome;
        private Guna.UI2.WinForms.Guna2PictureBox picGame;
        private Guna.UI2.WinForms.Guna2TextBox txtPreco;
    }
}