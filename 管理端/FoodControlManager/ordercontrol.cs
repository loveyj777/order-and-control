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
using Sunny;



namespace FoodControlManager
{
    public partial class ordercontrol : Form
    {
      
     
        int tab ;
        int ishas;
     public static   int count;
        public ordercontrol()
        {
            InitializeComponent();
        }

    
        public void get_count()
        {
            dbhelper dbh = new dbhelper();

            try
            {
                dbh.open();

                StringBuilder sb = new StringBuilder(" select count(*) from (select id from orderfood group by id) as A ");
                SqlCommand comm = new SqlCommand(sb.ToString(), dbh.Conn);
                string a = Convert.ToString(comm.ExecuteScalar());


              

                uiLabel14.Text = (tab - Convert.ToInt32(a)).ToString();
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

        private void ordercontrol_Load(object sender, EventArgs e)
        {
            
            tbcount();
                uiLabel12.Text = tab.ToString() ; 
             
             get_count();

          

            
          
            addtable();

            
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            uiLabel16.Text = DateTime.Now.ToString();
            tbcount();
            uiLabel12.Text = tab.ToString();

            get_count();

           

        }

        public void addtable()
        {
            table tb = new table();
            dbhelper dbh = new dbhelper();
            SqlDataReader reader = null;
            try
            {
                dbh.open();

                StringBuilder sb = new StringBuilder(" select tableid from tablee order by tableid    ");
                SqlCommand comm = new SqlCommand(sb.ToString(), dbh.Conn);
                reader = comm.ExecuteReader();

                while (reader.Read())
                {

                    for (int i = 0; i < 1; i++)
                    {

                         tb = new table();
                        tb.label1.Text = reader["tableid"].ToString();
                        tb.uiLabel1.Text = reader["tableid"].ToString() + "号桌";
                    
                        flowLayoutPanel1.Controls.Add(tb);
                        tb.Show();

                       
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
        public void tbcount()
        {
            dbhelper dbh = new dbhelper();
            SqlDataReader reader = null;
            try
            {
                dbh.open();

                StringBuilder sb = new StringBuilder(" select count(*) from tablee   ");
                SqlCommand comm = new SqlCommand(sb.ToString(), dbh.Conn);
                int a = Convert.ToInt32(comm.ExecuteScalar());
                tab = a;

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

        private void uiCheckBox1_ValueChanged_1(object sender, bool value)
        {
            if (uiCheckBox1.Checked == true)
            {
                uiCheckBox2.Checked = false;
                selectpic();
            }
            else
            {
                flowLayoutPanel1.Controls.Clear();
                addtable();
            }

        }

        private void uiCheckBox2_ValueChanged_1(object sender, bool value)
        {
            if (uiCheckBox2.Checked == true)
            {
               
                uiCheckBox1.Checked = false;
                selectpic1();
            }
            else
            {
                flowLayoutPanel1.Controls.Clear();
                addtable();
            }
        }

        public void selectpic()
        {
            dbhelper dbh = new dbhelper();
            SqlDataReader reader = null;
            try
            {
                dbh.open();

                StringBuilder sb = new StringBuilder(" select id from orderfood group by id  ");
                SqlCommand comm = new SqlCommand(sb.ToString(), dbh.Conn);
                reader = comm.ExecuteReader();
                flowLayoutPanel1.Controls.Clear();
                while (reader.Read())
                {


                    for (int i = 0; i < 1; i++)
                    {
                        table tb = new table();
                        tb = new table();
                        tb.label1.Text = reader["id"].ToString();
                        tb.uiLabel1.Text = reader["id"].ToString() + "号桌";
                        tb.pictureBox1.Image = Image.FromFile(@"C:\Users\asus\Desktop\ab.jpg");
                        flowLayoutPanel1.Controls.Add(tb);
                        tb.Show();

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

        public void selectpic1()
        {
            dbhelper dbh = new dbhelper();
            SqlDataReader reader = null;
            try
            {
                dbh.open();

                StringBuilder sb = new StringBuilder(" select tableid from tablee where tableid not in(select id from orderfood group by id)  ");
                SqlCommand comm = new SqlCommand(sb.ToString(), dbh.Conn);
                reader = comm.ExecuteReader();
                flowLayoutPanel1.Controls.Clear();
                while (reader.Read())
                {


                    for (int i = 0; i < 1; i++)
                    {
                        table tb = new table();
                        tb = new table();
                        tb.label1.Text = reader["tableid"].ToString();
                        tb.uiLabel1.Text = reader["tableid"].ToString() + "号桌";
                        
                        flowLayoutPanel1.Controls.Add(tb); 
                       
                        tb.Show();
                        
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

        private void uiButton1_Click(object sender, EventArgs e)
        {
            addtable_1();
            insettable(count + 1);
            flowLayoutPanel1.Controls.Clear();
            addtable();
           
        }

        public void addtable_1()
        {
            dbhelper dbh = new dbhelper();
          
            try
            {
                dbh.open();

                StringBuilder sb = new StringBuilder(" select * from tablee order by tableid desc  ");
                SqlCommand comm = new SqlCommand(sb.ToString(), dbh.Conn);
                count = Convert.ToInt32(comm.ExecuteScalar());
                

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

        public void insettable(int id)
        {
            dbhelper dbh = new dbhelper();

            try
            {
                dbh.open();

                StringBuilder sb = new StringBuilder(" insert tablee(tableid,state) values  ");
                sb.AppendFormat(" ( {0} , 0 )", id);
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
           
            addtable_1();
            detable(count);
           
            flowLayoutPanel1.Controls.Clear();
            addtable();
           
          
        }
        public void deleteid(int id)
        {
            dbhelper dbh = new dbhelper();

            try
            {
                dbh.open();

                StringBuilder sb = new StringBuilder(" delete tablee where tableid =  ");
                sb.AppendFormat("  {0} ", id);
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

        public void detable(int id)
        {
            dbhelper dbh = new dbhelper();

            try
            {
                dbh.open();

                StringBuilder sb = new StringBuilder(" select state from tablee where tablee.tableid =  ");
                sb.AppendFormat(" {0} ", id);
                SqlCommand comm = new SqlCommand(sb.ToString(), dbh.Conn);

                ishas = Convert.ToInt32(comm.ExecuteScalar());

                if (ishas == 0)
                {
                    deleteid(count);
                }
                else
                {
                    Sunny.UI.UIMessageDialog.ShowErrorDialog(this,"桌台正在使用中！");
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
    }
}
