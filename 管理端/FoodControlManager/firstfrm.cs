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

namespace FoodControlManager
{

    public partial class firstfrm : Form
    {
        string names;
        int i = 1;
        int table = 10;
        dbhelper dbh = new dbhelper();

        public firstfrm(string name)
        {
            names = name;
            InitializeComponent();
           

        }

        private void firstfrm_Load(object sender, EventArgs e)
        {
            lblusers.Text = Convert.ToString(i);

            lblname.Text = names;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            uiLabel6.Text = DateTime.Now.ToString();
            lblname.Text = names;
        }  

        public void get_count()
        {

            try
            {
                dbh.open();

                StringBuilder sb = new StringBuilder(" select count(*) from (select id from orderfood group by id) as A ");
                SqlCommand comm = new SqlCommand(sb.ToString(), dbh.Conn);
                string a = Convert.ToString(comm.ExecuteScalar());


                lblorder.Text = a;


                lblfree.Text = (table - Convert.ToInt32(a)).ToString();
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

        private void timer2_Tick(object sender, EventArgs e)
        {
            get_count();
            get_finnish();
        }

        public void get_finnish()
        {

            try
            {
                dbh.open();

                StringBuilder sb = new StringBuilder(" select COUNT(*) from finsh ");
                SqlCommand comm = new SqlCommand(sb.ToString(), dbh.Conn);
                string a = Convert.ToString(comm.ExecuteScalar());


                lblfinish.Text = a;



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

        private void uiLabel6_Click(object sender, EventArgs e)
        {

        }
    }
}
