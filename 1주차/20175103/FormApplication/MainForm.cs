using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormApplication
{
    // MainForm : Form 기본 폼을 상속 받아서 동작시킴.
    public partial class MainForm : Form
    {
        // 생성자
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // label2의 Text형태에 대입
            label2.Text = textBox1.Text;
        }
    }
}
