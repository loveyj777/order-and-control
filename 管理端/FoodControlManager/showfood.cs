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

namespace FoodControlManager
{
    public partial class showfood : Form
    {

     
        string pay = null;
        int dd;
        string price;
        string time;
        dbhelper dbh = new dbhelper();
        public showfood(int idd)
        {
            InitializeComponent();
            dd = idd;
        }

        private void showfood_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.Text = string.Empty;
            this.FormBorderStyle = FormBorderStyle.None;
            return_price(dd);
            label2.Text = price+"￥";
            label3.Visible = false;
            label4.Visible = false;
            return_vip(dd);
        
        }
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]

        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void uiTitlePanel1_MouseDown(object sender, MouseEventArgs e)
        {
             ReleaseCapture();
             SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void uiImageButton2_Click(object sender, EventArgs e)
        {
 
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void return_price(int tid)
        {
            SqlDataReader reader = null;
            try
            {
                dbh.open();

                StringBuilder sb = new StringBuilder("  select SUM(price*[count]) AS a ,starttime from orderfood group by starttime,id having orderfood.id= ");
                sb.AppendFormat(" {0} ", tid);
                SqlCommand comm = new SqlCommand(sb.ToString(), dbh.Conn);
                reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    price = reader["a"].ToString();
                    time = reader["starttime"].ToString();
                
                    
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

        public void return_vip(int id)
        {
            SqlDataReader reader = null;
            try
            {
                dbh.open();

                StringBuilder sb = new StringBuilder(" select Viptype.vipname,discount,pay from orderfood inner join Viptype on orderfood.viptype=Viptype.id group by vipname,discount,pay,orderfood.id having orderfood.id =");
                sb.AppendFormat(" {0} ", id);
                SqlCommand comm = new SqlCommand(sb.ToString(), dbh.Conn);
                reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    label3.Visible = true;
                    label4.Visible = true;
                        label3.Text = reader["vipname"].ToString();
                        label2.Text = Convert.ToString(Convert.ToInt32(price) * Convert.ToDouble(reader["discount"].ToString())) + "￥";
                    price = Convert.ToString(Convert.ToInt32(price) * Convert.ToDouble(reader["discount"].ToString()));
                        pay = reader["pay"].ToString();
                    

                  
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
          
             if (pay == null)
                        {

                            Sunny.UI.UIMessageDialog.ShowErrorDialog(this, "请从客户端选择支付方式");
                            uiButton1.Enabled = false;
                        }
            else if (pay.Equals(string.Empty))
            {
               
                Sunny.UI.UIMessageDialog.ShowErrorDialog(this, "请从客户端选择支付方式");
            uiButton1.Enabled = false;
            }
            else
              
            {
                finish_order(dd, Convert.ToDateTime(DateTime.Now), pay, Convert.ToDouble(price), Convert.ToDateTime(time), label3.Text.Trim());
                update_state(dd);
                this.Close();

            }
        }


        public void finish_order(int id,DateTime end,string pay ,double price,DateTime start,string vid)
        {
          try
            {
                dbh.open();

                StringBuilder sb = new StringBuilder(" insert finsh(tableid,finishtime,paytype,price,starttime,viptype) ");
                sb.AppendFormat(" values ( {0} , '{1}' , '{2}' , {3} , '{4}' , '{5}' )", id, end, pay, price, start, vid);
                SqlCommand comm = new SqlCommand(sb.ToString(), dbh.Conn);
               int a=comm.ExecuteNonQuery();

                if (a > 0)
                {
                    Sunny.UI.UIMessageDialog.ShowSuccessDialog(this, "订单已结算!");
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

        public void update_state(int id)
        {
            try
            {
                dbh.open();

                StringBuilder sb = new StringBuilder(" update tablee set state = 0  ");
                sb.AppendFormat(" where tableid = {0}",id);
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

        public void clearlove(int id)
        {
            
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

        private void uiButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void uiImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void uiPanel1_Click(object sender, EventArgs e)
        {

        }
    }
}
