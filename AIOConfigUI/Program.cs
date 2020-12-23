using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Diagnostics;

namespace AIOConfigUI
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {

            string processName = Process.GetCurrentProcess().ProcessName;
            Process[] ps = Process.GetProcessesByName(processName);
            //如果该数组长度大于1，说明多次运行
            if (ps.Length > 1)
            {
                Sunny.UI.UIMessageBox.Show("程序已运行，不能再次打开！");
                Environment.Exit(1);
            }

            ps = Process.GetProcessesByName("Server");
            if (ps.Length > 0)
            {
                Sunny.UI.UIMessageBox.Show("请关闭服务端程序，再修改！");
                Application.Exit();
            }
            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new AIOConfigUI());
            }
            
        }
    }
}
