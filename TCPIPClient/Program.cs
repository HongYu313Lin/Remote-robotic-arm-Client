using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TCPIPClient
{
    static class Program
    {
        /// <summary>
        /// 作者:林紘宇
        /// 正在國立高雄科技大學工程科技研究所攻讀博士學位
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
