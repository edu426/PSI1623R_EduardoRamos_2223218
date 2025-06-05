namespace projeto
{
    partial class AdicionarColecao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdicionarColecao));
            this.label1 = new System.Windows.Forms.Label();
            this.txtJogo = new Guna.UI2.WinForms.Guna2TextBox();
            this.generoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.collectionDataSet1 = new projeto.collectionDataSet1();
            this.generoTableAdapter = new projeto.collectionDataSet1TableAdapters.GeneroTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.plataformasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.collectionDataSet2 = new projeto.collectionDataSet2();
            this.plataformasTableAdapter = new projeto.collectionDataSet2TableAdapters.PlataformasTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtImagem = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnCon = new Guna.UI2.WinForms.Guna2Button();
            this.comboPlat = new Guna.UI2.WinForms.Guna2ComboBox();
            this.plataformasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.collectionDataSet3 = new projeto.collectionDataSet3();
            this.comboGen = new Guna.UI2.WinForms.Guna2ComboBox();
            this.generoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.collectionDataSet4 = new projeto.collectionDataSet4();
            this.plataformasTableAdapter1 = new projeto.collectionDataSet3TableAdapters.PlataformasTableAdapter();
            this.generoTableAdapter1 = new projeto.collectionDataSet4TableAdapters.GeneroTableAdapter();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.close = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.generoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collectionDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plataformasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collectionDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plataformasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collectionDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collectionDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Adicionar Jogo";
            // 
            // txtJogo
            // 
            this.txtJogo.BorderRadius = 5;
            this.txtJogo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtJogo.DefaultText = "";
            this.txtJogo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtJogo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtJogo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtJogo.DisabledState.Parent = this.txtJogo;
            this.txtJogo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtJogo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtJogo.FocusedState.Parent = this.txtJogo;
            this.txtJogo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtJogo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtJogo.HoverState.Parent = this.txtJogo;
            this.txtJogo.Location = new System.Drawing.Point(39, 90);
            this.txtJogo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtJogo.Name = "txtJogo";
            this.txtJogo.PasswordChar = '\0';
            this.txtJogo.PlaceholderText = "Nome";
            this.txtJogo.SelectedText = "";
            this.txtJogo.ShadowDecoration.Parent = this.txtJogo;
            this.txtJogo.Size = new System.Drawing.Size(396, 36);
            this.txtJogo.TabIndex = 3;
            // 
            // generoBindingSource
            // 
            this.generoBindingSource.DataMember = "Genero";
            this.generoBindingSource.DataSource = this.collectionDataSet1;
            // 
            // collectionDataSet1
            // 
            this.collectionDataSet1.DataSetName = "collectionDataSet1";
            this.collectionDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // generoTableAdapter
            // 
            this.generoTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Genero";
            // 
            // plataformasBindingSource
            // 
            this.plataformasBindingSource.DataMember = "Plataformas";
            this.plataformasBindingSource.DataSource = this.collectionDataSet2;
            // 
            // collectionDataSet2
            // 
            this.collectionDataSet2.DataSetName = "collectionDataSet2";
            this.collectionDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // plataformasTableAdapter
            // 
            this.plataformasTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(342, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Plataforma";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Imagem (opcional)";
            // 
            // txtImagem
            // 
            this.txtImagem.BorderRadius = 5;
            this.txtImagem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtImagem.DefaultText = "";
            this.txtImagem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtImagem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtImagem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtImagem.DisabledState.Parent = this.txtImagem;
            this.txtImagem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtImagem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtImagem.FocusedState.Parent = this.txtImagem;
            this.txtImagem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtImagem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtImagem.HoverState.Parent = this.txtImagem;
            this.txtImagem.Location = new System.Drawing.Point(39, 259);
            this.txtImagem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtImagem.Name = "txtImagem";
            this.txtImagem.PasswordChar = '\0';
            this.txtImagem.PlaceholderText = "URL da imagem";
            this.txtImagem.SelectedText = "";
            this.txtImagem.ShadowDecoration.Parent = this.txtImagem;
            this.txtImagem.Size = new System.Drawing.Size(396, 36);
            this.txtImagem.TabIndex = 9;
            // 
            // btnCon
            // 
            this.btnCon.CheckedState.Parent = this.btnCon;
            this.btnCon.CustomImages.Parent = this.btnCon;
            this.btnCon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCon.ForeColor = System.Drawing.Color.White;
            this.btnCon.HoverState.Parent = this.btnCon;
            this.btnCon.Location = new System.Drawing.Point(516, 250);
            this.btnCon.Name = "btnCon";
            this.btnCon.ShadowDecoration.Parent = this.btnCon;
            this.btnCon.Size = new System.Drawing.Size(180, 45);
            this.btnCon.TabIndex = 10;
            this.btnCon.Text = "Confirmar";
            this.btnCon.Click += new System.EventHandler(this.btnCon_Click);
            // 
            // comboPlat
            // 
            this.comboPlat.BackColor = System.Drawing.Color.Transparent;
            this.comboPlat.BorderRadius = 5;
            this.comboPlat.DataSource = this.plataformasBindingSource1;
            this.comboPlat.DisplayMember = "NomePlataforma";
            this.comboPlat.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboPlat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPlat.FocusedColor = System.Drawing.Color.Empty;
            this.comboPlat.FocusedState.Parent = this.comboPlat;
            this.comboPlat.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboPlat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboPlat.FormattingEnabled = true;
            this.comboPlat.HoverState.Parent = this.comboPlat;
            this.comboPlat.IntegralHeight = false;
            this.comboPlat.ItemHeight = 30;
            this.comboPlat.ItemsAppearance.Parent = this.comboPlat;
            this.comboPlat.Location = new System.Drawing.Point(345, 161);
            this.comboPlat.Name = "comboPlat";
            this.comboPlat.ShadowDecoration.Parent = this.comboPlat;
            this.comboPlat.Size = new System.Drawing.Size(265, 36);
            this.comboPlat.TabIndex = 14;
            this.comboPlat.ValueMember = "IdPlataforma";
            // 
            // plataformasBindingSource1
            // 
            this.plataformasBindingSource1.DataMember = "Plataformas";
            this.plataformasBindingSource1.DataSource = this.collectionDataSet3;
            // 
            // collectionDataSet3
            // 
            this.collectionDataSet3.DataSetName = "collectionDataSet3";
            this.collectionDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboGen
            // 
            this.comboGen.BackColor = System.Drawing.Color.Transparent;
            this.comboGen.BorderRadius = 5;
            this.comboGen.DataSource = this.generoBindingSource1;
            this.comboGen.DisplayMember = "NomeGenero";
            this.comboGen.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboGen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboGen.FocusedColor = System.Drawing.Color.Empty;
            this.comboGen.FocusedState.Parent = this.comboGen;
            this.comboGen.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboGen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboGen.FormattingEnabled = true;
            this.comboGen.HoverState.Parent = this.comboGen;
            this.comboGen.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboGen.IntegralHeight = false;
            this.comboGen.ItemHeight = 30;
            this.comboGen.ItemsAppearance.Parent = this.comboGen;
            this.comboGen.Location = new System.Drawing.Point(39, 161);
            this.comboGen.Name = "comboGen";
            this.comboGen.ShadowDecoration.Parent = this.comboGen;
            this.comboGen.Size = new System.Drawing.Size(265, 36);
            this.comboGen.TabIndex = 14;
            this.comboGen.ValueMember = "IdGenero";
            // 
            // generoBindingSource1
            // 
            this.generoBindingSource1.DataMember = "Genero";
            this.generoBindingSource1.DataSource = this.collectionDataSet4;
            // 
            // collectionDataSet4
            // 
            this.collectionDataSet4.DataSetName = "collectionDataSet4";
            this.collectionDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // plataformasTableAdapter1
            // 
            this.plataformasTableAdapter1.ClearBeforeFill = true;
            // 
            // generoTableAdapter1
            // 
            this.generoTableAdapter1.ClearBeforeFill = true;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.TargetControl = this;
            // 
            // close
            // 
            this.close.Image = ((System.Drawing.Image)(resources.GetObject("close.Image")));
            this.close.Location = new System.Drawing.Point(774, 12);
            this.close.Name = "close";
            this.close.ShadowDecoration.Parent = this.close;
            this.close.Size = new System.Drawing.Size(14, 18);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close.TabIndex = 17;
            this.close.TabStop = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // AdicionarColecao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.close);
            this.Controls.Add(this.comboGen);
            this.Controls.Add(this.comboPlat);
            this.Controls.Add(this.btnCon);
            this.Controls.Add(this.txtImagem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtJogo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdicionarColecao";
            this.Text = "AdicionarColecao";
            this.Load += new System.EventHandler(this.AdicionarColecao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.generoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collectionDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plataformasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collectionDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plataformasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collectionDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collectionDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtJogo;
        private collectionDataSet1 collectionDataSet1;
        private System.Windows.Forms.BindingSource generoBindingSource;
        private collectionDataSet1TableAdapters.GeneroTableAdapter generoTableAdapter;
        private System.Windows.Forms.Label label2;
        private collectionDataSet2 collectionDataSet2;
        private System.Windows.Forms.BindingSource plataformasBindingSource;
        private collectionDataSet2TableAdapters.PlataformasTableAdapter plataformasTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtImagem;
        private Guna.UI2.WinForms.Guna2Button btnCon;
        private Guna.UI2.WinForms.Guna2ComboBox comboPlat;
        private Guna.UI2.WinForms.Guna2ComboBox comboGen;
        private collectionDataSet3 collectionDataSet3;
        private System.Windows.Forms.BindingSource plataformasBindingSource1;
        private collectionDataSet3TableAdapters.PlataformasTableAdapter plataformasTableAdapter1;
        private collectionDataSet4 collectionDataSet4;
        private System.Windows.Forms.BindingSource generoBindingSource1;
        private collectionDataSet4TableAdapters.GeneroTableAdapter generoTableAdapter1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2PictureBox close;
    }
}