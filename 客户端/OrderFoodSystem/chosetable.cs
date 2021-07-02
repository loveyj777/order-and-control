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
    public partial class chosetable : Form
    {
        dbhelper dbh = new dbhelper();
        DataSet set = new DataSet();
        public chosetable()
        {
            InitializeComponent();
        }

        private void chosetable_Load(object sender, EventArgs e)
        {
            this.Text = string.Empty;
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.DoubleBuffered = true;
            return_price();
            comboBox1.DataSource = set.Tables["a"];
            comboBox1.DisplayMember = "tableid";
            comboBox1.ValueMember = "tableid";
           
        }

        private void btncexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mainform m = new Mainform(Convert.ToInt32( comboBox1.Text));
            update(Convert.ToInt32(comboBox1.Text));
            this.Hide();
            m.Show();
        }

        public void return_price()
        {
            dbhelper dbh = new dbhelper();
            try
            {
                dbh.open();
                StringBuilder sb = new StringBuilder(" select tableid from tablee where state=0" );
                SqlCommand comm = new SqlCommand(sb.ToString(), dbh.Conn);
                SqlDataAdapter adp = new SqlDataAdapter();
                adp.SelectCommand = comm;
                if (set.Tables["a"] != null)
                {
                    set.Tables["a"].Clear();
                }
                adp.Fill(set, "a");


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

        public void update(int id)
        {
            dbhelper dbh = new dbhelper();
            try
            {
                dbh.open();
                StringBuilder sb = new StringBuilder(" update tablee set state = 1 where ");
                sb.AppendFormat(" tableid = {0}", id);
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
