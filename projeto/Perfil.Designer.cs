namespace projeto
{
    partial class Perfil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Perfil));
            this.lblname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnNome = new Guna.UI2.WinForms.Guna2Button();
            this.btnFoto = new Guna.UI2.WinForms.Guna2Button();
            this.close = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Refresh = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Refresh)).BeginInit();
            this.SuspendLayout();
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblname.Location = new System.Drawing.Point(237, 107);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(67, 30);
            this.lblname.TabIndex = 2;
            this.lblname.Text = "name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(156, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(157, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblId.Location = new System.Drawing.Point(237, 153);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(32, 30);
            this.lblId.TabIndex = 5;
            this.lblId.Text = "id";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // btnNome
            // 
            this.btnNome.BorderRadius = 8;
            this.btnNome.CheckedState.Parent = this.btnNome;
            this.btnNome.CustomImages.Parent = this.btnNome;
            this.btnNome.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNome.ForeColor = System.Drawing.Color.White;
            this.btnNome.HoverState.Parent = this.btnNome;
            this.btnNome.Location = new System.Drawing.Point(24, 254);
            this.btnNome.Name = "btnNome";
            this.btnNome.ShadowDecoration.Parent = this.btnNome;
            this.btnNome.Size = new System.Drawing.Size(172, 57);
            this.btnNome.TabIndex = 16;
            this.btnNome.Text = "Mudar Nome";
            this.btnNome.Click += new System.EventHandler(this.btnNome_Click);
            // 
            // btnFoto
            // 
            this.btnFoto.BorderRadius = 8;
            this.btnFoto.CheckedState.Parent = this.btnFoto;
            this.btnFoto.CustomImages.Parent = this.btnFoto;
            this.btnFoto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFoto.ForeColor = System.Drawing.Color.White;
            this.btnFoto.HoverState.Parent = this.btnFoto;
            this.btnFoto.Location = new System.Drawing.Point(242, 254);
            this.btnFoto.Name = "btnFoto";
            this.btnFoto.ShadowDecoration.Parent = this.btnFoto;
            this.btnFoto.Size = new System.Drawing.Size(172, 57);
            this.btnFoto.TabIndex = 18;
            this.btnFoto.Text = "Mudar foto de perfil";
            this.btnFoto.Click += new System.EventHandler(this.btnFoto_Click);
            // 
            // close
            // 
            this.close.Image = ((System.Drawing.Image)(resources.GetObject("close.Image")));
            this.close.Location = new System.Drawing.Point(411, 12);
            this.close.Name = "close";
            this.close.ShadowDecoration.Parent = this.close;
            this.close.Size = new System.Drawing.Size(14, 18);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close.TabIndex = 15;
            this.close.TabStop = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(27, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Refresh
            // 
            this.Refresh.ImageLocation = "https://uxwing.com/wp-content/themes/uxwing/download/web-app-development/refresh-" +
    "icon.png";
            this.Refresh.Location = new System.Drawing.Point(391, 12);
            this.Refresh.Name = "Refresh";
            this.Refresh.ShadowDecoration.Parent = this.Refresh;
            this.Refresh.Size = new System.Drawing.Size(14, 18);
            this.Refresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Refresh.TabIndex = 19;
            this.Refresh.TabStop = false;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // Perfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 344);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.btnFoto);
            this.Controls.Add(this.btnNome);
            this.Controls.Add(this.close);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Perfil";
            this.Text = "Perfil";
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Refresh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblId;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2PictureBox close;
        private Guna.UI2.WinForms.Guna2Button btnNome;
        private Guna.UI2.WinForms.Guna2Button btnFoto;
        private Guna.UI2.WinForms.Guna2PictureBox Refresh;
    }
}