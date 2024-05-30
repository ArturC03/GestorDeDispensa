using CustomControls.RJControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            DBConnect dBConnect = new DBConnect();

            if (txtUsername.Texts.Trim() != dBConnect.Uid)
                MessageBox.Show("O utilizador especificado não existe", "Utilizador não Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                if (txtPass.Texts != dBConnect.Password)
                MessageBox.Show("Password inserida não corresponde à do utilizador", "Password Incorreta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                    txtPass.Texts = string.Empty;
                chkPass.Checked = false;
                txtUsername.Focus();

                Main main = new Main(this); // Passar a instância de LogIn para Main
                main.Show();
                this.Hide();
                
            }

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void chkPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPass.Checked)
                txtPass.PasswordChar = false;
            else
                txtPass.PasswordChar = true;
        }
    }
}
