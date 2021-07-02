using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sunny;
using System.Data.SqlClient;

namespace FoodControlManager
{
    public partial class Form1 : Form
    {
      static  int ids;
       static  string names;

      
        usercontrol user = new usercontrol();
        history his = new history();
        ordercontrol or = new ordercontrol();
        foodsadd add = new foodsadd();
     
       
        firstfrm f1 = new firstfrm(names);
        public Form1(string name,int id)
        {
            InitializeComponent();
            ids = id;
            names = name;
        }

        private void uiSwitch1_ValueChanged(object sender, bool value)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            this.TopLevel = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.DoubleBuffered = true;
            uiNavMenu1.SelectFirst();
          if (ids == 2)
            {
                
              
                uiNavMenu1.Nodes[1].Remove();
                uiNavMenu1.Nodes[2].Remove();
                uiNavMenu1.Nodes[3].Remove();
                uiNavMenu1.Nodes[1].Text = "菜品管理";
                uiNavMenu1.Nodes[1].Nodes[0].Text = "菜品管理";
                uiNavMenu1.Nodes[1].Nodes[1].Text = "菜品添加";
                uiNavMenu1.Nodes[2].Text = "系统设置";
            }

            if (ids == 3)
            {


             uiNavMenu1.Nodes[1].Remove();
                uiNavMenu1.Nodes[2].Remove();
                uiNavMenu1.Nodes[3].Remove();
         
                 uiNavMenu1.Nodes[2].Text = "系统设置";
            }

        }
      
        private void uiPieChart1_Click(object sender, EventArgs e)
        {

        }

        private void uiImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void uiImageButton2_Click(object sender, EventArgs e)
        {

            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void uiImageButton3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }


        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]

        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);



        private void uiTitlePanel1_MouseDown(object sender, MouseEventArgs e)
        {
   ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void uiNavMenu1_MenuItemClick(TreeNode node, Sunny.UI.NavMenuItem item, int pageIndex)
        {
        panel1.Controls.Clear();
            if (ids == 3)
            {
                if (uiNavMenu1.Nodes[0].IsSelected == true)
                {
                    f1.Owner = this;
                    f1.ControlBox = false;
                    f1.TopLevel = false;
                    f1.Text = string.Empty;
                    f1.BackColor = Color.White;
                    f1.FormBorderStyle = FormBorderStyle.None;
                    f1.Dock = DockStyle.Fill;
                    f1.AutoSize = false;
                    f1.lblname.Text = names;
                    panel1.Visible = true;
                    panel1.Controls.Add(f1);
                    f1.Show();
                }
                if (uiNavMenu1.Nodes[1].Nodes[0].IsSelected == true)
                {


                    ordercontrol or = new ordercontrol();

                    or.Owner = this;
                    or.ControlBox = false;
                    or.TopLevel = false;
                    or.Text = string.Empty;
                    or.FormBorderStyle = FormBorderStyle.None;
                    or.Dock = DockStyle.Fill;
                    or.AutoSize = false; ;
                    panel1.Visible = true;
                    panel1.Controls.Add(or);
                    or.Show();
                }
                if (uiNavMenu1.Nodes[1].Nodes[1].IsSelected == true)
                {




                    his.Owner = this;
                    his.ControlBox = false;
                    his.TopLevel = false;
                    his.Text = string.Empty;
                    his.FormBorderStyle = FormBorderStyle.None;
                    his.Dock = DockStyle.Fill;
                    his.AutoSize = false; ;
                    panel1.Visible = true;
                    panel1.Controls.Add(his);
                    his.Show();
                }
                if (uiNavMenu1.Nodes[2].IsSelected == true)
                {

                    this.panel1.Visible = false;
                }
            }
      else  if (ids == 2)
            {
                if (uiNavMenu1.Nodes[0].IsSelected == true)
                {
                    f1.Owner = this;
                    f1.ControlBox = false;
                    f1.TopLevel = false;
                    f1.Text = string.Empty;
                    f1.BackColor = Color.White;
                    f1.FormBorderStyle = FormBorderStyle.None;
                    f1.Dock = DockStyle.Fill;
                    f1.AutoSize = false;
                    f1.lblname.Text = names;
                    panel1.Visible = true;
                    panel1.Controls.Add(f1);
                    f1.Show();
                }
                if (uiNavMenu1.Nodes[1].Nodes[0].IsSelected == true)
                {
                    foodscontrol c1 = new foodscontrol();
                    c1.Owner = this;
                    c1.ControlBox = false;
                    c1.TopLevel = false;
                    c1.Text = string.Empty;
                    c1.BackColor = Color.White;
                    c1.FormBorderStyle = FormBorderStyle.None;
                    c1.Dock = DockStyle.Fill;
                    c1.AutoSize = false;
                    panel1.Visible = true;
                    panel1.Controls.Add(c1);
                    c1.Show();
                }
                if (uiNavMenu1.Nodes[1].Nodes[1].IsSelected == true)
                {

                    add.Owner = this;
                    add.ControlBox = false;
                    add.TopLevel = false;
                    add.Text = string.Empty;
                    add.BackColor = Color.White;
                    add.FormBorderStyle = FormBorderStyle.None;
                    add.Dock = DockStyle.Fill;
                    add.AutoSize = false;
                    panel1.Visible = true;
                    panel1.Controls.Add(add);
                    add.Show();
                }
                if (uiNavMenu1.Nodes[2].IsSelected == true)
                {

                    this.panel1.Visible = false;
                }
            }
          else { 
            if (uiNavMenu1.Nodes[1].Nodes[0].IsSelected == true)
                {
                    foodscontrol c1 = new foodscontrol();
                    c1.Owner = this;
                    c1.ControlBox = false;
                    c1.TopLevel = false;
                    c1.Text = string.Empty;
                    c1.BackColor = Color.White;
                    c1.FormBorderStyle = FormBorderStyle.None;
                    c1.Dock = DockStyle.Fill;
                    c1.AutoSize = false;
                    panel1.Visible = true;
                    panel1.Controls.Add(c1);
                    c1.Show();
                }
                    
            if (uiNavMenu1.Nodes[1].Nodes[1].IsSelected == true)
            {
             
                add.Owner = this;
                add.ControlBox = false;
                add.TopLevel = false;
                add.Text = string.Empty;
                add.BackColor = Color.White;
                add.FormBorderStyle = FormBorderStyle.None;
                add.Dock = DockStyle.Fill;
                add.AutoSize = false;
                panel1.Visible = true;
                panel1.Controls.Add(add);
                add.Show();
            }
            if (uiNavMenu1.Nodes[2].Nodes[0].IsSelected == true)
            {

              
                ordercontrol or = new ordercontrol();
              
                or.Owner = this;
                or.ControlBox = false;
                or.TopLevel = false;
                or.Text = string.Empty;
                or.FormBorderStyle = FormBorderStyle.None;
                or.Dock = DockStyle.Fill;
                or.AutoSize = false; ;
                panel1.Visible = true;
                panel1.Controls.Add(or);
                or.Show();
            }
            if (uiNavMenu1.Nodes[2].Nodes[1].IsSelected == true)
            {

            
               
            
                his.Owner = this;
                his.ControlBox = false;
                his.TopLevel = false;
                his.Text = string.Empty;
                his.FormBorderStyle = FormBorderStyle.None;
                his.Dock = DockStyle.Fill;
                his.AutoSize = false; ;
                panel1.Visible = true;
                panel1.Controls.Add(his);
                his.Show();
            }
                if (uiNavMenu1.Nodes[3].Nodes[2].IsSelected == true)
                {



                    user.Owner = this;
                    user.ControlBox = false;
                    user.TopLevel = false;
                    user.Text = string.Empty;
                    user.FormBorderStyle = FormBorderStyle.None;
                    user.Dock = DockStyle.Fill;
                    user.AutoSize = false; ;
                    panel1.Visible = true;
                    panel1.Controls.Add(user);
                    user.Show();
                }
              if (uiNavMenu1.Nodes[3].Nodes[1].IsSelected == true)
            {


                    vipupdate vi = new vipupdate();
                    
                    vi.Owner = this;
                    vi.ControlBox = false;
                    vi.TopLevel = false;
                    vi.Text = string.Empty;
                    vi.FormBorderStyle = FormBorderStyle.None;
                    vi.Dock = DockStyle.Fill;
                    vi.AutoSize = false; ;
                panel1.Visible = true;
                panel1.Controls.Add(vi);
                    vi.Show();
            }
                if (uiNavMenu1.Nodes[3].Nodes[0].IsSelected == true)
                {


                  
                    deleteuser delete = new deleteuser();
                    delete.Owner = this;
                    delete.ControlBox = false;
                    delete.TopLevel = false;
                    delete.Text = string.Empty;
                    delete.FormBorderStyle = FormBorderStyle.None;
                    delete.Dock = DockStyle.Fill;
                    delete.AutoSize = false; ;
                    panel1.Visible = true;
                    panel1.Controls.Add(delete);
                    delete.Show();
                }
                if (uiNavMenu1.Nodes[4].IsSelected == true)
            {
                    sellcount count = new sellcount();
                    count.Owner = this;
                count.ControlBox = false;
                count.TopLevel = false;
                count.Text = string.Empty;
                count.FormBorderStyle = FormBorderStyle.None;
                count.Dock = DockStyle.Fill;
                count.AutoSize = false; ;
                panel1.Visible = true;
                panel1.Controls.Add(count);
                count.Show();
            }
            if (uiNavMenu1.Nodes[0].IsSelected==true)
            {

              

               

                f1.Owner = this; 
                
                f1.ControlBox = false;
                f1.TopLevel = false;
                f1.Text = string.Empty;
                f1.BackColor = Color.White;
                f1.FormBorderStyle = FormBorderStyle.None;
                f1.Dock = DockStyle.Fill;
                f1.AutoSize = false;
                f1.lblname.Text = names;
                panel1.Visible = true;
                panel1.Controls.Add(f1);
                f1.Show();
            }
            if (uiNavMenu1.Nodes[5].IsSelected == true)
            {

                this.panel1.Visible = false;
            }
            }

        }

        private void uiTitlePanel1_Click(object sender, EventArgs e)
        {

        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
          
         
        
        }

        private void uiButton1_Click_1(object sender, EventArgs e)
        {
            this.uiTitlePanel1.Style = Sunny.UI.UIStyle.Blue;
            this.uiNavMenu1.Style = Sunny.UI.UIStyle.Blue;
            add.uiPanel1.Style = Sunny.UI.UIStyle.Blue;
            f1.uiPanel1.Style = Sunny.UI.UIStyle.Blue;
            or.uiGroupBox1.Style = Sunny.UI.UIStyle.Blue;
          
          
            his.uiDataGridView1.Style = Sunny.UI.UIStyle.Blue;
            his.uiPanel2.Style = Sunny.UI.UIStyle.Blue;
            user.uiPanel1.Style = Sunny.UI.UIStyle.Blue;
            this.uiButton7.Style = Sunny.UI.UIStyle.Blue;
        }

        private void uiButton3_Click(object sender, EventArgs e)
        {
            this.uiButton7.Style = Sunny.UI.UIStyle.Green;
            this.uiTitlePanel1.Style = Sunny.UI.UIStyle.Green;
            this.uiNavMenu1.Style = Sunny.UI.UIStyle.Green;
            add.uiPanel1.Style = Sunny.UI.UIStyle.Green;
            f1.uiPanel1.Style = Sunny.UI.UIStyle.Green;
            or.uiGroupBox1.Style = Sunny.UI.UIStyle.Green;
         
          
            his.uiDataGridView1.Style = Sunny.UI.UIStyle.Green;
            his.uiPanel2.Style = Sunny.UI.UIStyle.Green;
            user.uiPanel1.Style = Sunny.UI.UIStyle.Green;
        }

        private void uiButton5_Click(object sender, EventArgs e)
        {
            this.uiButton7.Style = Sunny.UI.UIStyle.Orange;
            this.uiTitlePanel1.Style = Sunny.UI.UIStyle.Orange;
            this.uiNavMenu1.Style = Sunny.UI.UIStyle.Orange;
            add.uiPanel1.Style = Sunny.UI.UIStyle.Orange;
            or.uiGroupBox1.Style = Sunny.UI.UIStyle.Orange;
          
          
            his.uiDataGridView1.Style = Sunny.UI.UIStyle.Orange;
            his.uiPanel2.Style = Sunny.UI.UIStyle.Orange;
            user.uiPanel1.Style = Sunny.UI.UIStyle.Orange; 
            f1.uiPanel1.Style = Sunny.UI.UIStyle.Orange;
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            this.uiButton7.Style = Sunny.UI.UIStyle.Red;
            f1.uiPanel1.Style = Sunny.UI.UIStyle.Red;
            this.uiTitlePanel1.Style = Sunny.UI.UIStyle.Red;
            this.uiNavMenu1.Style = Sunny.UI.UIStyle.Red;
            add.uiPanel1.Style = Sunny.UI.UIStyle.Red;
            or.uiGroupBox1.Style = Sunny.UI.UIStyle.Red;
          
        
            his.uiDataGridView1.Style = Sunny.UI.UIStyle.Red;
            his.uiPanel2.Style = Sunny.UI.UIStyle.Red;
            user.uiPanel1.Style = Sunny.UI.UIStyle.Red;
        }

        private void uiButton4_Click(object sender, EventArgs e)
        {
            this.uiButton7.Style = Sunny.UI.UIStyle.Office2010Blue;
            f1.uiPanel1.Style = Sunny.UI.UIStyle.Office2010Blue;
            this.uiTitlePanel1.Style = Sunny.UI.UIStyle.Office2010Blue;
            this.uiNavMenu1.Style = Sunny.UI.UIStyle.Office2010Blue;
            add.uiPanel1.Style = Sunny.UI.UIStyle.Office2010Blue;
            or.uiGroupBox1.Style = Sunny.UI.UIStyle.Office2010Blue;
        
         
            his.uiDataGridView1.Style = Sunny.UI.UIStyle.Office2010Blue;
            his.uiPanel2.Style = Sunny.UI.UIStyle.Office2010Blue;
            user.uiPanel1.Style = Sunny.UI.UIStyle.Office2010Blue;
        }

        private void uiButton6_Click(object sender, EventArgs e)
        {
            this.uiButton7.Style = Sunny.UI.UIStyle.Gray;
            f1.uiPanel1.Style = Sunny.UI.UIStyle.Gray;
            this.uiTitlePanel1.Style = Sunny.UI.UIStyle.Gray;
            this.uiNavMenu1.Style = Sunny.UI.UIStyle.Gray;
            add.uiPanel1.Style = Sunny.UI.UIStyle.Gray;
            or.uiGroupBox1.Style = Sunny.UI.UIStyle.Gray;
        
           
            his.uiDataGridView1.Style = Sunny.UI.UIStyle.Gray;
            his.uiPanel2.Style = Sunny.UI.UIStyle.Gray;
            user.uiPanel1.Style = Sunny.UI.UIStyle.Gray;
        }

        private void uiColorPicker1_Click(object sender, EventArgs e)
        {
          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
    
          
        }

        private void uiButton7_Click(object sender, EventArgs e)
        {
            login lo = new login();
            this.Close();
         
              lo.Show();
        }
    }
}
