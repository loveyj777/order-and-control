using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using FoodControlManager;

namespace MyCj2
{

    public partial class Cj2: UserControl
    {
        int a;
        showfood show = new showfood(0);
        dbhelper dbh = new dbhelper();
        public Cj2()
        {
            InitializeComponent();
        }

        private void Cj2_Load(object sender, EventArgs e)
        {
         pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
          
          
        }


        public void update_count(int count, string name)
        {

            try
            {
                dbh.open();
                StringBuilder sb = new StringBuilder(" update judgefood  ");
                sb.AppendFormat(" set [count]= {0}  ", count);
                sb.AppendFormat("  where foodname = '{0}'", name);
                SqlCommand comm = new SqlCommand(sb.ToString(), dbh.Conn);
                
                int a = comm.ExecuteNonQuery();
               
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

      

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

           
        }

        private void buttonplus_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonjian_Click(object sender, EventArgs e)
        {
            

        }

        private void ckbchose_CheckedChanged_1(object sender, EventArgs e)
        {

        }

     




        public void change_price(string name)
        {
          
            try
            {
                dbh.open();
                StringBuilder sb = new StringBuilder(" select price from Foodmenu     ");

                sb.AppendFormat("  where foodname= '{0}'", name);
                SqlCommand comm = new SqlCommand(sb.ToString(), dbh.Conn);

                lblprice.Text = Convert.ToString(comm.ExecuteScalar())+"￥";

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

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            bool a= Sunny.UI.UIMessageDialog.ShowAskDialog(show, "是否下架此菜品？");
            if (a == true)
            {
                delete(this.lblname.Text.Trim());
                delete1(this.lblname.Text.Trim());
            }
        }

        public void delete(string name)
        {

            try
            {
                dbh.open();
                StringBuilder sb = new StringBuilder(" delete Foodmenu  ");

                sb.AppendFormat("  where foodname = '{0}'", name);
                SqlCommand comm = new SqlCommand(sb.ToString(), dbh.Conn);
                int a = comm.ExecuteNonQuery();
                if (a > 0)
                {
                   Sunny.UI.UIMessageTip.ShowOk( "下架成功！");
                 
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


        public void delete1(string name)
        {

            try
            {
                dbh.open();
                StringBuilder sb = new StringBuilder(" delete judgefood  ");

                sb.AppendFormat("  where foodname = '{0}'", name);
                SqlCommand comm = new SqlCommand(sb.ToString(), dbh.Conn);
                int a = comm.ExecuteNonQuery();
                if (a > 0)
                {

                    
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
        public void update_price(string name,int price)
        {

            try
            {
                dbh.open();
                StringBuilder sb = new StringBuilder(" update Foodmenu  ");
                sb.AppendFormat(" set price ={0} ", price);
                sb.AppendFormat("  where foodname = '{0}'", name);
                SqlCommand comm = new SqlCommand(sb.ToString(), dbh.Conn);
                int a = comm.ExecuteNonQuery();
                if (a > 0)
                {

                    Sunny.UI.UIMessageTip.ShowOk("修改成功！");
                    panel1.Visible = false;
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

        private void 修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            panel1.Visible = true;
            uiTextBox1.Text = string.Empty;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (uiTextBox1.Text.Trim().Equals(string.Empty))
            {
                
                Sunny.UI.UIMessageDialog.ShowErrorDialog(show, "请输入大于零的整数");
            }
           else if (Convert.ToInt32(uiTextBox1.Text.Trim()) <= 0)
            {
                Sunny.UI.UIMessageDialog.ShowErrorDialog(show, "请输入大于零的整数");

            }
            else
            { 
              update_price(this.lblname.Text.Trim(), Convert.ToInt32(uiTextBox1.Text.Trim()));
                change_price(lblname.Text.Trim());
            }
           
            
     
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
             foodscontrol f1 = new foodscontrol();

            panel1.Visible = false;
        }
    }
}
