﻿
namespace CPU_Processing
{
    partial class SRFS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SRFS));
            this.dataview_input = new System.Windows.Forms.DataGridView();
            this.column_tientrinh1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_thoidiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_khoancpu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_thoigiancho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataview_output = new System.Windows.Forms.DataGridView();
            this.column_tientrinh2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_thoigianxuathien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_thoigianketthuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_thoigianhoanthanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_them = new System.Windows.Forms.Button();
            this.lb_tientrinh = new System.Windows.Forms.Label();
            this.lb_tgctbkq = new System.Windows.Forms.Label();
            this.lb_tgctb = new System.Windows.Forms.Label();
            this.lb_tghtcbkq = new System.Windows.Forms.Label();
            this.lb_tghtcb = new System.Windows.Forms.Label();
            this.txt_khoancpu = new System.Windows.Forms.TextBox();
            this.lb_khoancpu = new System.Windows.Forms.Label();
            this.btn_ketqua = new System.Windows.Forms.Button();
            this.txt_thoidiem = new System.Windows.Forms.TextBox();
            this.lb_thoidiem = new System.Windows.Forms.Label();
            this.btn_reset = new System.Windows.Forms.Button();
            this.txt_tientrinh = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataview_input)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataview_output)).BeginInit();
            this.SuspendLayout();
            // 
            // dataview_input
            // 
            this.dataview_input.AllowUserToAddRows = false;
            this.dataview_input.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataview_input.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataview_input.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataview_input.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.column_tientrinh1,
            this.column_thoidiem,
            this.column_khoancpu});
            this.dataview_input.Location = new System.Drawing.Point(561, 43);
            this.dataview_input.Name = "dataview_input";
            this.dataview_input.ReadOnly = true;
            this.dataview_input.RowHeadersWidth = 51;
            this.dataview_input.RowTemplate.Height = 24;
            this.dataview_input.Size = new System.Drawing.Size(627, 204);
            this.dataview_input.TabIndex = 77;
            // 
            // column_tientrinh1
            // 
            this.column_tientrinh1.HeaderText = "Tiến Trình";
            this.column_tientrinh1.MinimumWidth = 6;
            this.column_tientrinh1.Name = "column_tientrinh1";
            this.column_tientrinh1.ReadOnly = true;
            this.column_tientrinh1.Width = 125;
            // 
            // column_thoidiem
            // 
            this.column_thoidiem.HeaderText = "Thời Điểm";
            this.column_thoidiem.MinimumWidth = 6;
            this.column_thoidiem.Name = "column_thoidiem";
            this.column_thoidiem.ReadOnly = true;
            this.column_thoidiem.Width = 125;
            // 
            // column_khoancpu
            // 
            this.column_khoancpu.HeaderText = "Khoản CPU";
            this.column_khoancpu.MinimumWidth = 6;
            this.column_khoancpu.Name = "column_khoancpu";
            this.column_khoancpu.ReadOnly = true;
            this.column_khoancpu.Width = 125;
            // 
            // column_thoigiancho
            // 
            this.column_thoigiancho.HeaderText = "Thời Gian Chờ";
            this.column_thoigiancho.MinimumWidth = 6;
            this.column_thoigiancho.Name = "column_thoigiancho";
            this.column_thoigiancho.ReadOnly = true;
            this.column_thoigiancho.Width = 125;
            // 
            // dataview_output
            // 
            this.dataview_output.AllowUserToAddRows = false;
            this.dataview_output.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataview_output.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataview_output.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataview_output.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.column_tientrinh2,
            this.column_thoigianxuathien,
            this.column_thoigianketthuc,
            this.column_thoigianhoanthanh,
            this.column_thoigiancho});
            this.dataview_output.Location = new System.Drawing.Point(219, 265);
            this.dataview_output.Name = "dataview_output";
            this.dataview_output.ReadOnly = true;
            this.dataview_output.RowHeadersWidth = 51;
            this.dataview_output.RowTemplate.Height = 24;
            this.dataview_output.Size = new System.Drawing.Size(970, 220);
            this.dataview_output.TabIndex = 78;
            // 
            // column_tientrinh2
            // 
            this.column_tientrinh2.HeaderText = "Tiến Trình";
            this.column_tientrinh2.MinimumWidth = 6;
            this.column_tientrinh2.Name = "column_tientrinh2";
            this.column_tientrinh2.ReadOnly = true;
            this.column_tientrinh2.Width = 125;
            // 
            // column_thoigianxuathien
            // 
            this.column_thoigianxuathien.HeaderText = "Thời Gian Xuất Hiện";
            this.column_thoigianxuathien.MinimumWidth = 6;
            this.column_thoigianxuathien.Name = "column_thoigianxuathien";
            this.column_thoigianxuathien.ReadOnly = true;
            this.column_thoigianxuathien.Width = 150;
            // 
            // column_thoigianketthuc
            // 
            this.column_thoigianketthuc.HeaderText = "Thời Gian Kết Thúc";
            this.column_thoigianketthuc.MinimumWidth = 6;
            this.column_thoigianketthuc.Name = "column_thoigianketthuc";
            this.column_thoigianketthuc.ReadOnly = true;
            this.column_thoigianketthuc.Width = 150;
            // 
            // column_thoigianhoanthanh
            // 
            this.column_thoigianhoanthanh.HeaderText = "Thời Gian Hoàn Thành";
            this.column_thoigianhoanthanh.MinimumWidth = 6;
            this.column_thoigianhoanthanh.Name = "column_thoigianhoanthanh";
            this.column_thoigianhoanthanh.ReadOnly = true;
            this.column_thoigianhoanthanh.Width = 150;
            // 
            // btn_them
            // 
            this.btn_them.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.Location = new System.Drawing.Point(59, 213);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(86, 34);
            this.btn_them.TabIndex = 75;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // lb_tientrinh
            // 
            this.lb_tientrinh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_tientrinh.AutoSize = true;
            this.lb_tientrinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tientrinh.Location = new System.Drawing.Point(52, 127);
            this.lb_tientrinh.Name = "lb_tientrinh";
            this.lb_tientrinh.Size = new System.Drawing.Size(101, 25);
            this.lb_tientrinh.TabIndex = 76;
            this.lb_tientrinh.Text = "Tiến Trình";
            // 
            // lb_tgctbkq
            // 
            this.lb_tgctbkq.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_tgctbkq.AutoSize = true;
            this.lb_tgctbkq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_tgctbkq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tgctbkq.ForeColor = System.Drawing.Color.Red;
            this.lb_tgctbkq.Location = new System.Drawing.Point(611, 554);
            this.lb_tgctbkq.Name = "lb_tgctbkq";
            this.lb_tgctbkq.Size = new System.Drawing.Size(94, 27);
            this.lb_tgctbkq.TabIndex = 89;
            this.lb_tgctbkq.Text = "Kết Quả";
            // 
            // lb_tgctb
            // 
            this.lb_tgctb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_tgctb.AutoSize = true;
            this.lb_tgctb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tgctb.Location = new System.Drawing.Point(216, 554);
            this.lb_tgctb.Name = "lb_tgctb";
            this.lb_tgctb.Size = new System.Drawing.Size(271, 25);
            this.lb_tgctb.TabIndex = 88;
            this.lb_tgctb.Text = "Thời Gian Chờ Trung Bình:";
            // 
            // lb_tghtcbkq
            // 
            this.lb_tghtcbkq.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_tghtcbkq.AutoSize = true;
            this.lb_tghtcbkq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_tghtcbkq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tghtcbkq.ForeColor = System.Drawing.Color.Red;
            this.lb_tghtcbkq.Location = new System.Drawing.Point(611, 511);
            this.lb_tghtcbkq.Name = "lb_tghtcbkq";
            this.lb_tghtcbkq.Size = new System.Drawing.Size(94, 27);
            this.lb_tghtcbkq.TabIndex = 87;
            this.lb_tghtcbkq.Text = "Kết Quả";
            // 
            // lb_tghtcb
            // 
            this.lb_tghtcb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_tghtcb.AutoSize = true;
            this.lb_tghtcb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tghtcb.Location = new System.Drawing.Point(214, 511);
            this.lb_tghtcb.Name = "lb_tghtcb";
            this.lb_tghtcb.Size = new System.Drawing.Size(350, 25);
            this.lb_tghtcb.TabIndex = 86;
            this.lb_tghtcb.Text = "Thời Gian Hoàn Thành Trung Bình:";
            // 
            // txt_khoancpu
            // 
            this.txt_khoancpu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_khoancpu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_khoancpu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_khoancpu.Location = new System.Drawing.Point(363, 174);
            this.txt_khoancpu.Name = "txt_khoancpu";
            this.txt_khoancpu.Size = new System.Drawing.Size(137, 30);
            this.txt_khoancpu.TabIndex = 85;
            this.txt_khoancpu.TextChanged += new System.EventHandler(this.txt_khoancpu_TextChanged);
            this.txt_khoancpu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_khoancpu_KeyPress);
            // 
            // lb_khoancpu
            // 
            this.lb_khoancpu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_khoancpu.AutoSize = true;
            this.lb_khoancpu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_khoancpu.Location = new System.Drawing.Point(373, 127);
            this.lb_khoancpu.Name = "lb_khoancpu";
            this.lb_khoancpu.Size = new System.Drawing.Size(117, 25);
            this.lb_khoancpu.TabIndex = 84;
            this.lb_khoancpu.Text = "Khoản CPU";
            // 
            // btn_ketqua
            // 
            this.btn_ketqua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_ketqua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_ketqua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ketqua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ketqua.Location = new System.Drawing.Point(361, 213);
            this.btn_ketqua.Name = "btn_ketqua";
            this.btn_ketqua.Size = new System.Drawing.Size(140, 34);
            this.btn_ketqua.TabIndex = 83;
            this.btn_ketqua.Text = "Kết Quả";
            this.btn_ketqua.UseVisualStyleBackColor = false;
            this.btn_ketqua.Click += new System.EventHandler(this.btn_ketqua_Click);
            // 
            // txt_thoidiem
            // 
            this.txt_thoidiem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_thoidiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_thoidiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_thoidiem.Location = new System.Drawing.Point(194, 174);
            this.txt_thoidiem.Name = "txt_thoidiem";
            this.txt_thoidiem.Size = new System.Drawing.Size(137, 30);
            this.txt_thoidiem.TabIndex = 82;
            this.txt_thoidiem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_thoidiem_KeyPress);
            // 
            // lb_thoidiem
            // 
            this.lb_thoidiem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_thoidiem.AutoSize = true;
            this.lb_thoidiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_thoidiem.Location = new System.Drawing.Point(212, 127);
            this.lb_thoidiem.Name = "lb_thoidiem";
            this.lb_thoidiem.Size = new System.Drawing.Size(101, 25);
            this.lb_thoidiem.TabIndex = 81;
            this.lb_thoidiem.Text = "Thời Điểm";
            // 
            // btn_reset
            // 
            this.btn_reset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.Location = new System.Drawing.Point(219, 213);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(86, 34);
            this.btn_reset.TabIndex = 80;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // txt_tientrinh
            // 
            this.txt_tientrinh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_tientrinh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_tientrinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tientrinh.Location = new System.Drawing.Point(34, 174);
            this.txt_tientrinh.Name = "txt_tientrinh";
            this.txt_tientrinh.Size = new System.Drawing.Size(137, 30);
            this.txt_tientrinh.TabIndex = 79;
            this.txt_tientrinh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_tientrinh_KeyPress);
            // 
            // SRFS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1228, 621);
            this.Controls.Add(this.dataview_input);
            this.Controls.Add(this.dataview_output);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.lb_tientrinh);
            this.Controls.Add(this.lb_tgctbkq);
            this.Controls.Add(this.lb_tgctb);
            this.Controls.Add(this.lb_tghtcbkq);
            this.Controls.Add(this.lb_tghtcb);
            this.Controls.Add(this.txt_khoancpu);
            this.Controls.Add(this.lb_khoancpu);
            this.Controls.Add(this.btn_ketqua);
            this.Controls.Add(this.txt_thoidiem);
            this.Controls.Add(this.lb_thoidiem);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.txt_tientrinh);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SRFS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SRFS";
            ((System.ComponentModel.ISupportInitialize)(this.dataview_input)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataview_output)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataview_input;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_tientrinh1;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_thoidiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_khoancpu;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_thoigiancho;
        private System.Windows.Forms.DataGridView dataview_output;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_tientrinh2;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_thoigianxuathien;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_thoigianketthuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_thoigianhoanthanh;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Label lb_tientrinh;
        private System.Windows.Forms.Label lb_tgctbkq;
        private System.Windows.Forms.Label lb_tgctb;
        private System.Windows.Forms.Label lb_tghtcbkq;
        private System.Windows.Forms.Label lb_tghtcb;
        private System.Windows.Forms.TextBox txt_khoancpu;
        private System.Windows.Forms.Label lb_khoancpu;
        private System.Windows.Forms.Button btn_ketqua;
        private System.Windows.Forms.TextBox txt_thoidiem;
        private System.Windows.Forms.Label lb_thoidiem;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.TextBox txt_tientrinh;
    }
}