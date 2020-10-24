using System;
using System.Data;
using System.Drawing;
using System.Data.OracleClient;

namespace FlexQuality.ClassLib
{
	/// <summary>
	/// ComVar에 대한 요약 설명입니다.
	/// </summary>
	public class ComVar : COM.ComVar
	{
		public ComVar()
		{
			//
			// TODO: 여기에 생성자 논리를 추가합니다.
			//
		}
        
		public static object[] Parameter_PopUp_ObjectGAC  = null;
		public static object[] Parameter_PopUp_ObjectGAC2 = null;
		public const string REQUEST		= "REQUEST";
		public const string PURCHASE	= "PURCHASE";
		public const string INCOMING	= "INCOMING";
		public const string SHIPPING	= "SHIPPING";
		public const string OUTGOING	= "OUTGOING";
		public const string TRADE		= "TRADE"; 
		public const string QC_REQUEST	= "QC_REQ_NEW";	
		public const string QC_TEST		= "QC_TEST";
		public static string dayChange;
		public static string _user;
		public static string []Parameter_Values;
		public static string This_User_AD = "";
		public static string This_JobCdoe = "M";		
		
		public static string This_Lang = "KO";
		public static string _resultFlag;
		public static int _rowPage = 100;
		public static int _firstPage = 1;
		public static int pages ;
		public static int lastPage;
		public static int curPage;
		public static DataTable vDt1 = null;
        public static DataTable vDt2 = null;

		public static string This_Computer;
		public static string This_Action ;
		public static string This_Win_ID ;
		public static string This_PGM ;
		public static string This_Packages;
		public static string This_REF1 = "";
		public static string This_REF2 = "";
		public static string This_REF3 = "";
		public static string This_User = "admin";
		public static string This_Role = "";
		public static string This_Del = "";
		public static string This_Fix = "";
		
		//page rows 
		public static string _xPage1 = "0-99";
		public static string _xPage2 = "100-199";
		public static string _xPage3 = "200-299";
		public static string _xPage4 = "300-399";
		public static string _xPage5 = "400-499";
		public static string _xPage6 = "500-599";
		public static string _xPage7 = "600-699";
		public static string _xPage8 = "700-799";
		public static string _xPage9 = "800-899";
		public static string _xPage10 = "900-999";
		public static string _xPage11 = "1000-1099";
		public static string _xPage12 = "1100-1199";
		public static string _xPage13 = "1200-1299";
		public static string _xPage14 = "1300-1399";
		public static string _xPage15 = "1400-1499";
		public static string _xPage16 = "1500-1599";
		public static string _xPage17 = "1600-1699";
		public static string _xPage18 = "1700-1799";
		public static string _xPage19 = "1800-1899";
		public static string _xPage20 = "1900-1999";
		public static string _xPage21 = "2000-2099";
		public static string _xPage22 = "2100-2199";
		public static string _xPage23 = "2200-2299";
		public static string _xPage24 = "2300-2399";
		public static string _xPage25 = "2400-2499";
		

		//
		//grid color
		public static Color ClrLevel_1st = Color.FromArgb(255,223,255);//(239, 231, 241);
		public static Color ClrLevel_2nd = Color.FromArgb(255, 242, 238);
		public static Color ClrLevel_3rd = Color.FromArgb(249, 249, 251);
		public static Color ClrYield_SizeY = Color.Magenta;
		public static Color ClrEdit = Color.Magenta;
		public static Color ClrFormulaEdit = Color.Blue;
		
		//
		//Page send flag
		public static string _pageFlag1="N";
		public static string _pageFlag2="N";
		public static string _pageFlag3="N";
		public static string _pageFlag4="N";
		public static string _pageFlag5="N";
		public static string _pageFlag6="N";
		public static string _pageFlag7="N";
		public static string _pageFlag8="N";
		public static string _pageFlag9="N";
		public static string _pageFlag10="N";
		public static string _pageFlag11="N";
		public static string _pageFlag12="N";
		public static string _pageFlag13="N";
		public static string _pageFlag14="N";
		public static string _pageFlag15="N";
		public static string _pageFlag16="N";
		public static string _pageFlag17="N";
		public static string _pageFlag18="N";
		public static string _pageFlag19="N";
		public static string _pageFlag20="N";
		public static string _pageFlag21="N";
		public static string _pageFlag22="N";
		public static string _pageFlag23="N";
		public static string _pageFlag24="N";
		public static string _pageFlag25="N";
		

		public enum TBSPS_NOTICE_USER_HOME : int
		{

			IxFACTORY    = 0,
			IxDIVISION   = 1,
			IxSEQ        = 2,
			IxSUSER_NAME = 3,
			IxTITLE      = 4,
			IxUPD_YMD    = 5, 

		}



	
		public enum TBSPS_NOTICE_HOME : int
		{

			IxFACTORY = 0,
			IxSEQ     = 1,
			IxTITLE	  = 2,
			IxSYMD	  = 3,


		}
		public enum TBSPS_AUTO_INFO_HOME : int
		{

			IxFACTORY    = 0,
			IxSEQ        = 1,
			IxCONTENTS   = 2,
			IxREMARKS    = 3,
			IxUPD_USER   = 4,
			IxUPD_YMD    = 5, 

		}
		public enum TBSPS_NOTICE_INGWORK_HOME : int
		{

			IxFACTORY    = 0,
			IxSEQ        = 1,
			IxEDATE      = 2,
			IxJOB_CD     = 3,
			IxSUSER_NAME = 4,
			IxTITLE      = 5, 
			IxUPD_YMD    = 6, 

		}

 

		/// <summary>
		/// TBSPS_WORKINFO_USER_HOME : [Please, Do it] 사용자 업무 공지
		/// </summary>
		public enum TBSPS_WORKINFO_USER_HOME : int
		{

			IxFACTORY    = 0,
			IxSEQ        = 1,
			IxJOB_CD     = 2,
			IxREAD_YN    = 3,
			IxTITLE      = 4,
			IxUPD_YMD    = 5, 
			IxRUSER_ID   = 6, 

		}
	        
	}
}
