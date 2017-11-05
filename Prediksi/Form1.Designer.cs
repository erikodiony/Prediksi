namespace Prediksi
{
    partial class Form1
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
            this.btn_Exec = new System.Windows.Forms.Button();
            this.lbl_tgl = new System.Windows.Forms.Label();
            this.lbl_jml = new System.Windows.Forms.Label();
            this.tBox_tgl = new System.Windows.Forms.TextBox();
            this.tBox_jml = new System.Windows.Forms.TextBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.dGV_db = new System.Windows.Forms.DataGridView();
            this.no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tgl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jml = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox_prediksi = new System.Windows.Forms.GroupBox();
            this.cmb_cat1 = new System.Windows.Forms.ComboBox();
            this.lbl_db = new System.Windows.Forms.Label();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.groupBox_input = new System.Windows.Forms.GroupBox();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.cmb_cat2 = new System.Windows.Forms.ComboBox();
            this.lbl_db2 = new System.Windows.Forms.Label();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.groupBox_db = new System.Windows.Forms.GroupBox();
            this.btn_Show = new System.Windows.Forms.Button();
            this.cmb_cat3 = new System.Windows.Forms.ComboBox();
            this.lbl_db3 = new System.Windows.Forms.Label();
            this.groupBox_hasil = new System.Windows.Forms.GroupBox();
            this.lbl_nilai_mad = new System.Windows.Forms.Label();
            this.lbl_hasil = new System.Windows.Forms.Label();
            this.lbl_mad = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_db)).BeginInit();
            this.groupBox_prediksi.SuspendLayout();
            this.groupBox_input.SuspendLayout();
            this.groupBox_db.SuspendLayout();
            this.groupBox_hasil.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Exec
            // 
            this.btn_Exec.Location = new System.Drawing.Point(46, 79);
            this.btn_Exec.Name = "btn_Exec";
            this.btn_Exec.Size = new System.Drawing.Size(223, 37);
            this.btn_Exec.TabIndex = 0;
            this.btn_Exec.Text = "CEK !!!";
            this.btn_Exec.UseVisualStyleBackColor = true;
            this.btn_Exec.Click += new System.EventHandler(this.btn_Exec_Click);
            // 
            // lbl_tgl
            // 
            this.lbl_tgl.AutoSize = true;
            this.lbl_tgl.Location = new System.Drawing.Point(15, 27);
            this.lbl_tgl.Name = "lbl_tgl";
            this.lbl_tgl.Size = new System.Drawing.Size(64, 13);
            this.lbl_tgl.TabIndex = 1;
            this.lbl_tgl.Text = "TANGGAL :";
            // 
            // lbl_jml
            // 
            this.lbl_jml.AutoSize = true;
            this.lbl_jml.Location = new System.Drawing.Point(23, 55);
            this.lbl_jml.Name = "lbl_jml";
            this.lbl_jml.Size = new System.Drawing.Size(56, 13);
            this.lbl_jml.TabIndex = 2;
            this.lbl_jml.Text = "JUMLAH :";
            // 
            // tBox_tgl
            // 
            this.tBox_tgl.Location = new System.Drawing.Point(85, 26);
            this.tBox_tgl.Name = "tBox_tgl";
            this.tBox_tgl.Size = new System.Drawing.Size(104, 20);
            this.tBox_tgl.TabIndex = 3;
            // 
            // tBox_jml
            // 
            this.tBox_jml.Location = new System.Drawing.Point(85, 52);
            this.tBox_jml.Name = "tBox_jml";
            this.tBox_jml.Size = new System.Drawing.Size(104, 20);
            this.tBox_jml.TabIndex = 4;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Location = new System.Drawing.Point(312, 24);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(91, 13);
            this.lbl_title.TabIndex = 5;
            this.lbl_title.Text = "HASIL PREDIKSI";
            // 
            // dGV_db
            // 
            this.dGV_db.AllowUserToAddRows = false;
            this.dGV_db.AllowUserToDeleteRows = false;
            this.dGV_db.AllowUserToResizeColumns = false;
            this.dGV_db.AllowUserToResizeRows = false;
            this.dGV_db.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGV_db.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_db.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.no,
            this.tgl,
            this.jml});
            this.dGV_db.Location = new System.Drawing.Point(20, 25);
            this.dGV_db.Name = "dGV_db";
            this.dGV_db.ReadOnly = true;
            this.dGV_db.RowHeadersVisible = false;
            this.dGV_db.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dGV_db.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGV_db.Size = new System.Drawing.Size(279, 173);
            this.dGV_db.TabIndex = 6;
            this.dGV_db.SelectionChanged += new System.EventHandler(this.dGV_db_SelectionChanged);
            // 
            // no
            // 
            this.no.HeaderText = "No.";
            this.no.Name = "no";
            this.no.ReadOnly = true;
            // 
            // tgl
            // 
            this.tgl.HeaderText = "Tanggal";
            this.tgl.Name = "tgl";
            this.tgl.ReadOnly = true;
            // 
            // jml
            // 
            this.jml.HeaderText = "Jumlah";
            this.jml.Name = "jml";
            this.jml.ReadOnly = true;
            // 
            // groupBox_prediksi
            // 
            this.groupBox_prediksi.Controls.Add(this.cmb_cat1);
            this.groupBox_prediksi.Controls.Add(this.lbl_db);
            this.groupBox_prediksi.Controls.Add(this.btn_Exec);
            this.groupBox_prediksi.Location = new System.Drawing.Point(27, 55);
            this.groupBox_prediksi.Name = "groupBox_prediksi";
            this.groupBox_prediksi.Size = new System.Drawing.Size(315, 155);
            this.groupBox_prediksi.TabIndex = 7;
            this.groupBox_prediksi.TabStop = false;
            this.groupBox_prediksi.Text = "Cek Prediksi";
            // 
            // cmb_cat1
            // 
            this.cmb_cat1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_cat1.FormattingEnabled = true;
            this.cmb_cat1.Location = new System.Drawing.Point(133, 41);
            this.cmb_cat1.Name = "cmb_cat1";
            this.cmb_cat1.Size = new System.Drawing.Size(135, 21);
            this.cmb_cat1.TabIndex = 6;
            // 
            // lbl_db
            // 
            this.lbl_db.AutoSize = true;
            this.lbl_db.Location = new System.Drawing.Point(43, 44);
            this.lbl_db.Name = "lbl_db";
            this.lbl_db.Size = new System.Drawing.Size(66, 13);
            this.lbl_db.TabIndex = 5;
            this.lbl_db.Text = "Jenis Pulsa :";
            // 
            // btn_Reset
            // 
            this.btn_Reset.Location = new System.Drawing.Point(207, 29);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(75, 68);
            this.btn_Reset.TabIndex = 8;
            this.btn_Reset.Text = "CLEAR";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // groupBox_input
            // 
            this.groupBox_input.Controls.Add(this.btn_Delete);
            this.groupBox_input.Controls.Add(this.cmb_cat2);
            this.groupBox_input.Controls.Add(this.lbl_db2);
            this.groupBox_input.Controls.Add(this.btn_Insert);
            this.groupBox_input.Controls.Add(this.btn_Update);
            this.groupBox_input.Controls.Add(this.lbl_tgl);
            this.groupBox_input.Controls.Add(this.btn_Reset);
            this.groupBox_input.Controls.Add(this.lbl_jml);
            this.groupBox_input.Controls.Add(this.tBox_jml);
            this.groupBox_input.Controls.Add(this.tBox_tgl);
            this.groupBox_input.Location = new System.Drawing.Point(365, 55);
            this.groupBox_input.Name = "groupBox_input";
            this.groupBox_input.Size = new System.Drawing.Size(318, 155);
            this.groupBox_input.TabIndex = 10;
            this.groupBox_input.TabStop = false;
            this.groupBox_input.Text = "Insert | Update | Delete";
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(207, 109);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 35);
            this.btn_Delete.TabIndex = 11;
            this.btn_Delete.Text = "DELETE";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // cmb_cat2
            // 
            this.cmb_cat2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_cat2.FormattingEnabled = true;
            this.cmb_cat2.Location = new System.Drawing.Point(85, 78);
            this.cmb_cat2.Name = "cmb_cat2";
            this.cmb_cat2.Size = new System.Drawing.Size(104, 21);
            this.cmb_cat2.TabIndex = 10;
            // 
            // lbl_db2
            // 
            this.lbl_db2.AutoSize = true;
            this.lbl_db2.Location = new System.Drawing.Point(20, 81);
            this.lbl_db2.Name = "lbl_db2";
            this.lbl_db2.Size = new System.Drawing.Size(59, 13);
            this.lbl_db2.TabIndex = 9;
            this.lbl_db2.Text = "J. PULSA :";
            // 
            // btn_Insert
            // 
            this.btn_Insert.Location = new System.Drawing.Point(21, 109);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(75, 35);
            this.btn_Insert.TabIndex = 9;
            this.btn_Insert.Text = "INSERT";
            this.btn_Insert.UseVisualStyleBackColor = true;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(114, 109);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 35);
            this.btn_Update.TabIndex = 10;
            this.btn_Update.Text = "UPDATE";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // groupBox_db
            // 
            this.groupBox_db.Controls.Add(this.btn_Show);
            this.groupBox_db.Controls.Add(this.cmb_cat3);
            this.groupBox_db.Controls.Add(this.dGV_db);
            this.groupBox_db.Controls.Add(this.lbl_db3);
            this.groupBox_db.Location = new System.Drawing.Point(365, 227);
            this.groupBox_db.Name = "groupBox_db";
            this.groupBox_db.Size = new System.Drawing.Size(318, 242);
            this.groupBox_db.TabIndex = 11;
            this.groupBox_db.TabStop = false;
            this.groupBox_db.Text = "Data Database";
            // 
            // btn_Show
            // 
            this.btn_Show.Location = new System.Drawing.Point(203, 205);
            this.btn_Show.Name = "btn_Show";
            this.btn_Show.Size = new System.Drawing.Size(96, 29);
            this.btn_Show.TabIndex = 12;
            this.btn_Show.Text = "TAMPIL DATA";
            this.btn_Show.UseVisualStyleBackColor = true;
            this.btn_Show.Click += new System.EventHandler(this.btn_Show_Click);
            // 
            // cmb_cat3
            // 
            this.cmb_cat3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_cat3.FormattingEnabled = true;
            this.cmb_cat3.Location = new System.Drawing.Point(85, 210);
            this.cmb_cat3.Name = "cmb_cat3";
            this.cmb_cat3.Size = new System.Drawing.Size(104, 21);
            this.cmb_cat3.TabIndex = 13;
            // 
            // lbl_db3
            // 
            this.lbl_db3.AutoSize = true;
            this.lbl_db3.Location = new System.Drawing.Point(20, 213);
            this.lbl_db3.Name = "lbl_db3";
            this.lbl_db3.Size = new System.Drawing.Size(59, 13);
            this.lbl_db3.TabIndex = 12;
            this.lbl_db3.Text = "J. PULSA :";
            // 
            // groupBox_hasil
            // 
            this.groupBox_hasil.Controls.Add(this.lbl_nilai_mad);
            this.groupBox_hasil.Controls.Add(this.lbl_hasil);
            this.groupBox_hasil.Controls.Add(this.lbl_mad);
            this.groupBox_hasil.Location = new System.Drawing.Point(27, 227);
            this.groupBox_hasil.Name = "groupBox_hasil";
            this.groupBox_hasil.Size = new System.Drawing.Size(315, 242);
            this.groupBox_hasil.TabIndex = 12;
            this.groupBox_hasil.TabStop = false;
            this.groupBox_hasil.Text = "Hasil Prediksi";
            // 
            // lbl_nilai_mad
            // 
            this.lbl_nilai_mad.AutoSize = true;
            this.lbl_nilai_mad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nilai_mad.Location = new System.Drawing.Point(34, 57);
            this.lbl_nilai_mad.Name = "lbl_nilai_mad";
            this.lbl_nilai_mad.Size = new System.Drawing.Size(118, 15);
            this.lbl_nilai_mad.TabIndex = 17;
            this.lbl_nilai_mad.Text = "PREDIKSI (Pulsa -) :";
            // 
            // lbl_hasil
            // 
            this.lbl_hasil.AutoSize = true;
            this.lbl_hasil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hasil.Location = new System.Drawing.Point(34, 144);
            this.lbl_hasil.Name = "lbl_hasil";
            this.lbl_hasil.Size = new System.Drawing.Size(171, 15);
            this.lbl_hasil.TabIndex = 16;
            this.lbl_hasil.Text = "Hasil Prediksi hari berikutnya :";
            // 
            // lbl_mad
            // 
            this.lbl_mad.AutoSize = true;
            this.lbl_mad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mad.Location = new System.Drawing.Point(34, 116);
            this.lbl_mad.Name = "lbl_mad";
            this.lbl_mad.Size = new System.Drawing.Size(175, 15);
            this.lbl_mad.TabIndex = 15;
            this.lbl_mad.Text = "Metode yang dipakai adalah : -";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 486);
            this.Controls.Add(this.groupBox_hasil);
            this.Controls.Add(this.groupBox_db);
            this.Controls.Add(this.groupBox_input);
            this.Controls.Add(this.groupBox_prediksi);
            this.Controls.Add(this.lbl_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hasil Prediksi";
            ((System.ComponentModel.ISupportInitialize)(this.dGV_db)).EndInit();
            this.groupBox_prediksi.ResumeLayout(false);
            this.groupBox_prediksi.PerformLayout();
            this.groupBox_input.ResumeLayout(false);
            this.groupBox_input.PerformLayout();
            this.groupBox_db.ResumeLayout(false);
            this.groupBox_db.PerformLayout();
            this.groupBox_hasil.ResumeLayout(false);
            this.groupBox_hasil.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Exec;
        private System.Windows.Forms.Label lbl_tgl;
        private System.Windows.Forms.Label lbl_jml;
        private System.Windows.Forms.TextBox tBox_tgl;
        private System.Windows.Forms.TextBox tBox_jml;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.DataGridView dGV_db;
        private System.Windows.Forms.GroupBox groupBox_prediksi;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Label lbl_db;
        private System.Windows.Forms.ComboBox cmb_cat1;
        private System.Windows.Forms.GroupBox groupBox_input;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.ComboBox cmb_cat2;
        private System.Windows.Forms.Label lbl_db2;
        private System.Windows.Forms.DataGridViewTextBoxColumn no;
        private System.Windows.Forms.DataGridViewTextBoxColumn tgl;
        private System.Windows.Forms.DataGridViewTextBoxColumn jml;
        private System.Windows.Forms.GroupBox groupBox_db;
        private System.Windows.Forms.Button btn_Show;
        private System.Windows.Forms.ComboBox cmb_cat3;
        private System.Windows.Forms.Label lbl_db3;
        private System.Windows.Forms.GroupBox groupBox_hasil;
        private System.Windows.Forms.Label lbl_mad;
        private System.Windows.Forms.Label lbl_hasil;
        private System.Windows.Forms.Label lbl_nilai_mad;
    }
}

