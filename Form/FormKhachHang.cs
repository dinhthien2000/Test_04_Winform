using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic.Logging;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Test_04.DAO;
using Test_04.Entities;



namespace Test_04
{
    public partial class FormKhachHang : Form
    {
        KhachHangDAO khachHangDAO;

        public FormKhachHang()
        {
            InitializeComponent();
            khachHangDAO = new KhachHangDAO();

            loadData();

            //foreach (Control control in control)
            //{
            //    if (control is TextBox)
            //    {
            //        control.Text = "Hello";
            //    }
            //}
        }

        private void loadData()
        {
            List<KhachHang> khachHangs = khachHangDAO.getAll();
            grdv_khachang.DataSource = khachHangs;
        }
        private void clear()
        {
            txt_makh.Text = "";
            txt_tenkh.Text = "";
            txt_masothue.Text = "";
            ckb_la_khachhang.Checked = false;
            ckb_la_nhacungcap.Checked = false;
            ckb_la_canhan.Checked = false;
            txt_sdt.Text = "";
            txt_email.Text = "";
            txt_diachi.Text = "";
            txt_nglienhe.Text = "";
            txt_tiennochophep.Text = "";
            txt_songaychophep.Text = "";

        }

        private void textBoxName_Validating(object sender, CancelEventArgs e)
        {
            var tb = (TextBox)sender;
            if (string.IsNullOrEmpty(tb.Text))
            {
                errorProvider1.SetError(tb, "error");
            }
        }

        // true is email
        //private bool IsValidEmail(this string email)
        //{
        //    //    string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|" + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)" + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";
        //    //var regex = new Regex(pattern, RegexOptions.IgnoreCase);
        //    //bool flag = regex.IsMatch(email);
        //    //    return flag;
        //    //    return new EmailAddressAttribute().IsValid(email);
        //    bool flag = false;
        //    if (email.LastIndexOf("@") > -1)
        //    {
        //        //valid
        //        flag = true;
        //    }
        //    return flag;
        //}

        private bool checkStringValueValid(TextBox textBox)
        {
            bool flag = false;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                MessageBox.Show("Không để trống Mã KH, Tên KH !!");
                flag = true;
            }
            return flag;
        }

        private bool checkNumberValueValid(TextBox textBox)
        {
            decimal d;

            int i;
            bool flag = false;
            if (string.IsNullOrWhiteSpace(textBox.Text) || int.TryParse(textBox.Text, out _))
            {
                MessageBox.Show("Nhập chữ số thập phân cho số tiền !! ");
                flag = true;
            }
            else if (string.IsNullOrWhiteSpace(textBox.Text) || int.TryParse(textBox.Text, out i))
            {
                MessageBox.Show("Nhập chữ số  nguyên cho số ngày !!");
                flag = true;
            }
            return flag;
        }

        private bool checkEmailValueValid(TextBox textBox)
        {
            bool flag = false;
            if (textBox.Text.LastIndexOf("@") > -1)
            {
                //valid
                MessageBox.Show("Không đúng format Email !!");
                flag = true;
            }
            return flag;
        }


        private bool isValidData(Control control)
        {
            bool flag = true;
            if (string.IsNullOrEmpty(control.Text))
            {
                flag = false;
            }
            return flag;
        }

        private void pushTextBoxError(Control control)
        {
            errorProvider1.SetError(control,"Erros");
        }

        private void btn_them_moi_Click(object sender, EventArgs e)
        {
            bool flag = false;
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    Debug.WriteLine("Control " + control.Name);
                    Debug.WriteLine("Loop " + flag);
                    if (isValidData(control))
                    {
                        flag = true;
                    }
                    else
                    {
                        Debug.WriteLine("Erros " + flag);
                        pushTextBoxError(control);
                    }
                }

            }
            Debug.WriteLine(flag);
            if (flag)
            {
                KhachHang khachHang = new KhachHang(
                    txt_makh.Text,
                    txt_tenkh.Text,
                    txt_masothue.Text,
                    ckb_la_khachhang.Checked,
                    ckb_la_nhacungcap.Checked,
                    ckb_la_canhan.Checked,
                    txt_sdt.Text,
                    txt_email.Text,
                    txt_diachi.Text,
                    txt_nglienhe.Text,
                    decimal.Parse(txt_tiennochophep.Text),
                    int.Parse(txt_songaychophep.Text)
                );

                khachHangDAO.create(khachHang);
                loadData();
                MessageBox.Show("Thêm thành công");
            }

        }

        private void btn_cap_nhat_Click(object sender, EventArgs e)
        {
            KhachHang khachHang = new KhachHang(
                txt_makh.Text,
                txt_tenkh.Text,
                txt_masothue.Text,
                ckb_la_khachhang.Checked,
                ckb_la_nhacungcap.Checked,
                ckb_la_canhan.Checked,
                txt_sdt.Text,
                txt_email.Text,
                txt_diachi.Text,
                txt_nglienhe.Text,
                decimal.Parse(txt_tiennochophep.Text),
                int.Parse(txt_songaychophep.Text)
            );

            khachHangDAO.update(khachHang);
            loadData();
            MessageBox.Show("Cập nhật thành công");

        }


        //  lấy  được chọn 1 hoặc nhiều kết quả trong grid view
        public List<KhachHang> GetSelectionInGridView()
        {
            List<KhachHang> list = new List<KhachHang>();
            var rows = grdv_khachang.SelectedRows;
            for (int i = 0; i < rows.Count; i++)
            {
                KhachHang? p = rows[i].DataBoundItem as KhachHang;
                if (p != null)
                    list.Add(p);
            }

            return list;
        }


        private void grdv_khachang_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            txt_makh.Text = grdv_khachang.CurrentRow.Cells[0].FormattedValue.ToString();
            txt_tenkh.Text = grdv_khachang.CurrentRow.Cells[1].FormattedValue.ToString();
            txt_masothue.Text = grdv_khachang.CurrentRow.Cells[2].FormattedValue.ToString();
            ckb_la_khachhang.Checked = (bool)grdv_khachang.CurrentRow.Cells[3].Value;
            ckb_la_nhacungcap.Checked = (bool)grdv_khachang.CurrentRow.Cells[4].Value;
            ckb_la_canhan.Checked = (bool)grdv_khachang.CurrentRow.Cells[5].Value;
            txt_sdt.Text = grdv_khachang.CurrentRow.Cells[6].FormattedValue.ToString();
            txt_email.Text = grdv_khachang.CurrentRow.Cells[7].FormattedValue.ToString();
            txt_diachi.Text = grdv_khachang.CurrentRow.Cells[8].FormattedValue.ToString();
            txt_nglienhe.Text = grdv_khachang.CurrentRow.Cells[9].FormattedValue.ToString();
            txt_tiennochophep.Text = grdv_khachang.CurrentRow.Cells[10].FormattedValue.ToString();
            txt_songaychophep.Text = grdv_khachang.CurrentRow.Cells[11].FormattedValue.ToString();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc xóa kết quả đã chọn ?",
                      "Thông báo", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
                    List<KhachHang> list = GetSelectionInGridView();
                    foreach (var kh in list)
                    {
                        khachHangDAO.deleteByCustomerID(kh.CustomerID);
                    }
                    loadData();
                    break;
                case DialogResult.No:
                    break;
            }
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            clear();
            loadData();
        }
    }
}