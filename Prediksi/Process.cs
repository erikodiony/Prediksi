using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
using static Prediksi.Data;

namespace Prediksi
{
    class Process
    {
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt;

        public bool Koneksi()
        {
            try
            {
                string connstr = "server=localhost;database=prediksi;uid=root;pwd=;";
                conn = new MySqlConnection(connstr);
                conn.Open();
                return true;
            }
            catch(Exception)
            {
                conn.Close();
                return false;
            }
        }

        public DataTable SELECT_DB(string cat, bool type)
        {
            if (Koneksi() == true)
            {
                dt = new DataTable();
                string command = String.Format("SELECT * FROM `{0}` ORDER BY `Tanggal` ASC;", cat);
                cmd = new MySqlCommand(command, conn);
                adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);

                Result.Data_Jml = new int[dt.Rows.Count];
                Result.Data_Tgl = new string[dt.Rows.Count];

                int i = 0;
                foreach (DataRow row in dt.Rows)
                {
                    Result.Data_Jml[i] = Convert.ToInt32(dt.Rows[i][1]);
                    Result.Data_Tgl[i] = dt.Rows[i][0].ToString();
                    i++;
                }

                if (type == true)
                {
                    dt.Columns.Add("no", typeof(System.Int32));
                    dt.Columns.Add("ses", typeof(System.String));
                    dt.Columns.Add("ls", typeof(System.String));

                    int inc = 1;
                    foreach (DataRow row in dt.Rows)
                    {
                        row["no"] = inc;
                        inc++;
                    }
                }
                else
                {
                    Count_SES();
                    Count_LS();

                    if (Result.Data_LS_MAD_Rerata < Result.Data_SES_MAD_Rerata)
                    {
                        Result.Winner = "LS";
                        Count_LS_MinMax();
                    }
                    else
                    {
                        Result.Winner = "SES";
                        Count_SES_MinMax();
                    }
                }
                return dt;
            }
            else
            {
                ShowMessageBox(Attr_MBox.title_Err, Attr_MBox.Err_ConnDB);
                return null;
            }
        }

        public void INSERT_DB(string tgl, string jml, string cat)
        {
            if (Koneksi() == true)
            {
                string command = String.Format("INSERT INTO `{0}`(`Tanggal`, `jumlah`) VALUES ('{1}','{2}')", cat, tgl, jml);
                cmd = new MySqlCommand(command, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                ShowMessageBox(Attr_MBox.title_OK, Attr_MBox.OK_InsertDB);                
            }
            else
            {
                ShowMessageBox(Attr_MBox.title_Err, Attr_MBox.Err_ConnDB);
            }
        }
        public void UPDATE_DB(string tgl_new, string jml_new, string cat, string tgl, string jml)
        {
            if (Koneksi() == true)
            {
                string command = String.Format("UPDATE `{0}` SET `Tanggal`='{1}',`jumlah`='{2}' WHERE `Tanggal`='{3}' AND `jumlah`='{4}'", cat, tgl_new, jml_new, tgl, jml);
                cmd = new MySqlCommand(command, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                ShowMessageBox(Attr_MBox.title_OK, Attr_MBox.OK_UpdateDB);
            }
            else
            {
                ShowMessageBox(Attr_MBox.title_Err, Attr_MBox.Err_ConnDB);
            }
        }
        public void DELETE_DB(string tgl, string jml, string cat)
        {
            if (Koneksi() == true)
            {
                string command = String.Format("DELETE FROM `{0}` WHERE `Tanggal`='{1}' AND `jumlah`='{2}'", cat, tgl, jml);
                cmd = new MySqlCommand(command, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                ShowMessageBox(Attr_MBox.title_OK, Attr_MBox.OK_DeleteDB);
            }
            else
            {
                ShowMessageBox(Attr_MBox.title_Err, Attr_MBox.Err_ConnDB);
            }
        }

        public void Count_SES()
        {
            Count_SES_Prediksi();
            Count_SES_MAD();
        }

        public void Count_LS()
        {
            Count_LS_X();
            Count_LS_Xpangkat2();
            Count_LS_XY();
            Count_LS_Y();
            Count_LS_AB();

            Count_LS_X2();
            Count_LS_Y2();
            Count_LS_Prediksi();
            Count_LS_MAD();
        }

        public void ShowMessageBox(string title, string msg)
        {
            MessageBox.Show(msg, title);
        }

        public string SetValueComboBox(string val)
        {
            if (val == "5")
            {
                return "lima";
            }
            else if (val == "10")
            {
                return "sepuluh";
            }
            else
            {
                return "duapuluh";
            }
        }

        public void Count_SES_Prediksi()
        {
            double[] temp = new double[Result.Data_Jml.Length];
            temp[0] = Result.Data_Jml[0];
            for (int i = 1; i < Result.Data_Jml.Length; i++)
            {
                temp[i] = Math.Ceiling(temp[i - 1] + 0.1 * (Result.Data_Jml[i - 1] - temp[i - 1]));                
            }

            Result.Data_SES_Prediksi = temp;
        }

        public void Count_SES_MAD()
        {
            double[] temp = new double[Result.Data_Jml.Length];
            for (int i = 0; i < Result.Data_Jml.Length; i++)
            {
                temp[i] = Math.Abs(Result.Data_Jml[i] - Result.Data_SES_Prediksi[i]);
            }

            Result.Data_SES_MAD = temp;
            Result.Data_SES_MAD_Rerata = Math.Round((temp.Sum() / temp.Length), 2);
        }

        public void Count_SES_MinMax()
        {
            double res;
            double res_min;
            double res_max;
            double[] temp;

            res = Math.Ceiling(Result.Data_SES_Prediksi[Result.Data_SES_Prediksi.Length - 1] + 0.1 * (Result.Data_Jml[Result.Data_Jml.Length - 1] - Result.Data_SES_Prediksi[Result.Data_SES_Prediksi.Length - 1]));
            res_min = res - Math.Ceiling(Result.Data_SES_MAD_Rerata);
            res_max = res + Math.Ceiling(Result.Data_SES_MAD_Rerata);

            temp = new double[3] { res, res_min, res_max };
            Result.Hasil_Prediksi = temp;
        }

        public void Count_LS_Y()
        {
            if (Result.Data_Jml.Length % 2 == 0)
            {
                double[] temp = new double[Result.Data_Jml.Length / 2];

                int inc = 0;
                foreach (var x in temp)
                {
                    temp[inc] = Result.Data_Jml[inc];
                    inc++;
                }
                Result.Data_LS_Y = temp;
            }
            else
            {
                double[] temp = new double[(Result.Data_Jml.Length + 1) / 2];

                int inc = 0;
                foreach (var x in temp)
                {
                    temp[inc] = Result.Data_Jml[inc];
                    inc++;
                }
                Result.Data_LS_Y = temp;
            }
        }

        public void Count_LS_X()
        {
            if (Result.Data_Jml.Length % 2 == 0)
            {
                double[] temp;
                int div;
                if ((Result.Data_Jml.Length / 2) % 2 == 0)
                {
                    temp = new double[Result.Data_Jml.Length / 2];
                    div = Result.Data_Jml.Length / 4;
                    Result.Data_LS_X = Count_LS_TimeSeries_A(temp, div);
                }
                else
                {
                    temp = new double[Result.Data_Jml.Length / 2];
                    div = ((Result.Data_Jml.Length / 2) - 1) / 2;
                    Result.Data_LS_X = Count_LS_TimeSeries_B(temp, div);
                }
                Result.PointTimeSeries = div;
            }
            else
            {
                double[] temp;
                int div;
                if (((Result.Data_Jml.Length + 1) / 2) % 2 == 0)
                {
                    temp = new double[(Result.Data_Jml.Length + 1) / 2];
                    div = (Result.Data_Jml.Length + 1) / 4;
                    Result.Data_LS_X = Count_LS_TimeSeries_A(temp, div);
                }
                else
                {
                    temp = new double[(Result.Data_Jml.Length + 1) / 2];
                    div = (((Result.Data_Jml.Length + 1) / 2) - 1) / 2;
                    Result.Data_LS_X = Count_LS_TimeSeries_B(temp, div);
                }
                Result.PointTimeSeries = div;
            }
        }

        public double[] Count_LS_TimeSeries_A(double[] temp, int div)
        {
            int inc = 0;
            for (int i = -div; i < 0; i++)
            {
                temp[inc] = i;
                inc++;
            }

            int inc2 = div;
            for (int i = 1; i <= div; i++)
            {
                temp[inc2] = i;
                inc2++;
            }
            return temp;
        }

        public double[] Count_LS_TimeSeries_B(double[] temp, int div)
        {
            int inc = 0;
            for (int i = -div; i <= 0; i++)
            {
                temp[inc] = i;
                inc++;
            }

            int inc2 = div + 1;
            for (int i = 1; i <= div; i++)
            {
                temp[inc2] = i;
                inc2++;
            }
            return temp;
        }

        public void Count_LS_Xpangkat2()
        {
            double[] temp = new double[Result.Data_LS_X.Length];

            int inc = 0;
            foreach (var x in Result.Data_LS_X)
            {
                temp[inc] = Math.Pow(Result.Data_LS_X[inc], 2);
                inc++;
            }
            Result.Data_LS_Xpangkat2 = temp;
        }

        public void Count_LS_XY()
        {
            double[] temp = new double[Result.Data_LS_X.Length];

            for (int i = 0; i < Result.Data_LS_X.Length; i++)
            {
                temp[i] = Result.Data_LS_X[i] * Result.Data_Jml[i];
            }
            Result.Data_LS_XY = temp;
        }

        public void Count_LS_AB()
        {
            Result.SUM_Data_LS_Y = Result.Data_LS_Y.Sum();
            Result.SUM_Data_LS_X = Result.Data_LS_X.Sum();
            Result.SUM_Data_LS_Xpangkat2 = Result.Data_LS_Xpangkat2.Sum();
            Result.SUM_Data_LS_XY = Result.Data_LS_XY.Sum();

            Result.Data_LS_A = Result.SUM_Data_LS_Y / Result.Data_LS_Y.Length;
            Result.Data_LS_B = Result.SUM_Data_LS_XY / Result.SUM_Data_LS_Xpangkat2;
        }

        public void Count_LS_Prediksi()
        {
            double[] temp = new double[Result.Data_Jml.Length - Result.Data_LS_X.Length];

            for (int i = 0; i < (Result.Data_Jml.Length - Result.Data_LS_X.Length); i++)
            {
                temp[i] = Math.Ceiling(Result.Data_LS_A + (Result.Data_LS_B * Result.Data_LS_X2[i]));
            }
            Result.Data_LS_Prediksi = temp;
        }

        public void Count_LS_Y2()
        {
            double[] temp = new double[Result.Data_Jml.Length - Result.Data_LS_X.Length];

            int inc = Result.Data_Jml.Length - Result.Data_LS_X.Length;
            for (int i = 0; i < (Result.Data_Jml.Length - Result.Data_LS_X.Length); i++)
            {
                temp[i] = Result.Data_Jml[inc];
                inc++;
            }
            Result.Data_LS_Y2 = temp;
        }

        public void Count_LS_MAD()
        {
            double[] temp = new double[Result.Data_Jml.Length - Result.Data_LS_X.Length];

            for (int i = 0; i < (Result.Data_Jml.Length - Result.Data_LS_X.Length); i++)
            {
                temp[i] = Math.Abs(Result.Data_LS_Y2[i] - Result.Data_LS_Prediksi[i]);
            }

            Result.Data_LS_MAD = temp;
            Result.Data_LS_MAD_Rerata = Math.Round((Result.Data_LS_MAD.Sum() / Result.Data_LS_MAD.Length),2);
        }

        public void Count_LS_X2()
        {
            double[] temp = new double[Result.Data_Jml.Length - Result.Data_LS_X.Length];
            int val = Result.PointTimeSeries + 1;
            for (int i = 0; i < (Result.Data_Jml.Length - Result.Data_LS_X.Length); i++)
            {
                temp[i] = Convert.ToDouble(val);
                val++;
            }
            Result.Data_LS_X2 = temp;
        }

        public void Count_LS_MinMax()
        {
            double res;
            double res_min;
            double res_max;
            double[] temp;
            double x2 = Result.Data_LS_X2[Result.Data_LS_X2.Length - 1] + 1;

            res = Math.Ceiling(Result.Data_LS_A + (Result.Data_LS_B * x2));
            res_min = res - Math.Ceiling(Result.Data_LS_MAD_Rerata);
            res_max = res + Math.Ceiling(Result.Data_LS_MAD_Rerata);

            temp = new double[3] { res, res_min, res_max };
            Result.Hasil_Prediksi = temp;
        }
    }
}
