using System;
using System.Data;
using System.Windows.Forms;
using static Prediksi.Data;

namespace Prediksi
{
    public partial class Form1 : Form
    {
        Process proc = new Process();

        public Form1()
        {
            InitializeComponent();
            SetComboBox();
            dGV_db.Columns[0].Width = 40;
            lbl_nilai_mad.Text = string.Format("PREDIKSI (Pulsa -) :{0}{0}Metode SES : 0 | Metode LS : 0", Environment.NewLine);
            lbl_hasil.Text = string.Format("Hasil Prediksi hari berikutnya :{0}{0}Prediksi: - | (Min: - | Max: -)", Environment.NewLine);
        }
 
        #region Button Pressed Event
        private void btn_Exec_Click(object sender, EventArgs e)
        {
            ShowResult(proc.SetValueComboBox(cmb_cat1.SelectedItem.ToString()));
            lbl_nilai_mad.Text = string.Format("PREDIKSI (Pulsa {3}) :{0}{0}Metode SES : {1} | Metode LS : {2}", Environment.NewLine, Result.Data_SES_MAD_Rerata, Result.Data_LS_MAD_Rerata, cmb_cat1.SelectedItem.ToString());
            lbl_mad.Text = string.Format("Metode yang dipakai adalah : {0}", Result.Winner);
            if (Result.Hasil_Prediksi != null)
            {
                lbl_hasil.Text = string.Format("Hasil Prediksi hari berikutnya :{0}{0}Prediksi: {1} | (Min: {2} | Max: {3})", Environment.NewLine, Result.Hasil_Prediksi[0], Result.Hasil_Prediksi[1], Result.Hasil_Prediksi[2]);
            }
        }
        private void btn_Reset_Click(object sender, EventArgs e)
        {
            tBox_jml.Text = string.Empty;
            tBox_tgl.Text = string.Empty;
            dGV_db.DataSource = null;
        }
        private void btn_Insert_Click(object sender, EventArgs e)
        {
            if (tBox_tgl.Text == string.Empty && tBox_jml.Text == string.Empty)
            {
                proc.ShowMessageBox(Attr_MBox.title_Err, Attr_MBox.Err_Input);
            }
            else
            {
                proc.INSERT_DB(tBox_tgl.Text, tBox_jml.Text, proc.SetValueComboBox(cmb_cat2.SelectedItem.ToString()));
                Reload(proc.SetValueComboBox(cmb_cat2.SelectedItem.ToString()));
            }
        }
        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (tBox_tgl.Text == string.Empty && tBox_jml.Text == string.Empty)
            {
                proc.ShowMessageBox(Attr_MBox.title_Err, Attr_MBox.Err_Input);
            }
            else
            {
                object[] data = GetSelectedRow();
                proc.UPDATE_DB(tBox_tgl.Text, tBox_jml.Text, proc.SetValueComboBox(cmb_cat2.SelectedItem.ToString()), (string)data[0], (string)data[1]);
                Reload(proc.SetValueComboBox(cmb_cat2.SelectedItem.ToString()));
            }
        }
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (tBox_tgl.Text == string.Empty && tBox_jml.Text == string.Empty)
            {
                proc.ShowMessageBox(Attr_MBox.title_Err, Attr_MBox.Err_Input);
            }
            else
            {
                object[] data = GetSelectedRow();
                proc.DELETE_DB((string)data[0], (string)data[1], proc.SetValueComboBox(cmb_cat2.SelectedItem.ToString()));
                Reload(proc.SetValueComboBox(cmb_cat2.SelectedItem.ToString()));
            }
        }
        private void btn_Show_Click(object sender, EventArgs e)
        {
            Reload(proc.SetValueComboBox(cmb_cat3.SelectedItem.ToString()));
        }
        #endregion

        #region Other Event
        public object[] GetSelectedRow()
        {
            object[] result;
            string get_Tgl = string.Empty;
            string get_Jml = string.Empty;
            int get_Cat = 0;
            foreach (DataGridViewRow row in dGV_db.SelectedRows)
            {
                get_Tgl = row.Cells[1].Value.ToString();
                get_Jml = row.Cells[2].Value.ToString();
                get_Cat = cmb_cat3.SelectedIndex;
            }
            result = new object[] { get_Tgl, get_Jml, get_Cat };
            return result;
        }
        private void dGV_db_SelectionChanged(object sender, EventArgs e)
        {
            object[] data = GetSelectedRow();
            InsertTBox(data[0].ToString(), data[1].ToString(), (int)data[2]);
        }
        #endregion

        #region Other Function
        private void SetComboBox()
        {
            foreach (var x in Data.Attr_form.cat)
            {
                cmb_cat1.Items.Add(x);
                cmb_cat2.Items.Add(x);
                cmb_cat3.Items.Add(x);
            }
            cmb_cat1.SelectedIndex = 0;
            cmb_cat2.SelectedIndex = 0;
            cmb_cat3.SelectedIndex = 0;
        }
        private void InsertTBox(string tgl, string jml, int cat)
        {
            tBox_tgl.Text = tgl;
            tBox_jml.Text = jml;
            cmb_cat2.SelectedIndex = cat;
        }
        public void Reload(string cat)
        {
            SetBinding(proc.SELECT_DB(cat, true));
            dGV_db.Update();
            dGV_db.Refresh();
        }
        public void ShowResult(string cat)
        {
            proc.SELECT_DB(cat, false);
        }
        private void SetBinding(DataTable dt)
        {
            if (dt != null)
            {
                dGV_db.AutoGenerateColumns = false;
                dGV_db.Columns[0].DataPropertyName = dt.Columns[2].ToString();
                dGV_db.Columns[1].DataPropertyName = dt.Columns[0].ToString();
                dGV_db.Columns[2].DataPropertyName = dt.Columns[1].ToString();
                dGV_db.DataSource = dt;
            }
        }
        #endregion
    }
}