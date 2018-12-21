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
using Security;

namespace QuanLyNhaXe
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
            if (principal.IsInRole("x"))
            {
                MessageBox.Show("Bạn không có quyền sử dụng chức năng này.");
                Close();
                return;
            }
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
                GenericIdentity genericIdentity = new GenericIdentity("Ứng Dụng Quản Lý Vé Xe");
                GenericPrincipal genericPrincipal = new GenericPrincipal(genericIdentity, new string[] { role });
                Thread.CurrentPrincipal = genericPrincipal;     

                frmDashboard frm = new frmDashboard();
                frm.Show();
                //MessageBox.Show("Đăng nhập thành công.\n" +
                  //  "UserID là "+user.UserName);
            }
            else {
                MessageBox.Show("Đăng nhập thất bại.\n");
            }
        }
    }
}
