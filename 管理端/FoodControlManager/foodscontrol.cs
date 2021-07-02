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
    public partial class foodscontrol : Form
    {
        dbhelper dbh = new dbhelper();
        Cj2 cj;
        public int right;
        public foodscontrol()
        {
            InitializeComponent();
        }

        private void foodscontrol_Load(object sender, EventArgs e)
        {
            addfoods();
          
            
        }

        public void addfoods()
        {
            SqlDataReader reader = null;
        try
            {
                dbh.open();
                StringBuilder sb = new StringBuilder(" select id, foodname, price, filee from Foodmenu   ");

                SqlCommand comm = new SqlCommand(sb.ToString(), dbh.Conn);

                reader = comm.ExecuteReader();

                while (reader.Read())
                {

                 

                    for (int i = 0; i < 1; i++)
                    {

                        cj = new Cj2();

                        cj.pictureBox1.Image = Image.FromFile(reader["filee"].ToString());
                        cj.lblname.Text = reader["foodname"].ToString();
                        cj.lblprice.Text = reader["price"].ToString() + "￥";
                        cj.ckbchose.Checked = true;
                        cj.lblcount.Text = "0";

                        cj.ckbchose.Enabled = false;
                        cj.buttonjian.Enabled = false;
                        cj.buttonplus.Enabled = false;

                        cj.pictureBox1.Enabled = false;
                       
                    }

                    flowLayoutPanel1.Controls.Add(cj);


                    cj.Show();


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
             //   flowLayoutPanel1.Controls.Clear();
              //  addfoods();
            MessageBox.Show("123");
            
            
        }
        
        }
    
}