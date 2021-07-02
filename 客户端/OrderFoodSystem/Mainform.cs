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
using FontAwesome;
using MyCj;

namespace OrderFoodSystem
{
    public partial class Mainform : Form
    {
        int table1;
        public Mainform(int table)
        {
            table1 = table;
            InitializeComponent();
        }

        private void Mainform_Load(object sender, EventArgs e)
        {
            
           this.Text = string.Empty;
           this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.None;
           this.DoubleBuffered = true;

            indexform i1 = new indexform();
            i1.TopLevel = false;
            i1.Text = string.Empty;
            i1.ControlBox = false;
            i1.FormBorderStyle = FormBorderStyle.None;
            i1.Dock = DockStyle.Fill;
            panelmain.Controls.Add(i1);
            i1.Show();
           
        } 


        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        //formexit
        private void btncexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //formmaxsized
        private void btnMax_Click(object sender, EventArgs e)
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

        //formminisized
        private void btnnarrow_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }


        #region 窗体拖动
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]

        private extern static void ReleaseCapture();

       [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);



        private void panelmenubar_MouseDown_1(object sender, MouseEventArgs e)
        {
        ReleaseCapture();
           SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion 

        private void btnFoods_Click(object sender, EventArgs e)
        {

           
           
            

            Foods f1 = new Foods();
            Foods.tabid = table1;
            f1.ControlBox = false;
            f1.TopLevel = false;
            f1.Text = string.Empty;
            f1.BackColor = Color.White;
            f1.FormBorderStyle = FormBorderStyle.None;
            f1.Dock = DockStyle.Fill;
            f1.AutoSize = false;

        
           
            
           

            this.btnFoods.ImageIndex = 4;
            this.btnFoods.TextImageRelation = TextImageRelation.TextBeforeImage;

            if (btnFoodsbag.TextImageRelation == TextImageRelation.TextBeforeImage)
            {
                btnFoodsbag.ImageIndex = 1;
                btnFoodsbag.TextImageRelation = TextImageRelation.ImageBeforeText;
                
            }
            else if (btnCloseOrder.TextImageRelation == TextImageRelation.TextBeforeImage)
            {
                btnCloseOrder.ImageIndex = 2;
                btnCloseOrder.TextImageRelation = TextImageRelation.ImageBeforeText;
                
            }
         


            if (panelmain.Controls.Count > 0)
            {

                panelmain.Controls.Clear();


                this.panelmain.Controls.Add(f1);
                f1.Show();
            }
            else
            {

                this.panelmain.Controls.Add(f1);
                f1.Show();
                
            }
        }

        private void panelmain_Paint(object sender, PaintEventArgs e)
        {
         
        }

        private void btnFoodsbag_Click(object sender, EventArgs e)
        {
           
            orderfoods o1 = new orderfoods(table1);
            o1.ControlBox = false;
            o1.TopLevel = false;
            o1.Text = string.Empty;
            o1.BackColor = Color.White;
            o1.FormBorderStyle = FormBorderStyle.None;
            o1.Dock = DockStyle.Fill;

            this.btnFoodsbag.ImageIndex = 6;
             this.btnFoodsbag.TextImageRelation = TextImageRelation.TextBeforeImage;

            if (btnFoods.TextImageRelation == TextImageRelation.TextBeforeImage)
            {
                btnFoods.ImageIndex = 0;
                btnFoods.TextImageRelation = TextImageRelation.ImageBeforeText;

            }
            else if (btnCloseOrder.TextImageRelation == TextImageRelation.TextBeforeImage)
            {
                btnCloseOrder.ImageIndex = 2;
                btnCloseOrder.TextImageRelation = TextImageRelation.ImageBeforeText;

            }
         


            if (panelmain.Controls.Count > 0)
            {

                panelmain.Controls.Clear();

                this.panelmain.Controls.Add(o1);
                o1.Show();
            }
            else
            {

                this.panelmain.Controls.Add(o1);
                o1.Show();

            }

        }

        private void btnCloseOrder_Click(object sender, EventArgs e)
        {
            
            closeorder c1 = new closeorder();

            c1.ControlBox = false;
            c1.TopLevel = false;
            c1.Text = string.Empty;
            c1.BackColor = Color.White;
            c1.FormBorderStyle = FormBorderStyle.None;
            c1.Dock = DockStyle.Fill;

            this.btnCloseOrder.ImageIndex   = 5;
             this.btnCloseOrder.TextImageRelation = TextImageRelation.TextBeforeImage;


            if (btnFoodsbag.TextImageRelation == TextImageRelation.TextBeforeImage)
            {
                btnFoodsbag.ImageIndex = 1;
                btnFoodsbag.TextImageRelation = TextImageRelation.ImageBeforeText;

            }
            else if (btnFoods.TextImageRelation == TextImageRelation.TextBeforeImage)
            {
                btnFoods.ImageIndex = 0;
                btnFoods.TextImageRelation = TextImageRelation.ImageBeforeText;

            }
          



            if (panelmain.Controls.Count > 0)
            {

                panelmain.Controls.Clear();

              
                this.panelmain.Controls.Add(c1);
                c1.Show();
            }
            else
            {

                this.panelmain.Controls.Add(c1);
                c1.Show();

            }
        }

        
        private void timerNowTime_Tick(object sender, EventArgs e)
        {
          
        }

        private void lblwelcome_Click(object sender, EventArgs e)
        {

        }

        private void btnmenu_Click(object sender, EventArgs e)
        {

            if (panelmain.Controls.Count > 0)
            {
                panelmain.Controls.Clear();

             indexform i1 = new indexform();
                i1.TopLevel = false;
                i1.Text = string.Empty;
                i1.ControlBox = false;
                i1.FormBorderStyle = FormBorderStyle.None;
             i1.Dock = DockStyle.Fill;
                panelmain.Controls.Add(i1);
             i1.Show();
            }

            if (btnFoodsbag.TextImageRelation == TextImageRelation.TextBeforeImage)
            {
                btnFoodsbag.ImageIndex = 1;
                btnFoodsbag.TextImageRelation = TextImageRelation.ImageBeforeText;

            }
            else if (btnCloseOrder.TextImageRelation == TextImageRelation.TextBeforeImage)
            {
                btnCloseOrder.ImageIndex = 2;
                btnCloseOrder.TextImageRelation = TextImageRelation.ImageBeforeText;

            }
            else if (btnFoods.TextImageRelation == TextImageRelation.TextBeforeImage)
            {
                btnFoods.ImageIndex = 0;
                btnFoods.TextImageRelation = TextImageRelation.ImageBeforeText;
            }
       



       

        }

        }
    
}
