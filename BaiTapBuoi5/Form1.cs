using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BaiTapBuoi5
{
    public partial class Form1 : Form
    {

        List<Student> listStudent = new List<Student>();
        DataGridView dgv;
        public Form1()
        {
            InitializeComponent();
        }
        public Form1(DataGridView dgv, int index = -1)
        {
            InitializeComponent();
            this.dgv = dgv;
        }


        private void tsbtnAdd_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(dgvSinhvien, listStudent);
            form2.ShowDialog();

        }

        private void tsmExit_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn có muốn thoát chương trình", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void tsmAdd_Click(object sender, EventArgs e)
        {
            Form2 fm2 = new Form2(dgvSinhvien, listStudent);
            fm2.ShowDialog();
        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            ToolStripTextBox toolStripTextBox = sender as ToolStripTextBox;
            if (toolStripTextBox.Text.Length == 0)
            {
                dgvSinhvien.DataSource = null;
                dgvSinhvien.DataSource = listStudent;
            }
            else
            {
                dgvSinhvien.DataSource = null;
                List<Student> students = new List<Student>();
                students = listStudent.Where(s => s.Fullname.Contains(toolStripTextBox1.Text)).ToList();
                if (students.Count > 0)
                {
                    dgvSinhvien.DataSource = null;
                    dgvSinhvien.DataSource = students;
                }
            }
        }
    }
}

