using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using LTUDQL1_BAOMAT;
namespace LTUDQL1_ADONET
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
            //User user = new User()
            //{
            //    UserName = "user2",
            //    HashPassword = User.MD5Hash("123456"),
            //    Email = "user2@mail.com"
            //};
            //user.CreateUser();
            GenericIdentity genericIdentity = new GenericIdentity("myapp");          
            GenericPrincipal genericPrincipal = new GenericPrincipal(genericIdentity, new string[] { "admin","client","guest" });
            Thread.CurrentPrincipal = genericPrincipal;     

            Application.Run(new FrmLogin());
        }
    }
}
