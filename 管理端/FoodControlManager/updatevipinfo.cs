using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodControlManager
{
    public partial class updatevipinfo : Form
    {
        Regex r = new Regex("^1(3([0-35-9]\\d|4[1-8])|4[14-9]\\d|5([0125689]\\d|7[1-79])|66\\d|7[2-35-8]\\d|8\\d{2}|9[89]\\d)\\d{7}$");
        public static int index;
        public static string name;
        public static string phone;
        public updatevipinfo()
        {
            InitializeComponent();
        }

        private void updatevipinfo_Load(object sender, EventArgs e)
        {
            uiComboBox1.SelectedIndex = index;
            uiTextBox1.Text = name;
            uiTextBox1.Enabled = false;
            uiTextBox2.Text = phone;
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            bool b = r.IsMatch(uiTextBox2.Text.Trim());
            if (uiTextBox2.Text.Equals(string.Empty))
            {

                Sunny.UI.UIMessageDialog.ShowErrorDialog(this, "电话号码不能为空！");
            }
            else if (b == false)
            {
                Sunny.UI.UIMessageDialog.ShowErrorDialog(this, "请输入正确的号码格式！");

            }
            else if (uiComboBox1.SelectedIndex == -1)
            {
                Sunny.UI.UIMessageDialog.ShowErrorDialog(this, "请选择会员等级！");
            }
            else
            { 
            vipupdate vip = (vipupdate)this.Owner;
            vip.update(uiTextBox2.Text.Trim(), uiComboBox1.SelectedIndex + 1, uiTextBox1.Text.Trim());
            vip.query();
            this.Close();
            }
         
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void uiTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
