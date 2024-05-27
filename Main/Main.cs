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
            FormsDispensa dispensa = new FormsDispensa();

            dispensa.TopLevel = false;
            dispensa.AutoScroll = true;

            panelMain.Controls.Add(dispensa);
            
            dispensa.Show();
            //CreateProdutoListView(ref lstv);
            //LoadProdutoListView(ref lstv, "*".Split());
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            logIn.Show();
            this.Hide();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            //CreateProdutoListView(ref lstv);
            
            //LoadProdutoListView(ref lstv, "*".Split());
        }

        private void btnGestCategoria_Click(object sender, EventArgs e)
        {
  
            //CreateCategoriaListView(ref lstv);

            //string[] fields = { "*" };

            //LoadCategoriaListView(ref lstv, fields);
            
        }

        private void btnHome_Click(object sender, EventArgs e)
        {

        }

        private void panelMain_Resize(object sender, EventArgs e)
        {
            foreach (Form form in panelMain.Controls)
            {
                form.Width = panelMain.Width - 7;
                form.Height = panelMain.Height - 7;
            }
        }
    }
}



