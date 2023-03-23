using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNPCApp
{
    static class Program
    {

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // 设置自启动
            //string path = Application.ExecutablePath;
            //RegistryKey rk = Registry.LocalMachine;
            //RegistryKey rk2 = rk.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run");
            //if (rk2.GetValue("CNPCApp") != null)
            //{
            //    rk2.SetValue("CNPCApp", path);
            //    rk2.Close();
            //    rk.Close();
            //}

            Application.Run(new MainFrom());


        }

    }
}
