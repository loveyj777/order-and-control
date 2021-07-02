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
    public partial class viplogin : Form
    {
        public static int id;
        
        string rd;
        string price;
        public viplogin()
        {
            InitializeComponent();
        }

        private void viplogin_Load(object sender, EventArgs e)
        {

            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.None;
            return_price(id);
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals(string.Empty))
            {
                Sunny.UI.UIMessageDialog.ShowErrorDialog(this, "请输入手机号");
               
            }
          
            else
            {
              
              
             
                login_vip(textBox1.Text.Trim());

                update_vip(Convert.ToInt32(rd), id);

            }
        }

        public void login_vip(string name)
        {
            dbhelper dbh = new dbhelper();
            SqlDataReader reader = null;
            try
            {
                dbh.open();
                StringBuilder sb = new StringBuilder("select  discount,id  from vipinfo inner join Viptype on vipinfo.viptypeid=viptype.id  ");
                sb.AppendFormat("  where vippname='{0}' ", name);
                
                SqlCommand comm = new SqlCommand(sb.ToString(), dbh.Conn);

                string a =Convert.ToString( comm.ExecuteScalar());
                reader = comm.ExecuteReader();
                if (a.Equals(string.Empty))
                {
                    Sunny.UI.UIMessageDialog.ShowErrorDialog(this, "账户不存在！");
                }
                else
                { 
                while (reader.Read())
                { 
                        payform pay = new payform();
                        wechat.price = Convert.ToDouble(Convert.ToString(Convert.ToInt32(price) * Convert.ToDouble(reader["discount"].ToString())));
                        alipay.price = Convert.ToDouble(Convert.ToString(Convert.ToInt32(price) * Convert.ToDouble(reader["discount"].ToString())));
                        pay.label3.Text = Convert.ToString(Convert.ToInt32(price) * Convert.ToDouble(reader["discount"].ToString())) + "￥";
                        pay.return_price1(id);
                        rd = reader["id"].ToString();
                        if (Convert.ToInt32(rd) == 3)
                        {
                            alipay.vid = "钻石会员";
                            wechat.vid = "钻石会员";
                            pay.label5.Text = "尊贵的钻石会员";
                        }
                        else if (Convert.ToInt32(rd) == 2)
                        {
                            alipay.vid = "铂金会员";
                            wechat.vid = "铂金会员";
                            pay.label5.Text = "尊贵的铂金会员";
                        }
                        else
                        {
                            alipay.vid = "黄金会员";
                            wechat.vid = "黄金会员";
                            pay.label5.Text = "尊贵的黄金会员";

                        }

                        this.Close();
                        pay.Show();



                    }

                }
            
            }
            catch (Exception e)
            {


                MessageBox.Show(e.ToString());
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



        public void update_vip(int id,int tid)
        {
            dbhelper dbh = new dbhelper();
            try
            {
                dbh.open();
                StringBuilder sb = new StringBuilder("  update orderfood   ");
                sb.AppendFormat(" set orderfood.viptype ={0} where id= {1} ", id,tid);
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void return_price(int id)
        {
            dbhelper dbh = new dbhelper();
            try
            {
                dbh.open();

                StringBuilder sb = new StringBuilder("  select SUM(price*[count]) from orderfood where id = ");
                sb.AppendFormat(" {0} ", id);
                SqlCommand comm = new SqlCommand(sb.ToString(), dbh.Conn);
                price = Convert.ToString(comm.ExecuteScalar());
              



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
