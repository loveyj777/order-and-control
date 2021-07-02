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
    public partial class vipupdate : Form
    {
        DataSet set = new DataSet();
        public vipupdate()
        {
            InitializeComponent();
        }

        private void vipupdate_Load(object sender, EventArgs e)
        {
            query();
        }
        public void query()
        {
            dbhelper dbh = new dbhelper();
            try
            {
                dbh.open();

                StringBuilder sb = new StringBuilder("  select vipinfo.vipid,vipinfo.vippname,Viptype.vipname from vipinfo inner join Viptype on vipinfo.viptypeid = Viptype.id    ");

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

                StringBuilder sb = new StringBuilder("  select vipinfo.vipid,vipinfo.vippname,Viptype.vipname from vipinfo inner join Viptype on vipinfo.viptypeid = Viptype.id where vipinfo.vippname  like ");
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

        private void 修改职务ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updatevipinfo up = new updatevipinfo();

            updatevipinfo.name = Convert.ToString(uiDataGridView1.CurrentRow.Cells[0].Value);
            updatevipinfo.phone = Convert.ToString(uiDataGridView1.CurrentRow.Cells[1].Value);
        
            queryid(Convert.ToString(uiDataGridView1.CurrentRow.Cells[0].Value));
            up.Owner = this;
            up.Show();
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
               bool a = Sunny.UI.UIMessageDialog.ShowAskDialog(this, "确认删除？");
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

                StringBuilder sb = new StringBuilder("  delete from vipinfo where vipinfo.vipid =     ");
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

        public void update(string phone,int id,string name)
        {
            dbhelper dbh = new dbhelper();
            try
            {
                dbh.open();

                StringBuilder sb = new StringBuilder(" UPDATE vipinfo set  ");
                sb.AppendFormat("  vippname = '{0}' , viptypeid = {1}  ", phone,id);
                sb.AppendFormat("  where vipid = '{0}'", name);
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            query();
        }

        public void queryid(string name)
        {
            dbhelper dbh = new dbhelper();
            try
            {
                dbh.open();

                StringBuilder sb = new StringBuilder(" select viptypeid from vipinfo where vipid =   ");
                sb.AppendFormat(" '{0}' ", name);
                SqlCommand comm = new SqlCommand(sb.ToString(), dbh.Conn);

                int a = Convert.ToInt32(comm.ExecuteScalar());

                updatevipinfo.index = a-1;

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
