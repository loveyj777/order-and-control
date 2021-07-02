
namespace FoodControlManager
{
    partial class foodsadd
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
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.combotype = new Sunny.UI.UIComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.txtfile = new Sunny.UI.UITextBox();
            this.uiButton3 = new Sunny.UI.UIButton();
            this.uiButton2 = new Sunny.UI.UIButton();
            this.uiButton1 = new Sunny.UI.UIButton();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.txtprice = new Sunny.UI.UITextBox();
            this.txtfname = new Sunny.UI.UITextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.uiPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiLabel1
            // 
            this.uiLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uiLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel1.Location = new System.Drawing.Point(144, 153);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(100, 23);
            this.uiLabel1.TabIndex = 0;
            this.uiLabel1.Text = "菜品名称:";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel2
            // 
            this.uiLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uiLabel2.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel2.Location = new System.Drawing.Point(144, 235);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(100, 23);
            this.uiLabel2.TabIndex = 1;
            this.uiLabel2.Text = "菜品单价:";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel2.Click += new System.EventHandler(this.uiLabel2_Click);
            // 
            // combotype
            // 
            this.combotype.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.combotype.FillColor = System.Drawing.Color.White;
            this.combotype.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.combotype.Items.AddRange(new object[] {
            "湘",
            "粤",
            "川"});
            this.combotype.Location = new System.Drawing.Point(226, 316);
            this.combotype.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.combotype.MinimumSize = new System.Drawing.Size(63, 0);
            this.combotype.Name = "combotype";
            this.combotype.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.combotype.Size = new System.Drawing.Size(150, 29);
            this.combotype.TabIndex = 2;
            this.combotype.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Location = new System.Drawing.Point(572, 110);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 198);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // uiLabel3
            // 
            this.uiLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uiLabel3.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel3.Location = new System.Drawing.Point(466, 110);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(100, 23);
            this.uiLabel3.TabIndex = 4;
            this.uiLabel3.Text = "菜品图片:";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiPanel1
            // 
            this.uiPanel1.Controls.Add(this.txtfile);
            this.uiPanel1.Controls.Add(this.combotype);
            this.uiPanel1.Controls.Add(this.uiButton3);
            this.uiPanel1.Controls.Add(this.uiButton2);
            this.uiPanel1.Controls.Add(this.uiButton1);
            this.uiPanel1.Controls.Add(this.uiLabel5);
            this.uiPanel1.Controls.Add(this.uiLabel4);
            this.uiPanel1.Controls.Add(this.txtprice);
            this.uiPanel1.Controls.Add(this.txtfname);
            this.uiPanel1.Controls.Add(this.uiLabel1);
            this.uiPanel1.Controls.Add(this.pictureBox1);
            this.uiPanel1.Controls.Add(this.uiLabel3);
            this.uiPanel1.Controls.Add(this.uiLabel2);
            this.uiPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiPanel1.Location = new System.Drawing.Point(0, 0);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Size = new System.Drawing.Size(1028, 559);
            this.uiPanel1.TabIndex = 5;
            this.uiPanel1.Text = null;
            this.uiPanel1.Click += new System.EventHandler(this.uiPanel1_Click);
            // 
            // txtfile
            // 
            this.txtfile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtfile.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtfile.FillColor = System.Drawing.Color.White;
            this.txtfile.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtfile.Location = new System.Drawing.Point(572, 316);
            this.txtfile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtfile.Maximum = 2147483647D;
            this.txtfile.Minimum = -2147483648D;
            this.txtfile.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtfile.Name = "txtfile";
            this.txtfile.Padding = new System.Windows.Forms.Padding(5);
            this.txtfile.Size = new System.Drawing.Size(268, 29);
            this.txtfile.TabIndex = 7;
            // 
            // uiButton3
            // 
            this.uiButton3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uiButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiButton3.Location = new System.Drawing.Point(546, 395);
            this.uiButton3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton3.Name = "uiButton3";
            this.uiButton3.Size = new System.Drawing.Size(100, 35);
            this.uiButton3.TabIndex = 12;
            this.uiButton3.Text = "清空";
            this.uiButton3.Click += new System.EventHandler(this.uiButton3_Click);
            // 
            // uiButton2
            // 
            this.uiButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uiButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiButton2.Location = new System.Drawing.Point(327, 395);
            this.uiButton2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton2.Name = "uiButton2";
            this.uiButton2.Size = new System.Drawing.Size(100, 35);
            this.uiButton2.TabIndex = 11;
            this.uiButton2.Text = "添加";
            this.uiButton2.Click += new System.EventHandler(this.uiButton2_Click);
            // 
            // uiButton1
            // 
            this.uiButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiButton1.Location = new System.Drawing.Point(847, 316);
            this.uiButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.Size = new System.Drawing.Size(100, 35);
            this.uiButton1.TabIndex = 10;
            this.uiButton1.Text = "选择图片";
            this.uiButton1.Click += new System.EventHandler(this.uiButton1_Click);
            // 
            // uiLabel5
            // 
            this.uiLabel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uiLabel5.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel5.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel5.Location = new System.Drawing.Point(491, 322);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(100, 23);
            this.uiLabel5.TabIndex = 9;
            this.uiLabel5.Text = "图片路径:";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel5.Click += new System.EventHandler(this.uiLabel5_Click);
            // 
            // uiLabel4
            // 
            this.uiLabel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uiLabel4.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel4.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel4.Location = new System.Drawing.Point(144, 322);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(100, 23);
            this.uiLabel4.TabIndex = 8;
            this.uiLabel4.Text = "菜品类型:";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtprice
            // 
            this.txtprice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtprice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtprice.FillColor = System.Drawing.Color.White;
            this.txtprice.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtprice.Location = new System.Drawing.Point(226, 229);
            this.txtprice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtprice.Maximum = 2147483647D;
            this.txtprice.Minimum = -2147483648D;
            this.txtprice.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtprice.Name = "txtprice";
            this.txtprice.Padding = new System.Windows.Forms.Padding(5);
            this.txtprice.Size = new System.Drawing.Size(150, 29);
            this.txtprice.TabIndex = 6;
            this.txtprice.Text = "0";
            this.txtprice.Type = Sunny.UI.UITextBox.UIEditType.Integer;
            // 
            // txtfname
            // 
            this.txtfname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtfname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtfname.FillColor = System.Drawing.Color.White;
            this.txtfname.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtfname.Location = new System.Drawing.Point(226, 152);
            this.txtfname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtfname.Maximum = 2147483647D;
            this.txtfname.Minimum = -2147483648D;
            this.txtfname.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtfname.Name = "txtfname";
            this.txtfname.Padding = new System.Windows.Forms.Padding(5);
            this.txtfname.Size = new System.Drawing.Size(150, 29);
            this.txtfname.TabIndex = 5;
            // 
            // foodsadd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 559);
            this.Controls.Add(this.uiPanel1);
            this.Name = "foodsadd";
            this.Text = "foodsadd";
            this.Load += new System.EventHandler(this.foodsadd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.uiPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UIComboBox combotype;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UITextBox txtfile;
        private Sunny.UI.UITextBox txtprice;
        private Sunny.UI.UITextBox txtfname;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UIButton uiButton3;
        private Sunny.UI.UIButton uiButton2;
        private Sunny.UI.UIButton uiButton1;
        public Sunny.UI.UIPanel uiPanel1;
    }
}