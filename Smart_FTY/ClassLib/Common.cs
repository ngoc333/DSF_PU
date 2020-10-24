using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Drawing;

namespace IPEX_Monitor.ClassLib
{
    public class WinAPI
    {
        //flag Values

        //왼쪽에서 오른쪽
        public const int AW_HOR_POSITIVE = 0x1;
        //오른쪽에서 왼쪽
        public const int AW_HOR_NEGATIVE = 0x2;
        //위에서 아래
        public const int AW_VER_POSITIVE = 0x4;
        //아래에서 위로
        public const int AW_VER_NEGATIVE = 0x08;
        //안쪽에서 접히면서(무너지면서)
        public const int AW_CENTER = 0x10;
        //숨김
        public const int AW_HIDE = 0x10000;
        //펼쳐지는 효과
        public const int AW_ACTIVATE = 0x20000;
        //효과 설정
        public const int AW_SLIDE = 0x40000;
        //흐려지는 효과
        public const int AW_BLEND = 0x80000;


        [DllImport("user32.dll")]
        public static extern int AnimateWindow(IntPtr hwand, int dwTime, int dwFlags);

        //internal static int getSlidType(string p)
        //{
        //    throw new NotImplementedException();
        //}

        public static int getSlidType(string direction)
        {
            int nFlags = 1;

            switch (direction)
            {
                case "1":
                    nFlags = WinAPI.AW_ACTIVATE | WinAPI.AW_HOR_POSITIVE;
                    break;
                case "2":
                    nFlags = WinAPI.AW_ACTIVATE | WinAPI.AW_HOR_NEGATIVE;
                    break;
                case "3":
                    nFlags = WinAPI.AW_ACTIVATE | WinAPI.AW_VER_POSITIVE;
                    break;
                case "4":
                    nFlags = WinAPI.AW_ACTIVATE | WinAPI.AW_VER_NEGATIVE;
                    break;
                case "5":
                    nFlags = WinAPI.AW_ACTIVATE | WinAPI.AW_CENTER;
                    break;
                default:
                    nFlags = WinAPI.AW_ACTIVATE | WinAPI.AW_HOR_POSITIVE;
                    
                    break;
            }

            return nFlags;
        }

    }   


    class Common
    {

        public static int getSlidType(string direction)
        {
            int nFlags = 1;

            switch (direction)
            {
                case "1":
                    nFlags = WinAPI.AW_ACTIVATE | WinAPI.AW_HOR_POSITIVE;
                    break;
                case "2":
                    nFlags = WinAPI.AW_ACTIVATE | WinAPI.AW_HOR_NEGATIVE;
                    break;
                case "3":
                    nFlags = WinAPI.AW_ACTIVATE | WinAPI.AW_VER_POSITIVE;
                    break;
                case "4":
                    nFlags = WinAPI.AW_ACTIVATE | WinAPI.AW_VER_NEGATIVE;
                    break;
                default:
                    nFlags = WinAPI.AW_ACTIVATE | WinAPI.AW_HOR_POSITIVE;
                    break;
            }

            return nFlags;
        }

        /// <summary>
        /// 현재시간을 HH 형식으로 가져오는 함수
        /// </summary>
        /// <returns>HH</returns>
        public string getHour()
        {
            string returnHour = string.Empty;
            int hour = Convert.ToInt32(DateTime.Now.ToString("HH"));
            if (hour < 10)
            {
                returnHour = "0" + hour.ToString();
            }
            else
            {
                returnHour = hour.ToString();
            }

            return returnHour ;
        }

        /// <summary>
        /// YYYYMMDD 형식으로 오늘날짜값 반환
        /// </summary>
        /// <returns>YYYYMMDD</returns>
        public string getDateYYYYMMDD()
        {
            return DateTime.Now.ToString("YYYYMMDD");
        }


        /// <summary>
        /// 영문데이트
        /// </summary>
        /// <returns></returns>
        public string getDateEng()
        {
            CultureInfo culture = CultureInfo.CreateSpecificCulture("en-US");
            return String.Format(culture, "{0:dd.MMM}", DateTime.Now);            
            

        }

        public string getDateEng(int addDay)
        {
            CultureInfo culture = CultureInfo.CreateSpecificCulture("en-US");
            return String.Format(culture, "{0:dd.MMMM}", DateTime.Now.AddDays(addDay));            
        }

        public string getDateEngShort(int addDay)
        {
            CultureInfo culture = CultureInfo.CreateSpecificCulture("en-US");
            return String.Format(culture, "{0:dd.MMM}", DateTime.Now.AddDays(addDay));
        }

        /// <summary>
        /// 날짜값 계산. - Minus
        /// </summary>
        /// <param name="addDay"></param>
        /// <returns></returns>
        public string getAddDayYYYYMMDD(int addDay)
        {
            DateTime tmpDt = DateTime.Now.AddDays(addDay);
            if (tmpDt.DayOfWeek == DayOfWeek.Sunday)
            {
                tmpDt = DateTime.Now.AddDays(addDay - 1);
            }

            return tmpDt.ToString("yyyyMMdd");
        }


        /// <summary>
        /// 날짜값 계산. - Flag
        /// </summary>
        /// <param name="addDay"></param>
        /// <param name="div">+ or -</param>
        /// <returns></returns>
        public string getAddDayYYYYMMDD(int addDay, string div)
        {
            /*
            DateTime tmpDt = DateTime.Now.AddDays(addDay);
            if (tmpDt.DayOfWeek == DayOfWeek.Sunday)
            {
                tmpDt = DateTime.Now.AddDays(addDay - 1);
            }*/

            DateTime rdt = DateTime.Now.AddDays(addDay);

            if (div == "+")
            {
                for (int i = 0; i < addDay; i++)
                {
                    DateTime tmpDt = DateTime.Now.AddDays(i + 1);
                    if (tmpDt.DayOfWeek == DayOfWeek.Sunday)
                    {
                        rdt = DateTime.Now.AddDays(addDay + 1);
                        break;
                    }
                }
            }

            if (div == "-")
            {
                for (int i = 0; i > addDay; i--)
                {
                    DateTime tmpDt = DateTime.Now.AddDays(i - 1);
                    if (tmpDt.DayOfWeek == DayOfWeek.Sunday)
                    {

                        rdt = DateTime.Now.AddDays(addDay - 1);
                        break;

                    }
                }
            }

            return rdt.ToString("yyyyMMdd");
        }


        /// <summary>
        /// 시간가져오기
        /// </summary>
        /// <returns></returns>
        public string getTime()
        {
            //CultureInfo culture = CultureInfo.CreateSpecificCulture("en-US");
            //return String.Format(culture, "{0:dd.MMMM}", DateTime.Now.AddDays(addDay));            

            return DateTime.Now.ToString("hh:mm");// --String.Format(@"{0:hh\:mm", DateTime.Now);
        }

        /// <summary>
        /// 1h~8h 구간값 가져오기.
        /// </summary>
        /// <returns></returns>
        public string getHH()
        {
            string returnStr = string.Empty; 

            int iHour = DateTime.Now.Hour;
            int iMin = DateTime.Now.Minute;

            //07시이전은 01로 간주.
            if (iHour < 7)
            {
                returnStr = "01";
            }

            //17시이후는 08로 간주.
            if (iHour > 16)
            {
                returnStr = "08";
            }

            switch (iHour)
            {
                case (7):
                    if (iMin >= 30)
                    {
                        returnStr = "01";
                    }
                    else
                    {
                        returnStr = "01";
                    }
                    break;

                case (8):
                    if (iMin >= 30)
                    {
                        returnStr = "02";
                    }
                    else
                    {
                        returnStr = "01";
                    }
                    break;

                case (9):
                    if (iMin >= 30)
                    {
                        returnStr = "03";
                    }
                    else
                    {
                        returnStr = "02";
                    }
                    break;

                case (10):
                    if (iMin >= 30)
                    {
                        returnStr = "04";
                    }
                    else
                    {
                        returnStr = "03";
                    }
                    break;
                case (11):
                    if (iMin >= 30)
                    {
                        returnStr = "05";
                    }
                    else
                    {
                        returnStr = "04";
                    }
                    break;
                case (12):
                    if (iMin >= 30)
                    {
                        returnStr = "06";
                    }
                    else
                    {
                        returnStr = "05";
                    }
                    break;
                case (13):
                    if (iMin >= 30)
                    {
                        returnStr = "07";
                    }
                    else
                    {
                        returnStr = "06";
                    }
                    break;
                case (14):
                    if (iMin >= 30)
                    {
                        returnStr = "08";
                    }
                    else
                    {
                        returnStr = "07";
                    }
                    break;
                case (15):
                    if (iMin >= 30)
                    {
                        returnStr = "08";
                    }
                    else
                    {
                        returnStr = "07";
                    }
                    break;
                case (16):
                    if (iMin >= 30)
                    {
                        returnStr = "08";
                    }
                    else
                    {
                        returnStr = "08";
                    }
                    break;
            }

            return returnStr;

        }


        /// <summary>
        /// 윈도우로그인계정가져오기.
        /// </summary>
        /// <returns></returns>
        public string getWindowAccount()
        {
            return System.Security.Principal.WindowsIdentity.GetCurrent().Name;  
        }


        /// <summary>
        /// KPI  BTS Color 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public Color[] getMIColor(double value)
        {
            Color[] tmpColor = new Color[2];

            if (value < 60)
            {
                tmpColor[0] = Color.Red;
                tmpColor[1] = Color.White;
            }

            if (value >= 60 && value <= 69)
            {
                tmpColor[0] = Color.Yellow;
                tmpColor[1] = Color.Black;
            }

            if (value >= 70 && value <= 85)
            {
                tmpColor[0] = Color.Brown;
                tmpColor[1] = Color.White;
            }

            if (value >= 85 && value <= 95)
            {
                tmpColor[0] = Color.LightGray;
                tmpColor[1] = Color.Black;
            }


            if (value >= 95)
            {
                tmpColor[0] = Color.Orange;
                tmpColor[1] = Color.Black;
            }

            return tmpColor;
        }



        /// <summary>
        /// KPI  BTS Color 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public Color[] getBTSColor(double value)
        {
            Color[] tmpColor = new Color[2];

            if (value < 50)
            {
                tmpColor[0] = Color.Black;
                tmpColor[1] = Color.White;
            }

            if(value >= 50 && value <= 60) 
            {
                tmpColor[0] = Color.Red;
                tmpColor[1] = Color.White;
            } 

            if (value >= 60 && value <= 80 )
            {
                tmpColor[0] = Color.Yellow;
                tmpColor[1] = Color.Black;
            }

            if (value > 80)
            {
                tmpColor[0] = Color.Green;
                tmpColor[1] = Color.Black;
            }

            return tmpColor;
        }


        /// <summary>
        /// RR / POD / POH / TPA Color
        /// </summary>
        /// <param name="target"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public Color[] getRR_POD_POH_TPA_Color(double target, double value) 
        {
            Color[] tmpColor = new Color[2];
            double compareValue = target * 0.9;

            if (compareValue > value)
            {
                tmpColor[0] = Color.Red;
                tmpColor[1] = Color.White;
                return tmpColor;
            }

            if (compareValue <= value && target >= value)
            {
                tmpColor[0] = Color.Yellow;
                tmpColor[1] = Color.Black;
                return tmpColor;
            }

            if (target > value)
            {
                tmpColor[0] = Color.Green;
                tmpColor[1] = Color.Black;
                return tmpColor;
            }

            tmpColor[0] = Color.White;
            tmpColor[1] = Color.Black;

            return tmpColor;

        }

    }
}
