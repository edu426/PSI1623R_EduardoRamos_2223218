namespace projeto
{
    partial class MainProgram
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainProgram));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.picNewAdd = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnPerfil = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.close = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnDesejo = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.btnColecao = new Guna.UI2.WinForms.Guna2Button();
            this.lblNewAdd = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picNewAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // picNewAdd
            // 
            this.picNewAdd.Location = new System.Drawing.Point(551, 85);
            this.picNewAdd.Name = "picNewAdd";
            this.picNewAdd.ShadowDecoration.Parent = this.picNewAdd;
            this.picNewAdd.Size = new System.Drawing.Size(201, 271);
            this.picNewAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picNewAdd.TabIndex = 18;
            this.picNewAdd.TabStop = false;
            // 
            // btnPerfil
            // 
            this.btnPerfil.BorderRadius = 5;
            this.btnPerfil.CheckedState.Parent = this.btnPerfil;
            this.btnPerfil.CustomImages.Parent = this.btnPerfil;
            this.btnPerfil.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerfil.ForeColor = System.Drawing.Color.White;
            this.btnPerfil.HoverState.Parent = this.btnPerfil;
            this.btnPerfil.Image = global::projeto.Properties.Resources.user;
            this.btnPerfil.ImageSize = new System.Drawing.Size(30, 30);
            this.btnPerfil.Location = new System.Drawing.Point(217, 359);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.ShadowDecoration.Parent = this.btnPerfil;
            this.btnPerfil.Size = new System.Drawing.Size(400, 67);
            this.btnPerfil.TabIndex = 17;
            this.btnPerfil.Text = "Perfil";
            this.btnPerfil.Click += new System.EventHandler(this.btnPerfil_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.Location = new System.Drawing.Point(-23, 0);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(167, 72);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 16;
            this.guna2PictureBox1.TabStop = false;
            // 
            // close
            // 
            this.close.Image = ((System.Drawing.Image)(resources.GetObject("close.Image")));
            this.close.Location = new System.Drawing.Point(791, 12);
            this.close.Name = "close";
            this.close.ShadowDecoration.Parent = this.close;
            this.close.Size = new System.Drawing.Size(14, 18);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close.TabIndex = 15;
            this.close.TabStop = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // btnDesejo
            // 
            this.btnDesejo.BorderRadius = 5;
            this.btnDesejo.CheckedState.Parent = this.btnDesejo;
            this.btnDesejo.CustomImages.Parent = this.btnDesejo;
            this.btnDesejo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesejo.ForeColor = System.Drawing.Color.White;
            this.btnDesejo.HoverState.Parent = this.btnDesejo;
            this.btnDesejo.Image = global::projeto.Properties.Resources.wishlist;
            this.btnDesejo.ImageSize = new System.Drawing.Size(30, 30);
            this.btnDesejo.Location = new System.Drawing.Point(217, 273);
            this.btnDesejo.Name = "btnDesejo";
            this.btnDesejo.ShadowDecoration.Parent = this.btnDesejo;
            this.btnDesejo.Size = new System.Drawing.Size(400, 67);
            this.btnDesejo.TabIndex = 10;
            this.btnDesejo.Text = "Lista de Desejos";
            this.btnDesejo.Click += new System.EventHandler(this.btnDesejo_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BorderRadius = 5;
            this.btnAdd.CheckedState.Parent = this.btnAdd;
            this.btnAdd.CustomImages.Parent = this.btnAdd;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.HoverState.Parent = this.btnAdd;
            this.btnAdd.Image = global::projeto.Properties.Resources.add;
            this.btnAdd.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAdd.Location = new System.Drawing.Point(217, 176);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ShadowDecoration.Parent = this.btnAdd;
            this.btnAdd.Size = new System.Drawing.Size(400, 67);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnColecao
            // 
            this.btnColecao.BorderRadius = 5;
            this.btnColecao.CheckedState.Parent = this.btnColecao;
            this.btnColecao.CustomImages.Parent = this.btnColecao;
            this.btnColecao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColecao.ForeColor = System.Drawing.Color.White;
            this.btnColecao.HoverState.Parent = this.btnColecao;
            this.btnColecao.Image = global::projeto.Properties.Resources.game_controller;
            this.btnColecao.ImageSize = new System.Drawing.Size(30, 30);
            this.btnColecao.Location = new System.Drawing.Point(217, 85);
            this.btnColecao.Name = "btnColecao";
            this.btnColecao.ShadowDecoration.Parent = this.btnColecao;
            this.btnColecao.Size = new System.Drawing.Size(400, 67);
            this.btnColecao.TabIndex = 8;
            this.btnColecao.Text = "Minha Coleção";
            this.btnColecao.Click += new System.EventHandler(this.btnColecao_Click);
            // 
            // lblNewAdd
            // 
            this.lblNewAdd.AutoSize = true;
            this.lblNewAdd.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewAdd.Location = new System.Drawing.Point(602, 389);
            this.lblNewAdd.Name = "lblNewAdd";
            this.lblNewAdd.Size = new System.Drawing.Size(72, 30);
            this.lblNewAdd.TabIndex = 19;
            this.lblNewAdd.Text = "label1";
            this.lblNewAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(572, 359);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 30);
            this.label1.TabIndex = 20;
            this.label1.Text = "Ultima Adição:";
            // 
            // MainProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 500);
            this.Controls.Add(this.btnPerfil);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.close);
            this.Controls.Add(this.btnDesejo);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnColecao);
            this.Controls.Add(this.picNewAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNewAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainProgram";
            this.Text = "MainProgram";
            this.Load += new System.EventHandler(this.MainProgram_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picNewAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnColecao;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2Button btnDesejo;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2PictureBox close;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnPerfil;
        private Guna.UI2.WinForms.Guna2PictureBox picNewAdd;
        private System.Windows.Forms.Label lblNewAdd;
        private System.Windows.Forms.Label label1;
    }
}