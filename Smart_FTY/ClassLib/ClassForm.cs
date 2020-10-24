using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using System.Media;
using System.ComponentModel;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data;
using System.Diagnostics;
using System.Drawing.Drawing2D;

namespace IPEX_Monitor.ClassLib
{
	/// <summary>
	/// ClassForm:  메뉴의 폼 생성을 위한 Form에 대한 정보
	/// </summary>
    public class ClassForm
    {
        public ClassForm()
        {
            //
            // TODO: 여기에 생성자 논리를 추가합니다.
            //
        }
        /// <summary>
        /// 해당 폼의 Type 정보 Return
        /// </summary>
        /// <param name="arg_FormName"> 폼의 네임스페이스.이름</param>
        public Type TypeForm(string arg_FormName)
        {

            Type tp = Type.GetType(arg_FormName);
            return tp;

        }
    }

    
}
