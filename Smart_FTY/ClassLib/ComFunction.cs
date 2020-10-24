using System;
using System.Reflection;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;

using FarPoint.Win.Spread;
using System.Data.OleDb;
using Microsoft.Office.Core;
using System.IO;
using System.Drawing.Imaging;


namespace IPEX_Monitor.ClassLib
{



    /// <summary>
    /// Common_Function에 대한 요약 설명입니다.
    /// </summary>
    public class ComFunction : COM.ComFunction
    {

        private static string[] _specialChar = new string[] { "\"", "'", "|" };


        public ComFunction()
        {
            //
            // TODO: 여기에 생성자 논리를 추가합니다.
            //
        }


        #region Neomics 이행관련
        /// <summary>
        /// Select_GroupCode : Group코드 리스트 SELECT(대분류)
        /// </summary>
        /// <param name="arg_group_type">Type</param>
        /// <returns>DataTable</returns>
        public static DataTable Select_ClassTypeCode()
        {
            COM.OraDB oraDB = new COM.OraDB();

            string Proc_Name = "PKG_SBC_NEOMICS.SELECT_SBC_CLASS";

            oraDB.ReDim_Parameter(1);
            oraDB.Process_Name = Proc_Name;

            oraDB.Parameter_Name[0] = "OUT_CURSOR";

            oraDB.Parameter_Type[0] = (int)OracleType.Cursor;

            oraDB.Parameter_Values[0] = "";

            oraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = oraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];
        }
        #endregion

        #region 이정한 추가

        /// <summary>
        /// KeyEnter_Tab : KEY ENTER시 TAB 이동
        /// </summary>		
        /// <returns></returns>
        public static void KeyEnter_Tab(System.Windows.Forms.KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)13)
                {
                    System.Windows.Forms.SendKeys.Send("{TAB}");
                }
            }
            catch
            {
            }
        }


        /// <summary>
        /// Init_Form_Control : Form Control 초기화
        /// </summary>		
        /// <returns></returns>
        public static void Init_Form_Control(System.Windows.Forms.Form arg_Form)
        {
            try
            {
                //컨트롤 셋팅
                FieldInfo[] infos = arg_Form.GetType().GetFields(BindingFlags.GetField | BindingFlags.IgnoreCase | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);

                TextBox txtctrl = null;
                foreach (FieldInfo info in infos)
                {
                    switch (info.FieldType.Name)
                    {
                        case "TextBox":
                            txtctrl = (TextBox)info.GetValue(arg_Form);
                            //대문자 입력만 되게
                            txtctrl.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
                            //폰트
                            txtctrl.Font = new System.Drawing.Font("Verdana", 8.5F);
                            break;
                    }

                }

            }
            catch
            {
            }
        }

        /// <summary>
        /// Init_MenuRole : menu 이름과 권한
        /// </summary>		
        /// <returns></returns>
        //public static void Init_MenuRole(System.Windows.Forms.Form arg_form, System.Windows.Forms.Label arg_label, C1.Win.C1Command.C1Command tbtn_search, C1.Win.C1Command.C1Command tbtn_save, C1.Win.C1Command.C1Command tbtn_print)
        //{
        //    try
        //    {
        //        //프로그램 이름
        //        DataTable dt_ret;
        //        dt_ret = Select_MenuRole(arg_form.Name);

        //        arg_form.Text = dt_ret.Rows[0].ItemArray[0].ToString();
        //        arg_label.Text = dt_ret.Rows[0].ItemArray[0].ToString();

        //        tbtn_search.Enabled = (dt_ret.Rows[0].ItemArray[1].ToString() == "Y") ? true : false;
        //        tbtn_save.Enabled = (dt_ret.Rows[0].ItemArray[2].ToString() == "Y") ? true : false;
        //        tbtn_print.Enabled = (dt_ret.Rows[0].ItemArray[3].ToString() == "Y") ? true : false;

        //    }
        //    catch
        //    {
        //    }
        //}

        /// <summary>
        /// SELECT_SCM_CUST_LIST : 거래처리스트
        /// </summary>
        /// <param name="arg_factory">공장코드</param>
        /// <param name="arg_value">검색어</param>
        /// <returns>DataTable</returns>
        public static DataTable SELECT_SCM_CUST_LIST(string arg_factory, string arg_value)
        {
            COM.OraDB oraDB = new COM.OraDB();

            string Proc_Name = "PKG_SBC_COMMON.SELECT_SCM_CUST_LIST";

            oraDB.ReDim_Parameter(3);
            oraDB.Process_Name = Proc_Name;

            oraDB.Parameter_Name[0] = "ARG_FACTORY";
            oraDB.Parameter_Name[1] = "ARG_VALUE";
            oraDB.Parameter_Name[2] = "OUT_CURSOR";

            oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            oraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            oraDB.Parameter_Type[2] = (int)OracleType.Cursor;

            oraDB.Parameter_Values[0] = COM.ComFunction.Empty_String(arg_factory, " ");
            oraDB.Parameter_Values[1] = COM.ComFunction.Empty_String(arg_value, " ");
            oraDB.Parameter_Values[2] = "";

            oraDB.Add_Select_Parameter(false);
            DataSet DS_Ret = oraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];
        }




        /// <summary>
        /// SELECT_SCM_CUST_LIST : 거래처리스트
        /// </summary>
        /// <param name="arg_factory">공장코드</param>
        /// <param name="arg_value">검색어</param>
        /// <returns>DataTable</returns>
        public static DataTable SELECT_SCM_DEPT_LIST(string arg_factory, string arg_value)
        {
            COM.OraDB oraDB = new COM.OraDB();

            string Proc_Name = "PKG_SBC_COMMON.SELECT_SCM_DEPT_LIST";

            oraDB.ReDim_Parameter(3);
            oraDB.Process_Name = Proc_Name;

            oraDB.Parameter_Name[0] = "ARG_FACTORY";
            oraDB.Parameter_Name[1] = "ARG_VALUE";
            oraDB.Parameter_Name[2] = "OUT_CURSOR";

            oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            oraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            oraDB.Parameter_Type[2] = (int)OracleType.Cursor;

            oraDB.Parameter_Values[0] = COM.ComFunction.Empty_String(arg_factory, " ");
            oraDB.Parameter_Values[1] = COM.ComFunction.Empty_String(arg_value, " ");
            oraDB.Parameter_Values[2] = "";

            oraDB.Add_Select_Parameter(false);
            DataSet DS_Ret = oraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];
        }





        /// <summary>
        /// Select_MenuRole : MENU NAME & ROLE  
        /// </summary>
        /// <param name="arg_menuid">MENU ID</param>
        /// <returns>DataTable</returns>
        public static DataTable Select_MenuRole(string arg_menuid)
        {
            COM.OraDB oraDB = new COM.OraDB();

            string Proc_Name = "PKG_SBC_COMMON.SELECT_MENU_ROLE";

            oraDB.ReDim_Parameter(3);
            oraDB.Process_Name = Proc_Name;

            oraDB.Parameter_Name[0] = "ARG_USER";
            oraDB.Parameter_Name[1] = "ARG_MENUID";
            oraDB.Parameter_Name[2] = "OUT_CURSOR";

            oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            oraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            oraDB.Parameter_Type[2] = (int)OracleType.Cursor;

            oraDB.Parameter_Values[0] = COM.ComVar.This_User;
            oraDB.Parameter_Values[1] = arg_menuid;
            oraDB.Parameter_Values[2] = "";

            oraDB.Add_Select_Parameter(false);
            DataSet DS_Ret = oraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];
        }

        #endregion

        #region 조남숙 추가

        #region Group 관련

        /// <summary>
        /// Get_Next_Group_Cd : 다음 아이템 그룹 코드 추출
        /// </summary>
        /// <param name="arg_level"></param>
        /// <param name="arg_group_type"></param>
        /// <param name="arg_group_l"></param>
        /// <param name="arg_group_m"></param>
        /// <returns></returns>
        public static string Get_Next_Group_Cd(string arg_level, string arg_group_type, string arg_group_l, string arg_group_m)
        {
            try
            {
                COM.OraDB oraDB = new COM.OraDB();

                string Proc_Name = "PKG_SBC_ITEM_GROUP.GET_NEXT_GROUP_CD";

                oraDB.ReDim_Parameter(5);
                oraDB.Process_Name = Proc_Name;

                oraDB.Parameter_Name[0] = "ARG_LEVEL";
                oraDB.Parameter_Name[1] = "ARG_GROUP_TYPE";
                oraDB.Parameter_Name[2] = "ARG_GROUP_L";
                oraDB.Parameter_Name[3] = "ARG_GROUP_M";
                oraDB.Parameter_Name[4] = "OUT_CURSOR";

                oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                oraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                oraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                oraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                oraDB.Parameter_Type[4] = (int)OracleType.Cursor;

                oraDB.Parameter_Values[0] = arg_level;
                oraDB.Parameter_Values[1] = Empty_String(arg_group_type, " ");
                oraDB.Parameter_Values[2] = Empty_String(arg_group_l, " ");
                oraDB.Parameter_Values[3] = Empty_String(arg_group_m, " ");
                oraDB.Parameter_Values[4] = "";

                oraDB.Add_Select_Parameter(true);
                DataSet DS_Ret = oraDB.Exe_Select_Procedure();

                if (DS_Ret == null) return null;
                return DS_Ret.Tables[Proc_Name].Rows[0].ItemArray[0].ToString();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Get_Next_Group_Cd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }


        /// <summary>
        /// Select_GroupCode : Group코드 리스트 SELECT(대분류)
        /// </summary>
        /// <param name="arg_group_type">Type</param>
        /// <returns>DataTable</returns>
        public static DataTable Select_GroupTypeCode()
        {
            COM.OraDB oraDB = new COM.OraDB();

            string Proc_Name = "PKG_SBC_ITEM_GROUP.SELECT_SBC_ITEM_GROUP_TYPE";

            oraDB.ReDim_Parameter(1);
            oraDB.Process_Name = Proc_Name;

            oraDB.Parameter_Name[0] = "OUT_CURSOR";

            oraDB.Parameter_Type[0] = (int)OracleType.Cursor;

            oraDB.Parameter_Values[0] = "";

            oraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = oraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];
        }



        /// <summary>
        /// Select_GroupCode : Group코드 리스트 SELECT(대분류)
        /// </summary>
        /// <param name="arg_group_type">Type</param>
        /// <returns>DataTable</returns>
        public static DataTable Select_GroupLCode(string arg_group_type)
        {
            COM.OraDB oraDB = new COM.OraDB();

            string Proc_Name = "PKG_SBC_ITEM_GROUP.SELECT_SBC_ITEM_GROUP_L";

            oraDB.ReDim_Parameter(2);
            oraDB.Process_Name = Proc_Name;

            oraDB.Parameter_Name[0] = "ARG_GROUP_TYPE";
            oraDB.Parameter_Name[1] = "OUT_CURSOR";

            oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            oraDB.Parameter_Type[1] = (int)OracleType.Cursor;

            oraDB.Parameter_Values[0] = arg_group_type;
            oraDB.Parameter_Values[1] = "";

            oraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = oraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];
        }


        /// <summary>
        /// Select_GroupCode : Group코드 리스트 SELECT(중분류)
        /// </summary>
        /// <param name="arg_group_type">Type</param>
        /// <param name="arg_group_l">대분류</param>
        /// <returns>DataTable</returns>
        public static DataTable Select_GroupMCode(string arg_group_type, string arg_group_l)
        {
            COM.OraDB oraDB = new COM.OraDB();

            string Proc_Name = "PKG_SBC_ITEM_GROUP.SELECT_SBC_ITEM_GROUP_M";

            oraDB.ReDim_Parameter(3);
            oraDB.Process_Name = Proc_Name;

            oraDB.Parameter_Name[0] = "ARG_GROUP_TYPE";
            oraDB.Parameter_Name[1] = "ARG_GROUP_L";
            oraDB.Parameter_Name[2] = "OUT_CURSOR";

            oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            oraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            oraDB.Parameter_Type[2] = (int)OracleType.Cursor;

            oraDB.Parameter_Values[0] = arg_group_type;
            oraDB.Parameter_Values[1] = arg_group_l;
            oraDB.Parameter_Values[2] = "";

            oraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = oraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];

        }

        /// <summary>
        /// Select_GroupCode : Group코드 리스트 SELECT(소분류)
        /// </summary>
        /// <param name="arg_group_type">Type</param>
        /// <param name="arg_group_l">대분류</param>
        /// <param name="arg_group_m">중분류</param>
        /// <returns>DataTable</returns>
        public static DataTable Select_GroupSCode(string arg_group_type, string arg_group_l, string arg_group_m)
        {
            COM.OraDB oraDB = new COM.OraDB();

            string Proc_Name = "PKG_SBC_ITEM_GROUP.SELECT_SBC_ITEM_GROUP_S";

            //// DB에서 언어 Dictionary 추출
            oraDB.ReDim_Parameter(4);
            oraDB.Process_Name = Proc_Name;

            oraDB.Parameter_Name[0] = "ARG_GROUP_TYPE";
            oraDB.Parameter_Name[1] = "ARG_GROUP_L";
            oraDB.Parameter_Name[2] = "ARG_GROUP_M";
            oraDB.Parameter_Name[3] = "OUT_CURSOR";

            oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            oraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            oraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            oraDB.Parameter_Type[3] = (int)OracleType.Cursor;

            oraDB.Parameter_Values[0] = arg_group_type;
            oraDB.Parameter_Values[1] = arg_group_l;
            oraDB.Parameter_Values[2] = arg_group_m;
            oraDB.Parameter_Values[3] = "";

            oraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = oraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];

        }

        /// <summary>
        /// Select_GroupCode : Group코드 소분류 정보 SELECT
        /// </summary>
        /// <param name="arg_group_type">Type</param>
        /// <param name="arg_group_l">대분류</param>
        /// <param name="arg_group_m">중분류</param>
        /// <returns>DataTable</returns>
        public static DataTable Select_GroupSCode(string arg_group_type, string arg_group_l, string arg_group_m, string arg_group_s)
        {
            COM.OraDB oraDB = new COM.OraDB();

            string Proc_Name = "PKG_SBC_ITEM_GROUP.SELECT_SBC_ITEM_GROUP_S_INFO";

            //// DB에서 언어 Dictionary 추출
            oraDB.ReDim_Parameter(5);
            oraDB.Process_Name = Proc_Name;

            oraDB.Parameter_Name[0] = "ARG_GROUP_TYPE";
            oraDB.Parameter_Name[1] = "ARG_GROUP_L";
            oraDB.Parameter_Name[2] = "ARG_GROUP_M";
            oraDB.Parameter_Name[3] = "ARG_GROUP_S";
            oraDB.Parameter_Name[4] = "OUT_CURSOR";

            oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            oraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            oraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            oraDB.Parameter_Type[3] = (int)OracleType.VarChar;
            oraDB.Parameter_Type[4] = (int)OracleType.Cursor;

            oraDB.Parameter_Values[0] = arg_group_type;
            oraDB.Parameter_Values[1] = arg_group_l;
            oraDB.Parameter_Values[2] = arg_group_m;
            oraDB.Parameter_Values[3] = arg_group_s;
            oraDB.Parameter_Values[4] = "";

            oraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = oraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];

        }




        #endregion




        /// 해당 Group Name 조회 : 
        /// </summary>
        /// <returns></returns>
        public static DataTable Select_Group_Name(string arg_groupcd)
        {

            COM.OraDB MyOraDB = new COM.OraDB();

            DataSet ds_ret;

            MyOraDB.ReDim_Parameter(2);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_SBC_ITEM_GROUP.SELECT_SBC_ITEM_GROUP_NAME";

            //02.ARGURMENT명
            MyOraDB.Parameter_Name[0] = "ARG_GROUP_CD";
            MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

            //03.DATA TYPE
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

            //04.DATA 정의  
            MyOraDB.Parameter_Values[0] = arg_groupcd;
            MyOraDB.Parameter_Values[1] = "";

            MyOraDB.Add_Select_Parameter(true);

            ds_ret = MyOraDB.Exe_Select_Procedure();
            if (ds_ret == null) return null;

            return ds_ret.Tables[MyOraDB.Process_Name];
        }


        /// <summary>
        /// Select_Group_List : Group List 조회
        /// </summary>
        /// <returns></returns>
        public static DataTable Select_Group_List()
        {
            COM.OraDB MyOraDB = new COM.OraDB();

            DataSet ds_ret;
            string process_name = "PKG_SBC_ITEM_GROUP.SELECT_SBC_ITEM_GROUP_LIST";

            MyOraDB.ReDim_Parameter(1);

            //01.PROCEDURE명
            MyOraDB.Process_Name = process_name;

            //02.ARGURMENT명
            MyOraDB.Parameter_Name[0] = "OUT_CURSOR";

            //03.DATA TYPE
            MyOraDB.Parameter_Type[0] = (int)OracleType.Cursor;

            //04.DATA 정의  
            MyOraDB.Parameter_Values[0] = "";

            MyOraDB.Add_Select_Parameter(true);

            ds_ret = MyOraDB.Exe_Select_Procedure();

            if (ds_ret == null) return null;

            return ds_ret.Tables[process_name];
        }

        #endregion

        #region 담당자 관련

        /// <summary>
        /// Select_Man_Charge : 담당자리스트
        /// </summary>
        /// <param name="arg_factory">공장코드e</param>
        /// <returns>DataTable</returns>
        public static DataTable Select_Man_Charge(string arg_factory)
        {
            COM.OraDB oraDB = new COM.OraDB();

            string Proc_Name = "PKG_SBC_COMMON.SELECT_SCM_MAN_CHARGE";

            oraDB.ReDim_Parameter(2);
            oraDB.Process_Name = Proc_Name;

            oraDB.Parameter_Name[0] = "ARG_FACTORY";
            oraDB.Parameter_Name[1] = "OUT_CURSOR";

            oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            oraDB.Parameter_Type[1] = (int)OracleType.Cursor;

            oraDB.Parameter_Values[0] = arg_factory;
            oraDB.Parameter_Values[1] = "";

            oraDB.Add_Select_Parameter(false);
            DataSet DS_Ret = oraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];
        }


        /// <summary>
        /// Select_Man_Charge : 담당자리스트
        /// </summary>
        /// <param name="arg_factory">공장코드</param>
        /// <param name="arg_user_id"></param>
        /// <returns>DataTable</returns>
        public static DataTable Select_Man_Charge(string arg_factory, string arg_user_id)
        {
            COM.OraDB oraDB = new COM.OraDB();

            string Proc_Name = "PKG_SBC_COMMON.SELECT_SCM_MAN_CHARGE_LIKE";

            oraDB.ReDim_Parameter(3);
            oraDB.Process_Name = Proc_Name;

            oraDB.Parameter_Name[0] = "ARG_FACTORY";
            oraDB.Parameter_Name[1] = "ARG_USER_ID";
            oraDB.Parameter_Name[2] = "OUT_CURSOR";

            oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            oraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            oraDB.Parameter_Type[2] = (int)OracleType.Cursor;

            oraDB.Parameter_Values[0] = arg_factory;
            oraDB.Parameter_Values[1] = arg_user_id;
            oraDB.Parameter_Values[2] = "";

            oraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = oraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;
            return DS_Ret.Tables[Proc_Name];
        }





        #endregion

        #region 품목 관련

        /// <summary>
        ///  품목 조회
        /// </summary>
        /// <param name="arg_Group_CD">그룹타입+대분류+중분류</param>
        /// <param name="arg_Item_Name">품목이름</param>
        /// <returns></returns>
        public static DataTable Select_Item(string arg_Group_CD, string arg_Item_Name)
        {
            COM.OraDB MyOraDB = new COM.OraDB();

            DataSet ds_ret;

            MyOraDB.ReDim_Parameter(3);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_SBC_ITEM.SELECT_SBC_ITEM";

            //02.ARGURMENT명
            MyOraDB.Parameter_Name[0] = "ARG_GROUP_CD";
            MyOraDB.Parameter_Name[1] = "ARG_ITEM_NAME";
            MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

            //03.DATA TYPE
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

            //04.DATA 정의  
            MyOraDB.Parameter_Values[0] = arg_Group_CD;
            MyOraDB.Parameter_Values[1] = arg_Item_Name;
            MyOraDB.Parameter_Values[2] = "";

            MyOraDB.Add_Select_Parameter(true);

            ds_ret = MyOraDB.Exe_Select_Procedure();

            if (ds_ret == null) return null;

            return ds_ret.Tables[MyOraDB.Process_Name];
        }




        /// <summary>
        /// 품목 조회  - 거래처 명 함께 조회 
        /// </summary>
        /// <param name="arg_Group_CD">그룹타입+대분류+중분류</param>
        /// <param name="arg_Item_Name">품목이름</param>
        /// <param name="arg_Factory"></param>
        /// <returns></returns>
        public static DataTable Select_Item_With_CustName(string arg_Group_CD, string arg_Item_Name, string arg_Factory)
        {
            COM.OraDB MyOraDB = new COM.OraDB();

            DataSet ds_ret;

            MyOraDB.ReDim_Parameter(4);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_SBC_ITEM.SELECT_SBC_ITEM_WITH_CUSTNAME";

            //02.ARGURMENT명
            MyOraDB.Parameter_Name[0] = "ARG_GROUP_CD";
            MyOraDB.Parameter_Name[1] = "ARG_ITEM_NAME";
            MyOraDB.Parameter_Name[2] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[3] = "OUT_CURSOR";

            //03.DATA TYPE
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;

            //04.DATA 정의  
            MyOraDB.Parameter_Values[0] = arg_Group_CD;
            MyOraDB.Parameter_Values[1] = arg_Item_Name;
            MyOraDB.Parameter_Values[2] = arg_Factory;
            MyOraDB.Parameter_Values[3] = "";

            MyOraDB.Add_Select_Parameter(true);

            ds_ret = MyOraDB.Exe_Select_Procedure();

            if (ds_ret == null) return null;

            return ds_ret.Tables[MyOraDB.Process_Name];
        }




        /// <summary>
        /// 해당 품목이름 조회
        /// </summary>
        /// <param name="arg_itemcd"></param>
        /// <returns></returns>
        public static DataTable Select_Item_Name(string arg_itemcd)
        {

            COM.OraDB MyOraDB = new COM.OraDB();

            DataSet ds_ret;

            MyOraDB.ReDim_Parameter(2);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_SBC_COMMON.SELECT_SBC_ITEM_NAMES";

            //02.ARGURMENT명
            MyOraDB.Parameter_Name[0] = "ARG_ITEM_CD";
            MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

            //03.DATA TYPE
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

            //04.DATA 정의  
            MyOraDB.Parameter_Values[0] = arg_itemcd;
            MyOraDB.Parameter_Values[1] = "";

            MyOraDB.Add_Select_Parameter(true);

            ds_ret = MyOraDB.Exe_Select_Procedure();
            if (ds_ret == null) return null;

            return ds_ret.Tables[MyOraDB.Process_Name];
        }



        #endregion

        #region 우효동 추가
        /// <summary>
        /// numeric_Type : 숫자입력 체크
        /// </summary>		
        /// <returns></returns>
        public static void numeric_Type(System.Windows.Forms.KeyPressEventArgs e)
        {

            int Ascil = 0;
            Ascil = (int)e.KeyChar;
            if (Ascil >= 48 && Ascil <= 58 || Ascil == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Select_StyleList : 스타일 조회
        /// </summary>
        /// <returns></returns>
        public static DataTable Select_StyleList(string arg_style_cd)
        {

            COM.OraDB MyOraDB = new COM.OraDB();
            DataSet ds_ret;

            MyOraDB.ReDim_Parameter(2);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_SBC_COMMON.SELECT_STYLE_LIST";

            //02.ARGURMENT명
            MyOraDB.Parameter_Name[0] = "ARG_STYLE_CD";
            MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

            //03.DATA TYPE
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

            //04.DATA 정의  
            MyOraDB.Parameter_Values[0] = arg_style_cd;
            MyOraDB.Parameter_Values[1] = "";

            MyOraDB.Add_Select_Parameter(true);

            ds_ret = MyOraDB.Exe_Select_Procedure();

            if (ds_ret == null) return null;

            return ds_ret.Tables[MyOraDB.Process_Name];
        }

        /// <summary>
        /// SELECT_MENU_USER_LIST : 담당자리스트(권한)
        /// </summary>
        /// <param name="arg_factory">공장코드</param>
        /// <param name="arg_menu_pg">프로그램 id</param>
        /// <param name="arg_user_id">사용자 id</param>
        /// <returns>DataTable</returns>
        public static DataTable SELECT_MENU_USER_LIST(string arg_factory, string arg_menu_pg, string arg_user_id)
        {
            COM.OraDB oraDB = new COM.OraDB();

            string Proc_Name = "PKG_SBC_COMMON.SELECT_MENU_USER_LIST";

            oraDB.ReDim_Parameter(4);
            oraDB.Process_Name = Proc_Name;

            oraDB.Parameter_Name[0] = "ARG_FACTORY";
            oraDB.Parameter_Name[1] = "ARG_MENU_PG";
            oraDB.Parameter_Name[2] = "ARG_USER_ID";
            oraDB.Parameter_Name[3] = "OUT_CURSOR";

            oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            oraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            oraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            oraDB.Parameter_Type[3] = (int)OracleType.Cursor;

            oraDB.Parameter_Values[0] = arg_factory;
            oraDB.Parameter_Values[1] = arg_menu_pg;
            oraDB.Parameter_Values[2] = arg_user_id;
            oraDB.Parameter_Values[3] = "";

            oraDB.Add_Select_Parameter(false);
            DataSet DS_Ret = oraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];
        }


        /// <summary>
        /// SELECT_LOT_LIST : Lot 조회
        /// </summary>
        /// <returns></returns>
        public static DataTable SELECT_LOT_LIST(string arg_factory, string arg_style_cd)
        {

            COM.OraDB MyOraDB = new COM.OraDB();
            DataSet ds_ret;

            MyOraDB.ReDim_Parameter(3);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_SBC_COMMON.SELECT_LOT_LIST";

            //02.ARGURMENT명
            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_STYLE";
            MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

            //03.DATA TYPE
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

            //04.DATA 정의  
            MyOraDB.Parameter_Values[0] = arg_factory;
            MyOraDB.Parameter_Values[1] = arg_style_cd;
            MyOraDB.Parameter_Values[2] = "";

            MyOraDB.Add_Select_Parameter(true);

            ds_ret = MyOraDB.Exe_Select_Procedure();

            if (ds_ret == null) return null;

            return ds_ret.Tables[MyOraDB.Process_Name];
        }


        #endregion

        #region 정환정 추가

        #region 멤버 메서드

        /// <summary>
        /// Cell_AfterEdit : 
        /// </summary>
        public static void Cell_AfterEdit(COM.SSP arg_grid, int arg_col)
        {
            try
            {
                int now_row = arg_grid.ActiveSheet.ActiveRowIndex;
                int now_col = arg_grid.ActiveSheet.ActiveColumnIndex;

                if (arg_grid.ActiveSheet.Cells[now_row, 0].Tag == null) return;


                //insert
                if (arg_grid.ActiveSheet.Cells[now_row, 0].Tag.ToString().Trim() == "I")
                {
                    //신규 행 범위에서의 중복 체크
                    bool check = Check_Duplicate_ING(arg_grid, arg_col);

                    if (check)
                    {
                        arg_grid.ActiveSheet.Cells[now_row, now_col].Text = "";
                    }

                }
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Cell_AfterEdit", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        /// <summary>
        /// Check_Duplicate_ING : 신규 행 범위에서의 중복 체크
        /// </summary>
        /// <returns></returns>
        public static bool Check_Duplicate_ING(COM.SSP arg_grid, int arg_col)
        {
            int now_row = arg_grid.ActiveSheet.RowCount - 1;
            int count = 0;
            string now_key = "", diff_key = "";

            arg_grid.ActiveSheet.ActiveRowIndex = now_row;
            now_key = arg_grid.ActiveSheet.Cells[now_row, arg_col].Text.ToString().Trim();

            for (int i = now_row - 1; i >= 0; i--)
            {
                if (arg_grid.ActiveSheet.Cells[i, 0].Tag == null
                    || arg_grid.ActiveSheet.Cells[i, 0].Tag.ToString().Trim() != "I") break;

                diff_key = arg_grid.ActiveSheet.Cells[i, arg_col].Text.ToString().Trim();

                if (now_key != diff_key) continue;

                count++;

            } // end for i

            if (count > 0)
            {
                ClassLib.ComFunction.User_Message("Duplicate Data : " + "[" + now_key + "]");
                return true;
            }
            else
            {
                return false;
            } // end if

        }





        /// <summary>
        /// Set_ComboList_5 : 5개짜리 콤보리스트 -> 채산에서 스타일 콤보 세팅
        /// </summary> 
        //public static void Set_ComboList_5(DataTable dtcmb_list, C1.Win.C1List.C1Combo arg_cmb,
        //    int arg_1_pos, int arg_2_pos, int arg_3_pos, int arg_4_pos, int arg_5_pos,
        //    bool arg_emptyrow, int arg_1_width, int arg_2_width)
        //{
        //    DataSet temp_dataset = new System.Data.DataSet();
        //    DataTable temp_datatable;
        //    DataRow newrow;

        //    temp_datatable = temp_dataset.Tables.Add("Combo List");
        //    temp_datatable.Columns.Add(new DataColumn("Code", Type.GetType("System.String")));
        //    temp_datatable.Columns.Add(new DataColumn("Name", Type.GetType("System.String")));
        //    temp_datatable.Columns.Add(new DataColumn("Gender", Type.GetType("System.String")));
        //    temp_datatable.Columns.Add(new DataColumn("Presto", Type.GetType("System.String")));
        //    temp_datatable.Columns.Add(new DataColumn("ModelName", Type.GetType("System.String")));


        //    for (int i = 0; i < dtcmb_list.Rows.Count; i++)
        //    {
        //        newrow = temp_datatable.NewRow();
        //        newrow[0] = dtcmb_list.Rows[i].ItemArray[arg_1_pos];
        //        newrow[1] = dtcmb_list.Rows[i].ItemArray[arg_2_pos];
        //        newrow[2] = dtcmb_list.Rows[i].ItemArray[arg_3_pos];
        //        newrow[3] = dtcmb_list.Rows[i].ItemArray[arg_4_pos];
        //        newrow[4] = dtcmb_list.Rows[i].ItemArray[arg_5_pos];
        //        temp_datatable.Rows.Add(newrow);
        //    }



        //    arg_cmb.DataSource = temp_datatable;

        //    arg_cmb.ValueMember = "Code";
        //    arg_cmb.DisplayMember = "Name";

        //    arg_cmb.SelectedIndex = -1;

        //    arg_cmb.MaxDropDownItems = 10;

        //    int dropdownwidth = arg_1_width + arg_2_width;
        //    if (arg_cmb.Width > dropdownwidth) dropdownwidth = arg_cmb.Width;
        //    arg_cmb.DropDownWidth = dropdownwidth;

        //    arg_cmb.Splits[0].DisplayColumns["Code"].Width = arg_1_width;
        //    arg_cmb.Splits[0].DisplayColumns["Name"].Width = arg_2_width - 25;
        //    arg_cmb.Splits[0].DisplayColumns[2].Visible = false;
        //    arg_cmb.Splits[0].DisplayColumns[3].Visible = false;
        //    arg_cmb.Splits[0].DisplayColumns[4].Visible = false;

        //    arg_cmb.ExtendRightColumn = true;
        //    arg_cmb.CellTips = C1.Win.C1List.CellTipEnum.Anchored;

        //}



        #endregion

        #region DB Connect



        #region 공통 쿼리 (style list, lot list)


        /// <summary>
        /// Select_SDC_STYLE : Style List - Like 처리, gen, pst_yn 포함 (SDC_STYLE)
        /// </summary>
        /// <param name="arg_stylecd"></param>
        /// <returns></returns>
        public static DataTable Select_SDC_STYLE(string arg_stylecd)
        {
            COM.OraDB MyOraDB = new COM.OraDB();
            DataSet ds_ret;

            MyOraDB.ReDim_Parameter(2);

            MyOraDB.Process_Name = "PKG_SBC_COMMON.SELECT_SDC_STYLE";

            MyOraDB.Parameter_Name[0] = "ARG_STYLE_CD";
            MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = arg_stylecd;
            MyOraDB.Parameter_Values[1] = "";

            MyOraDB.Add_Select_Parameter(true);
            ds_ret = MyOraDB.Exe_Select_Procedure();

            if (ds_ret == null) return null;
            return ds_ret.Tables[MyOraDB.Process_Name];

        }


        /// <summary>
        /// Select_SDC_STYLE : Style List - Like 처리, gen, pst_yn 포함 (SDC_STYLE)
        /// </summary>
        /// <param name="arg_factory"></param>
        /// <param name="arg_obs_id"></param>
        /// <param name="arg_style_cd"></param>
        /// <returns></returns>
        public static DataTable Select_SDC_STYLE(string arg_factory, string arg_obs_id, string arg_style_cd)
        {
            COM.OraDB MyOraDB = new COM.OraDB();
            DataSet ds_ret;

            MyOraDB.ReDim_Parameter(4);

            MyOraDB.Process_Name = "PKG_SBC_COMMON.SELECT_SDC_STYLE_DPO";

            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_OBS_ID";
            MyOraDB.Parameter_Name[2] = "ARG_STYLE_CD";
            MyOraDB.Parameter_Name[3] = "OUT_CURSOR";

            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = arg_factory;
            MyOraDB.Parameter_Values[1] = arg_obs_id;
            MyOraDB.Parameter_Values[2] = arg_style_cd;
            MyOraDB.Parameter_Values[3] = "";

            MyOraDB.Add_Select_Parameter(true);
            ds_ret = MyOraDB.Exe_Select_Procedure();

            if (ds_ret == null) return null;
            return ds_ret.Tables[MyOraDB.Process_Name];

        }


        public static DataTable Select_SDC_STYLE_NAME(string arg_stylecd)
        {
            COM.OraDB MyOraDB = new COM.OraDB();
            DataSet ds_ret;

            MyOraDB.ReDim_Parameter(2);

            MyOraDB.Process_Name = "PKG_SBC_COMMON.SELECT_SDC_STYLE_NAME";

            MyOraDB.Parameter_Name[0] = "ARG_STYLE_CD";
            MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = arg_stylecd;
            MyOraDB.Parameter_Values[1] = "";

            MyOraDB.Add_Select_Parameter(true);
            ds_ret = MyOraDB.Exe_Select_Procedure();

            if (ds_ret == null) return null;
            return ds_ret.Tables[MyOraDB.Process_Name];

        }


        /// <summary>
        /// Select_SBC_YIELD_SEMIGOOD : semigood list 추출
        /// </summary>
        /// <param name="arg_factory"></param>
        /// <param name="arg_stylecd"></param>
        /// <returns></returns>
        public static DataTable Select_SBC_YIELD_SEMIGOOD(string arg_factory, string arg_stylecd)
        {
            COM.OraDB MyOraDB = new COM.OraDB();
            DataSet ds_ret;

            MyOraDB.ReDim_Parameter(3);

            MyOraDB.Process_Name = "PKG_SBC_YIELD.SELECT_SBC_YIELD_SEMIGOOD";

            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_STYLE_CD";
            MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = arg_factory;
            MyOraDB.Parameter_Values[1] = arg_stylecd;
            MyOraDB.Parameter_Values[2] = "";

            MyOraDB.Add_Select_Parameter(true);
            ds_ret = MyOraDB.Exe_Select_Procedure();

            if (ds_ret == null) return null;
            return ds_ret.Tables[MyOraDB.Process_Name];

        }





        /// <summary>
        /// Select_SIZE_COLHEAD_ALL : 사이즈 전 문대 조회
        /// </summary>
        /// <param name="arg_stylecd"></param>
        /// <returns></returns>
        public static DataTable Select_SIZE_COLHEAD_ALL(string arg_factory)
        {
            COM.OraDB MyOraDB = new COM.OraDB();
            DataSet ds_ret;

            MyOraDB.ReDim_Parameter(3);

            MyOraDB.Process_Name = "PKG_SBC_COMMON.SELECT_SIZE_COLHEAD_ALL";

            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_STYLE";
            MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = arg_factory;
            MyOraDB.Parameter_Values[1] = " ";
            MyOraDB.Parameter_Values[2] = "";

            MyOraDB.Add_Select_Parameter(true);
            ds_ret = MyOraDB.Exe_Select_Procedure();

            if (ds_ret == null) return null;
            return ds_ret.Tables[MyOraDB.Process_Name];

        }



        /// <summary>
        /// Select_SPO_LOT_COMBO : LOT List - Like 처리, factory, obs_id, style_cd
        /// </summary>
        /// <param name="arg_factory"></param>
        /// <param name="arg_obs_id"></param>
        /// <param name="arg_style_cd"></param>
        /// <param name="arg_lot_no"></param>
        /// <param name="arg_lot_seq"></param>
        /// <returns></returns>
        public static DataTable Select_SPO_LOT_COMBO(string arg_factory,
            string arg_obs_id,
            string arg_style_cd,
            string arg_lot_no,
            string arg_lot_seq)
        {
            COM.OraDB MyOraDB = new COM.OraDB();
            DataSet ds_ret;

            MyOraDB.ReDim_Parameter(6);

            MyOraDB.Process_Name = "PKG_SPO_MPS_HISTORY_BSC.SELECT_SPO_LOT_COMBO";

            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_OBS_ID";
            MyOraDB.Parameter_Name[2] = "ARG_STYLE_CD";
            MyOraDB.Parameter_Name[3] = "ARG_LOT_NO";
            MyOraDB.Parameter_Name[4] = "ARG_LOT_SEQ";
            MyOraDB.Parameter_Name[5] = "OUT_CURSOR";

            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[5] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = arg_factory;
            MyOraDB.Parameter_Values[1] = arg_obs_id;
            MyOraDB.Parameter_Values[2] = arg_style_cd;
            MyOraDB.Parameter_Values[3] = arg_lot_no;
            MyOraDB.Parameter_Values[4] = arg_lot_seq;
            MyOraDB.Parameter_Values[5] = "";

            MyOraDB.Add_Select_Parameter(true);
            ds_ret = MyOraDB.Exe_Select_Procedure();

            if (ds_ret == null) return null;
            return ds_ret.Tables[MyOraDB.Process_Name];

        }



        #endregion


        #endregion

        #region Excel Upload


        /// <summary>
        /// Read_Excel : Read Excel File -> Return : DataSet
        /// </summary>
        /// <param name="arg_dtsrc">엑셀 파일 경로 (파일 이름까지 풀 경로)</param>
        /// <param name="arg_sql"></param>
        /// <returns></returns>
        public static DataSet Read_Excel(string arg_dtsrc)
        {

            /*

            <소스 추가>
            using System.Data.OleDb;
            using Microsoft.Office.Core;

            <참조 추가>
            Interop.Excel.dll
            Interop.Microsoft.Office.Core.dll
			
            */



            try
            {
                OleDbConnection AdoConn = null;
                OleDbDataAdapter oraDA = null;
                DataSet oraDS = new DataSet("OraDataSet");


                //string ExcelCon=@"Provider=Microsoft.Jet.OLED B.4.0;Data Source="+arg_dtsrc+";Excel 8.0;Imex=1;HDR=NO"; 

                // imex = 0 : export, 1 : import, 2 : update
                string ExcelCon = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + arg_dtsrc + @";Extended Properties=""Excel 8.0;HDR=No;IMEX=1""";


                AdoConn = new OleDbConnection(ExcelCon);
                AdoConn.Close();
                AdoConn.Open();


                DataTable sheetNameTable = AdoConn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });
                string sheetName = sheetNameTable.Rows[0].ItemArray.GetValue(2).ToString();
                string AdoSQL = @"SELECT * FROM [" + sheetName + "]";





                OleDbCommand Cmd = new OleDbCommand(AdoSQL, AdoConn);
                oraDA = new OleDbDataAdapter(Cmd);
                oraDA.Fill(oraDS);

                oraDS.Namespace = sheetName;

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
        /// <param name="arg_dtsrc">엑셀 파일 경로 (파일 이름까지 풀 경로)</param>
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

        #endregion

        #region 이재민 추가

        #region 유틸리티

        // Validate check by defined string
        public static string ValidateCheck(string arg_string)
        {
            //			for (int i = 0 ; i < ClassLib.ComVar.SpecialCharacter.Length ; i++)
            //				arg_string = arg_string.Replace(ClassLib.ComVar.SpecialCharacter[i], "\\" + ClassLib.ComVar.SpecialCharacter[i]);
            //
            //			return arg_string;

            return "";
        }

        // Validate check by user argument
        public static string ValidateCheck(string arg_string, string[] arg_specialChar)
        {
            for (int vCnt = 0; vCnt < arg_specialChar.Length; vCnt++)
                if (arg_string.IndexOf(arg_specialChar[vCnt]) != -1)
                    return arg_specialChar[vCnt];

            return null;
        }

        // Create listbox
        public static ListBox CreateListBox(DataTable arg_dt, int idx)
        {
            ListBox vTempList = new ListBox();

            for (int i = 0; i < arg_dt.Rows.Count; i++)
                vTempList.Items.Add(arg_dt.Rows[i].ItemArray[idx].ToString());

            return vTempList;
        }

        // create combo
        //public static void CreateComboBox(C1.Win.C1List.C1Combo arg_cmb, string[] code, string[] name)
        //{
        //    int i = 0;

        //    try
        //    {
        //        arg_cmb.DataMode = C1.Win.C1List.DataModeEnum.AddItem;
        //        arg_cmb.ClearItems();

        //        arg_cmb.AddItemTitles("Unit;Code");

        //        arg_cmb.ValueMember = "Unit";
        //        arg_cmb.DisplayMember = "Code";

        //        for (i = 0; i < code.Length; i++)
        //            arg_cmb.AddItem(code[i] + ";" + name[i]);

        //        arg_cmb.SelectedIndex = -1;

        //        arg_cmb.MaxDropDownItems = 10;
        //        arg_cmb.Splits[0].DisplayColumns[0].Width = 50;
        //        arg_cmb.Splits[0].DisplayColumns[1].Width = 150;

        //        arg_cmb.ExtendRightColumn = true;
        //        arg_cmb.CellTips = C1.Win.C1List.CellTipEnum.Anchored;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message.ToString(), "Set_ComboList_AddItem", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        //// merge grid
        //public static void MergeCell(COM.SSP arg_grid, int[] arg_sortCols)
        //{
        //    int vEndRow = arg_grid.ActiveSheet.RowCount;
        //    int[] vMergeCellIdx = new int[arg_sortCols.Length];
        //    FarPoint.Win.Spread.SheetView vSheet = arg_grid.ActiveSheet;

        //    for (int row = 1; row <= vEndRow; row++)
        //    {
        //        for (int idx = 0; idx < arg_sortCols.Length; idx++)
        //        {
        //            if (row == vEndRow)
        //            {
        //                vSheet.AddSpanCell(vMergeCellIdx[idx], arg_sortCols[idx], row - vMergeCellIdx[idx], 1);
        //                vMergeCellIdx[idx] = row;
        //            }
        //            else
        //            {
        //                if (!vSheet.Cells[row - 1, arg_sortCols[idx]].Text.Equals(vSheet.Cells[row, arg_sortCols[idx]].Text))
        //                {
        //                    for (; idx < arg_sortCols.Length; idx++)
        //                    {
        //                        vSheet.AddSpanCell(vMergeCellIdx[idx], arg_sortCols[idx], row - vMergeCellIdx[idx], 1);
        //                        vMergeCellIdx[idx] = row;
        //                    }
        //                }
        //            }
        //        }
        //    }
        //}

        // object type data null check
        public static string NullToBlank(object val)
        {
            if (val != null)
                return val.ToString();
            else
                return "";
        }

        // object type data null check
        public static string NullCheck(object arg_val, string arg_return)
        {
            if (arg_val != null)
                return arg_val.ToString();
            else
                return arg_return;
        }

        // string to DateTime
        public static DateTime StringToDateTime(string strDate)
        {
            if (strDate != null && !strDate.Equals(""))
            {
                strDate = strDate.Replace("-", "");
                return new DateTime(Convert.ToInt32(strDate.Substring(0, 4)), Convert.ToInt32(strDate.Substring(4, 2)), Convert.ToInt32(strDate.Substring(6, 2)));
            }
            else
                return System.DateTime.Now;
        }


        // string to DateTime
        public static DateTime ObjectToDateTime(object objDate)
        {
            string strDate = "";
            if (objDate != null)
            {
                strDate = objDate.ToString();
                if (strDate.Equals(""))
                    return System.DateTime.Now;

                strDate = strDate.Replace("-", "");
                return new DateTime(Convert.ToInt32(strDate.Substring(0, 4)), Convert.ToInt32(strDate.Substring(4, 2)), Convert.ToInt32(strDate.Substring(6, 2)));
            }
            else
                return System.DateTime.Now;
        }



        // combo style change (title, width, visible)
        //public static void SetComboStyle(C1.Win.C1List.C1Combo arg_combo, string[] arg_title, int[] arg_width, bool[] arg_visible)
        //{
        //    if (arg_title.Length == arg_width.Length && arg_width.Length == arg_visible.Length)
        //        for (int i = 0; i < arg_title.Length; i++)
        //        {
        //            arg_combo.Columns[i].Caption = arg_title[i];
        //            arg_combo.Splits[0].DisplayColumns[i].Width = arg_width[i];
        //            arg_combo.Splits[0].DisplayColumns[i].Visible = arg_visible[i];
        //        }
        //    else
        //        return;
        //}

        // combo style change (title, width, visible)
        //public static void SetComboStyle(C1.Win.C1List.C1Combo arg_combo, string[] arg_title, int[] arg_width, bool[] arg_visible, string arg_display)
        //{
        //    if (arg_title.Length == arg_width.Length && arg_width.Length == arg_visible.Length)
        //    {
        //        for (int i = 0; i < arg_title.Length; i++)
        //        {
        //            arg_combo.Columns[i].Caption = arg_title[i];
        //            arg_combo.Splits[0].DisplayColumns[i].Width = arg_width[i];
        //            arg_combo.Splits[0].DisplayColumns[i].Visible = arg_visible[i];
        //        }

        //        arg_combo.DisplayMember = arg_display;
        //    }
        //    else
        //        return;
        //}

        public static void Control_MoveNextByFocus(object sender, int arg_keyCode)
        {
            try
            {
                Control vThis = (System.Windows.Forms.Control)sender;
                if (arg_keyCode == 13)
                    vThis.Parent.Controls[vThis.Parent.Controls.IndexOf(vThis) + 1].Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Control_MoveNextByFocus", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // 공통 코드 설정
        //public static void SetComboData(C1.Win.C1List.C1Combo arg_Combo, string arg_ComCode, bool arg_VisibleAll, int arg_Index)
        //{
        //    DataTable vDt = null;

        //    try
        //    {
        //        vDt = COM.ComVar.Select_ComCode(COM.ComVar.This_Factory, arg_ComCode);
        //        COM.ComCtl.Set_ComboList(vDt, arg_Combo, 1, 2, arg_VisibleAll);
        //        if (arg_Index != -1)
        //            arg_Combo.SelectedIndex = arg_Index;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message.ToString(), "SetComboData", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    finally
        //    {
        //        vDt.Dispose();
        //    }
        //}

        // Confirm 여부를 String 형태로 리턴
        public static string GetCheckStatusToString(int arg_status)
        {
            //			switch (arg_status)
            //			{
            //				case 1:
            //					return ComVar.Status_SAVE;
            //				case 0:
            //					return ComVar.Status_CONFIRM;
            //				default:
            //					return "ERROR";
            //			}

            return "";
        }

        // Confirm 여부를 String 형태로 리턴
        public static bool DoAccessible(int arg_status, string arg_charge)
        {
            if (arg_status == 1 && arg_charge.Equals(COM.ComVar.This_User))
                return true;
            else
                return false;
        }



        /// <summary>
        /// Set_ComboList_Multi : 여러개 콤보리스트
        /// </summary> 
        //public static void Set_ComboList_Multi(DataTable dtcmb_list, C1.Win.C1List.C1Combo arg_cmb, int[] arg_pos, bool arg_emptyrow)
        //{
        //    DataSet temp_dataset = new System.Data.DataSet();
        //    DataTable temp_datatable;
        //    DataRow newrow;

        //    temp_datatable = temp_dataset.Tables.Add("Combo List");

        //    for (int i = 0; i < arg_pos.Length; i++)
        //    {
        //        temp_datatable.Columns.Add(new DataColumn("Item" + i, Type.GetType("System.String")));
        //    }

        //    for (int i = 0; i < dtcmb_list.Rows.Count; i++)
        //    {
        //        newrow = temp_datatable.NewRow();
        //        for (int j = 0; j < arg_pos.Length; j++)
        //        {
        //            newrow[j] = dtcmb_list.Rows[i].ItemArray[arg_pos[j]];
        //        }
        //        temp_datatable.Rows.Add(newrow);
        //    }



        //    arg_cmb.DataSource = temp_datatable;

        //    arg_cmb.ValueMember = "Item0";
        //    arg_cmb.DisplayMember = "Item0";

        //    arg_cmb.SelectedIndex = -1;
        //    arg_cmb.MaxDropDownItems = 10;

        //    int dropdownwidth = arg_pos.Length * 60;
        //    if (arg_cmb.Width > dropdownwidth) dropdownwidth = arg_cmb.Width;
        //    arg_cmb.DropDownWidth = dropdownwidth;

        //    arg_cmb.ExtendRightColumn = true;
        //    arg_cmb.CellTips = C1.Win.C1List.CellTipEnum.Anchored;
        //}




        #endregion

        #region 그리드 관련

        //#region FSP

        ////public static void Display_FlexGrid(C1.Win.C1FlexGrid.C1FlexGrid arg_grid, DataTable arg_dt)
        ////{
        ////    int vFixed = arg_grid.Rows.Fixed;
        ////    int vLevel = 1;

        ////    for (int vRow = 0; vRow < arg_dt.Rows.Count; vRow++)
        ////    {
        ////        vLevel = int.Parse(arg_dt.Rows[vRow].ItemArray[0].ToString());
        ////        C1.Win.C1FlexGrid.Node newRow = arg_grid.Rows.InsertNode(vFixed + vRow, vLevel);

        ////        for (int vCol = 1; vCol <= arg_dt.Columns.Count; vCol++)
        ////        {
        ////            arg_grid[newRow.Row.Index, vCol] = arg_dt.Rows[vRow].ItemArray[vCol - 1];
        ////        }
        ////    }
        ////}



        ////public static void Display_FlexGrid_Normal(COM.FSP arg_grid, DataTable arg_dt)
        ////{
        ////    try
        ////    {
        ////        arg_grid.ClearAll();
        ////        int vFixed = arg_grid.Rows.Fixed;

        ////        for (int vRow = 0; vRow < arg_dt.Rows.Count; vRow++)
        ////        {
        ////            //******arg_grid.Rows.Fixed + vRow******/
        ////            arg_grid.AddItem(arg_dt.Rows[vRow].ItemArray, arg_grid.Rows.Fixed + vRow, 1);
        ////        }
        ////    }
        ////    catch (Exception ex)
        ////    {
        ////        MessageBox.Show(ex.Message.ToString(), "Display_FlexGrid_Tree", MessageBoxButtons.OK, MessageBoxIcon.Error);
        ////    }

        ////}


        ////public static void Display_FlexGrid_Tree(COM.FSP arg_grid, DataTable arg_dt, int arg_tree)
        ////{
        ////    try
        ////    {
        ////        arg_grid.ClearAll();
        ////        int vFixed = arg_grid.Rows.Fixed;

        ////        for (int vRow = 0; vRow < arg_dt.Rows.Count; vRow++)
        ////        {
        ////            C1.Win.C1FlexGrid.Row vNewRow = arg_grid.AddItem(arg_dt.Rows[vRow].ItemArray, vRow + arg_grid.Rows.Fixed, 1);
        ////            vNewRow.IsNode = true;
        ////            vNewRow.Node.Level = int.Parse(arg_dt.Rows[vRow].ItemArray[arg_tree].ToString());
        ////        }
        ////    }
        ////    catch (Exception ex)
        ////    {
        ////        MessageBox.Show(ex.Message.ToString(), "Display_FlexGrid_Tree", MessageBoxButtons.OK, MessageBoxIcon.Error);
        ////    }
        ////}


        ////public static void Display_FlexGrid_Tree_Add(COM.FSP arg_grid, DataTable arg_dt, int arg_tree)
        ////{
        ////    try
        ////    {
        ////        int vFixed = arg_grid.Rows.Fixed;

        ////        for (int vRow = 0; vRow < arg_dt.Rows.Count; vRow++)
        ////        {
        ////            C1.Win.C1FlexGrid.Row vNewRow = arg_grid.AddItem(arg_dt.Rows[vRow].ItemArray, arg_grid.Rows.Count, 1);
        ////            vNewRow.IsNode = true;
        ////            vNewRow.Node.Level = int.Parse(arg_dt.Rows[vRow].ItemArray[arg_tree].ToString());
        ////        }
        ////    }
        ////    catch (Exception ex)
        ////    {
        ////        MessageBox.Show(ex.Message.ToString(), "Display_FlexGrid_Tree_Add", MessageBoxButtons.OK, MessageBoxIcon.Error);
        ////    }
        ////}

        ////public static void FGrid_SetRowColor(C1.Win.C1FlexGrid.C1FlexGrid arg_grid, int arg_row, Color arg_color)
        ////{
        ////    arg_grid.Rows[arg_row].StyleNew.BackColor = arg_color;
        ////}

        //// Empty cell check -- FSP
        ////public static bool EmptyCellCheck(COM.FSP arg_grid, int arg_startCol, int arg_endCol)
        ////{
        ////    int vLength = -1;

        ////    // empty cell check
        ////    for (int vRow = arg_grid.Rows.Fixed; vRow < arg_grid.Rows.Count; vRow++)
        ////    {
        ////        for (int vCol = arg_startCol; vCol < arg_endCol; vCol++)
        ////        {
        ////            vLength = arg_grid[vRow, vCol] == null ? -1 : arg_grid[vRow, vCol].ToString().Trim().Length;
        ////            if (vLength <= 0)
        ////            {
        ////                User_Message("Exist empty data : " + arg_grid[0, vCol].ToString(), "Check", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        ////                arg_grid.Selection.StyleNew.ForeColor = Color.Red;
        ////                arg_grid.Select(vRow, vCol);
        ////                return true;
        ////            }
        ////        }
        ////    }

        ////    return false;
        ////}

        //// Empty cell check -- FSP
        ////public static bool EmptyCellCheck(COM.FSP arg_grid, int[] arg_index)
        ////{
        ////    int vLength = -1;
        ////    int vCol = 0;

        ////    // empty cell check
        ////    for (int vRow = arg_grid.Rows.Fixed; vRow < arg_grid.Rows.Count; vRow++)
        ////    {
        ////        for (int i = 0; i < arg_index.Length; i++)
        ////        {
        ////            vCol = arg_index[i];
        ////            vLength = arg_grid[vRow, vCol] == null ? -1 : arg_grid[vRow, vCol].ToString().Length;
        ////            if (vLength <= 0)
        ////            {
        ////                User_Message("Exist empty data : " + arg_grid[0, vCol].ToString(), "Check", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        ////                arg_grid.Selection.StyleNew.ForeColor = Color.Red;
        ////                arg_grid.Select(vRow, vCol);
        ////                return true;
        ////            }
        ////        }
        ////    }

        ////    return false;
        ////}

        //// Empty cell check -- FSP
        ////public static bool EmptyCellCheck(COM.FSP arg_grid, int arg_startCol, int arg_endCol, int arg_proviso)
        ////{
        ////    int vLength = -1;
        ////    int vProvisoLength = -1;

        ////    // empty cell check
        ////    for (int vRow = arg_grid.Rows.Fixed; vRow < arg_grid.Rows.Count; vRow++)
        ////    {
        ////        for (int vCol = arg_startCol; vCol < arg_endCol; vCol++)
        ////        {
        ////            vLength = arg_grid[vRow, vCol] == null ? -1 : arg_grid[vRow, vCol].ToString().Length;
        ////            vProvisoLength = arg_grid[vRow, arg_proviso] == null ? -1 : arg_grid[vRow, arg_proviso].ToString().Length;

        ////            if (vLength <= 0 && vProvisoLength > 0)
        ////            {
        ////                User_Message("Exist empty data : " + arg_grid[0, vCol].ToString(), "Check", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        ////                arg_grid.Select(vRow, vCol);
        ////                return true;
        ////            }
        ////        }
        ////    }

        ////    return false;
        ////}

        //// 지정된 구간의 데이터 삽입
        //public static void SetData_FSP(C1.Win.C1FlexGrid.C1FlexGrid arg_grid, C1.Win.C1FlexGrid.CellRange arg_range, string arg_data)
        //{
        //    int vStartRow = arg_range.r1;
        //    int vStartCol = arg_range.c1;
        //    int vEndRow = arg_range.r2;
        //    int vEndCol = arg_range.c2;

        //    for (int vRow = vStartRow; vRow <= vEndRow; vRow++)
        //        for (int vCol = vStartCol; vCol <= vEndCol; vCol++)
        //            arg_grid[vRow, vCol] = arg_data;
        //}



        //// Report Directory 
        //public static string Set_RD_Directory(string arg_FormName)
        //{
        //    //			return Application.StartupPath +"\\Report\\"+ arg_FormName + ".mrd";
        //    //return "C:\\Sephiroth\\FlexPurchase\\Report\\" + arg_FormName + ".mrd";

        //    return Application.StartupPath + "\\Report\\" + arg_FormName + ".mrd";
        //}


        //#endregion

        #region SSP

        // Empty cell check -- SSP
        public static bool EmptyCellCheck_SSP(COM.SSP arg_grid, int arg_startCol, int arg_endCol)
        {
            int vLength = -1;

            // empty cell check
            for (int vRow = 0; vRow < arg_grid.ActiveSheet.Rows.Count; vRow++)
            {
                for (int vCol = arg_startCol; vCol <= arg_endCol; vCol++)
                {
                    vLength = arg_grid.ActiveSheet.Cells[vRow, vCol].Text == null ? -1 : arg_grid.ActiveSheet.Cells[vRow, vCol].Text.Trim().Length;

                    if (vLength <= 0)
                    {
                        ClassLib.ComFunction.User_Message("Exist Empty Data : " + arg_grid.ActiveSheet.Columns[vCol].Label);
                        arg_grid.Set_CellPosition(vRow, vCol);
                        return true;
                    }
                }
            }

            return false;
        }

        /// <summary>
        /// CheckCellData : 전체 행 범위에서의 빈값 및 중복체크 (SSP)
        /// </summary>
        /// <returns></returns>
        public static bool CheckCellData(COM.SSP arg_grid, int arg_col)
        {
            int now_row = arg_grid.ActiveSheet.RowCount - 1;
            string now_key = "", diff_key = "";

            if (arg_grid.ActiveSheet.Rows.Count <= 0)
                return false;

            now_key = arg_grid.ActiveSheet.Cells[now_row, arg_col].Text.ToString().Trim();

            if (now_key.Length <= 0)
            {
                ClassLib.ComFunction.User_Message("Empty Data");
                arg_grid.ActiveSheet.Cells[now_row, arg_col].Text = "";
                arg_grid.Set_CellPosition(now_row, arg_col);
                return true;
            }

            for (int i = now_row - 1; i >= 0; i--)
            {
                diff_key = arg_grid.ActiveSheet.Cells[i, arg_col].Text.ToString().Trim();

                if (now_key.Equals(diff_key) && !NullCheck(arg_grid.ActiveSheet.Cells[i, 0].Tag, "").Equals("I"))
                {
                    ClassLib.ComFunction.User_Message("Duplicate Data : " + "[" + now_key + "]");
                    arg_grid.ActiveSheet.Cells[now_row, arg_col].Text = "";
                    arg_grid.Set_CellPosition(now_row, arg_col);
                    return true;
                }
            } // end for i

            return false;
        }

        /// <summary>
        /// CheckCellData : 키를 전제로 전체 행 범위에서의 빈값 및 중복체크 (SSP)
        /// </summary>
        /// <returns></returns>
        public static bool CheckCellData(COM.SSP arg_grid, int[] arg_col, string[] arg_key, int arg_pk)
        {
            int now_row = arg_grid.ActiveSheet.RowCount - 1;
            int vCount = 0;
            string vGridValue = "";

            if (arg_key[arg_pk].Length <= 0)
            {
                ClassLib.ComFunction.User_Message("Empty Data");
                return true;
            }

            if (arg_grid.ActiveSheet.Rows.Count <= 0)
                return false;

            for (int vRow = now_row; vRow >= 0; vRow--)
            {
                for (int vCol = 0; vCol < arg_col.Length; vCol++)
                {
                    vGridValue = arg_grid.ActiveSheet.Cells[vRow, arg_col[vCol]].Text.Trim();

                    if (arg_key[vCol].ToUpper().Equals(vGridValue.ToUpper()))
                        vCount++;
                }

                if (vCount == arg_col.Length && !NullToBlank(arg_grid.ActiveSheet.Cells[vRow, 0].Tag).Equals("I"))
                {
                    ClassLib.ComFunction.User_Message("Duplicate Data : " + "[" + arg_key[arg_pk] + "]");
                    return true;
                }
                else
                    vCount = 0;
            } // end for i

            return false;
        }

        // 지정된 구간의 데이터 삽입
        public static void SetData_SSP(FarPoint.Win.Spread.FpSpread arg_grid, FarPoint.Win.Spread.Model.CellRange arg_range, string arg_data)
        {
            int vStartRow = arg_range.Row;
            int vStartCol = arg_range.Column;
            int vEndRow = vStartRow + arg_range.RowCount;
            int vEndCol = vStartCol + arg_range.ColumnCount;

            for (int vRow = vStartRow; vRow < vEndRow; vRow++)
                for (int vCol = vStartCol; vCol < vEndCol; vCol++)
                    arg_grid.ActiveSheet.Cells[vRow, vCol].Text = arg_data;
        }


        public static void Display_Spread_CrossTabByHead(COM.SSP arg_grid, DataTable arg_dt, int arg_startCol, int arg_rowIndex, int arg_titleIndex, int arg_headIndex, int arg_dataIndex)
        {
            try
            {
                int vStartCol = arg_startCol;
                int vEndCol = arg_grid.ActiveSheet.Columns.Count;
                int vRow = 0;
                int vCol = 0;
                string vHead = "";
                string vData = "";
                string vColumnData = "";

                arg_grid.ClearAll();
                arg_grid.ActiveSheet.Rows.Count = 4;

                for (int i = vStartCol; i < vEndCol; i++)
                {
                    if (i < 10)
                        vColumnData += "0";

                    vColumnData += i + "[" + arg_grid.ActiveSheet.ColumnHeader.Cells[0, i].Text + "]";
                }

                if (vColumnData.Equals(""))
                    new Exception("Not Found Column Label Data");

                for (int vCount = 0; vCount < arg_dt.Rows.Count; vCount++)
                {
                    vRow = Convert.ToInt32(arg_dt.Rows[vCount].ItemArray[arg_rowIndex]);
                    vHead = "[" + arg_dt.Rows[vCount].ItemArray[arg_headIndex].ToString() + "]";
                    vData = arg_dt.Rows[vCount].ItemArray[arg_dataIndex].ToString();

                    vCol = Convert.ToInt32(vColumnData.Substring(vColumnData.IndexOf(vHead) - 2, 2));
                    arg_grid.ActiveSheet.Cells[vRow, vCol].Text = vData;

                    arg_grid.ActiveSheet.Cells[vRow, (int)ClassLib.TBSBS_SHIPPING_SIZE.IxKIND].Text = arg_dt.Rows[vCount].ItemArray[arg_titleIndex].ToString();
                }
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Diplay_CrossTabByHead");
            }
        }



        #endregion


        #endregion

        #region 데이터 검색

        /// <summary>
        /// PKG_SBS_SHIP_CONTAINER : 
        /// </summary>
        /// <param name="arg_ship_factory">선적공장</param>
        /// <param name="arg_ship_ymd">선적일</param>
        /// <returns>DataTable</returns>
        public static DataTable SELECT_SBS_SHIP_CONT_NO_LIST(string arg_ship_factory, string arg_ship_ymd)
        {
            COM.OraDB MyOraDB = new COM.OraDB();

            DataSet vDs;

            MyOraDB.ReDim_Parameter(3);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_SBS_SHIP_CONTAINER.SELECT_SBS_SHIP_CONT_NO_LIST";

            //02.ARGURMENT 명
            MyOraDB.Parameter_Name[0] = "ARG_SHIP_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_SHIP_YMD";
            MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

            //03.DATA TYPE 정의
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

            //04.DATA 정의
            MyOraDB.Parameter_Values[0] = arg_ship_factory;
            MyOraDB.Parameter_Values[1] = arg_ship_ymd;
            MyOraDB.Parameter_Values[2] = "";

            MyOraDB.Add_Select_Parameter(true);
            vDs = MyOraDB.Exe_Select_Procedure();
            if (vDs == null) return null;

            return vDs.Tables[MyOraDB.Process_Name];
        }


        /// <summary>
        /// PKG_SBC_WAREHOUSE_LOC : 사용중인 warehouse list 가져오기
        /// </summary>
        /// <param name="arg_factory">공장</param>
        /// <returns>DataTable</returns>
        public static DataTable SELECT_WAREHOUSE_LIST_USING(string arg_factory)
        {
            COM.OraDB MyOraDB = new COM.OraDB();

            DataSet vDt;

            MyOraDB.ReDim_Parameter(2);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_SBC_WAREHOUSE.SELECT_WAREHOUSE_LIST_USING";

            //02.ARGURMENT 명
            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

            //03.DATA TYPE 정의
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

            //04.DATA 정의
            MyOraDB.Parameter_Values[0] = arg_factory;
            MyOraDB.Parameter_Values[1] = "";

            MyOraDB.Add_Select_Parameter(true);
            vDt = MyOraDB.Exe_Select_Procedure();
            if (vDt == null) return null;

            return vDt.Tables[MyOraDB.Process_Name];
        }


        /// <summary>
        /// SELECT_DOCUMENT_NO : 
        /// </summary>
        /// <param name="arg_factory">Factory</param>
        /// <param name="arg_doc_division">Division</param>
        /// <param name="arg_doc_type">Type</param>
        /// <param name="agr_doc_date">Date</param>
        /// <param name="arg_upd_user">User</param>
        /// <returns></returns>
        public static DataTable SELECT_DOCUMENT_NO(string arg_factory, string arg_doc_division, string arg_doc_type, string agr_doc_date, string arg_upd_user)
        {
            COM.OraDB MyOraDB = new COM.OraDB();

            DataSet vds_ret;

            MyOraDB.ReDim_Parameter(6);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_SBC_COMMON.SELECT_DOCUMENT_NO";

            //02.ARGURMENT 명
            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_DOC_DIVISION";
            MyOraDB.Parameter_Name[2] = "ARG_DOC_TYPE";
            MyOraDB.Parameter_Name[3] = "AGR_DOC_DATE";
            MyOraDB.Parameter_Name[4] = "ARG_UPD_USER";
            MyOraDB.Parameter_Name[5] = "OUT_CURSOR";

            //03.DATA TYPE 정의
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[5] = (int)OracleType.Cursor;

            //04.DATA 정의
            MyOraDB.Parameter_Values[0] = arg_factory;
            MyOraDB.Parameter_Values[1] = arg_doc_division;
            MyOraDB.Parameter_Values[2] = arg_doc_type;
            MyOraDB.Parameter_Values[3] = agr_doc_date;
            MyOraDB.Parameter_Values[4] = arg_upd_user;
            MyOraDB.Parameter_Values[5] = "";

            MyOraDB.Add_Select_Parameter(true);
            vds_ret = MyOraDB.Exe_Select_Procedure();
            if (vds_ret == null) return null;

            return vds_ret.Tables[MyOraDB.Process_Name];
        }


        /// <summary>
        /// PKG_SBM_SHIPPING_MASTER : MRP_SHIP_NO 리스트 가져오기
        /// </summary>
        /// <returns>DataTable</returns>
        public static DataTable SELECT_MRP_SHIP_NO_LIST(string arg_factory, string arg_ship_type)
        {
            COM.OraDB MyOraDB = new COM.OraDB();

            DataSet vds_ret;

            MyOraDB.ReDim_Parameter(4);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_SBM_SHIPPING_MASTER.SELECT_MRP_SHIP_NO_LIST";

            //02.ARGURMENT 명
            MyOraDB.Parameter_Name[0] = "ARG_THIS_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[2] = "ARG_SHIP_TYPE";
            MyOraDB.Parameter_Name[3] = "OUT_CURSOR";

            //03.DATA TYPE 정의
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;

            //04.DATA 정의
            MyOraDB.Parameter_Values[0] = COM.ComVar.This_Factory;
            MyOraDB.Parameter_Values[1] = arg_factory;
            MyOraDB.Parameter_Values[2] = arg_ship_type;
            MyOraDB.Parameter_Values[3] = "";

            MyOraDB.Add_Select_Parameter(true);
            vds_ret = MyOraDB.Exe_Select_Procedure();
            if (vds_ret == null) return null;

            return vds_ret.Tables[MyOraDB.Process_Name];
        }

        //		/// <summary>
        //		/// PKG_SBM_SHIPPING_MASTER : MRP_SHIP_NO 리스트 가져오기 (운송구분별)
        //		/// </summary>
        //		/// <returns>DataTable</returns>
        //		public static DataTable SELECT_MRP_SHIP_NO_LIST(string arg_factory, string arg_ship_type, string arg_trans)
        //		{
        //			COM.OraDB MyOraDB = new COM.OraDB();
        //
        //			DataSet vds_ret;
        //
        //			MyOraDB.ReDim_Parameter(3);
        //
        //			//01.PROCEDURE명
        //			MyOraDB.Process_Name = "PKG_SBM_SHIPPING_MASTER.SELECT_MRP_SHIP_NO_LIST";
        //
        //			//02.ARGURMENT 명
        //			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
        //			MyOraDB.Parameter_Name[1] = "ARG_SHIP_TYPE";
        //			MyOraDB.Parameter_Name[2] = "OUT_CURSOR";
        //
        //			//03.DATA TYPE 정의
        //			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
        //			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
        //			MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;
        //
        //			//04.DATA 정의
        //			MyOraDB.Parameter_Values[0] = arg_factory;
        //			MyOraDB.Parameter_Values[1] = arg_ship_type;
        //			MyOraDB.Parameter_Values[2] = "";
        //
        //			MyOraDB.Add_Select_Parameter(true);
        //			vds_ret = MyOraDB.Exe_Select_Procedure();
        //			if(vds_ret == null) return null ;
        //
        //			return vds_ret.Tables[MyOraDB.Process_Name];
        //		}


        /// <summary>
        /// PKG_SBM_READY : MRP 체크 리스트 Confirm
        /// </summary>
        public static bool SAVE_CHECK_LIST_CONFIRM(string arg_process, string arg_factory, string arg_ship_type, string arg_upd_user, bool arg_clear)
        {
            try
            {
                COM.OraDB MyOraDB = new COM.OraDB();

                MyOraDB.ReDim_Parameter(4);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SBM_READY.SAVE_CHECK_LIST_CONFIRM";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_PROCESS";
                MyOraDB.Parameter_Name[1] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[2] = "ARG_SHIP_TYPE";
                MyOraDB.Parameter_Name[3] = "ARG_UPD_USER";

                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_process;
                MyOraDB.Parameter_Values[1] = arg_factory;
                MyOraDB.Parameter_Values[2] = arg_ship_type;
                MyOraDB.Parameter_Values[3] = arg_upd_user;

                MyOraDB.Add_Modify_Parameter(arg_clear);
                if (MyOraDB.Exe_Modify_Procedure() == null)
                    return false;
                else
                    return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// PKG_SBM_READY : mrp 상태 조회
        /// </summary>
        /// <returns>DataTable</returns>
        public static DataTable SELECT_OPERATION_INFO(string arg_division, string arg_factory, string arg_ship_type, string arg_mrp_ship_no)
        {
            COM.OraDB MyOraDB = new COM.OraDB();

            DataSet vds_ret;

            MyOraDB.ReDim_Parameter(5);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_SBM_READY.SELECT_OPERATION_INFO";

            //02.ARGURMENT 명
            MyOraDB.Parameter_Name[0] = "ARG_DIVISION";
            MyOraDB.Parameter_Name[1] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[2] = "ARG_SHIP_TYPE";
            MyOraDB.Parameter_Name[3] = "ARG_MRP_SHIP_NO";
            MyOraDB.Parameter_Name[4] = "OUT_CURSOR";

            //03.DATA TYPE 정의
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;

            //04.DATA 정의
            MyOraDB.Parameter_Values[0] = arg_division;
            MyOraDB.Parameter_Values[1] = arg_factory;
            MyOraDB.Parameter_Values[2] = arg_ship_type;
            MyOraDB.Parameter_Values[3] = arg_mrp_ship_no;
            MyOraDB.Parameter_Values[4] = "";

            MyOraDB.Add_Select_Parameter(true);
            vds_ret = MyOraDB.Exe_Select_Procedure();
            if (vds_ret == null) return null;

            return vds_ret.Tables[MyOraDB.Process_Name];
        }



        public static bool ButtonAccessable(DataTable arg_dt, int arg_index, string arg_status)
        {
            if (arg_dt.Rows.Count != 0)
            {
                string vCharges = arg_dt.Rows[0].ItemArray[arg_index].ToString();
                string[] vCharge = vCharges.Split(',');
                string vUser = COM.ComVar.This_User;

                //for (int vIdx = 0; vIdx < vCharge.Length; vIdx++)
                //{
                //    //					if (vCharge[vIdx].Equals(vUser) && arg_status.Equals(ClassLib.ComVar.Status_SAVE))
                //    return true;
                //}
            }

            return false;
        }

        /// <summary>
        /// PKG_SBM_MRP_REQUEST : 
        /// </summary>
        /// <returns>DataTable</returns>
        public static bool SELECT_SBM_MRP_ITEM_SEARCH(string[] vData)
        {
            try
            {
                COM.OraDB MyOraDB = new COM.OraDB();

                DataSet vds_ret;

                MyOraDB.ReDim_Parameter(11);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SBM_MRP_REQUEST.SELECT_SBM_MRP_ITEM_SEARCH";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_SHIP_TYPE";
                MyOraDB.Parameter_Name[2] = "ARG_MRP_SHIP_NO";
                MyOraDB.Parameter_Name[3] = "ARG_LOT_NO";
                MyOraDB.Parameter_Name[4] = "ARG_LOT_SEQ";
                MyOraDB.Parameter_Name[5] = "ARG_STYLE_CD";
                MyOraDB.Parameter_Name[6] = "ARG_ITEM_CD";
                MyOraDB.Parameter_Name[7] = "ARG_SPEC_CD";
                MyOraDB.Parameter_Name[8] = "ARG_COLOR_CD";
                MyOraDB.Parameter_Name[9] = "ARG_OUTSIDE_YN";
                MyOraDB.Parameter_Name[10] = "OUT_CURSOR";


                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[7] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[8] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[9] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[10] = (int)OracleType.Cursor;


                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = vData[0];
                MyOraDB.Parameter_Values[1] = vData[1];
                MyOraDB.Parameter_Values[2] = vData[2];
                MyOraDB.Parameter_Values[3] = vData[3];
                MyOraDB.Parameter_Values[4] = vData[4];
                MyOraDB.Parameter_Values[5] = vData[5].Replace("-", "");
                MyOraDB.Parameter_Values[6] = vData[6];
                MyOraDB.Parameter_Values[7] = vData[7];
                MyOraDB.Parameter_Values[8] = vData[8];
                MyOraDB.Parameter_Values[9] = "";//ClassLib.ComVar.No;
                MyOraDB.Parameter_Values[10] = "";

                MyOraDB.Add_Select_Parameter(true);
                vds_ret = MyOraDB.Exe_Select_Procedure();

                if (vds_ret.Tables[0].Rows.Count > 0)
                    return true;

                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SELECT_SBM_MRP_ITEM_SEARCH", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        #endregion

        #endregion

        #region 김미영 추가

        #region 메쏘드 관련
        //public static void Set_Year(C1.Win.C1List.C1Combo combo, string arg_div)
        //{
        //    try
        //    {
        //        int year = Int32.Parse(COM.ComVar.This_Date.Substring(0, 4));
        //        int Byear = year - 5;
        //        int Ayear = year + 5;

        //        combo.AddItemTitles("Code;Name");

        //        combo.ValueMember = "Code";
        //        combo.DisplayMember = "Name";
        //        if (arg_div.Equals("ALL"))
        //        {
        //            combo.AddItem(" ;ALL");
        //        }
        //        for (int i = Byear; i <= year; i++)
        //        {
        //            combo.AddItem(i.ToString() + ";" + i.ToString());
        //        }
        //        for (int i = year + 1; i <= Ayear; i++)
        //        {
        //            combo.AddItem(i.ToString() + ";" + i.ToString());
        //        }
        //        combo.Splits[0].DisplayColumns["Name"].Visible = false;
        //        combo.Splits[0].DisplayColumns["Code"].Width = combo.Width - 20;
        //    }
        //    catch (Exception ex)
        //    {
        //        ClassLib.ComFunction.User_Message(ex.Message, "Set_Year", MessageBoxButtons.OK, MessageBoxIcon.Error);

        //    }
        //}


        //public static void Set_Yield_Type(C1.Win.C1List.C1Combo combo, string arg_div)
        //{
        //    try
        //    {

        //        combo.AddItemTitles("Code;Name");
        //        combo.ValueMember = "Code";
        //        combo.DisplayMember = "Name";
        //        combo.AddItem("E;E_WEIGHT");
        //        combo.AddItem("M;M_WEIGHT");
        //        combo.AddItem("S;Spec");


        //    }
        //    catch (Exception ex)
        //    {
        //        ClassLib.ComFunction.User_Message(ex.Message, "Set_Yield_Type", MessageBoxButtons.OK, MessageBoxIcon.Error);

        //    }
        //}

        #endregion



        #region db관련


        /// <summary>
        /// Color List
        /// </summary>
        /// <param name="arg_style_cd">칼라 코드</param>
        /// <param name="arg_style_cd">칼라 명</param>
        /// <returns> 없음</returns>
        public static DataTable Select_Color_List(string arg_color_code, string arg_color_name)
        {
            COM.OraDB oraDB = new COM.OraDB();

            DataSet ret;


            oraDB.ReDim_Parameter(3);

            oraDB.Process_Name = "PKG_SBC_COLOR.SELECT_SBC_COLOR";

            oraDB.Parameter_Name[0] = "ARG_COLOR_CD";
            oraDB.Parameter_Name[1] = "ARG_COLOR_NAME";
            oraDB.Parameter_Name[2] = "OUT_CURSOR";

            oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            oraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            oraDB.Parameter_Type[2] = (int)OracleType.Cursor;

            oraDB.Parameter_Values[0] = COM.ComFunction.Empty_String(arg_color_code, " ");
            oraDB.Parameter_Values[1] = COM.ComFunction.Empty_String(arg_color_name, " ");
            oraDB.Parameter_Values[2] = "";

            oraDB.Add_Select_Parameter(true);
            ret = oraDB.Exe_Select_Procedure();

            if (ret == null) return null;

            return ret.Tables[oraDB.Process_Name];

        }


        /// <summary>
        /// Mcs List
        /// </summary>
        /// <param name="arg_style_cd">MCS 코드</param>
        /// <param name="arg_style_cd">MCS 명</param>
        /// <returns> 없음</returns>
        public static DataTable Select_Mcs_List(string arg_mcs_code, string arg_mcs_name)
        {
            COM.OraDB oraDB = new COM.OraDB();


            DataSet ret;

            oraDB.ReDim_Parameter(3);


            oraDB.Process_Name = "PKG_SBC_MCS.SELECT_SBC_MCS";

            oraDB.Parameter_Name[0] = "ARG_VALUE1";
            oraDB.Parameter_Name[1] = "ARG_VALUE2";
            oraDB.Parameter_Name[2] = "OUT_CURSOR";

            oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            oraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            oraDB.Parameter_Type[2] = (int)OracleType.Cursor;

            oraDB.Parameter_Values[0] = COM.ComFunction.Empty_String(arg_mcs_code, " ");
            oraDB.Parameter_Values[1] = COM.ComFunction.Empty_String(arg_mcs_name, " ");
            oraDB.Parameter_Values[2] = "";

            oraDB.Add_Select_Parameter(true);
            ret = oraDB.Exe_Select_Procedure();

            if (ret == null) return null;

            return ret.Tables[oraDB.Process_Name];

        }



        #endregion


        #endregion

        #region menu 이름과 권한

        /*
		/// <summary>
		/// Init_MenuRole : menu 이름과 권한
		/// </summary>		
		/// <returns></returns>
		public static void Init_MenuRole(System.Windows.Forms.Form arg_form, System.Windows.Forms.Label arg_label, C1.Win.C1Command.C1Command tbtn_search,C1.Win.C1Command.C1Command tbtn_save,C1.Win.C1Command.C1Command tbtn_print)
		{ 
			try
			{
				//프로그램 이름
				DataTable dt_ret;
				dt_ret = Select_MenuRole(arg_form.Name) ;

				arg_form.Text = dt_ret.Rows[0].ItemArray[0].ToString() ;
				arg_label.Text = dt_ret.Rows[0].ItemArray[0].ToString() ;
				
				tbtn_search.Enabled = (dt_ret.Rows[0].ItemArray[1].ToString() == "Y") ? true : false ;
				tbtn_save.Enabled = (dt_ret.Rows[0].ItemArray[2].ToString() == "Y") ? true : false ;
				tbtn_print.Enabled = (dt_ret.Rows[0].ItemArray[3].ToString() == "Y") ? true : false ;								
				
			}
			catch
			{
			}			
		}

		*/

        /// <summary>
        /// Init_MenuRole : menu 이름과 권한
        /// </summary>		
        /// <returns></returns>
        //public static void Init_MenuRole(System.Windows.Forms.Form arg_form, System.Windows.Forms.Label arg_label, C1.Win.C1Command.C1Command[] tbtn_list)
        //{
        //    try
        //    {
        //        //프로그램 이름
        //        DataTable dt_ret;
        //        dt_ret = Select_MenuRole(arg_form.Name);

        //        arg_form.Text = dt_ret.Rows[0].ItemArray[0].ToString();
        //        arg_label.Text = dt_ret.Rows[0].ItemArray[0].ToString();

        //        for (int i = 0; i < tbtn_list.Length; i++)
        //        {
        //            switch (tbtn_list[i].Name.ToLower())
        //            {
        //                case "tbtn_search":
        //                    tbtn_list[i].Enabled = (dt_ret.Rows[0].ItemArray[1].ToString() == "Y") ? true : false;
        //                    break;

        //                case "tbtn_print":
        //                    tbtn_list[i].Enabled = (dt_ret.Rows[0].ItemArray[3].ToString() == "Y") ? true : false;
        //                    break;

        //                default:
        //                    tbtn_list[i].Enabled = (dt_ret.Rows[0].ItemArray[2].ToString() == "Y") ? true : false;
        //                    break;
        //            }
        //        }
        //    }
        //    catch
        //    {
        //    }
        //}

        #endregion

        #region 박지수 추가

        /// <summary>
        /// SELECT_SCM_CUST_LIST : ITEM 리스트
        /// </summary>
        /// <param name="arg_value">검색어</param>
        /// <returns>DataTable</returns>
        public static DataTable SELECT_ITEM_NAME_LIST(string arg_value)
        {
            COM.OraDB oraDB = new COM.OraDB();

            string Proc_Name = "PKG_SBC_COMMON.SELECT_ITEM_NAME_LIST";

            oraDB.ReDim_Parameter(2);
            oraDB.Process_Name = Proc_Name;

            oraDB.Parameter_Name[0] = "ARG_VALUE";
            oraDB.Parameter_Name[1] = "OUT_CURSOR";

            oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            oraDB.Parameter_Type[1] = (int)OracleType.Cursor;

            oraDB.Parameter_Values[0] = COM.ComFunction.Empty_String(arg_value, " ");
            oraDB.Parameter_Values[1] = "";

            oraDB.Add_Select_Parameter(false);
            DataSet DS_Ret = oraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];
        }

        /// <summary>
        /// Select_Cur_Rate :Cur Date Rate Select  
        /// </summary>
        /// <param name="arg_menuid">YMD</param>
        /// <returns>DataTable</returns>
        public static DataTable Select_Ymd_Rate(string arg_ymd)
        {
            COM.OraDB oraDB = new COM.OraDB();

            string Proc_Name = "PKG_SBC_COMMON.SELECT_YMD_RATE";

            oraDB.ReDim_Parameter(2);
            oraDB.Process_Name = Proc_Name;

            oraDB.Parameter_Name[0] = "ARG_YMD";
            oraDB.Parameter_Name[1] = "OUT_CURSOR";

            oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            oraDB.Parameter_Type[1] = (int)OracleType.Cursor;

            oraDB.Parameter_Values[0] = arg_ymd;
            oraDB.Parameter_Values[1] = "";

            oraDB.Add_Select_Parameter(false);
            DataSet DS_Ret = oraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];
        }

        /// <summary>
        /// Select_Cur_Rate :Cur Date Rate Select  
        /// </summary>
        /// <param name="arg_menuid">YMD</param>
        /// <returns>DataTable</returns>
        public static DataTable Select_Cur_Rate(string arg_ymd)
        {
            COM.OraDB oraDB = new COM.OraDB();

            string Proc_Name = "PKG_SBC_COMMON.SELECT_CUR_RATE";

            oraDB.ReDim_Parameter(2);
            oraDB.Process_Name = Proc_Name;

            oraDB.Parameter_Name[0] = "ARG_YMD";
            oraDB.Parameter_Name[1] = "OUT_CURSOR";

            oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            oraDB.Parameter_Type[1] = (int)OracleType.Cursor;

            oraDB.Parameter_Values[0] = arg_ymd;
            oraDB.Parameter_Values[1] = "";

            oraDB.Add_Select_Parameter(false);
            DataSet DS_Ret = oraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];
        }

        /// <summary>
        /// SELECT_WORK_LINE_LIST : LINE 리스트
        /// </summary>
        /// <param name="arg_value">검색어</param>
        /// <returns>DataTable</returns>
        public static DataTable Select_Work_Line_List(string arg_factory)
        {
            COM.OraDB oraDB = new COM.OraDB();

            string Proc_Name = "PKG_SPB_WORK_LINE.SELECT_WORK_LINE_LIST";

            oraDB.ReDim_Parameter(2);
            oraDB.Process_Name = Proc_Name;

            oraDB.Parameter_Name[0] = "ARG_FACTORY";
            oraDB.Parameter_Name[1] = "OUT_CURSOR";

            oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            oraDB.Parameter_Type[1] = (int)OracleType.Cursor;

            oraDB.Parameter_Values[0] = COM.ComFunction.Empty_String(arg_factory, " ");
            oraDB.Parameter_Values[1] = "";

            oraDB.Add_Select_Parameter(false);
            DataSet DS_Ret = oraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];
        }

        /// <summary>
        /// SELECT_WORK_PROCESS_LIST : PROCESS 리스트
        /// </summary>
        /// <param name="arg_value">검색어</param>
        /// <returns>DataTable</returns>
        public static DataTable Select_Work_Process_List(string arg_factory)
        {
            COM.OraDB oraDB = new COM.OraDB();

            string Proc_Name = "PKG_SPB_WORK_PROCESS.SELECT_WORK_PROCESS_LIST";

            oraDB.ReDim_Parameter(2);
            oraDB.Process_Name = Proc_Name;

            oraDB.Parameter_Name[0] = "ARG_FACTORY";
            oraDB.Parameter_Name[1] = "OUT_CURSOR";

            oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            oraDB.Parameter_Type[1] = (int)OracleType.Cursor;

            oraDB.Parameter_Values[0] = COM.ComFunction.Empty_String(arg_factory, " ");
            oraDB.Parameter_Values[1] = "";

            oraDB.Add_Select_Parameter(false);
            DataSet DS_Ret = oraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];
        }

        /// <summary>
        /// SELECT_OUT_DIVISION_LIST : OUT DIVISION 리스트
        /// </summary>
        /// <returns>DataTable</returns>
        public static DataTable Select_Out_Division_List(string arg_factory)
        {
            COM.OraDB oraDB = new COM.OraDB();

            string Proc_Name = "PKG_SCM_CODE.SELECT_OUT_DIVISION_LIST";

            oraDB.ReDim_Parameter(2);
            oraDB.Process_Name = Proc_Name;

            oraDB.Parameter_Name[0] = "ARG_FACTORY";
            oraDB.Parameter_Name[1] = "OUT_CURSOR";

            oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            oraDB.Parameter_Type[1] = (int)OracleType.Cursor;

            oraDB.Parameter_Values[0] = COM.ComFunction.Empty_String(arg_factory, " ");
            oraDB.Parameter_Values[1] = "";

            oraDB.Add_Select_Parameter(false);
            DataSet DS_Ret = oraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];
        }

        /// <summary>
        /// SELECT_OUT_DIVISION_LIST : OUT DIVISION 리스트
        /// </summary>
        /// <returns>DataTable</returns>
        public static DataTable Select_Last_Date(string arg_date)
        {
            COM.OraDB oraDB = new COM.OraDB();

            string Proc_Name = "PKG_SBC_COMMON.SELECT_LAST_DATE";

            oraDB.ReDim_Parameter(2);
            oraDB.Process_Name = Proc_Name;

            oraDB.Parameter_Name[0] = "ARG_DATE";
            oraDB.Parameter_Name[1] = "OUT_CURSOR";

            oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            oraDB.Parameter_Type[1] = (int)OracleType.Cursor;

            oraDB.Parameter_Values[0] = COM.ComFunction.Empty_String(arg_date, " ");
            oraDB.Parameter_Values[1] = "";

            oraDB.Add_Select_Parameter(false);
            DataSet DS_Ret = oraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];
        }

        /// <summary>
        /// SELECT_SBS_BAR_OUT_CONTAINER : 출고 컨테이너 리스트
        /// </summary>
        /// <returns>DataTable</returns>
        public static DataTable Select_Container(string arg_factory, string arg_fromDate, string arg_toDate)
        {
            COM.OraDB oraDB = new COM.OraDB();

            string Proc_Name = "PKG_SBC_COMMON.SELECT_BAR_OUT_CONTAINER";

            oraDB.ReDim_Parameter(4);
            oraDB.Process_Name = Proc_Name;

            oraDB.Parameter_Name[0] = "ARG_FACTORY";
            oraDB.Parameter_Name[1] = "ARG_FROM";
            oraDB.Parameter_Name[2] = "ARG_TO";
            oraDB.Parameter_Name[3] = "OUT_CURSOR";

            oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            oraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            oraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            oraDB.Parameter_Type[3] = (int)OracleType.Cursor;

            oraDB.Parameter_Values[0] = COM.ComFunction.Empty_String(arg_factory, " ");
            oraDB.Parameter_Values[1] = COM.ComFunction.Empty_String(arg_fromDate, " ");
            oraDB.Parameter_Values[2] = COM.ComFunction.Empty_String(arg_toDate, " ");
            oraDB.Parameter_Values[3] = "";

            oraDB.Add_Select_Parameter(false);
            DataSet DS_Ret = oraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];
        }




        /// <summary>
        /// Select_Man_Charge : 담당자리스트
        /// </summary>
        /// <param name="arg_factory">공장코드e</param>
        /// <returns>DataTable</returns>
        public static DataTable SELECT_WAREHOUSE_USER(string arg_factory)
        {
            COM.OraDB oraDB = new COM.OraDB();

            string Proc_Name = "PKG_SBC_COMMON.SELECT_WAREHOUSE_USER";

            oraDB.ReDim_Parameter(2);
            oraDB.Process_Name = Proc_Name;

            oraDB.Parameter_Name[0] = "ARG_FACTORY";
            oraDB.Parameter_Name[1] = "OUT_CURSOR";

            oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            oraDB.Parameter_Type[1] = (int)OracleType.Cursor;

            oraDB.Parameter_Values[0] = arg_factory;
            oraDB.Parameter_Values[1] = "";

            oraDB.Add_Select_Parameter(false);
            DataSet DS_Ret = oraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];
        }


        /// <summary>
        /// Display_FlexGrid_Variable  
        /// </summary>
        /// <param name="arg_grid">COM.FSP</param>
        /// <param name="arg_dt">DataTable</param>
        /// <returns></returns>
        //public static void Display_FlexGrid_Variable(COM.FSP arg_grid, DataTable arg_dt)
        //{
        //    arg_grid.ClearAll();
        //    int vFixed = arg_grid.Rows.Fixed;

        //    for (int vRow = 0; vRow < arg_dt.Rows.Count; vRow++)
        //    {
        //        arg_grid.Rows.Add();
        //        for (int vCol = 0; vCol < arg_dt.Columns.Count; vCol++)
        //        {
        //            for (int hCol = 1; hCol < arg_dt.Columns.Count; hCol++)
        //            {
        //                if ((string)arg_dt.Rows[0].Table.Columns[vCol].ColumnName == (string)arg_grid[0, hCol])
        //                {
        //                    arg_grid[arg_grid.Rows.Count - 1, hCol] = arg_dt.Rows[vRow].ItemArray[vCol];
        //                }
        //            }
        //        }
        //    }
        //}



        //public static bool Essentiality_check(C1.Win.C1List.C1Combo[] arg_cmb, System.Windows.Forms.TextBox[] arg_txt)
        //{
        //    if (arg_cmb != null)
        //    {
        //        for (int i = 0; i < arg_cmb.Length; i++)
        //        {
        //            if (arg_cmb[i].SelectedIndex < 0)
        //            {
        //                ClassLib.ComFunction.User_Message("Input Essential Condition.", "Essentiality_check", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //                arg_cmb[i].Focus();
        //                return false;
        //            }
        //        }
        //    }
        //    if (arg_txt != null)
        //    {
        //        for (int i = 0; i < arg_txt.Length; i++)
        //        {
        //            if (arg_txt[i].Text == "")
        //            {
        //                ClassLib.ComFunction.User_Message("Input Essential Condition.", "Essentiality_check", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //                arg_txt[i].Focus();
        //                return false;
        //            }
        //        }
        //    }
        //    return true;
        //}


        //public static bool Essentiality_check(C1.Win.C1List.C1Combo[] arg_cmb, System.Windows.Forms.TextBox[] arg_txt, bool arg_blank_check)
        //{
        //    if (arg_cmb != null)
        //    {
        //        for (int i = 0; i < arg_cmb.Length; i++)
        //        {
        //            if (arg_cmb[i].SelectedIndex < 0 || arg_cmb[i].SelectedValue.ToString().Trim() == "")
        //            {
        //                ClassLib.ComFunction.User_Message("Input Essential Condition.", "Essentiality_check", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //                arg_cmb[i].Focus();
        //                return false;
        //            }
        //        }
        //    }
        //    if (arg_txt != null)
        //    {
        //        for (int i = 0; i < arg_txt.Length; i++)
        //        {
        //            if (arg_txt[i].Text == "")
        //            {
        //                ClassLib.ComFunction.User_Message("Input Essential Condition.", "Essentiality_check", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //                arg_txt[i].Focus();
        //                return false;
        //            }
        //        }
        //    }
        //    return true;
        //}





        /// <summary>
        /// Select_Factory_List : Factory ?
        /// </summary>
        /// <returns></returns>
        public static DataTable Select_OBS_ID_List(string arg_factory, string arg_obs_type)
        {
            COM.OraDB MyOraDB = new COM.OraDB();
            DataSet ds_ret;

            try
            {
                string process_name = "PKG_SEM_OBS.SELECT_SEM_OBS_LIST";

                MyOraDB.ReDim_Parameter(3);
                MyOraDB.Process_Name = process_name;

                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_OBS_TYPE";
                MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_obs_type;
                MyOraDB.Parameter_Values[2] = "";

                MyOraDB.Add_Select_Parameter(true);
                ds_ret = MyOraDB.Exe_Select_Procedure();

                if (ds_ret == null) return null;
                return ds_ret.Tables[process_name];
            }
            catch
            {
                return null;
            }
        }


        /// <summary>
        /// SELECT_SBS_BAR_OUT_CONTAINER : 출고 컨테이너 리스트
        /// </summary>
        /// <returns>DataTable</returns>
        public static DataTable Select_OrderType_List(string arg_factory)
        {
            COM.OraDB oraDB = new COM.OraDB();

            string Proc_Name = "PKG_SCM_CODE.SELECT_ORDER_TYPE_SS";

            oraDB.ReDim_Parameter(2);
            oraDB.Process_Name = Proc_Name;

            oraDB.Parameter_Name[0] = "ARG_FACTORY";
            oraDB.Parameter_Name[1] = "OUT_CURSOR";

            oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            oraDB.Parameter_Type[1] = (int)OracleType.Cursor;

            oraDB.Parameter_Values[0] = COM.ComFunction.Empty_String(arg_factory, " ");
            oraDB.Parameter_Values[1] = "";

            oraDB.Add_Select_Parameter(false);
            DataSet DS_Ret = oraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];
        }

        /// <summary>
        /// SELECT_SBS_BAR_OUT_CONTAINER : 출고 컨테이너 리스트
        /// </summary>
        /// <returns>DataTable</returns>
        public static DataTable Get_WeekDay(string arg_ymd, string arg_order, string arg_day)
        {
            COM.OraDB oraDB = new COM.OraDB();

            string Proc_Name = "PKG_SBC_COMMON.SELECT_FIND_WEEKDAY";

            oraDB.ReDim_Parameter(4);
            oraDB.Process_Name = Proc_Name;

            oraDB.Parameter_Name[0] = "ARG_YMD";
            oraDB.Parameter_Name[1] = "ARG_ORDER";
            oraDB.Parameter_Name[2] = "ARG_DAY";
            oraDB.Parameter_Name[3] = "OUT_CURSOR";

            oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            oraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            oraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            oraDB.Parameter_Type[3] = (int)OracleType.Cursor;

            oraDB.Parameter_Values[0] = arg_ymd;
            oraDB.Parameter_Values[1] = arg_order;
            oraDB.Parameter_Values[2] = arg_day;
            oraDB.Parameter_Values[3] = "";

            oraDB.Add_Select_Parameter(false);
            DataSet DS_Ret = oraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];
        }


        /// <summary>
        /// SELECT_SBS_BAR_OUT_CONTAINER : PROCESS 마감여부
        /// </summary>
        /// <returns>DataTable</returns>
        public static DataTable Select_Close_Yn(string arg_factory, string arg_temp_div, string arg_temp_ymd, string arg_process_div)
        {
            COM.OraDB oraDB = new COM.OraDB();

            string Proc_Name = "PKG_SBC_COMMON.SELECT_CLOSE_YN";

            oraDB.ReDim_Parameter(5);
            oraDB.Process_Name = Proc_Name;

            oraDB.Parameter_Name[0] = "ARG_FACTORY";
            oraDB.Parameter_Name[1] = "ARG_TERM_DIV";
            oraDB.Parameter_Name[2] = "ARG_TERM_YMD";
            oraDB.Parameter_Name[3] = "ARG_PROCESS_DIV";
            oraDB.Parameter_Name[4] = "OUT_CURSOR";

            oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            oraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            oraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            oraDB.Parameter_Type[3] = (int)OracleType.VarChar;
            oraDB.Parameter_Type[4] = (int)OracleType.Cursor;

            oraDB.Parameter_Values[0] = arg_factory;
            oraDB.Parameter_Values[1] = arg_temp_div;
            oraDB.Parameter_Values[2] = arg_temp_ymd;
            oraDB.Parameter_Values[3] = arg_process_div;
            oraDB.Parameter_Values[4] = "";

            oraDB.Add_Select_Parameter(false);
            DataSet DS_Ret = oraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];
        }


        /// <summary>
        /// SELECT_SQC_LAB_SPEC_LIST : MCS_NO 리스트
        /// </summary>
        /// <returns>DataTable</returns>
        public static DataTable SELECT_SBC_MCS_LIST(string arg_factory, string arg_mcsName)
        {
            COM.OraDB oraDB = new COM.OraDB();

            string Proc_Name = "PKG_SQC_LAB_SPEC.SELECT_MCS_CODE";

            oraDB.ReDim_Parameter(3);
            oraDB.Process_Name = Proc_Name;

            oraDB.Parameter_Name[0] = "ARG_FACTORY";
            oraDB.Parameter_Name[1] = "ARG_MCS_NAME";
            oraDB.Parameter_Name[2] = "OUT_CURSOR";

            oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            oraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            oraDB.Parameter_Type[2] = (int)OracleType.Cursor;

            oraDB.Parameter_Values[0] = arg_factory;
            oraDB.Parameter_Values[1] = arg_mcsName;
            oraDB.Parameter_Values[2] = "";

            oraDB.Add_Select_Parameter(false);
            DataSet DS_Ret = oraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];
        }


        /// <summary>
        /// SELECT_WORK_PROCESS_LIST : PROCESS 리스트
        /// </summary>
        /// <param name="arg_value">검색어</param>
        /// <returns>DataTable</returns>
        public static DataTable Select_Opcd_List(string arg_factory)
        {
            COM.OraDB oraDB = new COM.OraDB();

            string Proc_Name = "PKG_SPB_WORK_PROCESS.SELECT_OPCD_LINE_LIST";

            oraDB.ReDim_Parameter(2);
            oraDB.Process_Name = Proc_Name;

            oraDB.Parameter_Name[0] = "ARG_FACTORY";
            oraDB.Parameter_Name[1] = "OUT_CURSOR";

            oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            oraDB.Parameter_Type[1] = (int)OracleType.Cursor;

            oraDB.Parameter_Values[0] = COM.ComFunction.Empty_String(arg_factory, " ");
            oraDB.Parameter_Values[1] = "";

            oraDB.Add_Select_Parameter(false);
            DataSet DS_Ret = oraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];
        }


        /// <summary>
        /// SELECT_WORK_LINE_LIST : LINE 리스트
        /// </summary>
        /// <param name="arg_value">검색어</param>
        /// <returns>DataTable</returns>
        public static DataTable Select_Job_Line_List(string arg_factory, string arg_work_ymd,
            string arg_to_ymd, string arg_work_process, string arg_out_div)
        {
            COM.OraDB oraDB = new COM.OraDB();

            string Proc_Name = "PKG_SPB_WORK_LINE.SELECT_JOB_LINE_LIST";

            oraDB.ReDim_Parameter(6);
            oraDB.Process_Name = Proc_Name;

            oraDB.Parameter_Name[0] = "ARG_FACTORY";
            oraDB.Parameter_Name[1] = "ARG_WORK_YMD";
            oraDB.Parameter_Name[2] = "ARG_TO_YMD";
            oraDB.Parameter_Name[3] = "ARG_WORK_PROCESS";
            oraDB.Parameter_Name[4] = "ARG_OUT_DIVISION";
            oraDB.Parameter_Name[5] = "OUT_CURSOR";

            oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            oraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            oraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            oraDB.Parameter_Type[3] = (int)OracleType.VarChar;
            oraDB.Parameter_Type[4] = (int)OracleType.VarChar;
            oraDB.Parameter_Type[5] = (int)OracleType.Cursor;

            oraDB.Parameter_Values[0] = COM.ComFunction.Empty_String(arg_factory, " ");
            oraDB.Parameter_Values[1] = COM.ComFunction.Empty_String(arg_work_ymd, " "); ;
            oraDB.Parameter_Values[2] = COM.ComFunction.Empty_String(arg_to_ymd, " "); ;
            oraDB.Parameter_Values[3] = COM.ComFunction.Empty_String(arg_work_process, " ");
            oraDB.Parameter_Values[4] = COM.ComFunction.Empty_String(arg_out_div, " ");
            oraDB.Parameter_Values[5] = "";

            oraDB.Add_Select_Parameter(false);
            DataSet DS_Ret = oraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];
        }


        #endregion

        #region 안상민추가

        /// <summary>
        /// Set_OBSID_CmbList : OBS TYPE별 OBS ID 생성 및 콤보리스트에 추가
        /// </summary>
        /// <param name="arg_type">선택된 OBS Type</param>
        /// <param name="arg_cmb">적용 대상 콤보 박스명</param>
        //public static void Set_OBSID_CmbList(string arg_type, C1.Win.C1List.C1Combo arg_cmb)
        //{
        //    int i = 0;
        //    string sDate1, sDate2;

        //    COM.ComFunction MyComFunction = new COM.ComFunction();
        //    DateTime CurDate = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd"));


        //    arg_cmb.DataMode = C1.Win.C1List.DataModeEnum.AddItem;
        //    arg_cmb.ClearItems();
        //    arg_cmb.ExtendRightColumn = true;
        //    arg_cmb.ColumnHeaders = false;
        //    arg_cmb.SelectedIndex = -1;

        //    switch (arg_type)
        //    {
        //        case "OR":
        //            for (i = -1; i <= 1; i++)
        //                arg_cmb.AddItem(CurDate.AddYears(i).Year.ToString("yyyy-MM-dd").Substring(2, 2) + "0605");

        //            arg_cmb.SelectedIndex = 1;
        //            break;

        //        case "SS":
        //        case "PS":
        //            for (i = -1; i <= 1; i++)
        //                arg_cmb.AddItem(CurDate.AddYears(i).Year.ToString("yyyy-MM-dd").Substring(2, 2) + "0112");

        //            arg_cmb.SelectedIndex = 1;
        //            break;

        //        case "TS":
        //        case "TP":
        //        case "ID":
        //            for (i = -7; i <= 3; i++)
        //            {
        //                sDate1 = CurDate.AddMonths(i).ToString("yyyy-MM-dd");
        //                sDate1 = sDate1.Substring(2, 2) + sDate1.Substring(5, 2) + "01";

        //                arg_cmb.AddItem(sDate1);
        //            }

        //            arg_cmb.SelectedIndex = 3;
        //            break;

        //        case "QQ":

        //            for (i = -3; i <= 3; i++)
        //            {
        //                sDate1 = CurDate.AddMonths(i).ToString("yyyy-MM-dd");
        //                sDate2 = CurDate.AddMonths(i + 1).ToString("yyyy-MM-dd");

        //                sDate1 = sDate1.Substring(2, 2) + sDate1.Substring(5, 2) + sDate2.Substring(5, 2); ;

        //                arg_cmb.AddItem(sDate1);
        //            }

        //            arg_cmb.SelectedIndex = 3;
        //            break;

        //        default:
        //            for (i = -7; i <= 3; i++)
        //            {
        //                sDate1 = CurDate.AddMonths(i).ToString("yyyy-MM-dd");
        //                sDate2 = CurDate.AddMonths(i + 2).ToString("yyyy-MM-dd");

        //                sDate1 = sDate1.Substring(2, 2) + sDate1.Substring(5, 2) + sDate2.Substring(5, 2);

        //                arg_cmb.AddItem(sDate1);
        //            }


        //            arg_cmb.SelectedIndex = 5;
        //            break;
        //    }

        //    arg_cmb.MaxDropDownItems = Convert.ToInt16(arg_cmb.ListCount);
        //}

        /// <summary>
        /// Read MS-SQL Server
        /// </summary>
        /// <param name="arg_dtsrc">data source</param>
        /// <param name="arg_sql">sql string</param>
        public static OleDbDataReader Read_MSSQL(string arg_sql, string arg_dtsrc, string arg_id, string arg_pw)
        {
            OleDbConnection AdoConn = null;
            OleDbDataReader reader = null;

            string MSSQLCon;

            if (arg_pw.Length == 0)
            {
                MSSQLCon = @"Provider=SQLOLEDB.1;Data Source=" + arg_dtsrc + ";User ID=" + arg_id + ";Persist Security Info=False;Initial Catalog=MercuryFFSdb";
            }
            else
            {
                MSSQLCon = @"Provider=SQLOLEDB.1;Data Source=" + arg_dtsrc + ";User ID=" + arg_id + ";Password=" + arg_pw + ";Persist Security Info=False;Initial Catalog=MercuryFFSdb";
            }


            AdoConn = new OleDbConnection(MSSQLCon);

            AdoConn.Close();
            AdoConn.Open();

            string AdoSQL = arg_sql;

            OleDbCommand Cmd = new OleDbCommand(AdoSQL, AdoConn);
            Cmd.CommandTimeout = 60 * 1000;

            reader = Cmd.ExecuteReader();

            return reader;
        }

        /// <summary>
        /// Data Type 체크
        /// </summary>
        /// <param name="arg_type">Field Type</param>
        /// <param name="arg_data">Data</param>
        /// <returns>string</returns>
        public static string Convert_dtType(string arg_type, string arg_data)
        {
            switch (arg_type)
            {
                case "DateTime":
                    return arg_data.Substring(0, 4) + arg_data.Substring(5, 2) + arg_data.Substring(8, 2);

                case "Boolean":
                    return arg_data.Substring(0, 1);

                default:
                    return arg_data.Trim();
            }
        }

        #endregion

        #region 메모리 정리 (WINAPI)


        [System.Runtime.InteropServices.DllImport("kernel32.dll")]
        static extern bool SetProcessWorkingSetSize(IntPtr hProcess, UIntPtr dwMinimumWorkingSetSize, UIntPtr dwMaximumWorkingSetSize);

        #endregion

        #region "Fucntion for Model Description"

        /// <summary>
        /// Convert byte array to image
        /// </summary>
        /// <param name="arg_image"></param>
        public static Image ByteArrToImage(byte[] arg_image)
        {
            try
            {
                byte[] db_image = (byte[])arg_image;

                MemoryStream ms = new MemoryStream(db_image);

                System.Drawing.Bitmap true_image = new System.Drawing.Bitmap(ms);

                ms.Close();

                return true_image;
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Convert byte array to image
        /// </summary>
        /// <param name="arg_image"></param>
        public static Image ByteArrToImage(object arg_image)
        {
            if (arg_image == null) return null;
            if (arg_image.ToString().Trim().Equals(string.Empty)) return null;
            return ByteArrToImage((byte[])arg_image);
        }

        public static byte[] ImageToByteArr(System.Drawing.Image imageToConvert, ImageFormat formatOfImage)
        {
            byte[] Ret;

            try
            {

                using (MemoryStream ms = new MemoryStream())
                {
                    imageToConvert.Save(ms, ImageFormat.Jpeg);
                    Ret = ms.ToArray();
                }
            }
            catch (Exception)
            {
                //ImageFormat l_ImageFormat = new ImageFormat(formatOfImage.Guid);

                //ImageCodecInfo jpegCodec = GetEncoderInfo(@"image/jpeg");
                //Encoder myEncoder = Encoder.Transformation;
                //EncoderParameter qualityParam = new EncoderParameter(Encoder.Quality, (long)EncoderValue.CompressionNone);
                //EncoderParameters encoderParams = new EncoderParameters(1);
                //encoderParams.Param[0] = qualityParam;
                //System.IO.MemoryStream mss = new System.IO.MemoryStream();
                //imageToConvert.Save(mss, jpegCodec, encoderParams);
                //byte[] matriz = mss.ToArray(); 
                //mss.Close(); 
                //Ret = ms.ToArray();
                throw;
            }
            

            return Ret;
        }

        private static ImageCodecInfo GetEncoderInfo(String mimeType)
        {
            int j;
            ImageCodecInfo[] encoders;
            encoders = ImageCodecInfo.GetImageEncoders();
            for (j = 0; j < encoders.Length; ++j)
            {
                if (encoders[j].MimeType == mimeType)
                    return encoders[j];
            }
            return null;
        }


        public static Bitmap resizeImage(Bitmap imgToResize, Size size)
        {
            //source: http://www.personalmicrocosms.com/Pages/dotnettips.aspx?c=24&t=50

            int sourceWidth = imgToResize.Width;
            int sourceHeight = imgToResize.Height;

            float nPercent = 0;
            float nPercentW = 0;
            float nPercentH = 0;

            nPercentW = ((float)size.Width / (float)sourceWidth);
            nPercentH = ((float)size.Height / (float)sourceHeight);

            if (nPercentH < nPercentW)
                nPercent = nPercentH;
            else
                nPercent = nPercentW;

            int destWidth = (int)(sourceWidth * nPercent);
            int destHeight = (int)(sourceHeight * nPercent);

            Bitmap dest = new Bitmap(size.Width, size.Height);

            // Scale the bitmap in high quality mode.
            using (Graphics gr = Graphics.FromImage(dest))
            {
                gr.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                gr.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
                gr.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                gr.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                gr.DrawImage(imgToResize, new Rectangle(0, 0, size.Width, size.Height), new Rectangle(0, 0, imgToResize.Width, imgToResize.Height), GraphicsUnit.Pixel);
                gr.Dispose();
            }

            // Copy original Bitmap's EXIF tags to new bitmap.
            foreach (PropertyItem propertyItem in imgToResize.PropertyItems)
            {
                dest.SetPropertyItem(propertyItem);
            }

            imgToResize.Dispose();
            return dest;

            /*
            Bitmap b = new Bitmap(destWidth, destHeight);
            Graphics g = Graphics.FromImage((Image)b);
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;

            g.DrawImage(imgToResize, 0, 0, destWidth, destHeight);
            g.Dispose();

            return (Bitmap)b;*/
        }

        public static bool SAVE_SYS_PGM_MON(bool doExecute)
        {
            COM.OraDB oraDB = new COM.OraDB();

            try
            {
                oraDB.ReDim_Parameter(8);

                oraDB.Process_Name = "PKG_SYS_PGM_MON.SAVE_SYS_PGM";

                oraDB.Parameter_Name[0] = "ARG_USR_ID";
                oraDB.Parameter_Name[1] = "ARG_MC_ID";
                oraDB.Parameter_Name[2] = "ARG_PGM";
                oraDB.Parameter_Name[3] = "ARG_WIN_ID";
                oraDB.Parameter_Name[4] = "ARG_ACTION";
                oraDB.Parameter_Name[5] = "ARG_REF1";
                oraDB.Parameter_Name[6] = "ARG_REF2";
                oraDB.Parameter_Name[7] = "ARG_REF3";

                oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                oraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                oraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                oraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                oraDB.Parameter_Type[4] = (int)OracleType.VarChar;
                oraDB.Parameter_Type[5] = (int)OracleType.VarChar;
                oraDB.Parameter_Type[6] = (int)OracleType.VarChar;
                oraDB.Parameter_Type[7] = (int)OracleType.VarChar;

                oraDB.Parameter_Values[0] = COM.ComVar.This_User;
                oraDB.Parameter_Values[1] = IPEX_Monitor.ClassLib.ComVar.This_Computer;
                oraDB.Parameter_Values[2] = IPEX_Monitor.ClassLib.ComVar.This_PGM;
                oraDB.Parameter_Values[3] = IPEX_Monitor.ClassLib.ComVar.This_Win_ID;
                oraDB.Parameter_Values[4] = IPEX_Monitor.ClassLib.ComVar.This_Action;
                oraDB.Parameter_Values[5] = IPEX_Monitor.ClassLib.ComVar.This_Packages;
                oraDB.Parameter_Values[6] = IPEX_Monitor.ClassLib.ComVar.This_REF2;
                oraDB.Parameter_Values[7] = IPEX_Monitor.ClassLib.ComVar.This_REF3;

                oraDB.Add_Modify_Parameter(true);

                if (doExecute)
                {
                    if (oraDB.Exe_Modify_Procedure() == null)
                        return false;
                    else
                        return true;
                }

                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion


    }


    #region 메모리 정리 (WINAPI)


    public class MemoryManagement
    {
        [System.Runtime.InteropServices.DllImport("kernel32.dll")]
        public static extern bool SetProcessWorkingSetSize(IntPtr proc, int min, int max);

        public static void FlushMemory()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            if (Environment.OSVersion.Platform == PlatformID.Win32NT)
            {
                SetProcessWorkingSetSize(System.Diagnostics.Process.GetCurrentProcess().Handle, -1, -1);
            }
        }
    }


    #endregion





}