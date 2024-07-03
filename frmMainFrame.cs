using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace bookLibrary
{
    public partial class frmMainFrame : Form
    {
        public frmMainFrame()
        {
            InitializeComponent();
        }

        private void frmMainFrame_Load(object sender, EventArgs e)
        {
            dateLable.Text = DateTime.Now.ToString("dd-MM-yyyy");

            //this.BackgroundImage = Image.FromFile("path_to_your_image.jpg");
            //this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMainFrame_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmBook frm = new frmBook();
            frm.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            frmUser frm = new frmUser();
            frm.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            frmCategories frm = new frmCategories();
            frm.ShowDialog();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            frmBorrower frm = new frmBorrower();
            frm.ShowDialog();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            frmBorrow frm = new frmBorrow();
            frm.ShowDialog();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            frmUnReturn frm = new frmUnReturn();
            frm.ShowDialog();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            frmBooksBorrow frm = new frmBooksBorrow();
            frm.ShowDialog();
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {

        }

    }
}
