namespace ProjektiLoja
{
    partial class frmLojtaretFitues
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
            this.dgvLojtaretFitues = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLojtaretFitues)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLojtaretFitues
            // 
            this.dgvLojtaretFitues.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLojtaretFitues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLojtaretFitues.Location = new System.Drawing.Point(189, 91);
            this.dgvLojtaretFitues.Name = "dgvLojtaretFitues";
            this.dgvLojtaretFitues.RowHeadersWidth = 51;
            this.dgvLojtaretFitues.RowTemplate.Height = 24;
            this.dgvLojtaretFitues.Size = new System.Drawing.Size(550, 335);
            this.dgvLojtaretFitues.TabIndex = 0;
            // 
            // frmLojtaretFitues
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 532);
            this.Controls.Add(this.dgvLojtaretFitues);
            this.Name = "frmLojtaretFitues";
            this.Text = "frmLojtaretFitues";
    
            ((System.ComponentModel.ISupportInitialize)(this.dgvLojtaretFitues)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLojtaretFitues;
    }
}