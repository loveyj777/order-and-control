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
    public partial class history : Form
    {
        dbhelper dbh = new dbhelper();
        DataSet set = new DataSet();
        public history()
        {
            InitializeComponent();
        }

        private void uiTitlePanel1_Click(object sender, EventArgs e)
        {

        }

        private void history_Load(object sender, EventArgs e)
        {
            
  
            query();
        }

        private void uiDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void query_onlytime(DateTime time1 ,DateTime time2)
        {
         
            try
            {
                dbh.open();

                StringBuilder sb = new StringBuilder(" select * from finsh where finishtime     ");
                sb.AppendFormat(" between '{0}' and '{1}'", time1,time2);
                SqlCommand comm = new SqlCommand(sb.ToString(), dbh.Conn);

                SqlDataAdapter adp = new SqlDataAdapter();
                adp.SelectCommand = comm;

                if (set.Tables["a"] != null)
                {
                    set.Tables["a"].Clear();

                }
                adp.Fill(set, "a");
                uiDataGridView1.DataSource = set.Tables["a"];
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
        public void query_timetext(DateTime time1, DateTime time2,int id)
        {

            try
            {
                dbh.open();

                StringBuilder sb = new StringBuilder(" select * from finsh where finishtime     ");
                sb.AppendFormat("between '{0}' and '{1}' and tableid = {2} ", time1, time2,id);
                
                SqlCommand comm = new SqlCommand(sb.ToString(), dbh.Conn);

                SqlDataAdapter adp = new SqlDataAdapter();
                adp.SelectCommand = comm;

                if (set.Tables["a"] != null)
                {
                    set.Tables["a"].Clear();

                }
                adp.Fill(set, "a");
                uiDataGridView1.DataSource = set.Tables["a"];
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

        public void query()
        {

            try
            {
                dbh.open();

                StringBuilder sb = new StringBuilder("  select * from finsh     ");
                
                SqlCommand comm = new SqlCommand(sb.ToString(), dbh.Conn);

                SqlDataAdapter adp = new SqlDataAdapter();
                adp.SelectCommand = comm;

                if (set.Tables["b"] != null)
                {
                    set.Tables["b"].Clear();

                }
                adp.Fill(set, "b");
                uiDataGridView1.DataSource = set.Tables["b"];
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

        private void uiButton4_Click(object sender, EventArgs e)
        {
            Sunny.UI.UIMessageTip.Show("查询成功",Sunny.UI.TipStyle.Green);
            if (uiTextBox1.Text.Equals(string.Empty))
            {
                query_onlytime(Convert.ToDateTime(uiDatePicker1.Text), Convert.ToDateTime(uiDatePicker2.Text));
            }
            else
            {
                query_timetext(Convert.ToDateTime(uiDatePicker1.Text), Convert.ToDateTime(uiDatePicker2.Text), Convert.ToInt32(uiTextBox1.Text.Trim()));
            
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            query();
        }
    }
}
