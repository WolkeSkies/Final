using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormProject
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MatchingGame_Click(object sender, EventArgs e)
        {
            var frm = new MatchingGameMenu();
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }

        private void ImageViewer_Click(object sender, EventArgs e)
        {
            var frm = new Form2();
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); }; 
            frm.Show();
            this.Hide();
        }
    }
}
