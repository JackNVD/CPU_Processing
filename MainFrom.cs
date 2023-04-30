using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPU_Processing
{
    public partial class MainFrom : Form
    {
        public MainFrom()
        {
            InitializeComponent();
        }

        SJFS frm_sjfs;
        SRFS frm_srfs;
        RRS frm_rrs;

        private void btn_sjfs_Click(object sender, EventArgs e)
        {
            if (frm_sjfs == null || frm_sjfs.Text == "")
            {
                frm_sjfs = new SJFS();
                frm_sjfs.Enabled = true;
                frm_sjfs.Show();
            }
            else
            {
                frm_sjfs.WindowState = FormWindowState.Normal;
            }
            Console.WriteLine(frm_sjfs.Text);
        }

        private void btn_srfs_Click(object sender, EventArgs e)
        {
            if (frm_srfs == null || frm_srfs.Text == "")
            {
                frm_srfs = new SRFS();
                frm_srfs.Enabled = true;
                frm_srfs.Show();
            }
            else
            {
                frm_srfs.WindowState = FormWindowState.Normal;
            }
            Console.WriteLine(frm_srfs.Text);
        }

        private void btn_rrs_Click(object sender, EventArgs e)
        {
            if (frm_rrs == null || frm_rrs.Text == "")
            {
                frm_rrs = new RRS();
                frm_rrs.Enabled = true;
                frm_rrs.Show();
            }
            else
            {
                frm_rrs.WindowState = FormWindowState.Normal;
            }
            Console.WriteLine(frm_rrs.Text);
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
