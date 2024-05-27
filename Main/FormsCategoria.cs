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
    public partial class FormsCategoria : Form
    {
        public FormsCategoria()
        {
            InitializeComponent();
        }

        private void FormsCategoria_Load(object sender, EventArgs e)
        {

        }
        
        private void CreateCategoriaListView(ref System.Windows.Forms.ListView lstvCategoria)
        {
            lstvCategoria.Items.Clear();
            lstvCategoria.Columns.Clear();
            ColumnHeader[] titulos= new ColumnHeader[Categoria.Fields.Length];
            int k = 0;

            for(int i = 0; i <  titulos.Length; i++)
            {
                titulos[i] = new ColumnHeader();
            }

            foreach(ColumnHeader col in titulos)
            {   
                col.Name = Categoria.Fields[k];
                char firstChar = Char.ToUpper(Categoria.Fields[k][0]);
                string capitalizedStr = firstChar + Categoria.Fields[k].Substring(1);
                col.Text = capitalizedStr;
                col.Width = 100;
                k++;
            }
            lstvCategoria.Columns.AddRange(titulos);

        }
        private void LoadCategoriaListView(ref System.Windows.Forms.ListView lstvCategoria, string[] fields)
        {
            Categoria categoria = new Categoria();
            List<string>[] values;
            values = categoria.Select(fields);
            // Configurações da ListView
            lstvCategoria.View = View.Details;
            lstvCategoria.FullRowSelect = true;
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
    
    }

}
