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
    public partial class sellcount : Form
    {
        public sellcount()
        {
            InitializeComponent();
        }

        private void sellcount_Load(object sender, EventArgs e)
        {
            return_c();
            return_x();
            return_y();
            returnprice();
        }
        public void return_y()
        {
            dbhelper dbh = new dbhelper();
            int a;
            try
            {
                dbh.open();

                StringBuilder sb = new StringBuilder(" select COUNT(fid) from perfect group by fid having fid =2 ");
                SqlCommand comm = new SqlCommand(sb.ToString(), dbh.Conn);
                 a = Convert.ToInt32(comm.ExecuteScalar());
                chart1.Series[0].Points.AddXY("粤菜", a);
                uiLabel4.Text = "粤菜:" + a.ToString();



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

        public void return_c()
        {
            dbhelper dbh = new dbhelper();
            int a;
            try
            {
                dbh.open();

                StringBuilder sb = new StringBuilder(" select COUNT(fid) from perfect group by fid having fid =3 ");
                SqlCommand comm = new SqlCommand(sb.ToString(), dbh.Conn);
                a = Convert.ToInt32(comm.ExecuteScalar());
                chart1.Series[0].Points.AddXY("川菜", a);
                uiLabel3.Text = "川菜:" + a.ToString();


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
        public void return_x()
        {
            dbhelper dbh = new dbhelper();
            int a;
            try
            {
                dbh.open();

                StringBuilder sb = new StringBuilder(" select COUNT(fid) from perfect group by fid having fid =1 ");
                SqlCommand comm = new SqlCommand(sb.ToString(), dbh.Conn);
                a = Convert.ToInt32(comm.ExecuteScalar());
                chart1.Series[0].Points.AddXY("湘菜", a);
                uiLabel2.Text = "湘菜:" + a.ToString();


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

        public void returnprice()
        {
            dbhelper dbh = new dbhelper();
            SqlDataReader reader = null;
            try
            {
                dbh.open();

                StringBuilder sb = new StringBuilder(" select SUM(price) AS A,finishtime  from finsh group by finishtime ");
                SqlCommand comm = new SqlCommand(sb.ToString(), dbh.Conn);

                reader = comm.ExecuteReader();
                while (reader.Read())
                    {
                    chart2.Series[0].Points.AddXY(Convert.ToDateTime(reader["finishtime"].ToString()).ToString("yyyy-MM-dd"),Convert.ToDouble(reader["A"].ToString()));
                   
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
