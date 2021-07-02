using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderFoodSystem
{
    public partial class loadingform : Form
    {
        public loadingform()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            panel3.Width += 4;
            if (panel3.Width >= 700)
            {
                timer1.Stop();
                chosetable co = new chosetable();
                this.Hide();
                co.ShowDialog();
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    }
