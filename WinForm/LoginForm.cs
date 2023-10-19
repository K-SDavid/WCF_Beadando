using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForm.MusicService;

namespace WinForm
{
    public partial class LoginForm : Form
    {
        Service1Client client;

        public LoginForm()
        {
            client = new Service1Client();

            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                MusicForm mf = new MusicForm(client.Login(tb_userInput.Text, tb_pwInput.Text), client);
                
                MessageBox.Show("Sikeres bejelentkezés!");

                mf.Show();
                this.Hide();
            }
            catch (FaultException<ServiceData> Fex)
            {
                MessageBox.Show(Fex.Detail.ErrorMessage, "LOGIN", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "LOGIN", MessageBoxButtons.OK);
            }
        }
    }
}
