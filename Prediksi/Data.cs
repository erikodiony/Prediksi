using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prediksi
{
    class Data
    {
        internal static class Result
        {
            public static string[] Data_Tgl;
            public static int[] Data_Jml;
            public static string Winner;
            public static double[] Hasil_Prediksi;

            #region DATA SES
            public static double[] Data_SES_MAD;
            public static double[] Data_SES_Prediksi;

            public static double Data_SES_MAD_Rerata;
            #endregion
            #region DATA LS
            public static double[] Data_LS_X;
            public static double[] Data_LS_Xpangkat2;
            public static double[] Data_LS_XY;
            public static double[] Data_LS_Y;

            public static double SUM_Data_LS_Y; //Data Jumlah untuk menghitung A & B
            public static double SUM_Data_LS_X; //Time Series untuk menghitung A & B
            public static double SUM_Data_LS_Xpangkat2;
            public static double SUM_Data_LS_XY;

            public static double Data_LS_A;
            public static double Data_LS_B;
            public static int PointTimeSeries;

            public static double[] Data_LS_Y2; //Data Jumlah untuk menghitung MAD
            public static double[] Data_LS_X2; //Time Series untuk menghitung MAD
            public static double[] Data_LS_Prediksi;
            public static double[] Data_LS_MAD;

            public static double Data_LS_MAD_Rerata;
            #endregion            
        }
        internal static class Attr_form
        {
            public static readonly string[] cat = new string[] { "5", "10", "20" };
        }
        internal static class Attr_MBox
        {
            public static readonly string title_Err = "ERROR";
            public static readonly string title_OK = "SUCCESS";
            public static readonly string Err_ConnDB = "Gagal Terhubung dengan Database !";
            public static readonly string Err_Input = "Kolom masih kosong !\nHarap di isi !";
            public static readonly string OK_InsertDB = "Data berhasil di simpan !";
            public static readonly string OK_UpdateDB = "Data berhasil di update !";
            public static readonly string OK_DeleteDB = "Data berhasil di hapus !";
        }

        public void Count_SES_MAD()
        {

        }

    }
}