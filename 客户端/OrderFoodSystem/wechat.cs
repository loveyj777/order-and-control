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
    public partial class wechat : Form
    {
        public static bool issucces;
        public static DateTime time;
        public static double price;
        public static int id;
        public static string vid ="普通会员";
        public wechat()
        {
            InitializeComponent();
        }

        private void wechat_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.timer1.Enabled = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    
        private void timer1_Tick(object sender, EventArgs e)
        {
          
          
            this.Close();
           
            finish_order(id,DateTime.Now,"微信支付",price,time,vid);
            update_state(id);
        }

        public void finish_order(int id, DateTime end, string pay, double price, DateTime start, string vid)
        {
            dbhelper dbh = new dbhelper();
            try
            {
                dbh.open();

                StringBuilder sb = new StringBuilder(" insert finsh(tableid,finishtime,paytype,price,starttime,viptype) ");
                sb.AppendFormat(" values ( {0} , '{1}' , '{2}' , {3} , '{4}' , '{5}' )", id, end, pay, price, start, vid);
                SqlCommand comm = new SqlCommand(sb.ToString(), dbh.Conn);
                int a = comm.ExecuteNonQuery();

                if (a > 0)
                {
                Sunny.UI.UIMessageDialog.ShowSuccessDialog(this,"订单已结算!");
                    issucces = true;
                   clearlove(id);
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
        public void clearlove(int id)
        {
            dbhelper dbh = new dbhelper();
            try
            {
                dbh.open();

                StringBuilder sb = new StringBuilder(" delete orderfood ");
                sb.AppendFormat(" where id ={0} ", id);
                SqlCommand comm = new SqlCommand(sb.ToString(), dbh.Conn);
                comm.ExecuteNonQuery();
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
        public void update_state(int id)
        {
            dbhelper dbh = new dbhelper();
            try
            {
                dbh.open();

                StringBuilder sb = new StringBuilder(" update tablee set state = 0  ");
                sb.AppendFormat(" where tableid = {0}", id);
                SqlCommand comm = new SqlCommand(sb.ToString(), dbh.Conn);
                comm.ExecuteNonQuery();


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
