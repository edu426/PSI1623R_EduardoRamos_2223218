namespace projeto
{
    partial class MinhaColecao
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
            this.collectionDataSet = new projeto.collectionDataSet();
            this.jogoscolecaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jogoscolecaoTableAdapter = new projeto.collectionDataSetTableAdapters.JogoscolecaoTableAdapter();
            this.picBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.picBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.picBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lbln1 = new System.Windows.Forms.Label();
            this.lbln2 = new System.Windows.Forms.Label();
            this.lbln3 = new System.Windows.Forms.Label();
            this.lblPlat1 = new System.Windows.Forms.Label();
            this.lblPlat2 = new System.Windows.Forms.Label();
            this.lblPlat3 = new System.Windows.Forms.Label();
            this.lblGen1 = new System.Windows.Forms.Label();
            this.lblGen2 = new System.Windows.Forms.Label();
            this.lblGen3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.collectionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jogoscolecaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // collectionDataSet
            // 
            this.collectionDataSet.DataSetName = "collectionDataSet";
            this.collectionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jogoscolecaoBindingSource
            // 
            this.jogoscolecaoBindingSource.DataMember = "Jogoscolecao";
            this.jogoscolecaoBindingSource.DataSource = this.collectionDataSet;
            // 
            // jogoscolecaoTableAdapter
            // 
            this.jogoscolecaoTableAdapter.ClearBeforeFill = true;
            // 
            // picBox1
            // 
            this.picBox1.Location = new System.Drawing.Point(12, 12);
            this.picBox1.Name = "picBox1";
            this.picBox1.ShadowDecoration.Parent = this.picBox1;
            this.picBox1.Size = new System.Drawing.Size(72, 114);
            this.picBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox1.TabIndex = 0;
            this.picBox1.TabStop = false;
            // 
            // picBox2
            // 
            this.picBox2.Location = new System.Drawing.Point(12, 158);
            this.picBox2.Name = "picBox2";
            this.picBox2.ShadowDecoration.Parent = this.picBox2;
            this.picBox2.Size = new System.Drawing.Size(72, 114);
            this.picBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox2.TabIndex = 1;
            this.picBox2.TabStop = false;
            // 
            // picBox3
            // 
            this.picBox3.Location = new System.Drawing.Point(12, 311);
            this.picBox3.Name = "picBox3";
            this.picBox3.ShadowDecoration.Parent = this.picBox3;
            this.picBox3.Size = new System.Drawing.Size(72, 114);
            this.picBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox3.TabIndex = 2;
            this.picBox3.TabStop = false;
            // 
            // lbln1
            // 
            this.lbln1.AutoSize = true;
            this.lbln1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbln1.Location = new System.Drawing.Point(90, 12);
            this.lbln1.Name = "lbln1";
            this.lbln1.Size = new System.Drawing.Size(85, 30);
            this.lbln1.TabIndex = 3;
            this.lbln1.Text = "Nome1";
            // 
            // lbln2
            // 
            this.lbln2.AutoSize = true;
            this.lbln2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbln2.Location = new System.Drawing.Point(90, 158);
            this.lbln2.Name = "lbln2";
            this.lbln2.Size = new System.Drawing.Size(85, 30);
            this.lbln2.TabIndex = 4;
            this.lbln2.Text = "Nome2";
            // 
            // lbln3
            // 
            this.lbln3.AutoSize = true;
            this.lbln3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbln3.Location = new System.Drawing.Point(90, 311);
            this.lbln3.Name = "lbln3";
            this.lbln3.Size = new System.Drawing.Size(85, 30);
            this.lbln3.TabIndex = 5;
            this.lbln3.Text = "Nome3";
            // 
            // lblPlat1
            // 
            this.lblPlat1.AutoSize = true;
            this.lblPlat1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlat1.Location = new System.Drawing.Point(91, 51);
            this.lblPlat1.Name = "lblPlat1";
            this.lblPlat1.Size = new System.Drawing.Size(95, 21);
            this.lblPlat1.TabIndex = 6;
            this.lblPlat1.Text = "Plataforma1";
            // 
            // lblPlat2
            // 
            this.lblPlat2.AutoSize = true;
            this.lblPlat2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlat2.Location = new System.Drawing.Point(91, 199);
            this.lblPlat2.Name = "lblPlat2";
            this.lblPlat2.Size = new System.Drawing.Size(95, 21);
            this.lblPlat2.TabIndex = 7;
            this.lblPlat2.Text = "Plataforma2";
            // 
            // lblPlat3
            // 
            this.lblPlat3.AutoSize = true;
            this.lblPlat3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlat3.Location = new System.Drawing.Point(91, 351);
            this.lblPlat3.Name = "lblPlat3";
            this.lblPlat3.Size = new System.Drawing.Size(95, 21);
            this.lblPlat3.TabIndex = 8;
            this.lblPlat3.Text = "Plataforma3";
            // 
            // lblGen1
            // 
            this.lblGen1.AutoSize = true;
            this.lblGen1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGen1.Location = new System.Drawing.Point(91, 85);
            this.lblGen1.Name = "lblGen1";
            this.lblGen1.Size = new System.Drawing.Size(70, 21);
            this.lblGen1.TabIndex = 9;
            this.lblGen1.Text = "Genero1";
            // 
            // lblGen2
            // 
            this.lblGen2.AutoSize = true;
            this.lblGen2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGen2.Location = new System.Drawing.Point(91, 236);
            this.lblGen2.Name = "lblGen2";
            this.lblGen2.Size = new System.Drawing.Size(70, 21);
            this.lblGen2.TabIndex = 10;
            this.lblGen2.Text = "Genero2";
            // 
            // lblGen3
            // 
            this.lblGen3.AutoSize = true;
            this.lblGen3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGen3.Location = new System.Drawing.Point(91, 387);
            this.lblGen3.Name = "lblGen3";
            this.lblGen3.Size = new System.Drawing.Size(70, 21);
            this.lblGen3.TabIndex = 11;
            this.lblGen3.Text = "Genero3";
            // 
            // MinhaColecao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblGen3);
            this.Controls.Add(this.lblGen2);
            this.Controls.Add(this.lblGen1);
            this.Controls.Add(this.lblPlat3);
            this.Controls.Add(this.lblPlat2);
            this.Controls.Add(this.lblPlat1);
            this.Controls.Add(this.lbln3);
            this.Controls.Add(this.lbln2);
            this.Controls.Add(this.lbln1);
            this.Controls.Add(this.picBox3);
            this.Controls.Add(this.picBox2);
            this.Controls.Add(this.picBox1);
            this.Name = "MinhaColecao";
            this.Text = "MinhaColecao";
            ((System.ComponentModel.ISupportInitialize)(this.collectionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jogoscolecaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private collectionDataSet collectionDataSet;
        private System.Windows.Forms.BindingSource jogoscolecaoBindingSource;
        private collectionDataSetTableAdapters.JogoscolecaoTableAdapter jogoscolecaoTableAdapter;
        private Guna.UI2.WinForms.Guna2PictureBox picBox1;
        private Guna.UI2.WinForms.Guna2PictureBox picBox2;
        private Guna.UI2.WinForms.Guna2PictureBox picBox3;
        private System.Windows.Forms.Label lbln1;
        private System.Windows.Forms.Label lbln2;
        private System.Windows.Forms.Label lbln3;
        private System.Windows.Forms.Label lblPlat1;
        private System.Windows.Forms.Label lblPlat2;
        private System.Windows.Forms.Label lblPlat3;
        private System.Windows.Forms.Label lblGen1;
        private System.Windows.Forms.Label lblGen2;
        private System.Windows.Forms.Label lblGen3;
    }
}