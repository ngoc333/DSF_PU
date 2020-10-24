using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace IPEX_Monitor.ClassLib
{
   public class ExcelReader
    {
        #region Excel reader


        /// <summary>
        /// Read_Excel : Read Excel File -> Return : DataSet
        /// </summary>
        /// <param name="arg_dtsrc">Full path to excel file</param>
        /// <returns></returns>
        public static DataSet Read_Excel(string arg_dtsrc)
        {

            try
            {
                OleDbConnection AdoConn = null;
                OleDbDataAdapter oraDA = null;
                DataSet oraDS = new DataSet("OraDataSet");


                //string ExcelCon=@"Provider=Microsoft.Jet.OLED B.4.0;Data Source="+arg_dtsrc+";Excel 8.0;Imex=1;HDR=NO"; 

                // imex = 0 : export, 1 : import, 2 : update
                //string ExcelCon = @"Microsoft.Jet.OLEDB.12.0;Data Source=" + arg_dtsrc + @";Extended Properties=""Excel 12.;HDR=No;IMEX=1""";

                string ExcelCon = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + arg_dtsrc + @";Extended Properties=""Excel 8.0;HDR=No;IMEX=1""";


                AdoConn = new OleDbConnection(ExcelCon);
               // AdoConn.Close();
                AdoConn.Open();


                DataTable sheetNameTable = AdoConn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });
                for (int i = 0; i < sheetNameTable.Rows.Count; i++)
                {


                    string sheetName = sheetNameTable.Rows[i].ItemArray.GetValue(2).ToString();
                    if (sheetName.Contains("$_")) continue;
                    string AdoSQL = @"SELECT * FROM [" + sheetName + "]";

                    OleDbCommand Cmd = new OleDbCommand(AdoSQL, AdoConn);
                    oraDA = new OleDbDataAdapter(Cmd);
                    oraDA.Fill(oraDS, sheetName);

                    //oraDS.Namespace = sheetName;
                }

                AdoConn.Close();
                return oraDS;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;

            }
          
        }




        /// <summary>
        /// Read Excel file
        /// </summary>
        /// <param name="arg_dtsrc">¿¢¼¿ ÆÄÀÏ °æ·Î (ÆÄÀÏ ÀÌ¸§±îÁö Ç® °æ·Î)</param>
        /// <param name="arg_sql">sql string</param>
        public static OleDbDataReader Read_Excel(string arg_dtsrc, string arg_sql)
        {
            OleDbConnection AdoConn = null;
            OleDbDataReader reader = null;

            string ExcelCon = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + arg_dtsrc + ";Excel 8.0;Imex=1;HDR=YES";


            AdoConn = new OleDbConnection(ExcelCon);
            AdoConn.Close();
            AdoConn.Open();

            string AdoSQL = arg_sql;

            OleDbCommand Cmd = new OleDbCommand(AdoSQL, AdoConn);
            reader = Cmd.ExecuteReader();

            return reader;
        }




        #endregion
    }
}
