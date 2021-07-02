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
using MyCj2;

namespace OrderFoodSystem
{
    public partial class closeorder : Form
    {
        public static int id;
        string price;
        dbhelper dbh = new dbhelper();
        Cj2 cj = new Cj2();
        public closeorder()
        {
            InitializeComponent();
        }

        private void closeorder_Load(object sender, EventArgs e)
        {
            select_fname(id);
            wechat.issucces = false;
            alipay.issucces = false;
            return_price(id);
        }

        public void select_fname(int id)
        {

            SqlDataReader reader = null;
            try
            {

                dbh.open();
                StringBuilder sb = new StringBuilder("select Foodmenu.foodname,[count],Foodmenu.price,orderfood.[state],filee from orderfood inner join Foodmenu on orderfood.orderfood  = Foodmenu.foodname     ");

                sb.AppendFormat(" where orderfood.id ={0} ",id);  
                SqlCommand comm = new SqlCommand(sb.ToString(), dbh.Conn);

                reader = comm.ExecuteReader();


                while (reader.Read())
                {




                    for (int i = 0; i < 1; i++)
                    {

                        cj = new Cj2();
                        cj.ckbchose.Checked = true;
                        cj.ckbchose.Enabled = false;
                        cj.buttonjian.Enabled = false;
                        cj.buttonplus.Enabled = false;
                        cj.pictureBox1.Image = Image.FromFile(reader["filee"].ToString());
                        cj.lblname.Text = reader["foodname"].ToString();
                        cj.lblprice.Text = reader["price"].ToString()+"￥";

                        cj.pictureBox1.Enabled = false;
                        cj.lblcount.Text = reader["count"].ToString();
                        cj.ContextMenuStrip = null;
                        flowLayoutPanel1.Controls.Add(cj);



                        cj.Show();


                    }

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {

                if (reader != null)
                {
                    reader.Close();


                }


                dbh.close();


            }
        }

        public void return_price(int id)
        {
            try
            {
                dbh.open();
                
                StringBuilder sb = new StringBuilder(" select SUM(price*[count]) from orderfood where ");
                sb.AppendFormat(" orderfood.id = {0} ", id);
                SqlCommand comm = new SqlCommand(sb.ToString(), dbh.Conn);
                price = Convert.ToString(comm.ExecuteScalar());
                if (price == null)
                {


                }
                else
                {

                    label1 .Text = price+"￥";
                    

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

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            
            if (label1.Text.Equals("￥"))
            {
                Sunny.UI.UIMessageDialog.ShowErrorDialog(this, "餐袋里无菜品！");
              
            }
            else
            {
            bool b=    Sunny.UI.UIMessageDialog.ShowAskDialog(this, "是否为本店会员用户?");
               
                if (b == true)
                { 
                    clear();
                    viplogin vip = new viplogin();
                    viplogin.id = id;
                    vip.Show();
                    
                }
                else
                {
                    alipay.price=Convert.ToDouble(price);
                    wechat.price = Convert.ToDouble(price);
                    clear();
                    payform pay = new payform();
                    pay.Owner = this;
                    pay.label1.Visible = false;
                    pay.label2.Visible = false;
                    pay.return_price(id);
                    pay.Show();
                    update_vip(id);
                }
            }
        }

        public void clear()
        {

            try
            {
                dbh.open();
                StringBuilder sb = new StringBuilder("  update judgefood set judge=0 ,[count]=0  ");
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

        public void update_vip(int id)
        {

            try
            {
                dbh.open();
                StringBuilder sb = new StringBuilder("    update orderfood set viptype=0 where id =  ");
                sb.AppendFormat(" {0} ", id);
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

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
               if (wechat.issucces == true)
               {

                   flowLayoutPanel1.Controls.Clear();
                   select_fname(id);
                return_price(id);
                if (label1.Text.Equals("￥"))
                {
                    label1.Text = "0￥";
                }
                }

            if (alipay.issucces == true)
            {
                flowLayoutPanel1.Controls.Clear();
                select_fname(id);
                return_price(id);
                label1.Text = "0￥";
            }
           
        }
    }
}
