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

namespace FoodControlManager
{
    public partial class table : UserControl
    {
        string pay;
        public static bool ishas  ;
        showfood show ;
        Cj2 cj;
        public table()
        {
           
            InitializeComponent();
        }

        private void uiPanel1_Click(object sender, EventArgs e)
        {

        }
        public void return_vip()
        {
            dbhelper dbh = new dbhelper();
            SqlDataReader reader = null;
            try
            {
                dbh.open();

                StringBuilder sb = new StringBuilder(" select pay from orderfood ");
                SqlCommand comm = new SqlCommand(sb.ToString(), dbh.Conn);
                reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    pay = reader["pay"].ToString();
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
        private void table_Load(object sender, EventArgs e)
        {

;           picadd();
      
           

            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            return_vip();
            show = new showfood(Convert.ToInt32(label1.Text));
            show.flowLayoutPanel1.Controls.Clear();
           
            addfoods(Convert.ToInt32(label1.Text));
        }

        public void addfoods(int table)
        {
            dbhelper dbh = new dbhelper();
            SqlDataReader reader = null;
            try
            {
                dbh.open();
                StringBuilder sb = new StringBuilder(" select * from orderfood  inner join Foodmenu on orderfood.orderfood=Foodmenu.foodname   ");
                sb.AppendFormat(" where orderfood.id= {0} ", table);

                SqlCommand comm = new SqlCommand(sb.ToString(), dbh.Conn);

                reader = comm.ExecuteReader();
                show = new showfood(Convert.ToInt32(label1.Text));
                while (reader.Read())
                {



                    for (int i = 0; i < 1; i++)
                    {
                        cj = new Cj2();   
                        cj.ckbchose.Checked= true;
                        cj.lblname.Text = reader["orderfood"].ToString();
                        cj.lblcount.Text = reader["count"].ToString();
                        cj.lblprice.Text = reader["price"].ToString();
                        cj.pictureBox1.Image = Image.FromFile(reader["filee"].ToString());
                        cj.buttonjian.Enabled = false;
                        cj.buttonplus.Enabled = false;
                        cj.pictureBox1.Enabled = false;
                        cj.ckbchose.Enabled = false;
                     

                    }
                    show.flowLayoutPanel1.Controls.Add(cj);
                    show.Show();

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

        public void picadd()
        {
            dbhelper dbh = new dbhelper();
            SqlDataReader reader = null;
            try
            {
                dbh.open();

                StringBuilder sb = new StringBuilder(" select  id	from orderfood group by id ");
                SqlCommand comm = new SqlCommand(sb.ToString(), dbh.Conn);
                reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    for (int i = 0; i < 10; i++)
                    {
                        
                        if (label1.Text.Equals(reader["id"].ToString()))
                        {
                          pictureBox1.Image = Image.FromFile(@"C:\Users\asus\Desktop\ab.jpg");

                        }
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

        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }
    }
}
