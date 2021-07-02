using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Sunny;

namespace FoodControlManager
{
    public partial class login : Form
    {
       
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {

            this.FormBorderStyle = FormBorderStyle.None;
            this.DoubleBuffered = true;

        }
        private void uiTitlePanel1_MouseDown(object sender, MouseEventArgs e)
        {

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]

        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void btncancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (uiTextBox1.Text.Equals(string.Empty))
            {
                Sunny.UI.UIMessageDialog.ShowErrorDialog(this, "请输入账户！");

            }
            else if (uiTextBox2.Text.Equals(string.Empty))
            {
                Sunny.UI.UIMessageDialog.ShowErrorDialog(this, "请输入密码！");

            }
            else
            {
                llogin(uiTextBox1.Text.Trim(), uiTextBox2.Text.Trim());
            }


        }
        public void llogin(string name, string pwd)
        {
            dbhelper dbh = new dbhelper();
          //  SqlDataReader reader = null;
            try
            {
                dbh.open();

                StringBuilder sb = new StringBuilder(" select type from adnmin  ");
                sb.AppendFormat(" where adnmin.admin='{0}' and  pwd='{1}' ", name, pwd);
                SqlCommand comm = new SqlCommand(sb.ToString(), dbh.Conn);
                string id = Convert.ToString(comm.ExecuteScalar());

                    if (id.Equals(string.Empty))
                    {
                        Sunny.UI.UIMessageDialog.ShowErrorDialog(this, "账号或密码错误！");
  
                    }
                    else
                    {
                          Form1 f1 = new Form1(uiTextBox1.Text, Convert.ToInt32(id));
                        Sunny.UI.UIMessageTip.Show("登入成功！", Sunny.UI.TipStyle.Green);
                        f1.Show();
                     
                        this.Hide();
                    }
            }
            catch (Exception e)
            {


                MessageBox.Show(e.ToString());
            }
            finally
            {
               
                dbh.close();

            }

        }
    }
}

