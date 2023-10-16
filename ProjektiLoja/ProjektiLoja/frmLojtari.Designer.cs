namespace ProjektiLoja
{
    partial class frmLojtari
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
            this.btnRegjistrohu = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.emri = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtQyteti = new System.Windows.Forms.TextBox();
            this.mbiemri = new System.Windows.Forms.Label();
            this.txtEmri = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtMbiemri = new System.Windows.Forms.TextBox();
            this.Qyteti = new System.Windows.Forms.Label();
            this.dgvLojtaret = new System.Windows.Forms.DataGridView();
            this.txtNumriPerLoje = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLojtaret)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegjistrohu
            // 
            this.btnRegjistrohu.BackColor = System.Drawing.Color.SlateGray;
            this.btnRegjistrohu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegjistrohu.Location = new System.Drawing.Point(79, 596);
            this.btnRegjistrohu.Name = "btnRegjistrohu";
            this.btnRegjistrohu.Size = new System.Drawing.Size(130, 57);
            this.btnRegjistrohu.TabIndex = 34;
            this.btnRegjistrohu.Text = "Regjistrohu";
            this.btnRegjistrohu.UseVisualStyleBackColor = false;
            this.btnRegjistrohu.Click += new System.EventHandler(this.btnRegjistrohu_Click);
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.Location = new System.Drawing.Point(66, 5);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(30, 20);
            this.id.TabIndex = 23;
            this.id.Text = "Id:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(65, 306);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "Data e Lindjes:";
            // 
            // emri
            // 
            this.emri.AutoSize = true;
            this.emri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emri.Location = new System.Drawing.Point(66, 101);
            this.emri.Name = "emri";
            this.emri.Size = new System.Drawing.Size(48, 20);
            this.emri.TabIndex = 24;
            this.emri.Text = "Emri";
            // 
            // txtId
            // 
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(69, 37);
            this.txtId.Multiline = true;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(303, 38);
            this.txtId.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 25;
            // 
            // txtQyteti
            // 
            this.txtQyteti.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQyteti.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQyteti.Location = new System.Drawing.Point(69, 455);
            this.txtQyteti.Multiline = true;
            this.txtQyteti.Name = "txtQyteti";
            this.txtQyteti.Size = new System.Drawing.Size(303, 38);
            this.txtQyteti.TabIndex = 31;
            // 
            // mbiemri
            // 
            this.mbiemri.AutoSize = true;
            this.mbiemri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mbiemri.Location = new System.Drawing.Point(65, 198);
            this.mbiemri.Name = "mbiemri";
            this.mbiemri.Size = new System.Drawing.Size(76, 20);
            this.mbiemri.TabIndex = 26;
            this.mbiemri.Text = "Mbiemri";
            // 
            // txtEmri
            // 
            this.txtEmri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmri.Location = new System.Drawing.Point(69, 140);
            this.txtEmri.Multiline = true;
            this.txtEmri.Name = "txtEmri";
            this.txtEmri.Size = new System.Drawing.Size(303, 38);
            this.txtEmri.TabIndex = 30;
            // 
            // dtpDate
            // 
            this.dtpDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Location = new System.Drawing.Point(70, 354);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(302, 24);
            this.dtpDate.TabIndex = 27;
            // 
            // txtMbiemri
            // 
            this.txtMbiemri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMbiemri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMbiemri.Location = new System.Drawing.Point(69, 242);
            this.txtMbiemri.Multiline = true;
            this.txtMbiemri.Name = "txtMbiemri";
            this.txtMbiemri.Size = new System.Drawing.Size(303, 38);
            this.txtMbiemri.TabIndex = 29;
            // 
            // Qyteti
            // 
            this.Qyteti.AutoSize = true;
            this.Qyteti.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Qyteti.Location = new System.Drawing.Point(66, 412);
            this.Qyteti.Name = "Qyteti";
            this.Qyteti.Size = new System.Drawing.Size(59, 20);
            this.Qyteti.TabIndex = 28;
            this.Qyteti.Text = "Qyteti";
            // 
            // dgvLojtaret
            // 
            this.dgvLojtaret.AllowUserToOrderColumns = true;
            this.dgvLojtaret.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvLojtaret.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLojtaret.Location = new System.Drawing.Point(417, 208);
            this.dgvLojtaret.Name = "dgvLojtaret";
            this.dgvLojtaret.RowHeadersWidth = 51;
            this.dgvLojtaret.RowTemplate.Height = 24;
            this.dgvLojtaret.Size = new System.Drawing.Size(832, 400);
            this.dgvLojtaret.TabIndex = 35;
            this.dgvLojtaret.UseWaitCursor = true;
            this.dgvLojtaret.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLojtaret_RowEnter);
            // 
            // txtNumriPerLoje
            // 
            this.txtNumriPerLoje.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumriPerLoje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumriPerLoje.Location = new System.Drawing.Point(69, 535);
            this.txtNumriPerLoje.Multiline = true;
            this.txtNumriPerLoje.Name = "txtNumriPerLoje";
            this.txtNumriPerLoje.Size = new System.Drawing.Size(303, 38);
            this.txtNumriPerLoje.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 512);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 20);
            this.label2.TabIndex = 38;
            this.label2.Text = "Numri juaj i lojes";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SlateGray;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1094, 614);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 39);
            this.button1.TabIndex = 39;
            this.button1.Text = "Le te Luajm>>";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjektiLoja.Properties.Resources._1144840_200;
            this.pictureBox1.Location = new System.Drawing.Point(710, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 172);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1094, 32);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 36);
            this.button2.TabIndex = 41;
            this.button2.Text = "Lojtaret Fitues";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmLojtari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 699);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumriPerLoje);
            this.Controls.Add(this.dgvLojtaret);
            this.Controls.Add(this.btnRegjistrohu);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.emri);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtQyteti);
            this.Controls.Add(this.mbiemri);
            this.Controls.Add(this.txtEmri);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.txtMbiemri);
            this.Controls.Add(this.Qyteti);
            this.Name = "frmLojtari";
            this.Text = "frmLojtari";
            this.Load += new System.EventHandler(this.frmLojtari_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLojtaret)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegjistrohu;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label emri;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtQyteti;
        private System.Windows.Forms.Label mbiemri;
        private System.Windows.Forms.TextBox txtEmri;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox txtMbiemri;
        private System.Windows.Forms.Label Qyteti;
        private System.Windows.Forms.DataGridView dgvLojtaret;
        private System.Windows.Forms.TextBox txtNumriPerLoje;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
    }
}