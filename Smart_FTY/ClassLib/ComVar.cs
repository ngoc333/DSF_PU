using System;
using System.Data;
using System.Drawing;
using System.Data.OracleClient;


namespace Smart_FTY
{
	/// <summary>
	/// ComVar�� ���� ��� �����Դϴ�.
	/// </summary>
	public class ComVar 
	{
		public ComVar()
		{
			//
			// TODO: ���⿡ ������ ���� �߰��մϴ�.
			//
		}
        public static string Form_Type = "1";

        public static Form_Home_PU _frm_home = new Form_Home_PU();
        public static FORM_PU_DEFFECTIVE_STATUS _frmDefective = new FORM_PU_DEFFECTIVE_STATUS();
        public static FORM_PU_DEFFECTIVE_STATUS_YEAR _frmDefectiveYear = new FORM_PU_DEFFECTIVE_STATUS_YEAR();
        //public static string This_Action;
        //public static string This_Win_ID;
        //public static string This_PGM = "MOLD";
        //public static string This_Packages;
        //public static string This_REF1 = "";
        //public static string This_REF2 = "";
        //public static string This_REF3 = "";
        ////public static string This_User = "admin";
        //// ������
        //public const string Insert = "I";
        //public const string Update = "U";
        //public const string Delete = "D";
	}
}
