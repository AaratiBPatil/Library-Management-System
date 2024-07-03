using System;
using System.Windows.Forms;

namespace bookLibrary
{
    public partial class frmLogin : Form
    {
        data _data = new data();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
           /* try { pictureBox.Image = new Bitmap(@"source\images\logo.png"); pictureLable.Hide(); } catch { }*/
            userNameTextBox.Focus();
           // userNameTextBox.Text = "shubhams1401"; passwordTextBox.Text = "shubhams1401";
        }

        private void cancleButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _data.myWeb();   
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            
            if (userNameTextBox.Text != String.Empty)
            {
                if (passwordTextBox.Text != String.Empty)
                {
                    
                    frmWorking frmWorking = new frmWorking();
                    frmWorking.Show();
                    if (_data.chekLogin(userNameTextBox.Text, passwordTextBox.Text))
                    {
                        frmMainFrame frm = new frmMainFrame();
                        frm.Show();
                        this.Hide();
                    }

                    frmWorking.Close();
                }
                else { MessageBox.Show("Please Enter Password..."); }
            }
            else { MessageBox.Show("Please Enter User Name..."); }
        }
    }
}
