using System.Collections.Generic;

namespace Com_Base
{
    public class Variables
    {
        public Variables()
        {
           
        }

        /// <summary>
        /// 
        /// </summary>
       //public static WebSvc.OraPKG _WebSvc = new WebSvc.OraPKG();
        public static System.Windows.Forms.ImageList img_Button = new System.Windows.Forms.ImageList();
         public static string  ZONE_ ="";
        /// <summary>
        /// 
        /// </summary>
        public enum Log_Type : int
        {
            Write_File_DB = 0,
            Write_File = 1,
            Write_DB = 2,
            Write_NOLog = 3
        }

        public enum ComboList_Visible : int
        {
            Code = 0,				// ÄÚµå¸¸ º¸ÀÓ
            Name = 1,				// Description ¸¸ º¸ÀÓ
            Code_Name = 2			// ÄÚµå, Description ¸ðµÎ º¸ÀÓ
        }

        public static int frm_show = 2;
        public static int _time_auto = 40000;
        public static int _time_keypress = 180000;
        public static bool _iskeypress = false;

        public static Dictionary<string, string>[] Form;

        //public static C1.Win.C1FlexGrid.CellStyle Cell_St;
        //public static C1.Win.C1FlexGrid.CellRange Cell_Rg;
    }
}
