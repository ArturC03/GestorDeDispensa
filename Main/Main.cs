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
    public partial class Main : Form
    {
        
        public Main()
        {
            InitializeComponent();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnHome_MouseHover(object sender, EventArgs e)
        {
        }

        private void btnHome_MouseLeave(object sender, EventArgs e)
        {
            btnHome.ForeColor = Color.Crimson;
            btnHome.BackColor = Color.White;
        }

        private void btnHome_MouseEnter(object sender, EventArgs e)
        {
            btnHome.BackColor = Color.Crimson;
            btnHome.ForeColor = Color.White;
        }

        private void btnGestDispensa_Click(object sender, EventArgs e)
        {

        }

        private void btnGestDispensa_MouseEnter(object sender, EventArgs e)
        {
            btnGestDispensa.BackColor = Color.Crimson;
            btnGestDispensa.ForeColor = Color.White;
        }

        private void btnGestDispensa_MouseLeave(object sender, EventArgs e)
        {
            btnGestDispensa.ForeColor = Color.Crimson;
            btnGestDispensa.BackColor = Color.White;
        }

        private void btnGestCategoria_MouseEnter(object sender, EventArgs e)
        {
            btnGestCategoria.BackColor = Color.Crimson;
            btnGestCategoria.ForeColor = Color.White;

        }

        private void btnGestCategoria_MouseLeave(object sender, EventArgs e)
        {
            btnGestCategoria.ForeColor = Color.Crimson;
            btnGestCategoria.BackColor = Color.White;

        }

        private void btnLogOut_MouseEnter(object sender, EventArgs e)
        {
            btnLogOut.BackColor = Color.Crimson;
            btnLogOut.ForeColor = Color.White;

        }

        private void btnLogOut_MouseLeave(object sender, EventArgs e)
        {
            btnLogOut.ForeColor = Color.Crimson;
            btnLogOut.BackColor = Color.White;

        }

        private void btnExit_MouseEnter(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.Crimson;
            btnExit.ForeColor = Color.White;

        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            btnExit.ForeColor = Color.Crimson;
            btnExit.BackColor = Color.White;

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if(panelMenu.Visible)
                panelMenu.Visible = false;
            else
                panelMenu.Visible = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.Show();
            
        }

        private void Main_Load(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.Hide();
        }
    }
}
