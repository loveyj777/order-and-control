
namespace OrderFoodSystem
{
    partial class shopcar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);

        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(shopcar));
            this.button1 = new System.Windows.Forms.Button();
            this.lblprice = new System.Windows.Forms.Label();
            this.lblmoney = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnminisize = new System.Windows.Forms.Button();
            this.btnmaxsize = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(207)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(997, 441);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "返回";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblprice
            // 
            this.lblprice.AutoSize = true;
            this.lblprice.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblprice.ForeColor = System.Drawing.Color.Red;
            this.lblprice.Location = new System.Drawing.Point(816, 443);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(72, 27);
            this.lblprice.TabIndex = 2;
            this.lblprice.Text = "金额：";
            // 
            // lblmoney
            // 
            this.lblmoney.AutoSize = true;
            this.lblmoney.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblmoney.Location = new System.Drawing.Point(883, 450);
            this.lblmoney.Name = "lblmoney";
            this.lblmoney.Size = new System.Drawing.Size(0, 16);
            this.lblmoney.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.panel1.Controls.Add(this.btnminisize);
            this.panel1.Controls.Add(this.btnmaxsize);
            this.panel1.Controls.Add(this.btnexit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1109, 36);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // btnminisize
            // 
            this.btnminisize.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(207)))));
            this.btnminisize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnminisize.Image = ((System.Drawing.Image)(resources.GetObject("btnminisize.Image")));
            this.btnminisize.Location = new System.Drawing.Point(1019, 0);
            this.btnminisize.Name = "btnminisize";
            this.btnminisize.Size = new System.Drawing.Size(26, 23);
            this.btnminisize.TabIndex = 2;
            this.btnminisize.UseVisualStyleBackColor = true;
            this.btnminisize.Click += new System.EventHandler(this.btnminisize_Click);
            // 
            // btnmaxsize
            // 
            this.btnmaxsize.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(207)))));
            this.btnmaxsize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmaxsize.Image = ((System.Drawing.Image)(resources.GetObject("btnmaxsize.Image")));
            this.btnmaxsize.Location = new System.Drawing.Point(1051, 0);
            this.btnmaxsize.Name = "btnmaxsize";
            this.btnmaxsize.Size = new System.Drawing.Size(26, 23);
            this.btnmaxsize.TabIndex = 1;
            this.btnmaxsize.UseVisualStyleBackColor = true;
            this.btnmaxsize.Click += new System.EventHandler(this.btnmaxsize_Click);
            // 
            // btnexit
            // 
            this.btnexit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(207)))));
            this.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexit.Image = ((System.Drawing.Image)(resources.GetObject("btnexit.Image")));
            this.btnexit.Location = new System.Drawing.Point(1083, 0);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(26, 23);
            this.btnexit.TabIndex = 0;
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 36);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1109, 399);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // shopcar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1109, 487);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblmoney);
            this.Controls.Add(this.lblprice);
            this.Controls.Add(this.button1);
            this.Name = "shopcar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "shopcar";
            this.Load += new System.EventHandler(this.shopcar_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblprice;
        private System.Windows.Forms.Label lblmoney;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnminisize;
        private System.Windows.Forms.Button btnmaxsize;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Timer timer1;
    }
}