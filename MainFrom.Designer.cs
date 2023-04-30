
namespace CPU_Processing
{
    partial class MainFrom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrom));
            this.btn_sjfs = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_srfs = new System.Windows.Forms.Button();
            this.lb_tieude = new System.Windows.Forms.Label();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_rrs = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_sjfs
            // 
            this.btn_sjfs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_sjfs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_sjfs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sjfs.ImageIndex = 0;
            this.btn_sjfs.ImageList = this.imageList1;
            this.btn_sjfs.Location = new System.Drawing.Point(128, 160);
            this.btn_sjfs.Name = "btn_sjfs";
            this.btn_sjfs.Size = new System.Drawing.Size(141, 71);
            this.btn_sjfs.TabIndex = 0;
            this.btn_sjfs.Text = "SJFS";
            this.btn_sjfs.UseVisualStyleBackColor = false;
            this.btn_sjfs.Click += new System.EventHandler(this.btn_sjfs_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "add-button.png");
            this.imageList1.Images.SetKeyName(1, "add-to-cart.png");
            this.imageList1.Images.SetKeyName(2, "book.png");
            this.imageList1.Images.SetKeyName(3, "delete.png");
            this.imageList1.Images.SetKeyName(4, "file.png");
            this.imageList1.Images.SetKeyName(5, "filter.png");
            this.imageList1.Images.SetKeyName(6, "logout.png");
            this.imageList1.Images.SetKeyName(7, "pencil.png");
            this.imageList1.Images.SetKeyName(8, "setting.png");
            this.imageList1.Images.SetKeyName(9, "star.png");
            // 
            // btn_srfs
            // 
            this.btn_srfs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_srfs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_srfs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_srfs.ImageIndex = 0;
            this.btn_srfs.ImageList = this.imageList1;
            this.btn_srfs.Location = new System.Drawing.Point(328, 160);
            this.btn_srfs.Name = "btn_srfs";
            this.btn_srfs.Size = new System.Drawing.Size(141, 71);
            this.btn_srfs.TabIndex = 1;
            this.btn_srfs.Text = "SRFS";
            this.btn_srfs.UseVisualStyleBackColor = false;
            this.btn_srfs.Click += new System.EventHandler(this.btn_srfs_Click);
            // 
            // lb_tieude
            // 
            this.lb_tieude.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_tieude.AutoSize = true;
            this.lb_tieude.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tieude.Location = new System.Drawing.Point(131, 21);
            this.lb_tieude.Name = "lb_tieude";
            this.lb_tieude.Size = new System.Drawing.Size(661, 38);
            this.lb_tieude.TabIndex = 2;
            this.lb_tieude.Text = "BẠN MUỐN SỬ DỤNG GIẢI THUẬT NÀO";
            this.lb_tieude.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_thoat
            // 
            this.btn_thoat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_thoat.BackColor = System.Drawing.Color.Transparent;
            this.btn_thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_thoat.ImageIndex = 6;
            this.btn_thoat.ImageList = this.imageList1;
            this.btn_thoat.Location = new System.Drawing.Point(305, 274);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(181, 45);
            this.btn_thoat.TabIndex = 3;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = false;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.lb_tieude);
            this.panel1.Location = new System.Drawing.Point(-9, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(815, 80);
            this.panel1.TabIndex = 4;
            // 
            // btn_rrs
            // 
            this.btn_rrs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_rrs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_rrs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_rrs.ImageIndex = 0;
            this.btn_rrs.ImageList = this.imageList1;
            this.btn_rrs.Location = new System.Drawing.Point(528, 160);
            this.btn_rrs.Name = "btn_rrs";
            this.btn_rrs.Size = new System.Drawing.Size(141, 71);
            this.btn_rrs.TabIndex = 1;
            this.btn_rrs.Text = "RRS";
            this.btn_rrs.UseVisualStyleBackColor = false;
            this.btn_rrs.Click += new System.EventHandler(this.btn_rrs_Click);
            // 
            // MainFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(796, 368);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_rrs);
            this.Controls.Add(this.btn_srfs);
            this.Controls.Add(this.btn_sjfs);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "MainFrom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_sjfs;
        private System.Windows.Forms.Button btn_srfs;
        private System.Windows.Forms.Label lb_tieude;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btn_rrs;
    }
}

