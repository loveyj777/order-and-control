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
    public partial class orderfoods : Form
    {
        int fid;
        string price;

        Cj2[] cj2s;

        public orderfoods(int table)
        {

            InitializeComponent();
            fid = table;

        }

        private void lblprice_Click(object sender, EventArgs e)
        {

        }

        private void orderfoods_Load(object sender, EventArgs e)
        {
            #region

            cj2s = new Cj2[flowLayoutPanel1.Controls.Count];

            cj2s[0] = cj21;
            cj2s[1] = cj22;
            cj2s[2] = cj23;
            cj2s[3] = cj24;
            cj2s[4] = cj25;
            cj2s[5] = cj26;
            cj2s[6] = cj27;
            cj2s[7] = cj28;
            cj2s[8] = cj29;
            cj2s[9] = cj210;
            cj2s[10] = cj211;
            cj2s[11] = cj212;
            cj2s[12] = cj213;
            cj2s[13] = cj214;
            cj2s[14] = cj215;
            cj2s[15] = cj216;
            cj2s[16] = cj217;
            cj2s[17] = cj218;
            cj2s[18] = cj219;
            cj2s[19] = cj220;
            cj2s[20] = cj221;
            cj2s[21] = cj222;
            cj2s[22] = cj223;
            cj2s[23] = cj224;
            cj2s[24] = cj225;
            cj2s[25] = cj226;
            cj2s[26] = cj227;
            cj2s[27] = cj228;
            cj2s[28] = cj229;
            cj2s[29] = cj230;
            cj2s[30] = cj231;
            cj2s[31] = cj232;
            cj2s[32] = cj233;
            cj2s[33] = cj234;
            cj2s[34] = cj235;
            cj2s[35] = cj236;
            cj2s[36] = cj237;
            cj2s[37] = cj238;
            cj2s[38] = cj239;
            cj2s[39] = cj240;
            cj2s[40] = cj241;

            for (int i = 0; i < cj2s.Length; i++)
            {
                cj2s[i].Visible = false;

            }

            #endregion



            timer1.Enabled = true;
            addfoods();
            label3.Text = fid.ToString();
            closeorder.id = fid;
            payform.id = fid;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            alipay.id = fid;
            alipay.time = DateTime.Now;
            wechat.id = fid;
            wechat.time = DateTime.Now;  
            string name = null;
            string count = null;
            string price = null;
            if (label1.Text.Equals("￥"))
            {
               
                Sunny.UI.UIMessageDialog.ShowErrorDialog(this, "您未选择任何菜品");
               
            }


        
            else
            {
                for (int i = 0; i < flowLayoutPanel1.Controls.Count; i++)
                {


                    if (cj2s[i].Visible == true)
                    {
                        if (cj2s[i].ckbchose.Checked == true)
                        {
                            name = cj2s[i].lblname.Text;
                            count = cj2s[i].lblcount.Text;
                            price = cj2s[i].lblprice.Text;

                            submit(Convert.ToInt32(label3.Text), name, Convert.ToInt32(count), Convert.ToInt32(price), 0, DateTime.Now);
                        }
                    }



                }
                surre_(fid);
            }
            get_ftid();
            get_ftid2();
           
           clear();
            for (int i = 0; i < cj2s.Length; i++)
            {
                cj2s[i].ckbchose.Enabled = false;
                cj2s[i].pictureBox1.Enabled = false;
                cj2s[i].buttonjian.Enabled = false;
                cj2s[i].buttonplus.Enabled = false;

            }

        }



        public void return_price()
        {
            dbhelper dbh = new dbhelper();
            try
            {
                dbh.open();
                StringBuilder sb = new StringBuilder("select SUM(price*judgefood.count) from Foodmenu inner join judgefood on Foodmenu.id=judgefood.id  ");
                sb.Append(" where judge=1 ");

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

        public void submit(int id, string name, int count, int price, int state, DateTime time)
        {
            dbhelper dbh = new dbhelper();

            try
            {

                dbh.open();
                StringBuilder sb = new StringBuilder(" insert orderfood(id,orderfood,[count],price,state,starttime) ");
                sb.AppendFormat(" values  ({0},'{1}',{2},{3},{4},'{5}' )", id, name, count, price, state, time);
                SqlCommand comm = new SqlCommand(sb.ToString(), dbh.Conn);

                int a = comm.ExecuteNonQuery();
                

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {



                dbh.close();


            }
        }
        public void get_ftid()
        {
            dbhelper dbh = new dbhelper();

            try
            {

                dbh.open();
                StringBuilder sb = new StringBuilder("update orderfood set orderfood.ftypeid = foodstype.foodtypeid from foodstype,orderfood,Foodmenu where foodstype.foodtypeid=Foodmenu.foodtypeid and orderfood.orderfood= Foodmenu.foodname  ");
                SqlCommand comm = new SqlCommand(sb.ToString(), dbh.Conn);

                comm.ExecuteNonQuery();


            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {


                dbh.close();


            }
        }

        public void set_fid(int id)
        {
            dbhelper dbh = new dbhelper();

            try
            {

                dbh.open();
                StringBuilder sb = new StringBuilder("insert perfect(fid)  ");
                sb.AppendFormat(" values ({0}) ", id);
                SqlCommand comm = new SqlCommand(sb.ToString(), dbh.Conn);

                comm.ExecuteNonQuery();


            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {


                dbh.close();


            }
        }

        public void get_ftid2()
        {
            dbhelper dbh = new dbhelper();
            SqlDataReader reader = null;
            try
            {

                dbh.open();
                StringBuilder sb = new StringBuilder(" select ftypeid from orderfood  ");

                SqlCommand comm = new SqlCommand(sb.ToString(), dbh.Conn);

                reader = comm.ExecuteReader();

                while (reader.Read())
                {

                    set_fid(Convert.ToInt32(reader["ftypeid"].ToString()));
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
        public void addfoods()
        {
            SqlDataReader reader = null;

            dbhelper dbh = new dbhelper();

            try
            {
                dbh.open();
                StringBuilder sb = new StringBuilder(" select judgefood.foodname,price,judgefood.[count],filee,Foodmenu.id from Foodmenu  ");
                sb.Append(" inner join judgefood on Foodmenu.id = judgefood.id where judge=1   ");
                SqlCommand comm = new SqlCommand(sb.ToString(), dbh.Conn);

                reader = comm.ExecuteReader();

                while (reader.Read())
                {
                    for (int i = 0; i < cj2s.Length; i++)
                    {
                        if (i == Convert.ToInt32(reader["id"].ToString()))

                        {
                            cj2s[i].ckbchose.Checked = true;

                            cj2s[i].pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                            cj2s[i].lblprice.Text = reader["price"].ToString();
                            cj2s[i].lblname.Text = reader["foodname"].ToString();
                            cj2s[i].pictureBox1.Image = Image.FromFile(reader["filee"].ToString());
                            cj2s[i].lblcount.Text = reader["count"].ToString();
                            cj2s[i].ContextMenuStrip = null;


                            if (cj2s[i].lblname != null)
                            {
                                cj2s[i].Visible = true;

                            }


                        }


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

        private void timer1_Tick(object sender, EventArgs e)
        {
            return_price();
        }


        public void surre_(int id)
        {
            dbhelper dbh = new dbhelper();
            try
            {
                dbh.open();
                StringBuilder sb = new StringBuilder(" select * from orderfood where id = ");
                sb.AppendFormat(" {0} ", id);
                SqlCommand comm = new SqlCommand(sb.ToString(), dbh.Conn);

                string a = Convert.ToString(comm.ExecuteScalar());
                if (a != null)
                {
                  
                    Sunny.UI.UIMessageDialog.ShowSuccessDialog(this, "添加成功！");

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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void clear()
        {
            dbhelper dbh = new dbhelper();
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
    }
}