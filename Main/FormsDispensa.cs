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
    public partial class FormsDispensa : Form
    {
        public FormsDispensa()
        {
            InitializeComponent();
        }

        private void FormsDispensa_Load(object sender, EventArgs e)
        {

        }

        private void CreateProdutoListView(ref System.Windows.Forms.ListView lstvProduto)
        {
            lstvProduto.Items.Clear();
            lstvProduto.Columns.Clear();
            ColumnHeader[] titulos= new ColumnHeader[Produto.Fields.Length];
            int k = 0;

            for(int i = 0; i <  titulos.Length; i++)
            {
                titulos[i] = new ColumnHeader();
            }

            foreach(ColumnHeader col in titulos)
            {   
                col.Name = Produto.Fields[k];
                char firstChar = Char.ToUpper(Produto.Fields[k][0]);
                string capitalizedStr = firstChar + Produto.Fields[k].Substring(1);
                col.Text = capitalizedStr;
                col.Width = 100;
                k++;
            }
            lstvProduto.Columns.AddRange(titulos);

        }
        
        private void LoadProdutoListView(ref System.Windows.Forms.ListView lstvProduto, string[] fields)
        {
            Produto produto = new Produto();
            List<string>[] values;
            values = produto.Select(fields);
            // Configurações da ListView
            lstvProduto.View = View.Details;
            lstvProduto.FullRowSelect = true;
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
        

    }
}
