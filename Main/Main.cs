using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Main
{
    public partial class Main : Form
    {
        private LogIn logIn = new LogIn();
        public Main(LogIn logIn)
        {
            InitializeComponent();
            this.logIn = logIn;
        }

        private void btnGestDispensa_Click(object sender, EventArgs e)
        {
            FormsDispensa dispensa = new FormsDispensa();

            dispensa.TopLevel = false;
            dispensa.AutoScroll = true;

            panelMain.Controls.Clear();
            panelMain.Controls.Add(dispensa);

            dispensa.Show();
        }
        private void btnGestCategoria_Click(object sender, EventArgs e)
        {
            FormsCategoria categoria = new FormsCategoria();

            categoria.TopLevel = false;
            categoria.AutoScroll = true;

            panelMain.Controls.Clear();
            panelMain.Controls.Add(categoria);
            
            categoria.Show();
            
        }
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            logIn.Show();
            this.Hide();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
        

        private void panelMain_Resize(object sender, EventArgs e)
        {
            foreach (Form form in panelMain.Controls)
            {
                form.Width = panelMain.Width - 7;
                form.Height = panelMain.Height - 7;
            }
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
        private void btnHistorico_MouseEnter(object sender, EventArgs e)
        {
            btnHistorico.BackColor = Color.Crimson;
            btnHistorico.ForeColor = Color.White;

        }

        private void btnHistorico_MouseLeave(object sender, EventArgs e)
        {
            btnHistorico.ForeColor = Color.Crimson;
            btnHistorico.BackColor = Color.White;

        }
        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void Main_Load(object sender, EventArgs e)
        {
        }

        private void btnHistorico_Click(object sender, EventArgs e)
        {
            FormsHistorico historico = new FormsHistorico();

            historico.TopLevel = false;
            historico.AutoScroll = true;

            panelMain.Controls.Clear();
            panelMain.Controls.Add(historico);

            historico.Show();

        }
    }
}



