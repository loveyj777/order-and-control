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

namespace OrderFoodSystem
{
    public partial class payform : Form
    {
        public static int id;
        dbhelper dbh = new dbhelper();
        string price;
        public payform()
        {
            InitializeComponent();
        }

        private void payform_Load(object sender, EventArgs e)
        {

            closeorder closeorder = (closeorder)this.Owner;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.None;
            wechat.issucces = false;
            alipay.issucces = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public void return_price(int id)
        {
            try
            {
                dbh.open();

                StringBuilder sb = new StringBuilder("   select SUM(price*[count]) from orderfood where id = ");
                sb.AppendFormat(" {0} ", id);
                SqlCommand comm = new SqlCommand(sb.ToString(), dbh.Conn);
                price = Convert.ToString(comm.ExecuteScalar());
                if (price == null)
                {


                }
                else
                {

                  label3.Text = price + "￥";

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
        public void return_price1(int id)
        {
            try
            {
                dbh.open();

                StringBuilder sb = new StringBuilder(" select SUM(price*[count]) from orderfood where id = ");
                sb.AppendFormat(" {0} ", id);
                SqlCommand comm = new SqlCommand(sb.ToString(), dbh.Conn);
                price = Convert.ToString(comm.ExecuteScalar());
                if (price == null)
                {


                }
                else
                {

                    label1.Text = price + "￥";

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

        private void button1_Click(object sender, EventArgs e)
        {
            pay_type(button1.Text.Trim(),id);
            wechat we = new wechat();
          
            we.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pay_type(button2.Text.Trim(),id);
            alipay al = new alipay();
            al.Show();
        }


        public void pay_type(string pay,int id)
        {
            try
            {
                dbh.open();

                StringBuilder sb = new StringBuilder(" update orderfood ");
                sb.AppendFormat(" set pay='{0}' where id = {1} ", pay,id);
                SqlCommand comm = new SqlCommand(sb.ToString(), dbh.Conn);
                price = Convert.ToString(comm.ExecuteScalar());
                if (price == null)
                {


                }
                else
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

        private void button3_Click(object sender, EventArgs e)
        {
            pay_type(button3.Text.Trim(),id);
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (wechat.issucces == true)
            {
                this.Close();
            }
            if (alipay.issucces == true)
            {
                this.Close();
            }

        }
    } 
}
