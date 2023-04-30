using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;


namespace CPU_Processing
{
    public partial class RRS : Form
    {
        public RRS()
        {
            InitializeComponent();
        }

        int len_txt = 3;
        String txt_timequantum_clone = "20";

        private void txt_tientrinh_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(((char.IsDigit(e.KeyChar) || char.IsLetter(e.KeyChar)) && txt_tientrinh.Text.Length < len_txt) || e.KeyChar == (char)8);
        }

        private void txt_khoancpu_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !((char.IsDigit(e.KeyChar) && txt_khoancpu.Text.Length < len_txt) || e.KeyChar == (char)8);
        }

        private void txt_timequantum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((char.IsDigit(e.KeyChar) && txt_timequantum.Text.Length < len_txt) || e.KeyChar == (char)8))
            {
                e.Handled = true;
            }
            else
            {
                txt_timequantum_clone = txt_timequantum.Text;
            }
        }

        private void txt_timequantum_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_timequantum.Text) || Convert.ToInt32(txt_timequantum.Text) == 0)
            {
                txt_timequantum.Text = txt_timequantum_clone;
                MessageBox.Show("Time Quantum Không được để trống và không được bằng 0", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
            if (!(string.IsNullOrEmpty(txt_tientrinh.Text.ToString()) || string.IsNullOrEmpty(txt_khoancpu.Text.ToString())))
            {
                dataview_input.Rows.Add(txt_tientrinh.Text, Convert.ToInt32(txt_khoancpu.Text));
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_tientrinh.Text = "";
            txt_khoancpu.Text = "";
            dataview_input.Rows.Clear();
            dataview_output.Rows.Clear();
            lb_tghtcbkq.Text = "Kết Quả";
            lb_tgctbkq.Text = "Kết Quả";
            txt_timequantum.Text = "20";
            Focus();
        }

        private void btn_ketqua_Click(object sender, EventArgs e)
        {
            if (dataview_input.Rows.Count <= 0) //TEST KEY
            {
                dataview_input.Rows.Add("P1", 53);
                dataview_input.Rows.Add("P2", 17);
                dataview_input.Rows.Add("P3", 68);
                dataview_input.Rows.Add("P4", 24);
                //dataview_input.Rows.Add("P1", 50);
                //dataview_input.Rows.Add("P2", 10);
                //dataview_input.Rows.Add("P3", 70);
                //dataview_input.Rows.Add("P4", 60);
            }



            dataview_output.Rows.Clear();
            ArrayList arr_tt = new ArrayList();
            ArrayList arr_kcpu = new ArrayList();
            ArrayList fifo_loop = new ArrayList(); //Lưu Index bản đầu vào
            int Ngat = Convert.ToInt32(txt_timequantum.Text.ToString());

            int index = 0;
            foreach (DataGridViewRow row in dataview_input.Rows)
            {
                arr_tt.Add(row.Cells[0].Value.ToString());
                arr_kcpu.Add((int)row.Cells[1].Value);
                fifo_loop.Add(index);
                index++;
            }

            int tgctb = 0;
            int tghttb = 0;
            int tgkt = 0;
            int tght = 0;
            int tgc = 0;
            int index_kcpu_min; //Biến quan trọng: lưu khoản cpu nhỏ nhất
            int giatri_kcpu_index;

            int sl_tt = arr_tt.Count;
            int sl_tt_kt = 0;
            for (int time = 0, TimeQuantum = Ngat; sl_tt_kt < sl_tt; time += TimeQuantum, TimeQuantum = Ngat) //Quét các tiến trình cho đến khi số lượng tiến trình kết thúc == số lượng tiến trình
            {
                index_kcpu_min = (int)fifo_loop[0]; //Lấy index để thực hiện chạy tiếp
                fifo_loop.RemoveAt(0); //Thực hiện xóa index đã thực hiện
                giatri_kcpu_index = (int)arr_kcpu[index_kcpu_min]; //Lấy giá trị kcpu tại index
                int out_kcpu = giatri_kcpu_index - TimeQuantum;
                if (out_kcpu < 0) //nếu âm nên vượt qua kcpu tiến trình nên chỉ thực hiện vừa đủ 
                {
                    arr_kcpu[index_kcpu_min] = giatri_kcpu_index - (TimeQuantum + out_kcpu); //Có thể cho giá trị này bằng 0 chủ yếu để thể hiện đúng thuật toán
                    TimeQuantum = TimeQuantum + out_kcpu; //Có thể cho giá trị này bằng kcpu tiến trình bị âm giatri_kcpu_index
                }
                else //Không âm thì kcpu tại index đó bằng giá trị out_kcpu vì out_kcpu = giatri_kcpu_index - TimeQuantum
                {
                    arr_kcpu[index_kcpu_min] = out_kcpu;
                }

                if ((int)arr_kcpu[index_kcpu_min] == 0)
                {
                    int temp_kcpu = (int)dataview_input.Rows[index_kcpu_min].Cells[1].Value;
                    sl_tt_kt++;
                    tgkt = time + TimeQuantum;
                    tght = tgkt;
                    tgc = tght - temp_kcpu;
                    tghttb += tght;
                    tgctb += tgc;
                    dataview_output.Rows.Add(arr_tt[index_kcpu_min], temp_kcpu, tgkt, tght, tgc);
                }
                else
                {
                    fifo_loop.Add(index_kcpu_min); //Chèn lại index đã thực hiện vào sau danh sách fifo_loop để thực hiện kcpu còn lại
                }

                Console.WriteLine("P" + (index_kcpu_min + 1) + " Ngat: " + TimeQuantum); //Xem cac khoản ngắt
            }
            lb_tghtcbkq.Text = Convert.ToString(tghttb * 1.0 / sl_tt);
            lb_tgctbkq.Text = Convert.ToString(tgctb * 1.0 / sl_tt);
        }
    }
}
