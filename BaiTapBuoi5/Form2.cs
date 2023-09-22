using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapBuoi5
{


    public partial class Form2 : Form
    {
        List<Student> listStudent;
        DataGridView dgvStudent;

        public Form2(DataGridView dgvStudent, List<Student> listStudent)
        {
            InitializeComponent();
            this.listStudent = listStudent;
            this.dgvStudent = dgvStudent;
        }

        private void btnThemmoi_Click_1(object sender, EventArgs e)
        {
            
            try
            {
                if (txtMssv.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập mã số sinh viên!");
                    return;
                }
                if (txtName.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập ten sinh viên!");
                    return;
                }
                if (txtDtb.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập điểm!");
                    return;
                }
                if (float.Parse(txtDtb.Text) < 0 || float.Parse(txtDtb.Text) > 10 )
                {
                    MessageBox.Show("Điểm phải nằm trong khoảng từ 0 đến 10!");
                    return;
                }
                
                if (listStudent.Where(s => s.Id == txtMssv.Text).Count() > 0)
                {
                    throw new Exception("Mã số sinh viên đã bị trùng !");
                }
                listStudent.Add(new Student() { Id = txtMssv.Text, Fullname = txtName.Text, Khoa = cbKhoa.Text, Diem = float.Parse(txtDtb.Text) });
                dgvStudent.DataSource = null;
                dgvStudent.DataSource = listStudent;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            txtMssv.Focus(); 
        }

        

        
        private void Form2_Load(object sender, EventArgs e)
        {
            cbKhoa.SelectedItem = "Công nghệ thông tin";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

    }
}
