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
    public partial class deleteuser : Form
    {
        DataSet set = new DataSet();
        public deleteuser()
        {
            InitializeComponent();
        }

        private void deleteuser_Load(object sender, EventArgs e)
        {
            query();
        }

        public void query()
        {
            dbhelper dbh = new dbhelper();
            try
            {
                dbh.open();

                StringBuilder sb = new StringBuilder("  select [admin],atype.type from adnmin inner join atype on adnmin.type = atype.id     ");

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
            if (uiTextBox1.Text.Equals(string.Empty))
            {
                query();

            }
            else
            {
                query2(uiTextBox1.Text.Trim());
            }
        }

        private void uiDatePicker1_ValueChanged(object sender, DateTime value)
        {

        }

        private void uiDatePicker2_ValueChanged(object sender, DateTime value)
        {

        }

        private void uiLabel8_Click(object sender, EventArgs e)
        {

        }

        private void uiLabel7_Click(object sender, EventArgs e)
        {

        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
              bool a=  Sunny.UI.UIMessageDialog.ShowAskDialog(this, "确认删除？");
                if (a == true)
                {

                   query1(Convert.ToString(Convert.ToString(uiDataGridView1.CurrentRow.Cells[0].Value)));
                    query();
                }

            
            
        }
        public void query1(string name)
        {
            dbhelper dbh = new dbhelper();
            try
            {
                dbh.open();

                StringBuilder sb = new StringBuilder("  delete from adnmin where adnmin.admin =     ");
                sb.AppendFormat(" '{0}' ", name);
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

        public void query2(string name)
        {
            dbhelper dbh = new dbhelper();
            try
            {
                dbh.open();

                StringBuilder sb = new StringBuilder("  select [admin],atype.type from adnmin inner join atype on adnmin.type = atype.id where [admin] like   ");
                sb.AppendFormat(" '{0}%' ", name);
              
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

        private void 修改职务ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            cbx c = new cbx();
            cbx.name = Convert.ToString(uiDataGridView1.CurrentRow.Cells[0].Value);
            c.Owner = this;
            c.Show();
        }

        public void update(int id,string name)
        {
            dbhelper dbh = new dbhelper();
            try
            {
                dbh.open();

                StringBuilder sb = new StringBuilder("  update adnmin set type =  ");
                sb.AppendFormat(" {0} ", id);
                sb.AppendFormat(" where [admin] =  '{0}' ", name);

                SqlCommand comm = new SqlCommand(sb.ToString(), dbh.Conn);
                int a = comm.ExecuteNonQuery();
                if (a > 0)
                {
                    Sunny.UI.UIMessageDialog.ShowSuccessDialog(this, "修改成功!");
                    SqlDataAdapter adp = new SqlDataAdapter();
                    adp.SelectCommand = comm;

                    if (set.Tables["b"] != null)
                    {
                        set.Tables["b"].Clear();

                    }
                    adp.Fill(set, "b");
                    uiDataGridView1.DataSource = set.Tables["b"];
                }
                else
                {
                    Sunny.UI.UIMessageDialog.ShowErrorDialog(this, "修改失败!");

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

        private void timer1_Tick(object sender, EventArgs e)
        {
            query();
        }

        private void uiContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
