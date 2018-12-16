using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using LTUDQL1_BAOMAT;

namespace LTUDQL1_ADONET
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            GenericPrincipal principal = Thread.CurrentPrincipal as GenericPrincipal;
            if (principal == null)
            {
                Close();
                return;
            }
            //if (principal.IsInRole("x"))
            //{
            //    MessageBox.Show("Bạn không có quyền sử dụng chức năng này.");
            //    Close();
            //    return;
            //}
            MessageBox.Show("Chào mừng " +principal.Identity.Name + ".");
            InitializeComponent();
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            User user = new User()
            {
                UserName = txtUserName.Text,
                HashPassword = User.MD5Hash(txtPassword.Text)
            };

            if (user.Authenticate())
            {
                string role = "";
                foreach (var row in user.Roles)
                {
                    role += row.RoleName + "  ";
                }
                GenericIdentity genericIdentity = new GenericIdentity("myapp");
                GenericPrincipal genericPrincipal = new GenericPrincipal(genericIdentity, new string[] { role });
                Thread.CurrentPrincipal = genericPrincipal;     
                FrmKhachHang k = new FrmKhachHang();
                k.Show();
                //MessageBox.Show("Đăng nhập thành công.\n" +
                  //  "UserID là "+user.UserName);
            }
            else {
                MessageBox.Show("Đăng nhập thất bại.\n");
            }
        }
    }
}
