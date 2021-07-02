
namespace OrderFoodSystem
{
    partial class Mainform
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainform));
            this.panelOption = new System.Windows.Forms.Panel();
            this.btnCloseOrder = new System.Windows.Forms.Button();
            this.imgbtn = new System.Windows.Forms.ImageList(this.components);
            this.btnFoodsbag = new System.Windows.Forms.Button();
            this.btnFoods = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelmenubar = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnmenu = new System.Windows.Forms.Button();
            this.btnnarrow = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.btncexit = new System.Windows.Forms.Button();
            this.paneltop = new System.Windows.Forms.Panel();
            this.panelmain = new System.Windows.Forms.Panel();
            this.panelOption.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelmenubar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelOption
            // 
            this.panelOption.BackColor = System.Drawing.Color.White;
            this.panelOption.Controls.Add(this.btnCloseOrder);
            this.panelOption.Controls.Add(this.btnFoodsbag);
            this.panelOption.Controls.Add(this.btnFoods);
            this.panelOption.Controls.Add(this.pictureBox1);
            this.panelOption.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelOption.Location = new System.Drawing.Point(0, 0);
            this.panelOption.Name = "panelOption";
            this.panelOption.Size = new System.Drawing.Size(200, 679);
            this.panelOption.TabIndex = 0;
            // 
            // btnCloseOrder
            // 
            this.btnCloseOrder.BackColor = System.Drawing.Color.White;
            this.btnCloseOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCloseOrder.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCloseOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseOrder.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCloseOrder.ImageIndex = 2;
            this.btnCloseOrder.ImageList = this.imgbtn;
            this.btnCloseOrder.Location = new System.Drawing.Point(0, 425);
            this.btnCloseOrder.Name = "btnCloseOrder";
            this.btnCloseOrder.Size = new System.Drawing.Size(200, 109);
            this.btnCloseOrder.TabIndex = 3;
            this.btnCloseOrder.Text = "结算订单";
            this.btnCloseOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCloseOrder.UseVisualStyleBackColor = false;
            this.btnCloseOrder.Click += new System.EventHandler(this.btnCloseOrder_Click);
            // 
            // imgbtn
            // 
            this.imgbtn.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgbtn.ImageStream")));
            this.imgbtn.TransparentColor = System.Drawing.Color.Transparent;
            this.imgbtn.Images.SetKeyName(0, "food (7).png");
            this.imgbtn.Images.SetKeyName(1, "shop-cart-4.png");
            this.imgbtn.Images.SetKeyName(2, "money (2).png");
            this.imgbtn.Images.SetKeyName(3, "tools (1).png");
            this.imgbtn.Images.SetKeyName(4, "food (4).png");
            this.imgbtn.Images.SetKeyName(5, "money (3).png");
            this.imgbtn.Images.SetKeyName(6, "shop-cart-4 (1).png");
            this.imgbtn.Images.SetKeyName(7, "tools.png");
            // 
            // btnFoodsbag
            // 
            this.btnFoodsbag.BackColor = System.Drawing.Color.White;
            this.btnFoodsbag.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFoodsbag.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFoodsbag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFoodsbag.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnFoodsbag.ImageIndex = 1;
            this.btnFoodsbag.ImageList = this.imgbtn;
            this.btnFoodsbag.Location = new System.Drawing.Point(0, 316);
            this.btnFoodsbag.Name = "btnFoodsbag";
            this.btnFoodsbag.Size = new System.Drawing.Size(200, 109);
            this.btnFoodsbag.TabIndex = 2;
            this.btnFoodsbag.Text = "查看餐袋";
            this.btnFoodsbag.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFoodsbag.UseVisualStyleBackColor = false;
            this.btnFoodsbag.Click += new System.EventHandler(this.btnFoodsbag_Click);
            // 
            // btnFoods
            // 
            this.btnFoods.BackColor = System.Drawing.Color.White;
            this.btnFoods.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFoods.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFoods.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFoods.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnFoods.ImageIndex = 0;
            this.btnFoods.ImageList = this.imgbtn;
            this.btnFoods.Location = new System.Drawing.Point(0, 194);
            this.btnFoods.Name = "btnFoods";
            this.btnFoods.Size = new System.Drawing.Size(200, 122);
            this.btnFoods.TabIndex = 1;
            this.btnFoods.Text = "全部菜品";
            this.btnFoods.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFoods.UseVisualStyleBackColor = false;
            this.btnFoods.Click += new System.EventHandler(this.btnFoods_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 194);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelmenubar
            // 
            this.panelmenubar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.panelmenubar.Controls.Add(this.panel1);
            this.panelmenubar.Controls.Add(this.btnmenu);
            this.panelmenubar.Controls.Add(this.btnnarrow);
            this.panelmenubar.Controls.Add(this.btnMax);
            this.panelmenubar.Controls.Add(this.btncexit);
            this.panelmenubar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelmenubar.Location = new System.Drawing.Point(200, 0);
            this.panelmenubar.Name = "panelmenubar";
            this.panelmenubar.Size = new System.Drawing.Size(1190, 44);
            this.panelmenubar.TabIndex = 1;
            this.panelmenubar.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            this.panelmenubar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelmenubar_MouseDown_1);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(6, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 3;
            // 
            // btnmenu
            // 
            this.btnmenu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.btnmenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmenu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnmenu.Image = ((System.Drawing.Image)(resources.GetObject("btnmenu.Image")));
            this.btnmenu.Location = new System.Drawing.Point(0, 0);
            this.btnmenu.Name = "btnmenu";
            this.btnmenu.Size = new System.Drawing.Size(50, 41);
            this.btnmenu.TabIndex = 3;
            this.btnmenu.UseVisualStyleBackColor = true;
            this.btnmenu.Click += new System.EventHandler(this.btnmenu_Click);
            // 
            // btnnarrow
            // 
            this.btnnarrow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnnarrow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.btnnarrow.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.btnnarrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnarrow.Image = ((System.Drawing.Image)(resources.GetObject("btnnarrow.Image")));
            this.btnnarrow.Location = new System.Drawing.Point(1100, 0);
            this.btnnarrow.Name = "btnnarrow";
            this.btnnarrow.Size = new System.Drawing.Size(26, 23);
            this.btnnarrow.TabIndex = 2;
            this.btnnarrow.UseVisualStyleBackColor = false;
            this.btnnarrow.Click += new System.EventHandler(this.btnnarrow_Click);
            // 
            // btnMax
            // 
            this.btnMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.btnMax.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMax.Image = ((System.Drawing.Image)(resources.GetObject("btnMax.Image")));
            this.btnMax.Location = new System.Drawing.Point(1132, 0);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(26, 23);
            this.btnMax.TabIndex = 1;
            this.btnMax.UseVisualStyleBackColor = false;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btncexit
            // 
            this.btncexit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btncexit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.btncexit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.btncexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncexit.ForeColor = System.Drawing.Color.White;
            this.btncexit.Image = ((System.Drawing.Image)(resources.GetObject("btncexit.Image")));
            this.btncexit.Location = new System.Drawing.Point(1164, 0);
            this.btncexit.Name = "btncexit";
            this.btncexit.Size = new System.Drawing.Size(26, 23);
            this.btncexit.TabIndex = 0;
            this.btncexit.UseVisualStyleBackColor = false;
            this.btncexit.Click += new System.EventHandler(this.btncexit_Click);
            // 
            // paneltop
            // 
            this.paneltop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.paneltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltop.Location = new System.Drawing.Point(200, 44);
            this.paneltop.Name = "paneltop";
            this.paneltop.Size = new System.Drawing.Size(1190, 20);
            this.paneltop.TabIndex = 3;
            // 
            // panelmain
            // 
            this.panelmain.BackColor = System.Drawing.Color.White;
            this.panelmain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelmain.Location = new System.Drawing.Point(200, 64);
            this.panelmain.Name = "panelmain";
            this.panelmain.Size = new System.Drawing.Size(1190, 615);
            this.panelmain.TabIndex = 4;
            this.panelmain.Paint += new System.Windows.Forms.PaintEventHandler(this.panelmain_Paint);
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1390, 679);
            this.Controls.Add(this.panelmain);
            this.Controls.Add(this.paneltop);
            this.Controls.Add(this.panelmenubar);
            this.Controls.Add(this.panelOption);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Mainform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "点餐系统";
            this.Load += new System.EventHandler(this.Mainform_Load);
            this.panelOption.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelmenubar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelOption;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCloseOrder;
        private System.Windows.Forms.Button btnFoodsbag;
        private System.Windows.Forms.Button btnFoods;
        private System.Windows.Forms.Button btnmenu;
        private System.Windows.Forms.Button btnnarrow;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btncexit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelmain;
        private System.Windows.Forms.ImageList imgbtn;
        public System.Windows.Forms.Panel panelmenubar;
        public System.Windows.Forms.Panel paneltop;
    }
}

