using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyCj2;
using System.Data.SqlClient;


namespace OrderFoodSystem
{
    public partial class Foods : Form
    {
        public static int tabid;
        dbhelper dbh = new dbhelper();
        shopcar car;        
        public int a;
        int s=0;
        Cj2 cj;
        public Foods()
        {
            InitializeComponent();

        }

        private void Foods_Load(object sender, EventArgs e)
        {

            updateState(tabid);

        
            this.StartPosition = FormStartPosition.CenterScreen;


           

            addfoods();



        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panelnav_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            flowLayoutPanel1.Controls.Clear();
            type_Xiang();

        }


        public void updateState(int id)
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

        public void addfoods()
        {
            SqlDataReader reader = null;
            


            try
            {
                dbh.open();
                StringBuilder sb = new StringBuilder(" select Foodmenu.id,Foodmenu.foodname,price,Foodmenu.filee,judgefood.[count],judge from Foodmenu  ");
                sb.Append(" inner join judgefood on Foodmenu.id = judgefood.id   ");
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
                        cj.ContextMenu = null;
                        if (Convert.ToInt32(reader["judge"].ToString()) == 0)
                            {
                                cj.ckbchose.Checked = false;

                            }
                            else
                            {
                                cj.ckbchose.Checked = true ;

                            }

                    } 
                    cj.lblcount.Text = reader["count"].ToString();
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

        private void btnshopcar_Click(object sender, EventArgs e)


        {

             
            car = new shopcar();
            car.Owner = this;
            car.Show();

         
         
        }


        private void btnright_Click(object sender, EventArgs e)
        {

          a = 1;


             
        }


       public void type_Xiang()
        {
            SqlDataReader reader = null;
            try
            {
                dbh.open();
                StringBuilder sb = new StringBuilder("select Foodmenu.id, Foodmenu.foodname ,price, filee, judge, judgefood.[count] from Foodmenu inner join foodstype on Foodmenu.foodtypeid=foodstype.foodtypeid  ");
                sb.AppendFormat(" inner join judgefood on Foodmenu.id=judgefood.id  ");
                sb.AppendFormat(" where foodstype.foodtypeid=1   ");
                
                SqlCommand comm = new SqlCommand(sb.ToString(), dbh.Conn);
                reader = comm.ExecuteReader();
                while (reader.Read())
                {


                    for (int i = 0; i < 1; i++)
                    {

                        cj = new Cj2();

                        cj.pictureBox1.Image = Image.FromFile(reader["filee"].ToString());
                        cj.lblname.Text = reader["foodname"].ToString();
                        cj.lblprice.Text = reader["price"].ToString();
                        cj.lblcount.Text = reader["count"].ToString();

                        flowLayoutPanel1.Controls.Add(cj);

                        if (Convert.ToInt32(reader["judge"]) == 1)
                        {
                            cj.ckbchose.Checked = true;
                        }
                        cj.Show();
                        


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

        public void type_chuan()
         {
             SqlDataReader reader = null;
             try
             {
                 dbh.open();
                StringBuilder sb = new StringBuilder("select Foodmenu.id, Foodmenu.foodname ,price, filee, judge, judgefood.[count] from Foodmenu inner join foodstype on Foodmenu.foodtypeid=foodstype.foodtypeid  ");
                sb.AppendFormat(" inner join judgefood on Foodmenu.id=judgefood.id  ");
                sb.AppendFormat(" where foodstype.foodtypeid=3   ");

                SqlCommand comm = new SqlCommand(sb.ToString(), dbh.Conn);
                 reader = comm.ExecuteReader();
                 while (reader.Read())
                 {
                    for (int i = 0; i < 1; i++)
                    {

                        cj = new Cj2();

                        cj.pictureBox1.Image = Image.FromFile(reader["filee"].ToString());
                        cj.lblname.Text = reader["foodname"].ToString();
                        cj.lblprice.Text = reader["price"].ToString();
                        cj.lblcount.Text = reader["count"].ToString();

                        flowLayoutPanel1.Controls.Add(cj);

                        if (Convert.ToInt32(reader["judge"]) == 1)
                        {
                            cj.ckbchose.Checked = true;
                        }
                        cj.Show();



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
                 a = 2;
             }

         }


         public void type_yue()
         {
             SqlDataReader reader = null;
             try
             {
                 dbh.open();
                StringBuilder sb = new StringBuilder("select Foodmenu.id, Foodmenu.foodname ,price, filee, judge, judgefood.[count] from Foodmenu inner join foodstype on Foodmenu.foodtypeid=foodstype.foodtypeid  ");
                sb.AppendFormat(" inner join judgefood on Foodmenu.id=judgefood.id  ");
                sb.AppendFormat(" where foodstype.foodtypeid=2   ");

                SqlCommand comm = new SqlCommand(sb.ToString(), dbh.Conn);
                 reader = comm.ExecuteReader();
                 while (reader.Read())
                 {
                    for (int i = 0; i < 1; i++)
                    {

                        cj = new Cj2();
                        cj.pictureBox1.Image = Image.FromFile(reader["filee"].ToString());
                        cj.lblname.Text = reader["foodname"].ToString();
                        cj.lblprice.Text = reader["price"].ToString();
                        cj.lblcount.Text = reader["count"].ToString();

                        flowLayoutPanel1.Controls.Add(cj);

                        if (Convert.ToInt32(reader["judge"]) == 1)
                        {
                            cj.ckbchose.Checked = true;
                        }
                        cj.Show();



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
                 a = 3;
             }

         }
         
        private void btnChuan_Click(object sender, EventArgs e)
        {


            flowLayoutPanel1.Controls.Clear();
             type_chuan();
            

        }


        private void btnYue_Click(object sender, EventArgs e)
        {



            flowLayoutPanel1.Controls.Clear();
              type_yue();
           






        }

        private void btnmeau_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            addfoods();

        }

        public void Control_State(int jugde, int count,string name)
        {
            try
            {
                dbh.open();
                StringBuilder sb = new StringBuilder(" update judgefood ");
                sb.AppendFormat(" set judge = {0} ,",jugde);
                sb.AppendFormat("  [count] = {0}", count);
                sb.AppendFormat("  where foodname = '{0}'", name);
                SqlCommand comm = new SqlCommand(sb.ToString(), dbh.Conn);
                int a = comm.ExecuteNonQuery(); 

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


        public void select_checked()
        {
            SqlDataReader reader = null;

            try
            {
                dbh.open();
                StringBuilder sb = new StringBuilder(" select foodname from judgefood where  judge=1 ");
                SqlCommand comm = new SqlCommand(sb.ToString(), dbh.Conn);

                reader = comm.ExecuteReader();

                while (reader.Read())
                {
                    for (int i = 0; i < flowLayoutPanel1.Controls.Count; i++)
                    {
                       


                    }

                }
            }
            catch (Exception e)
            {


                MessageBox.Show(e.ToString());
            }
            finally
            {
                if ( reader!= null)
                {
                    reader.Close();
                
                }
                dbh.close();

            }

        }

        private void cj2_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            addfoods();
            MessageBox.Show("123");
        }

        private void cj22_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

