using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections; //Thư viện sử dụng arraylist


namespace CPU_Processing
{
    public partial class SRFS : Form
    {
        public SRFS()
        {
            InitializeComponent();
        }

        int len_txt = 3;
        ArrayList dif_number = new ArrayList();

        private Boolean isInList(int value)
        {
            foreach (int number in dif_number)
            {
                if (number == value)
                {
                    return true;
                }
            }
            return false;
        }

        private void txt_tientrinh_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(((char.IsDigit(e.KeyChar) || char.IsLetter(e.KeyChar)) && txt_tientrinh.Text.Length < len_txt) || e.KeyChar == (char)8);
        }

        private void txt_thoidiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !((char.IsDigit(e.KeyChar) && txt_thoidiem.Text.Length < len_txt) || e.KeyChar == (char)8);
        }

        private void txt_khoancpu_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !((char.IsDigit(e.KeyChar) && txt_khoancpu.Text.Length < len_txt) || e.KeyChar == (char)8);
        }

        private void txt_khoancpu_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(txt_khoancpu.Text) == 0)
                {
                    MessageBox.Show("Bạn không được phép cho khoảng CPU bằng 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    txt_khoancpu.Clear();
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(txt_tientrinh.Text.ToString()) || string.IsNullOrEmpty(txt_thoidiem.Text.ToString()) || string.IsNullOrEmpty(txt_khoancpu.Text.ToString())))
            {
                int value = Convert.ToInt32(txt_thoidiem.Text.ToString());
                if (!isInList(value))
                {
                    dataview_input.Rows.Add(txt_tientrinh.Text, Convert.ToInt32(txt_thoidiem.Text), Convert.ToInt32(txt_khoancpu.Text));
                    dif_number.Add(value);
                }
                else
                {
                    MessageBox.Show("Thời điểm bắt đầu trùng!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_tientrinh.Text = "";
            txt_thoidiem.Text = "";
            txt_khoancpu.Text = "";
            dataview_input.Rows.Clear();
            dataview_output.Rows.Clear();
            lb_tghtcbkq.Text = "Kết Quả";
            lb_tgctbkq.Text = "Kết Quả";
            dif_number.Clear();
            Focus();
        }

        private void btn_ketqua_Click(object sender, EventArgs e)
        {
            if (dataview_input.Rows.Count <= 0)
            {
                //dataview_input.Rows.Add("P1", 0, 7);
                //dataview_input.Rows.Add("P2", 0, 4);
                //dataview_input.Rows.Add("P3", 0, 1);
                //dataview_input.Rows.Add("P4", 0, 3);
                dataview_input.Rows.Add("P1", 0, 7);
                dataview_input.Rows.Add("P2", 2, 4);
                dataview_input.Rows.Add("P3", 4, 1);
                dataview_input.Rows.Add("P4", 5, 4);
                dif_number.Add(0);
                dif_number.Add(2);
                dif_number.Add(4);
                dif_number.Add(5);
            }
            dataview_output.Rows.Clear();
            ArrayList arr_kcpu = new ArrayList();

            foreach (DataGridViewRow row in dataview_input.Rows)
            {
                arr_kcpu.Add(Convert.ToInt32(row.Cells[2].Value));
            }

            arr_kcpu.Add(Int32.MaxValue);

            int tgctb = 0;
            int tghttb = 0;
            int tgkt = 0;
            int tght = 0;
            int tgc = 0;
            int index_kcpu_min; //Biến quan trọng: lưu khoản cpu nhỏ nhất

            int sl_tt = dataview_input.Rows.Count;
            int sl_tt_kt = 0;
            for (int time = 0; sl_tt_kt < sl_tt; time++) //Quét các tiến trình cho đến khi số lượng tiến trình kết thúc == số lượng tiến trình
            {
                index_kcpu_min = sl_tt;
                for (int j = 0; j < sl_tt; j++)
                {
                    if (Convert.ToInt32(dataview_input.Rows[j].Cells[1].Value) <= time &&
                        (int)arr_kcpu[j] < (int)arr_kcpu[index_kcpu_min] &&
                        (int)arr_kcpu[j] > 0) //Tìm giá trị kcpu nhỏ nhất trong thời gian cpu đang chạy
                    {
                        index_kcpu_min = j; //Tìm được kcpu nhỏ
                    }
                }

                arr_kcpu[index_kcpu_min] = (int)arr_kcpu[index_kcpu_min] - 1;
                if ((int)arr_kcpu[index_kcpu_min] == 0)
                {
                    int temp_kcpu = Convert.ToInt32(dataview_input.Rows[index_kcpu_min].Cells[2].Value);
                    int temp_tdbd = Convert.ToInt32(dataview_input.Rows[index_kcpu_min].Cells[1].Value);
                    sl_tt_kt++;
                    tgkt = time + 1;
                    tght = tgkt - temp_tdbd;
                    tgc = tght - temp_kcpu;
                    tghttb += tght;
                    tgctb += tgc;
                    dataview_output.Rows.Add(dataview_input.Rows[index_kcpu_min].Cells[0].Value.ToString(), Convert.ToInt32(dataview_input.Rows[index_kcpu_min].Cells[1].Value), tgkt, tght, tgc);
                }
            }
            lb_tghtcbkq.Text = Convert.ToString(tghttb * 1.0 / sl_tt);
            lb_tgctbkq.Text = Convert.ToString(tgctb * 1.0 / sl_tt);
        }


    }
}
