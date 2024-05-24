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

            if (txtUsername.Texts != dBConnect.Uid)
                MessageBox.Show("O utilizador especificado não existe", "Utilizador não Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                if (txtPass.Texts != dBConnect.Password)
                MessageBox.Show("Password inserida não corresponde à do utilizador", "Password Incorreta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                Main main = new Main();
                main.Show();
                
            }



        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
