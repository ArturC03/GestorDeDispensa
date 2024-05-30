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
    public partial class FormsHistorico : Form
    {
        public FormsHistorico()
        {
            InitializeComponent();
        }

        private void FormsHistorico_Load(object sender, EventArgs e)
        {
            CreateHistoricoListView(ref lstv);
            LoadCategoriaListView(ref lstv,"*".Split());
        }
        private void CreateHistoricoListView(ref System.Windows.Forms.ListView lstvHistorico)
        {
            lstvHistorico.Items.Clear();
            lstvHistorico.Columns.Clear();
            ColumnHeader[] titulos = new ColumnHeader[Historico.Fields.Length];
            int k = 0;

            for (int i = 0; i < titulos.Length; i++)
            {
                titulos[i] = new ColumnHeader();
            }

            foreach (ColumnHeader col in titulos)
            {
                col.Name = Historico.Fields[k];
                char firstChar = Char.ToUpper(Historico.Fields[k][0]);
                string capitalizedStr = firstChar + Historico.Fields[k].Substring(1);
                col.Text = capitalizedStr;
                col.Width = 100;
                k++;
            }
            lstvHistorico.Columns.AddRange(titulos);

            for (int i = 0; i < lstvHistorico.Columns.Count; i++)
            {
                lstvHistorico.AutoResizeColumn(i, ColumnHeaderAutoResizeStyle.HeaderSize);
            }

        }
        private void LoadCategoriaListView(ref System.Windows.Forms.ListView lstvHistorico, string[] fields)
        {
            lstvHistorico.Items.Clear();
            Tabela historico = new Historico();
            List<string>[] values;
            values = historico.Select("*".Split(), null, $"{Historico.Fields[6]} DESC");

            // Configurações da ListView
            lstvHistorico.View = View.Details;
            lstvHistorico.FullRowSelect = true;
            lstvHistorico.MultiSelect = true;
            if (values.Length > 0)
            {
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
                    lstvHistorico.Items.Add(listViewItem);
                }
            }
            for (int i = 0; i < lstvHistorico.Columns.Count; i++)
            {
                // Primeiro, ajusta a coluna para o conteúdo
                lstvHistorico.AutoResizeColumn(i, ColumnHeaderAutoResizeStyle.ColumnContent);

                // Obter a largura do conteúdo ajustado
                int contentWidth = lstvHistorico.Columns[i].Width;

                // Ajusta a coluna para o título e obter a largura do título
                lstvHistorico.AutoResizeColumn(i, ColumnHeaderAutoResizeStyle.HeaderSize);
                int headerWidth = lstvHistorico.Columns[i].Width;

                // Se a largura do conteúdo for menor que a largura do título, usa a largura do título
                if (contentWidth > headerWidth)
                {
                    lstvHistorico.Columns[i].Width = contentWidth;
                }
                else
                {
                    lstvHistorico.Columns[i].Width = headerWidth;
                }
            }
        }

    }
}
