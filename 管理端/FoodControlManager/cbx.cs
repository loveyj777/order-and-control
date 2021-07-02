using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodControlManager
{
    public partial class cbx : Form
    {
        public static string name;
        public cbx()
        {
            InitializeComponent();
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            
            if (uiComboBox1.SelectedIndex == -1)
            {
                Sunny.UI.UIMessageDialog.ShowErrorDialog(this, "请选择职务！");
            }
            else 
            {
                
                deleteuser de = (deleteuser)this.Owner;
              de.update(uiComboBox1.SelectedIndex+2,name);
            de.query();
            this.Close();
            
            }
          
        }

        private void cbx_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.Text = string.Empty;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
