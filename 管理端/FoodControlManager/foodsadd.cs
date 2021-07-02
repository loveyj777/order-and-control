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

namespace FoodControlManager
{
    public partial class foodsadd : Form
    {
        dbhelper dbh = new dbhelper();
        public foodsadd()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void uiLabel2_Click(object sender, EventArgs e)
        {

        }

        private void uiLabel5_Click(object sender, EventArgs e)
        {

        }

        private void uiPanel1_Click(object sender, EventArgs e)
        {

        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
          
            OpenFileDialog openFi = new OpenFileDialog();
            openFi.Filter = "图像文件(JPeg, Gif, Bmp, etc.)|*.jpg;*.jpeg;*.gif;*.bmp;*.tif; *.tiff; *.png| JPeg 图像文件(*.jpg;*.jpeg)"
              + "|*.jpg;*.jpeg |GIF 图像文件(*.gif)|*.gif |BMP图像文件(*.bmp)|*.bmp|Tiff图像文件(*.tif;*.tiff)|*.tif;*.tiff|Png图像文件(*.png)"
              + "| *.png |所有文件(*.*)|*.*";
            if (openFi.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFi.FileName;
                txtfile.Text = openFi.FileName;
            }

        }

        private void foodsadd_Load(object sender, EventArgs e)
        {

        }


        public void insert_food(string name, int price, int type, string filee) 
        {


            try
            {
                dbh.open();

                StringBuilder sb = new StringBuilder("insert Foodmenu(foodname,price,foodtypeid,filee) values  ");
                sb.AppendFormat(" ( '{0}' ,",name);
                sb.AppendFormat(" {0} ,",price);
                sb.AppendFormat("  {0} ,", type);
                sb.AppendFormat("  '{0}' )",filee);
                SqlCommand comm = new SqlCommand(sb.ToString(), dbh.Conn);
                int isr = comm.ExecuteNonQuery();


                if (isr>0)
                {
                    Sunny.UI.UIMessageTip.Show("添加成功！", Sunny.UI.TipStyle.Green);
                    txtfile.Text = string.Empty;
                    txtfname.Text = string.Empty;
                    txtprice.Text = "0";
                    pictureBox1.Image = null;
                    combotype.SelectedIndex = -1;
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

        public void insert_food2(string name)
        {


            try
            {
                dbh.open();

                StringBuilder sb = new StringBuilder(" insert judgefood(foodname)  ");
                sb.AppendFormat(" values ( '{0}' )", name);
              
                SqlCommand comm = new SqlCommand(sb.ToString(), dbh.Conn);
                int isr = comm.ExecuteNonQuery();

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

        private void uiButton2_Click(object sender, EventArgs e)
        {
            if (txtfname.Text.Equals(string.Empty))
            {
              
                Sunny.UI.UIMessageDialog.ShowErrorDialog(this, "请填写菜品名称！");

            }
          else if (Convert.ToInt32(txtprice.Text) <= 0)
            {
               
                Sunny.UI.UIMessageDialog.ShowErrorDialog(this, "请填写菜品价格为大于零的数！");
            }
        else if (combotype.SelectedIndex == -1)
            {

              
                Sunny.UI.UIMessageDialog.ShowErrorDialog(this, "请选择菜品类型！");

            }
          else    if (txtfile.Text.Equals(string.Empty))
            {

              
                Sunny.UI.UIMessageDialog.ShowErrorDialog(this, "请选择菜品图片！");

            }
            else
            {
                curre_name(txtfname.Text);
                
            }
        }

        private void uiButton3_Click(object sender, EventArgs e)
        {
            Sunny.UI.UIMessageTip.Show("清空成功！", Sunny.UI.TipStyle.Green);
            txtfile.Text = string.Empty;
            txtfname.Text = string.Empty;
            pictureBox1.Image = null;
            txtprice.Text = "0";
            combotype.SelectedIndex = -1;
        }
        public void curre_name(string user)
        {
            try
            {
                dbh.open();

                StringBuilder sb = new StringBuilder("  select foodname from Foodmenu where foodname =  ");
                sb.AppendFormat("  '{0}' ", user);

                SqlCommand comm = new SqlCommand(sb.ToString(), dbh.Conn);
                string a = Convert.ToString(comm.ExecuteScalar());

                if (a == txtfname.Text)
                {
                    Sunny.UI.UIMessageTip.ShowError("菜品已存在！");

                }
                else
                {
                    insert_food2(txtfname.Text.Trim());
                    insert_food(txtfname.Text.Trim(), Convert.ToInt32(txtprice.Text.Trim()), Convert.ToInt32(combotype.SelectedIndex + 1), txtfile.Text.Trim());
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
