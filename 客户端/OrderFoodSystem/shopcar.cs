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
using MyCj2;
using System.Data.SqlClient;


namespace OrderFoodSystem
{
    public partial class shopcar : Form
    {
       
        string price;
        Cj2 cj = new Cj2();

        dbhelper dbh = new dbhelper();
        public shopcar()

        {
            InitializeComponent();


        }

        private void flpshopcar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void shopcar_Load(object sender, EventArgs e)
        {

            this.Text = "购物车";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.None;


           
            
            select_fname();
            return_price();

            if (lblmoney.Text.Equals("￥"))
            {
                this.Close();
               
                Sunny.UI.UIMessageDialog.ShowErrorDialog(this,"您未选择任何菜品");
            }
        }


        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]

        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }



        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnmaxsize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void btnminisize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Foods f1 = (Foods)this.Owner;
            f1.flowLayoutPanel1.Controls.Clear();
            f1.addfoods();
           
            

            this.Hide();
            
        }


   /*     public void AddControl(string name)
        {
            SqlDataReader reader = null;
            try
            {

                dbh.open();

                StringBuilder sb = new StringBuilder("select foodname,price,filee from Foods inner join imgfile on Foods.id = imgfile.id  ");

                sb.AppendFormat(" where foodname ='{0}' ", name);

                SqlCommand comm = new SqlCommand(sb.ToString(), dbh.Conn);

                reader = comm.ExecuteReader();


                while (reader.Read())
                {
                    for (int i = 0; i < flowLayoutPanel1.Controls.Count; i++)
                    {
                        cj.pictureBox1.Image = Image.FromFile(reader["filee"].ToString());
                        cj.lblname.Text = reader["foodname"].ToString();
                        cj.lblprice.Text = reader["price"].ToString();
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

        public void ReadControl(string name)
        {
            SqlDataReader reader = null;
            try
            {
                dbh.open();
                StringBuilder sb = new StringBuilder(" select foodname,judge,[COUNT] from judgefood ");
                sb.AppendFormat(" where foodname ='{0}' ", name);
                SqlCommand comm = new SqlCommand(sb.ToString(), dbh.Conn);
                reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    for (int i = 0; i < flowLayoutPanel1.Controls.Count; i++)
                    {
                        cj.lblcount.Text = reader["count"].ToString();
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

        }*/

        public void return_price()
        {
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

                  lblmoney.Text = price + "￥";

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

        /*  public void update_jugde(string name)
          {

              try
              {
                  dbh.open();
                  StringBuilder sb = new StringBuilder("update judgefoodset judge = NULL,[count] = NULL  ");
                  sb.AppendFormat(" where foodname ='{0}'  ", name);
                  SqlCommand comm = new SqlCommand(sb.ToString(), dbh.Conn);
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
        */
        public void select_fname()
        {

            SqlDataReader reader = null;
            try
            {

                dbh.open();
                StringBuilder sb = new StringBuilder(" select judgefood.foodname,price,judgefood.[count],filee from Foodmenu  ");
                sb.Append(" inner join judgefood on Foodmenu.id = judgefood.id where judge=1   ");
                SqlCommand comm = new SqlCommand(sb.ToString(), dbh.Conn);

                reader = comm.ExecuteReader();


                while (reader.Read())
                {




                    for (int i = 0; i < 1; i++)
                    {

                        cj = new Cj2();
                         cj.ckbchose.Checked = true;
                          cj.pictureBox1.Image = Image.FromFile(reader["filee"].ToString());
                        cj.lblname.Text = reader["foodname"].ToString();
                        cj.lblprice.Text = reader["price"].ToString() + "￥";
                        cj.ContextMenuStrip = null;


                        cj.lblcount.Text = reader["count"].ToString();
                       
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            return_price();
            
        }
         public void clear()
 {

     try
     {
         dbh.open();
         StringBuilder sb = new StringBuilder("  update judgefood set judge=0 ,[count]=0  ");
         SqlCommand comm = new SqlCommand(sb.ToString(), dbh.Conn);
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


    }
}
