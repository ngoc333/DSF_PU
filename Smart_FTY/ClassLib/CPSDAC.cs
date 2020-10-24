using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using COM.eBiz.Framework.Lib;
using COM.eBiz.Framework.Data;

namespace LMS03CPSMonitor.Common
{
    class CPSDAC : COM.eBiz.Framework.Data.BaseDac
    {
        #region SP실행예제
        public DataSet GetTest(DataPack oDataPack)
        {
            return OraDBHelper.ExecuteDataSet("GETTEST", oDataPack);
            
        }
        #endregion


        #region SP실행부 - SELECT
        #region Common
        public DataSet GetLMSFormList(DataPack oDataPack)
        {
            return OraDBHelper.ExecuteDataSet("LMSP_GET_CPSFORMLIST_Q", oDataPack);
        }

        /// <summary>
        /// get Refresh time
        /// </summary>
        /// <param name="oDataPack"></param>
        /// <returns></returns>
        public DataSet GetLMSFormQueryTime(DataPack oDataPack)
        {
            return OraDBHelper.ExecuteDataSet("LMSP_GET_CPSFORM_QUERYTIME_Q", oDataPack);
        }



        /// <summary>
        /// R-PLAN (현재시간별 누적 생산계획)
        /// </summary>
        /// <param name="oDataPack"></param>
        /// <returns></returns>
        public DataSet GetRPlan(DataPack oDataPack)
        {
            return OraDBHelper.ExecuteDataSet("LMSP_GETRPLAN_SUMMARY_Q", oDataPack);
        }


        /// <summary>
        /// PLAN (전체 생산계획)
        /// </summary>
        /// <param name="oDataPack"></param>
        /// <returns></returns>
        public DataSet GetTarget(DataPack oDataPack)
        {
            return OraDBHelper.ExecuteDataSet("LMSP_GETPLAN_SUMMARY_Q", oDataPack);
        }

        /// <summary>
        /// Actual (생산실적)
        /// </summary>
        /// <param name="oDataPack"></param>
        /// <returns></returns>
        public DataSet GetActual(DataPack oDataPack)
        {
            return OraDBHelper.ExecuteDataSet("LMSP_GETRPROD_SUMMARY_Q", oDataPack);
        }
        #endregion


        #region FORM301
        /// <summary>
        /// FORM301 RR, POD, POH, TPA
        /// </summary>
        /// <param name="oDataPack"></param>
        /// <returns></returns>
        public DataSet GetLMSForm301_3List(DataPack oDataPack)
        {
            return OraDBHelper.ExecuteDataSet("LMSP_GET_FRM301_3_Q", oDataPack);
        }

        /// <summary>
        /// FORM301 BTS
        /// </summary>
        /// <param name="oDataPack"></param>
        /// <returns></returns>
        public DataSet GetLMSForm301BTSList(DataPack oDataPack)
        {
            return OraDBHelper.ExecuteDataSet("LMSP_GET_FRM301_BTS_Q", oDataPack);
        }

        /// <summary>
        /// FORM301 MI
        /// </summary>
        /// <param name="oDataPack"></param>
        /// <returns></returns>
        public DataSet GetLMSForm301MIList(DataPack oDataPack)
        {
            return OraDBHelper.ExecuteDataSet("LMSP_GET_FRM301_MI_Q", oDataPack);
        }

        #region FORM301_F1
        /// <summary>
        /// FORM301 RR, POD, POH, TPA
        /// </summary>
        /// <param name="oDataPack"></param>
        /// <returns></returns>
        public DataSet GetLMSForm301F1_3List(DataPack oDataPack)
        {
            return OraDBHelper.ExecuteDataSet("LMSP_GET_FRM301F1_3_Q", oDataPack);
        }

        /// <summary>
        /// FORM301 BTS
        /// </summary>
        /// <param name="oDataPack"></param>
        /// <returns></returns>
        public DataSet GetLMSForm301F1BTSList(DataPack oDataPack)
        {
            return OraDBHelper.ExecuteDataSet("LMSP_GET_FRM301F1_BTS_Q", oDataPack);
        }

        /// <summary>
        /// FORM301 MI
        /// </summary>
        /// <param name="oDataPack"></param>
        /// <returns></returns>
        public DataSet GetLMSForm301F1MIList(DataPack oDataPack)
        {
            return OraDBHelper.ExecuteDataSet("LMSP_GET_FRM301F1_MI_Q", oDataPack);
        }
        #endregion

        #region FORM301_F2
        /// <summary>
        /// FORM301 RR, POD, POH, TPA
        /// </summary>
        /// <param name="oDataPack"></param>
        /// <returns></returns>
        public DataSet GetLMSForm301F2_3List(DataPack oDataPack)
        {
            return OraDBHelper.ExecuteDataSet("LMSP_GET_FRM301F2_3_Q", oDataPack);
        }

        /// <summary>
        /// FORM301 BTS
        /// </summary>
        /// <param name="oDataPack"></param>
        /// <returns></returns>
        public DataSet GetLMSForm301F2BTSList(DataPack oDataPack)
        {
            return OraDBHelper.ExecuteDataSet("LMSP_GET_FRM301F2_BTS_Q", oDataPack);
        }

        /// <summary>
        /// FORM301 MI
        /// </summary>
        /// <param name="oDataPack"></param>
        /// <returns></returns>
        public DataSet GetLMSForm301F2MIList(DataPack oDataPack)
        {
            return OraDBHelper.ExecuteDataSet("LMSP_GET_FRM301F2_MI_Q", oDataPack);
        }
        #endregion

        #region FORM301_F3
        /// <summary>
        /// FORM301 RR, POD, POH, TPA
        /// </summary>
        /// <param name="oDataPack"></param>
        /// <returns></returns>
        public DataSet GetLMSForm301F3_3List(DataPack oDataPack)
        {
            return OraDBHelper.ExecuteDataSet("LMSP_GET_FRM301F3_3_Q", oDataPack);
        }

        /// <summary>
        /// FORM301 BTS
        /// </summary>
        /// <param name="oDataPack"></param>
        /// <returns></returns>
        public DataSet GetLMSForm301F3BTSList(DataPack oDataPack)
        {
            return OraDBHelper.ExecuteDataSet("LMSP_GET_FRM301F3_BTS_Q", oDataPack);
        }

        /// <summary>
        /// FORM301 MI
        /// </summary>
        /// <param name="oDataPack"></param>
        /// <returns></returns>
        public DataSet GetLMSForm301F3MIList(DataPack oDataPack)
        {
            return OraDBHelper.ExecuteDataSet("LMSP_GET_FRM301F3_MI_Q", oDataPack);
        }
        #endregion

        #region FORM301_F4
        /// <summary>
        /// FORM301 RR, POD, POH, TPA
        /// </summary>
        /// <param name="oDataPack"></param>
        /// <returns></returns>
        public DataSet GetLMSForm301F4_3List(DataPack oDataPack)
        {
            return OraDBHelper.ExecuteDataSet("LMSP_GET_FRM301F4_3_Q", oDataPack);
        }

        /// <summary>
        /// FORM301 BTS
        /// </summary>
        /// <param name="oDataPack"></param>
        /// <returns></returns>
        public DataSet GetLMSForm301F4BTSList(DataPack oDataPack)
        {
            return OraDBHelper.ExecuteDataSet("LMSP_GET_FRM301F4_BTS_Q", oDataPack);
        }

        /// <summary>
        /// FORM301 MI
        /// </summary>
        /// <param name="oDataPack"></param>
        /// <returns></returns>
        public DataSet GetLMSForm301F4MIList(DataPack oDataPack)
        {
            return OraDBHelper.ExecuteDataSet("LMSP_GET_FRM301F4_MI_Q", oDataPack);
        }
        #endregion

        #endregion
                
        #region FORM303
        /// <summary>
        /// FORM303 Grid Data.
        /// </summary>
        /// <param name="oDataPack"></param>
        /// <returns></returns>
        public DataSet GetLMSForm303List(DataPack oDataPack)
        {
            return OraDBHelper.ExecuteDataSet("LMSP_GET_FRM303LIST_Q", oDataPack);
        }

        /// <summary>
        /// FORM303_F1 Grid Data.
        /// </summary>
        /// <param name="oDataPack"></param>
        /// <returns></returns>
        public DataSet GetLMSForm303F1List(DataPack oDataPack)
        {
            return OraDBHelper.ExecuteDataSet("LMSP_GET_FRM303F1LIST_Q", oDataPack);
        }


        /// <summary>
        /// FORM303_F2 Grid Data.
        /// </summary>
        /// <param name="oDataPack"></param>
        /// <returns></returns>
        public DataSet GetLMSForm303F2List(DataPack oDataPack)
        {
            return OraDBHelper.ExecuteDataSet("LMSP_GET_FRM303F2LIST_Q", oDataPack);
        }


        /// <summary>
        /// FORM303_F3 Grid Data.
        /// </summary>
        /// <param name="oDataPack"></param>
        /// <returns></returns>
        public DataSet GetLMSForm303F3List(DataPack oDataPack)
        {
            return OraDBHelper.ExecuteDataSet("LMSP_GET_FRM303F3LIST_Q", oDataPack);
        }


        /// <summary>
        /// FORM303_F4 Grid Data.
        /// </summary>
        /// <param name="oDataPack"></param>
        /// <returns></returns>
        public DataSet GetLMSForm303F4List(DataPack oDataPack)
        {
            return OraDBHelper.ExecuteDataSet("LMSP_GET_FRM303F4LIST_Q", oDataPack);
        }
        #endregion

        #region FORM305
        /// <summary>
        /// FORM305 Grid Data.
        /// </summary>
        /// <param name="oDataPack"></param>
        /// <returns></returns>
        public DataSet GetLMSForm305List(DataPack oDataPack)
        {
            return OraDBHelper.ExecuteDataSet("LMSP_GET_FRM305LIST_Q", oDataPack);
        }

        /// <summary>
        /// FORM306_F1 Grid Data
        /// </summary>
        /// <param name="oDataPack"></param>
        /// <returns></returns>
        public DataSet GetLMSForm306F1List(DataPack oDataPack)
        {
            return OraDBHelper.ExecuteDataSet("LMSP_GET_FRM306f1LIST_Q", oDataPack);
        }

        /// <summary>
        /// FORM306_F2 Grid Data
        /// </summary>
        /// <param name="oDataPack"></param>
        /// <returns></returns>
        public DataSet GetLMSForm306F2List(DataPack oDataPack)
        {
            return OraDBHelper.ExecuteDataSet("LMSP_GET_FRM306f2LIST_Q", oDataPack);
        }

        /// <summary>
        /// FORM306_F3 Grid Data
        /// </summary>
        /// <param name="oDataPack"></param>
        /// <returns></returns>
        public DataSet GetLMSForm306F3List(DataPack oDataPack)
        {
            return OraDBHelper.ExecuteDataSet("LMSP_GET_FRM306f3LIST_Q", oDataPack);
        }


        /// <summary>
        /// FORM306_F4 Grid Data
        /// </summary>
        /// <param name="oDataPack"></param>
        /// <returns></returns>
        public DataSet GetLMSForm306F4List(DataPack oDataPack)
        {
            return OraDBHelper.ExecuteDataSet("LMSP_GET_FRM306f4LIST_Q", oDataPack);
        }
        #endregion

        #region FORM306
        /// <summary>
        /// FORM306 Grid Data.
        /// </summary>
        /// <param name="oDataPack"></param>
        /// <returns></returns>
        public DataSet GetLMSForm306List(DataPack oDataPack)
        {
            return OraDBHelper.ExecuteDataSet("LMSP_GET_FRM306LIST_Q", oDataPack);
        }
        #endregion

        #region FORM307


        /// <summary>
        /// LOGISTICS FORM307 LongThanh - Outgoing 가져오기
        /// </summary>
        /// <param name="oDataPack"></param>
        /// <returns></returns>
        public DataSet GetLMSForm307LTOut(DataPack oDataPack)
        {
            return OraDBHelper.ExecuteDataSet("LMSP_GET_FRM307_LTOUT_Q", oDataPack);
        }

        /// <summary>
        /// LOGISTICS FORM307 LongThanh - Outgoing 가져오기
        /// </summary>
        /// <param name="oDataPack"></param>
        /// <returns></returns>
        public DataSet GetLMSForm307LONGTHANHOut(DataPack oDataPack)
        {
            return OraDBHelper.ExecuteDataSet("LMSP_GET_FRM307_LONGTHOUT_Q", oDataPack);
        }

        /// <summary>
        /// LOGISTICS FORM307 BOTTOM 대입값 가져오기
        /// </summary>
        /// <param name="oDataPack"></param>
        /// <returns></returns>
        public DataSet GetLMSForm307Bottom(DataPack oDataPack)
        {
            return OraDBHelper.ExecuteDataSet("LMSP_GET_FRM307_BOTTOM_Q", oDataPack);
        }

        /// <summary>
        /// LOGISTICS FORM307 STOCKFIT 대입값 가져오기
        /// </summary>
        /// <param name="oDataPack"></param>
        /// <returns></returns>
        public DataSet GetLMSForm307STList(DataPack oDataPack)
        {
            return OraDBHelper.ExecuteDataSet("LMSP_GET_FRM307_STList_Q", oDataPack);
        }

        /// <summary>
        /// LOGISTICS FORM307 STOCKFIT 대입값 가져오기
        /// </summary>
        /// <param name="oDataPack"></param>
        /// <returns></returns>
        public DataSet GetLMSForm307ASSList(DataPack oDataPack)
        {
            return OraDBHelper.ExecuteDataSet("LMSP_GET_FRM307_ASSList_Q", oDataPack);
        }

        #endregion

        #region FORM308
        /// <summary>
        /// FORM308 Grid Data
        /// </summary>
        /// <param name="oDataPack"></param>
        /// <returns></returns>
        public DataSet GetLMSForm308List(DataPack oDataPack)
        {
            return OraDBHelper.ExecuteDataSet("LMSP_GET_FRM308LIST_Q", oDataPack);
        }

        #region FORM308
        /// <summary>
        /// FORM308 공정별 data (F/GOOD) 제외.
        /// </summary>
        /// <param name="oDataPack"></param>
        /// <returns></returns>
        public DataSet GetLMSForm308_OPList(DataPack oDataPack)
        {
            return OraDBHelper.ExecuteDataSet("LMSP_GET_FRM308_OPLIST_Q", oDataPack);
        }


        /// <summary>
        /// FORM308 PLAN 공정별 생산계획.
        /// </summary>
        /// <param name="oDataPack"></param>
        /// <returns></returns>
        public DataSet GetLMSForm308_PLANList(DataPack oDataPack)
        {
            return OraDBHelper.ExecuteDataSet("LMSP_GET_FRM308_PLANLIST_Q", oDataPack);
        }

        /// <summary>
        /// FORM308 F/GOOD.
        /// </summary>
        /// <param name="oDataPack"></param>
        /// <returns></returns>
        public DataSet GetLMSForm308_FGOODList(DataPack oDataPack)
        {
            return OraDBHelper.ExecuteDataSet("LMSP_GET_FRM308_FGOODLIST_Q", oDataPack);
        }
        #endregion

        #region FORM308_F1
        /// <summary>
        /// FORM308 공정별 data (F/GOOD) 제외.
        /// </summary>
        /// <param name="oDataPack"></param>
        /// <returns></returns>
        public DataSet GetLMSForm308_F1_OPList(DataPack oDataPack)
        {
            return OraDBHelper.ExecuteDataSet("LMSP_GET_FRM308F1_OPLIST_Q", oDataPack);
        }


        /// <summary>
        /// FORM308 PLAN 공정별 생산계획.
        /// </summary>
        /// <param name="oDataPack"></param>
        /// <returns></returns>
        public DataSet GetLMSForm308_F1_PLANList(DataPack oDataPack)
        {
            return OraDBHelper.ExecuteDataSet("LMSP_GET_FRM308F1_PLANLIST_Q", oDataPack);
        }

        /// <summary>
        /// FORM308 F/GOOD.
        /// </summary>
        /// <param name="oDataPack"></param>
        /// <returns></returns>
        public DataSet GetLMSForm308_F1_FGOODList(DataPack oDataPack)
        {
            return OraDBHelper.ExecuteDataSet("LMSP_GET_FRM308F1_FGOODLIST_Q", oDataPack);
        }
        #endregion

        #region FORM308_F2
        /// <summary>
        /// FORM308 공정별 data (F/GOOD) 제외.
        /// </summary>
        /// <param name="oDataPack"></param>
        /// <returns></returns>
        public DataSet GetLMSForm308_F2_OPList(DataPack oDataPack)
        {
            return OraDBHelper.ExecuteDataSet("LMSP_GET_FRM308F2_OPLIST_Q", oDataPack);
        }


        /// <summary>
        /// FORM308 PLAN 공정별 생산계획.
        /// </summary>
        /// <param name="oDataPack"></param>
        /// <returns></returns>
        public DataSet GetLMSForm308_F2_PLANList(DataPack oDataPack)
        {
            return OraDBHelper.ExecuteDataSet("LMSP_GET_FRM308F2_PLANLIST_Q", oDataPack);
        }

        /// <summary>
        /// FORM308 F/GOOD.
        /// </summary>
        /// <param name="oDataPack"></param>
        /// <returns></returns>
        public DataSet GetLMSForm308_F2_FGOODList(DataPack oDataPack)
        {
            return OraDBHelper.ExecuteDataSet("LMSP_GET_FRM308F2_FGOODLIST_Q", oDataPack);
        }
        #endregion

        #region FORM308_F3
        /// <summary>
        /// FORM308 공정별 data (F/GOOD) 제외.
        /// </summary>
        /// <param name="oDataPack"></param>
        /// <returns></returns>
        public DataSet GetLMSForm308_F3_OPList(DataPack oDataPack)
        {
            return OraDBHelper.ExecuteDataSet("LMSP_GET_FRM308F3_OPLIST_Q", oDataPack);
        }


        /// <summary>
        /// FORM308 PLAN 공정별 생산계획.
        /// </summary>
        /// <param name="oDataPack"></param>
        /// <returns></returns>
        public DataSet GetLMSForm308_F3_PLANList(DataPack oDataPack)
        {
            return OraDBHelper.ExecuteDataSet("LMSP_GET_FRM308F3_PLANLIST_Q", oDataPack);
        }

        /// <summary>
        /// FORM308 F/GOOD.
        /// </summary>
        /// <param name="oDataPack"></param>
        /// <returns></returns>
        public DataSet GetLMSForm308_F3_FGOODList(DataPack oDataPack)
        {
            return OraDBHelper.ExecuteDataSet("LMSP_GET_FRM308F3_FGOODLIST_Q", oDataPack);
        }
        #endregion

        #region FORM308_F4
        /// <summary>
        /// FORM308 공정별 data (F/GOOD) 제외.
        /// </summary>
        /// <param name="oDataPack"></param>
        /// <returns></returns>
        public DataSet GetLMSForm308_F4_OPList(DataPack oDataPack)
        {
            return OraDBHelper.ExecuteDataSet("LMSP_GET_FRM308F4_OPLIST_Q", oDataPack);
        }


        /// <summary>
        /// FORM308 PLAN 공정별 생산계획.
        /// </summary>
        /// <param name="oDataPack"></param>
        /// <returns></returns>
        public DataSet GetLMSForm308_F4_PLANList(DataPack oDataPack)
        {
            return OraDBHelper.ExecuteDataSet("LMSP_GET_FRM308F4_PLANLIST_Q", oDataPack);
        }

        /// <summary>
        /// FORM308 F/GOOD.
        /// </summary>
        /// <param name="oDataPack"></param>
        /// <returns></returns>
        public DataSet GetLMSForm308_F4_FGOODList(DataPack oDataPack)
        {
            return OraDBHelper.ExecuteDataSet("LMSP_GET_FRM308F4_FGOODLIST_Q", oDataPack);
        }
        #endregion
        #endregion

        #region FORM309
        #region FROM309
        /// <summary>
        /// FORM309 list
        /// </summary>
        /// <param name="oDataPack"></param>
        /// <returns></returns>
        public DataSet GetLMSForm309List(DataPack oDataPack)
        {
            return OraDBHelper.ExecuteDataSet("LMSP_GET_FRM309LIST_Q", oDataPack);
        }
        #endregion

        #region FROM309_F1
        /// <summary>
        /// FORM309 list
        /// </summary>
        /// <param name="oDataPack"></param>
        /// <returns></returns>
        public DataSet GetLMSForm309F1List(DataPack oDataPack)
        {
            return OraDBHelper.ExecuteDataSet("LMSP_GET_FRM309F1LIST_Q", oDataPack);
        }
        #endregion

        #region FROM309_F2
        /// <summary>
        /// FORM309 list
        /// </summary>
        /// <param name="oDataPack"></param>
        /// <returns></returns>
        public DataSet GetLMSForm309F2List(DataPack oDataPack)
        {
            return OraDBHelper.ExecuteDataSet("LMSP_GET_FRM309F2LIST_Q", oDataPack);
        }
        #endregion


        #region FROM309_F3
        /// <summary>
        /// FORM309 list
        /// </summary>
        /// <param name="oDataPack"></param>
        /// <returns></returns>
        public DataSet GetLMSForm309F3List(DataPack oDataPack)
        {
            return OraDBHelper.ExecuteDataSet("LMSP_GET_FRM309F3LIST_Q", oDataPack);
        }
        #endregion

        #region FROM309_F4
        /// <summary>
        /// FORM309 list
        /// </summary>
        /// <param name="oDataPack"></param>
        /// <returns></returns>
        public DataSet GetLMSForm309F4List(DataPack oDataPack)
        {
            return OraDBHelper.ExecuteDataSet("LMSP_GET_FRM309F4LIST_Q", oDataPack);
        }
        #endregion
        #endregion
        
        #region FORM311
        /// <summary>
        /// SHIPMENT
        /// </summary>
        /// <param name="oDataPack"></param>
        /// <returns></returns>
        public DataSet GetLMSForm311_TOTAL(DataPack oDataPack)
        {
            return OraDBHelper.ExecuteDataSet("LMSP_GET_FRM311_TOTAL_Q", oDataPack);
        }



        /// <summary>
        /// SHIPMENT
        /// </summary>
        /// <param name="oDataPack"></param>
        /// <returns></returns>
        public DataSet GetLMSForm311F1List(DataPack oDataPack)
        {
            return OraDBHelper.ExecuteDataSet("LMSP_GET_FRM311F1_LIST_Q", oDataPack);
        }

        /// <summary>
        /// SHIPMENT
        /// </summary>
        /// <param name="oDataPack"></param>
        /// <returns></returns>
        public DataSet GetLMSForm311F2List(DataPack oDataPack)
        {
            return OraDBHelper.ExecuteDataSet("LMSP_GET_FRM311F2_LIST_Q", oDataPack);
        }

        /// <summary>
        /// SHIPMENT
        /// </summary>
        /// <param name="oDataPack"></param>
        /// <returns></returns>
        public DataSet GetLMSForm311F3List(DataPack oDataPack)
        {
            return OraDBHelper.ExecuteDataSet("LMSP_GET_FRM311F3_LIST_Q", oDataPack);
        }

        /// <summary>
        /// SHIPMENT
        /// </summary>
        /// <param name="oDataPack"></param>
        /// <returns></returns>
        public DataSet GetLMSForm311F4List(DataPack oDataPack)
        {
            return OraDBHelper.ExecuteDataSet("LMSP_GET_FRM311F4_LIST_Q", oDataPack);
        }



        #endregion
        #endregion



    }
}
