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
    public partial class SJFS : Form
    {
        public SJFS()
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

        public void sort_list_kcpu(ArrayList arr_index)
        {
            int len = arr_index.Count;
            for (int i = 0; i < len - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < len; j++)
                {
                    if (Convert.ToInt32(dataview_input.Rows[(int)arr_index[j]].Cells[2].Value) < Convert.ToInt32(dataview_input.Rows[(int)arr_index[min]].Cells[2].Value) ||
                        (Convert.ToInt32(dataview_input.Rows[(int)arr_index[j]].Cells[2].Value) == Convert.ToInt32(dataview_input.Rows[(int)arr_index[min]].Cells[2].Value) &&
                        Convert.ToInt32(dataview_input.Rows[(int)arr_index[j]].Cells[1].Value) < Convert.ToInt32(dataview_input.Rows[(int)arr_index[min]].Cells[1].Value)))
                    {
                        min = j;
                    }
                }
                int temp = (int)arr_index[min];
                arr_index[min] = arr_index[i];
                arr_index[i] = temp;
            }
        }

        private void btn_ketqua_Click(object sender, EventArgs e)
        {
            if (dataview_input.Rows.Count <= 0)
            {
                //dataview_input.Rows.Add("P1", 0, 7);
                //dataview_input.Rows.Add("P2", 0, 4);
                //dataview_input.Rows.Add("P3", 0, 1);
                //dataview_input.Rows.Add("P4", 0, 3);


                //dataview_input.Rows.Add("P1", 0, 7);
                //dataview_input.Rows.Add("P2", 6, 4);
                //dataview_input.Rows.Add("P3", 4, 1);
                //dataview_input.Rows.Add("P4", 2, 4);

                dataview_input.Rows.Add("P1", 0, 7);
                dataview_input.Rows.Add("P2", 2, 4);
                dataview_input.Rows.Add("P3", 4, 1);
                dataview_input.Rows.Add("P4", 6, 4);
            }
            dataview_output.Rows.Clear();
            ArrayList arr_index = new ArrayList();
            ArrayList arr_index_min = new ArrayList();

            int values_min = int.MaxValue;
            foreach (DataGridViewRow row in dataview_input.Rows)
            {
                if (Convert.ToInt32(row.Cells[1].Value) < values_min)
                {
                    values_min = Convert.ToInt32(row.Cells[1].Value);
                }
            }

            int index = 0;
            foreach (DataGridViewRow row in dataview_input.Rows)
            {
                if (Convert.ToInt32(row.Cells[1].Value) != values_min)
                {
                    arr_index.Add(index);
                }
                else
                {
                    arr_index_min.Add(index);
                }
                index++;
            }

            sort_list_kcpu(arr_index);
            sort_list_kcpu(arr_index_min);

            //Đưa các index chứa điểm bắt đầu là 0 vào các mãng
            arr_index.InsertRange(0, arr_index_min);

            foreach (int value in arr_index) //Đưa các index chứa điểm bắt đầu là 0 vào các mãng
            {
                Console.WriteLine(value);
            }

            double tghttb = 0; //Tính thời gian hoàn thành trung bình
            double tgctb = 0;  //Tính thời gian chờ trung bình

            int wt = 0;   //Thời gian chờ của cpu
            int tgkt = 0; //Thời gian kết thúc của 1 tiến trình
            int tdbd = 0; //Thời điểm bắt đầu
            int kcpu = 0; //Khoản cpu

            for (int i = 0; i < arr_index.Count; i++)
            {
                Console.WriteLine(dataview_input.Rows[(int)arr_index[i]].Cells[0].Value.ToString() + "   " + Convert.ToInt32(dataview_input.Rows[(int)arr_index[i]].Cells[1].Value) + "   " + Convert.ToInt32(dataview_input.Rows[(int)arr_index[i]].Cells[2].Value));
                kcpu = Convert.ToInt32(dataview_input.Rows[(int)arr_index[i]].Cells[2].Value); //Đưa khoản cpu vao biến kcpu
                tdbd = Convert.ToInt32(dataview_input.Rows[(int)arr_index[i]].Cells[1].Value); //Đưa thời điểm bắt đầu vào biến tdbd
                tgkt = (tgkt > tdbd) ? (tgkt + kcpu) : (tdbd + kcpu); //Kiểm tra thời điểm bắt đầu của luồn này có lớn hơn thời gian kết thúc luồn trước hay không 
                wt = (tgkt - tdbd) - kcpu; //Thời Gian Chờ
                tghttb += tgkt - tdbd;
                tgctb += wt;
                dataview_output.Rows.Add(dataview_input.Rows[(int)arr_index[i]].Cells[0].Value.ToString(), tdbd, tgkt, tgkt - tdbd, wt);
            }

            tghttb /= dataview_output.Rows.Count;
            tgctb /= dataview_output.Rows.Count;

            lb_tghtcbkq.Text = Convert.ToString(tghttb);
            lb_tgctbkq.Text = Convert.ToString(tgctb);
        }

    }
}
