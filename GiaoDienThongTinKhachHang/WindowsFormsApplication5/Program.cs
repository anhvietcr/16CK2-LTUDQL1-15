using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security;
using System.Security.Principal;
using System.Threading;
namespace QuanLyNhaXe
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            GenericIdentity genericIdentity = new GenericIdentity("Ứng Dụng Quản Lý Vé Xe");
            GenericPrincipal genericPrincipal = new GenericPrincipal(genericIdentity, new string[] { "admin", "client", "guest" });
            Thread.CurrentPrincipal = genericPrincipal;
            Application.Run(new frmKhachhang());
        }
    }
}
