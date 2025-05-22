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
            ((System.ComponentModel.ISupportInitialize)(this.collectionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jogoscolecaoBindingSource)).BeginInit();
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
            // MinhaColecao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "MinhaColecao";
            this.Text = "MinhaColecao";
            this.Load += new System.EventHandler(this.MinhaColecao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.collectionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jogoscolecaoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private collectionDataSet collectionDataSet;
        private System.Windows.Forms.BindingSource jogoscolecaoBindingSource;
        private collectionDataSetTableAdapters.JogoscolecaoTableAdapter jogoscolecaoTableAdapter;
    }
}