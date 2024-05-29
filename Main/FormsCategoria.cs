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
            CreateCategoriaListView(ref lstv);
            LoadCategoriaListView(ref lstv, "*".Split());
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

            for (int i = 0; i < lstvCategoria.Columns.Count; i++)
            {
                lstvCategoria.AutoResizeColumn(i, ColumnHeaderAutoResizeStyle.HeaderSize);
            }

        }
        private void LoadCategoriaListView(ref System.Windows.Forms.ListView lstvCategoria, string[] fields)
        {
            lstvCategoria.Items.Clear();
            Categoria categoria = new Categoria();
            List<string>[] values;
            values = categoria.Select("*".Split());

            // Configurações da ListView
            lstvCategoria.View = View.Details;
            lstvCategoria.FullRowSelect = true;
            lstvCategoria.MultiSelect = true;

            int innerCount = values[0].Count;

            // Inserir todos os campos da tabela Produto
            List<string> row = new List<string>();

            for (int j = 0; j < innerCount; j++)
            {
                row = new List<string>();
                string[] linha = null;
                for (int i = 0; values.Length > i; i++)
                {
                    row.Add(values[i][j]);
                }
                linha = row.ToArray();
                var listViewItem = new ListViewItem(linha);
                lstvCategoria.Items.Add(listViewItem);
            }

            for (int i = 0; i < lstvCategoria.Columns.Count; i++)
            {
                // Primeiro, ajusta a coluna para o conteúdo
                lstvCategoria.AutoResizeColumn(i, ColumnHeaderAutoResizeStyle.ColumnContent);

                // Obter a largura do conteúdo ajustado
                int contentWidth = lstvCategoria.Columns[i].Width;

                // Ajusta a coluna para o título e obter a largura do título
                lstvCategoria.AutoResizeColumn(i, ColumnHeaderAutoResizeStyle.HeaderSize);
                int headerWidth = lstvCategoria.Columns[i].Width;

                // Se a largura do conteúdo for menor que a largura do título, usa a largura do título
                if (contentWidth > headerWidth)
                {
                    lstvCategoria.Columns[i].Width = contentWidth;
                }
                else
                {
                    lstvCategoria.Columns[i].Width = headerWidth;
                }
            }
        }

        private void lstv_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (0 < lstv.SelectedItems.Count)
            {
                btnRemover.Enabled = true;
                btnAlterar.Enabled = true;
            }
            else
            {
                btnRemover.Enabled = false;
                btnAlterar.Enabled = false;
            }

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Categoria categoria = new Categoria();
            int id;
           
            if (0 < lstv.Items.Count)
               id = int.Parse(categoria.Max($"{Categoria.Fields[0]}")) + 1;
            else
               id = 0;

            //DadosDispensa dados = new DadosDispensa(this,"Adicionar", id);
            //dados.Show();


        }
    }

}
