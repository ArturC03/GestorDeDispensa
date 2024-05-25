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
            CreateProdutoListView(ref lstv);
            LoadProdutoListView(ref lstv, "*".Split());
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
            if (panelMenu.Visible)
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
            logIn.Show();
            this.Hide();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            CreateProdutoListView(ref lstv);
            
            LoadProdutoListView(ref lstv, "*".Split());
        }
        private void CreateProdutoListView(ref System.Windows.Forms.ListView lstvProduto)
        {
            lstvProduto.Items.Clear();
            lstvProduto.Columns.Clear();
            ColumnHeader[] titulos= new ColumnHeader[Produto.ProdutoFields.Length];
            int k = 0;

            for(int i = 0; i <  titulos.Length; i++)
            {
                titulos[i] = new ColumnHeader();
            }

            foreach(ColumnHeader col in titulos)
            {   
                col.Name = Produto.ProdutoFields[k];
                char firstChar = Char.ToUpper(Produto.ProdutoFields[k][0]);
                string capitalizedStr = firstChar + Produto.ProdutoFields[k].Substring(1);
                col.Text = capitalizedStr;
                col.Width = 100;
                k++;
            }
            lstvProduto.Columns.AddRange(titulos);

        }


        
        private void CreateCategoriaListView(ref System.Windows.Forms.ListView lstvCategoria)
        {
            lstvCategoria.Items.Clear();
            lstvCategoria.Columns.Clear();
            ColumnHeader[] titulos= new ColumnHeader[Categoria.CategoriaFields.Length];
            int k = 0;

            for(int i = 0; i <  titulos.Length; i++)
            {
                titulos[i] = new ColumnHeader();
            }

            foreach(ColumnHeader col in titulos)
            {   
                col.Name = Categoria.CategoriaFields[k];
                char firstChar = Char.ToUpper(Categoria.CategoriaFields[k][0]);
                string capitalizedStr = firstChar + Categoria.CategoriaFields[k].Substring(1);
                col.Text = capitalizedStr;
                col.Width = 100;
                k++;
            }
            lstvCategoria.Columns.AddRange(titulos);

        }
        private void LoadProdutoListView(ref System.Windows.Forms.ListView lstvProduto, string[] fields)
        {
            Produto produto = new Produto();
            List<string>[] values;
            values = produto.Select(fields);
            // Configurações da ListView
            lstvProduto.View = View.Details;
            lstvProduto.FullRowSelect = false;
            lstvProduto.MultiSelect = true;

            List<string> row = new List<string>();
            for (int j = 0; j < values[j].Count; j++) {
                for (int i = 0; values.Length > i; i++) {
                    row.Add(values[i][j]);
                }
                string[] linha = row.ToArray();
                    var listViewItem = new ListViewItem(linha);
                    lstvProduto.Items.Add(listViewItem);
           }

        }
        private void LoadCategoriaListView(ref System.Windows.Forms.ListView lstvCategoria, string[] fields)
        {
            Categoria categoria = new Categoria();
            List<string>[] values;
            values = categoria.Select(fields);
            // Configurações da ListView
            lstvCategoria.View = View.Details;
            lstvCategoria.FullRowSelect = false;
            lstvCategoria.MultiSelect = true;

            List<string> row = new List<string>();
            for (int j = 0; j < values[j].Count; j++) {
                for (int i = 0; values.Length > i; i++) {
                    row.Add(values[i][j]);
                }
                string[] linha = row.ToArray();
                    var listViewItem = new ListViewItem(linha);
                    lstvCategoria.Items.Add(listViewItem);
           }

        }

        private void btnGestCategoria_Click(object sender, EventArgs e)
        {
  
            CreateCategoriaListView(ref lstv);

            string[] fields = { "*" };

            LoadCategoriaListView(ref lstv, fields);
            
        }
    }
}



