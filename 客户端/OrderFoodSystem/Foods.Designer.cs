
namespace OrderFoodSystem
{
    partial class Foods
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Foods));
            this.panelnav = new System.Windows.Forms.Panel();
            this.btnmeau = new System.Windows.Forms.Button();
            this.btnimg = new System.Windows.Forms.ImageList(this.components);
            this.btnshopcar = new System.Windows.Forms.Button();
            this.btnYue = new System.Windows.Forms.Button();
            this.btnChuan = new System.Windows.Forms.Button();
            this.btnXiang = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelnav.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelnav
            // 
            this.panelnav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(237)))), ((int)(((byte)(228)))));
            this.panelnav.Controls.Add(this.btnmeau);
            this.panelnav.Controls.Add(this.btnshopcar);
            this.panelnav.Controls.Add(this.btnYue);
            this.panelnav.Controls.Add(this.btnChuan);
            this.panelnav.Controls.Add(this.btnXiang);
            this.panelnav.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelnav.Location = new System.Drawing.Point(0, 0);
            this.panelnav.Name = "panelnav";
            this.panelnav.Size = new System.Drawing.Size(44, 563);
            this.panelnav.TabIndex = 0;
            this.panelnav.Paint += new System.Windows.Forms.PaintEventHandler(this.panelnav_Paint);
            // 
            // btnmeau
            // 
            this.btnmeau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(237)))), ((int)(((byte)(228)))));
            this.btnmeau.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnmeau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmeau.ImageIndex = 4;
            this.btnmeau.ImageList = this.btnimg;
            this.btnmeau.Location = new System.Drawing.Point(3, 12);
            this.btnmeau.Name = "btnmeau";
            this.btnmeau.Size = new System.Drawing.Size(38, 43);
            this.btnmeau.TabIndex = 5;
            this.btnmeau.UseVisualStyleBackColor = false;
            this.btnmeau.Click += new System.EventHandler(this.btnmeau_Click);
            // 
            // btnimg
            // 
            this.btnimg.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("btnimg.ImageStream")));
            this.btnimg.TransparentColor = System.Drawing.Color.Transparent;
            this.btnimg.Images.SetKeyName(0, "confirm.png");
            this.btnimg.Images.SetKeyName(1, "shop-car.png");
            this.btnimg.Images.SetKeyName(2, "confirm (1).png");
            this.btnimg.Images.SetKeyName(3, "shop-car (1).png");
            this.btnimg.Images.SetKeyName(4, "bx-food-menu.png");
            // 
            // btnshopcar
            // 
            this.btnshopcar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnshopcar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(237)))), ((int)(((byte)(228)))));
            this.btnshopcar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnshopcar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnshopcar.ImageIndex = 1;
            this.btnshopcar.ImageList = this.btnimg;
            this.btnshopcar.Location = new System.Drawing.Point(3, 496);
            this.btnshopcar.Name = "btnshopcar";
            this.btnshopcar.Size = new System.Drawing.Size(38, 43);
            this.btnshopcar.TabIndex = 4;
            this.btnshopcar.UseVisualStyleBackColor = false;
            this.btnshopcar.Click += new System.EventHandler(this.btnshopcar_Click);
            // 
            // btnYue
            // 
            this.btnYue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(237)))), ((int)(((byte)(228)))));
            this.btnYue.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnYue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYue.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnYue.ForeColor = System.Drawing.Color.Gray;
            this.btnYue.Location = new System.Drawing.Point(3, 186);
            this.btnYue.Name = "btnYue";
            this.btnYue.Size = new System.Drawing.Size(38, 43);
            this.btnYue.TabIndex = 2;
            this.btnYue.Text = "粤";
            this.btnYue.UseVisualStyleBackColor = false;
            this.btnYue.Click += new System.EventHandler(this.btnYue_Click);
            // 
            // btnChuan
            // 
            this.btnChuan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(237)))), ((int)(((byte)(228)))));
            this.btnChuan.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnChuan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChuan.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnChuan.ForeColor = System.Drawing.Color.Gray;
            this.btnChuan.Location = new System.Drawing.Point(3, 128);
            this.btnChuan.Name = "btnChuan";
            this.btnChuan.Size = new System.Drawing.Size(38, 43);
            this.btnChuan.TabIndex = 1;
            this.btnChuan.Text = "川";
            this.btnChuan.UseVisualStyleBackColor = false;
            this.btnChuan.Click += new System.EventHandler(this.btnChuan_Click);
            // 
            // btnXiang
            // 
            this.btnXiang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(237)))), ((int)(((byte)(228)))));
            this.btnXiang.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnXiang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXiang.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnXiang.ForeColor = System.Drawing.Color.Gray;
            this.btnXiang.Location = new System.Drawing.Point(3, 70);
            this.btnXiang.Name = "btnXiang";
            this.btnXiang.Size = new System.Drawing.Size(38, 43);
            this.btnXiang.TabIndex = 0;
            this.btnXiang.Text = "湘";
            this.btnXiang.UseVisualStyleBackColor = false;
            this.btnXiang.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(44, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1103, 563);
            this.flowLayoutPanel1.TabIndex = 1;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // Foods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1147, 563);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panelnav);
            this.Name = "Foods";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Foods_Load);
            this.panelnav.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelnav;
        private System.Windows.Forms.Button btnYue;
        private System.Windows.Forms.Button btnChuan;
        private System.Windows.Forms.Button btnXiang;
        private System.Windows.Forms.Button btnshopcar;
        private System.Windows.Forms.ImageList btnimg;
        private System.Windows.Forms.Button btnmeau;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}