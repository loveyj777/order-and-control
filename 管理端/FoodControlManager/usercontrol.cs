using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace FoodControlManager
{
    public partial class usercontrol : Form
    {
        dbhelper dbh = new dbhelper();
        Regex r = new Regex("^1(3([0-35-9]\\d|4[1-8])|4[14-9]\\d|5([0125689]\\d|7[1-79])|66\\d|7[2-35-8]\\d|8\\d{2}|9[89]\\d)\\d{7}$");
           
        public usercontrol()
        {
            InitializeComponent();
        }

        private void uiGroupBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void uiTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void uiGroupBox1_Click(object sender, EventArgs e)
        {

        }

        public void addadmin(string user,string pwd,int id)
        {
            try
            {
                dbh.open();

                StringBuilder sb = new StringBuilder(" insert adnmin([admin],pwd,type) values  ");
                sb.AppendFormat(" ( '{0}' ,", user);
                sb.AppendFormat(" '{0}' ,", pwd);
                sb.AppendFormat("  {0} )", id);
                SqlCommand comm = new SqlCommand(sb.ToString(), dbh.Conn);
                int isr = comm.ExecuteNonQuery();


                if (isr > 0)
                {
                    Sunny.UI.UIMessageTip.ShowOk("添加成功！");
                    uiTextBox1.Text = string.Empty;
                    uiTextBox2.Text = string.Empty;
                    uiTextBox3.Text = string.Empty;
                    uiComboBox2.SelectedIndex = -1;
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
        public void curre_addadmin(string user)
        {
            try
            {
                dbh.open();

                StringBuilder sb = new StringBuilder(" select [admin] from adnmin where [admin] =  ");
                sb.AppendFormat(" '{0}'", user);
              
                SqlCommand comm = new SqlCommand(sb.ToString(), dbh.Conn);
                string a =Convert.ToString( comm.ExecuteScalar() );

                if (a == uiTextBox1.Text)
                {
                    Sunny.UI.UIMessageTip.ShowError("用户已存在！");

                }
                else
                {
                    addadmin(uiTextBox1.Text.Trim(), uiTextBox2.Text.Trim(),uiComboBox2.SelectedIndex+2);
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
        private void uiButton1_Click(object sender, EventArgs e)
        {
            if (uiTextBox1.Text.Equals(string.Empty))
            {
                Sunny.UI.UIMessageDialog.ShowErrorDialog(this, "请填写要添加的账户！");

            }
            else if (uiTextBox2.Text.Equals(string.Empty))
            {
                Sunny.UI.UIMessageDialog.ShowErrorDialog(this, "请填写账户密码！");

            }
            else if (uiTextBox3.Text.Equals(string.Empty))
            {
                Sunny.UI.UIMessageDialog.ShowErrorDialog(this, "请确认密码！");
                ;
            }
            else if (uiTextBox2.Text != uiTextBox3.Text)
            {
                Sunny.UI.UIMessageDialog.ShowErrorDialog(this, "两次输入密码不相同！");

            }
            else if (uiComboBox2.SelectedIndex == -1)
            {

                Sunny.UI.UIMessageDialog.ShowErrorDialog(this, "请选择职务！");
            }
            else
            {
                curre_addadmin(uiTextBox1.Text.Trim());

            }
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            Sunny.UI.UIMessageTip.ShowOk("已清空！");
            uiTextBox1.Text = string.Empty;
            uiTextBox2.Text = string.Empty;
            uiTextBox3.Text = string.Empty;
            uiComboBox2.SelectedIndex = -1;
        }

        private void usercontrol_Load(object sender, EventArgs e)
        {

        }

        public void vipinfo(string pwd, string user, int id)
        {
            try
            {
                dbh.open();

                StringBuilder sb = new StringBuilder(" insert vipinfo(vipid,vippname,viptypeid) values ");
                sb.AppendFormat(" ( '{0}' ,", pwd);
                sb.AppendFormat("  '{0}' ,", user);
                sb.AppendFormat(" {0} )", id);
                SqlCommand comm = new SqlCommand(sb.ToString(), dbh.Conn);
                int isr = comm.ExecuteNonQuery();


                if (isr > 0)
                {
                    Sunny.UI.UIMessageTip.ShowOk("添加成功！");
                  
                    uiTextBox5.Text = string.Empty;
                    uiTextBox4.Text = string.Empty;
                    uiComboBox1.SelectedIndex = -1;
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

        private void uiButton3_Click(object sender, EventArgs e)
        {
           bool b= r.IsMatch(uiTextBox5.Text.Trim());
          
            if (uiTextBox4.Text.Equals(string.Empty))
            {
                Sunny.UI.UIMessageDialog.ShowErrorDialog(this, "请输入姓名！");
              
            }
            else if (uiTextBox5.Text.Equals(string.Empty))
            {
                Sunny.UI.UIMessageDialog.ShowErrorDialog(this, "请输入电话号码！");
             
            }
            else if (b==false)
            {
                Sunny.UI.UIMessageDialog.ShowErrorDialog(this, "请输入正确电话号码格式！");
             
            }
            else if (Convert.ToInt32(uiComboBox1.SelectedIndex) == -1)
            {
                Sunny.UI.UIMessageDialog.ShowErrorDialog(this, "请选这会员类型！");
              ;
            }
            else
            {
                curre_name(uiTextBox5.Text);
            }
        }

        private void uiButton4_Click(object sender, EventArgs e)
        {
            Sunny.UI.UIMessageTip.ShowOk("已清空！");
            uiTextBox5.Text = string.Empty;
            uiTextBox4.Text= string.Empty;
            uiComboBox1.SelectedIndex = -1;
        }
        public void curre_name(string user)
        {
            try
            {
                dbh.open();

                StringBuilder sb = new StringBuilder(" select vippname from vipinfo where vippname =  ");
                sb.AppendFormat("  '{0}' ", user);

                SqlCommand comm = new SqlCommand(sb.ToString(), dbh.Conn);
                string a = Convert.ToString(comm.ExecuteScalar());

               
                if (a.Equals(uiTextBox5.Text))
                {
                    Sunny.UI.UIMessageTip.ShowError("用户已存在！");

                }
                else
                {
                    vipinfo(uiTextBox4.Text.Trim(), uiTextBox5.Text.Trim(), uiComboBox1.SelectedIndex + 1);
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

