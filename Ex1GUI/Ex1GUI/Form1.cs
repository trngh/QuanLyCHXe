using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using System.Web;

namespace Ex1GUI
{
    public partial class Form1 : Form
    {
        string file = "dsXe.txt";
        LinkedList myList = new LinkedList();
        public Form1()
        {
            ReadFiles();
            InitializeComponent();
        }
        private void ReadFiles()
        {
            var dsXe = File.ReadAllLines(file);
            foreach (var word in dsXe)
            {
                string[] str = word.Split('-');
                Double.TryParse(str[4].Trim(), out double giaBan);
                myList.AddLast(new Automobile(str[0].Trim(), str[1].Trim(), str[2].Trim(), str[3].Trim(), giaBan));
            }
        }
        private void WriteFiles()
        {
            File.Delete(file);
            for (int i = 0; i < myList.Length(); i++)
            {
                File.AppendAllText(file, myList.Get(i).Xe.ToString()) ;
            }
        }
        private bool CheckControl()
        {
            if(string.IsNullOrEmpty(maXe_text.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã xe!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                maXe_text.Focus();
                return false;   
            }
            if (string.IsNullOrEmpty(tenXe_text.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên xe!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tenXe_text.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(giaBan_text.Text))
            {
                MessageBox.Show("Bạn chưa nhập giá xe!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                giaBan_text.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(dongXe_comboBox.Text))
            {
                MessageBox.Show("Bạn chưa chọn dòng xe!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dongXe_comboBox.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(phienBan_comboBox.Text))
            {
                MessageBox.Show("Bạn chưa chọn phiên bản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                phienBan_comboBox.Focus();
                return false;
            }
            return true;
        }
        private Automobile ThongTinXe()
        {
            string maXe = maXe_text.Text.Trim();
            string tenXe = tenXe_text.Text.Trim();
            string dongXe = dongXe_comboBox.Text.Trim();
            string phienBan = phienBan_comboBox.Text.Trim();
            double giaBan;
            Double.TryParse(giaBan_text.Text, out giaBan);
            return new Automobile(maXe, tenXe, dongXe, phienBan, giaBan);
        }
        private void Them_Click(object sender, EventArgs e)
        {
            if(CheckControl())
            {
                Automobile Xe = ThongTinXe();
                if (!myList.Contains(Xe))
                {
                    myList.AddLast(Xe);
                    File.AppendAllText(file, Xe.ToString());
                    HienThiThongTin(Xe);
                }
                else
                {
                    MessageBox.Show("Thông tin xe vừa nhập đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tenXe_text.Focus();
                }
            }
        }

        private void Xoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(maXe_text.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã xe!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                maXe_text.Focus();
            }
            else
            {
                Automobile Xe = ThongTinXe();
                Node p = myList.SearchNode(Xe);
                if (p != null)
                {
                    if (MessageBox.Show("Bạn chắc chắn muốn xóa!", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        myList.RemoveNode(p);
                        WriteFiles();
                        XuatDS();
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void HienThiThongTin(Automobile x)
        {
            listBox1.Items.Add($"Mã xe: {x.maXe} - Tên xe: {x.tenXe} - Dòng xe: {x.dongXe} - Phiên bản: {x.phienBan} - Giá bán: {x.giaBan}000000VND");
        }
        private void XuatDS()
        {
            listBox1.Items.Clear();
            for (int i = 0; i < myList.Length(); i++)
                HienThiThongTin(myList.Get(i).Xe);
        }
        private void XuatDS_Click(object sender, EventArgs e)
        {
            XuatDS();
        }
        private void CapNhatThongTin_Click(object sender, EventArgs e)
        {
            if(CheckControl())
            {
                Automobile Xe = ThongTinXe();
                Node p = myList.SearchNode(Xe);
                if (p != null)
                {
                    if (MessageBox.Show("Cập nhật lại thông tin", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        myList.ChangeInfo(p, Xe);
                        WriteFiles();
                        XuatDS();
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void SapXep_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            LinkedList list = new LinkedList();
            list.CopyTo(myList);
            if(!string.IsNullOrWhiteSpace(comboBox.Text))
            {
                switch (comboBox.Text)
                {
                    case "Giá xe tăng dần":
                        list.QuickSort("gia xe");
                        break;
                    case "Giá xe giảm dần":
                        list.SortDescending("gia xe");
                        break;
                    case "Thứ tự mã xe tăng":
                        list.QuickSort("ma xe");
                        break;
                    case "Thứ tự mã xe giảm":
                        list.SortDescending("ma xe");
                        break;
                    case "Thứ tự tên xe A - Z":
                        list.QuickSort("ten xe");
                        break;
                    case "Thứ tự tên xe Z - A":
                        list.SortDescending("ten xe");
                        break;
                    default:
                        break;
                }
                listBox1.Items.Clear();
                for (int i = 0; i < list.Length(); i++)
                {
                    HienThiThongTin(list.Get(i).Xe);
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            LinkedList list = new LinkedList();
            list.CopyTo(myList);
            string[] danhMuc = { "ma xe", "ten xe", "gia ban", "dong xe", "phien ban" };
            string[] control = { maXe_text.Text, tenXe_text.Text, giaBan_text.Text, dongXe_comboBox.Text, phienBan_comboBox.Text };
            bool ok = false;
            for (int i = 0; i < danhMuc.Length; i++)
            {
                if (!string.IsNullOrEmpty(control[i]))
                {
                    list = list.SearchNodes(danhMuc[i], control[i].Trim().ToLower());
                    ok = true;
                }
            }
           
            if(ok)
            {
                if (!list.IsEmpty())
                {
                    listBox1.Items.Clear();
                    for (int i = 0; i < list.Length(); i++)
                        HienThiThongTin(list.Get(i).Xe);
                }
                else MessageBox.Show("Không tìm thấy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("Bạn chưa nhập thông tin tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
        }
      
        private void BatDau_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            maXe_text.Clear();
            maXe_text.Clear();
            tenXe_text.Clear();
            giaBan_text.Clear();
        }
    }
}
