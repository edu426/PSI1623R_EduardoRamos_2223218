namespace projeto
{
    partial class EditJogo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditJogo));
            this.picGame = new Guna.UI2.WinForms.Guna2PictureBox();
            this.comboGen = new Guna.UI2.WinForms.Guna2ComboBox();
            this.generoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.collectionDataSet7 = new projeto.collectionDataSet7();
            this.txtNome = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtImage = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnCon = new Guna.UI2.WinForms.Guna2Button();
            this.generoTableAdapter = new projeto.collectionDataSet7TableAdapters.GeneroTableAdapter();
            this.btnApagar = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.close = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picGame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collectionDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            this.SuspendLayout();
            // 
            // picGame
            // 
            this.picGame.Location = new System.Drawing.Point(37, 85);
            this.picGame.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picGame.Name = "picGame";
            this.picGame.ShadowDecoration.Parent = this.picGame;
            this.picGame.Size = new System.Drawing.Size(183, 246);
            this.picGame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picGame.TabIndex = 0;
            this.picGame.TabStop = false;
            // 
            // comboGen
            // 
            this.comboGen.BackColor = System.Drawing.Color.Transparent;
            this.comboGen.BorderRadius = 5;
            this.comboGen.DataSource = this.generoBindingSource;
            this.comboGen.DisplayMember = "NomeGenero";
            this.comboGen.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboGen.DropDownHeight = 100;
            this.comboGen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboGen.FocusedColor = System.Drawing.Color.Empty;
            this.comboGen.FocusedState.Parent = this.comboGen;
            this.comboGen.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboGen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboGen.FormattingEnabled = true;
            this.comboGen.HoverState.Parent = this.comboGen;
            this.comboGen.IntegralHeight = false;
            this.comboGen.ItemHeight = 30;
            this.comboGen.ItemsAppearance.Parent = this.comboGen;
            this.comboGen.Location = new System.Drawing.Point(248, 281);
            this.comboGen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboGen.Name = "comboGen";
            this.comboGen.ShadowDecoration.Parent = this.comboGen;
            this.comboGen.Size = new System.Drawing.Size(336, 36);
            this.comboGen.TabIndex = 1;
            this.comboGen.ValueMember = "IdGenero";
            // 
            // generoBindingSource
            // 
            this.generoBindingSource.DataMember = "Genero";
            this.generoBindingSource.DataSource = this.collectionDataSet7;
            // 
            // collectionDataSet7
            // 
            this.collectionDataSet7.DataSetName = "collectionDataSet7";
            this.collectionDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.txtNome.Location = new System.Drawing.Point(248, 100);
            this.txtNome.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtNome.Name = "txtNome";
            this.txtNome.PasswordChar = '\0';
            this.txtNome.PlaceholderText = "";
            this.txtNome.SelectedText = "";
            this.txtNome.ShadowDecoration.Parent = this.txtNome;
            this.txtNome.Size = new System.Drawing.Size(336, 55);
            this.txtNome.TabIndex = 2;
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
            this.txtImage.Location = new System.Drawing.Point(248, 193);
            this.txtImage.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtImage.Name = "txtImage";
            this.txtImage.PasswordChar = '\0';
            this.txtImage.PlaceholderText = "";
            this.txtImage.SelectedText = "";
            this.txtImage.ShadowDecoration.Parent = this.txtImage;
            this.txtImage.Size = new System.Drawing.Size(336, 55);
            this.txtImage.TabIndex = 3;
            // 
            // btnCon
            // 
            this.btnCon.BorderRadius = 5;
            this.btnCon.CheckedState.Parent = this.btnCon;
            this.btnCon.CustomImages.Parent = this.btnCon;
            this.btnCon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCon.ForeColor = System.Drawing.Color.White;
            this.btnCon.HoverState.Parent = this.btnCon;
            this.btnCon.Location = new System.Drawing.Point(351, 385);
            this.btnCon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCon.Name = "btnCon";
            this.btnCon.ShadowDecoration.Parent = this.btnCon;
            this.btnCon.Size = new System.Drawing.Size(270, 69);
            this.btnCon.TabIndex = 4;
            this.btnCon.Text = "Confirmar Mudanças";
            this.btnCon.Click += new System.EventHandler(this.btnCon_Click);
            // 
            // generoTableAdapter
            // 
            this.generoTableAdapter.ClearBeforeFill = true;
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
            this.btnApagar.Location = new System.Drawing.Point(25, 385);
            this.btnApagar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.ShadowDecoration.Parent = this.btnApagar;
            this.btnApagar.Size = new System.Drawing.Size(270, 69);
            this.btnApagar.TabIndex = 5;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // close
            // 
            this.close.Image = ((System.Drawing.Image)(resources.GetObject("close.Image")));
            this.close.Location = new System.Drawing.Point(616, 18);
            this.close.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.close.Name = "close";
            this.close.ShadowDecoration.Parent = this.close;
            this.close.Size = new System.Drawing.Size(21, 28);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close.TabIndex = 29;
            this.close.TabStop = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // EditJogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 529);
            this.Controls.Add(this.close);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnCon);
            this.Controls.Add(this.txtImage);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.comboGen);
            this.Controls.Add(this.picGame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EditJogo";
            this.Text = "EditJogo";
            this.Load += new System.EventHandler(this.EditJogo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picGame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collectionDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox picGame;
        private Guna.UI2.WinForms.Guna2ComboBox comboGen;
        private Guna.UI2.WinForms.Guna2TextBox txtNome;
        private Guna.UI2.WinForms.Guna2TextBox txtImage;
        private Guna.UI2.WinForms.Guna2Button btnCon;
        private collectionDataSet7 collectionDataSet7;
        private System.Windows.Forms.BindingSource generoBindingSource;
        private collectionDataSet7TableAdapters.GeneroTableAdapter generoTableAdapter;
        private Guna.UI2.WinForms.Guna2Button btnApagar;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2PictureBox close;
    }
}