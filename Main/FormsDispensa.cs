﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            CreateProdutoListView(ref lstv);
            LoadProdutoListView(ref lstv, "*".Split());
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

            // Inserir todos os campos da tabela Produto
            List<string> row = new List<string>();
            for (int j = 0; j < values[j].Count; j++) {
                row = new List<string>();
                string[] linha = null;
                for (int i = 0; values.Length > i; i++) {
                    row.Add(values[i][j]);
                }
                linha = row.ToArray();
                    var listViewItem = new ListViewItem(linha);
                    lstvProduto.Items.Add(listViewItem);
           }
            Categoria categoria = new Categoria();

            // Pegar no idCategoria e Mostrar o nome da Categoria
            for(int i = 0; i < lstvProduto.Items.Count; i++)
            {
                 List<string>[] nomeCategoria = categoria.Select(Categoria.Fields[1].Split(), $"{Categoria.Fields[0]}={lstvProduto.Items[i].SubItems[1].Text}");
                lstvProduto.Items[i].SubItems[1].Text = nomeCategoria[0][0];
            }


        }

        public void RefreshListView()
        {
            CreateProdutoListView(ref lstv);
            LoadProdutoListView(ref lstv, "*".Split());
        }
  
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            DadosDispensa dados = new DadosDispensa(this,"Alterar", lstv.SelectedIndices[0]);
            dados.Show();

            btnAlterar.Enabled = false;
        }

        private void lstv_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstv.SelectedItems.Count > 0) 
                btnAlterar.Enabled = true;
            else
                btnAlterar.Enabled = false;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto();
            int id;
           
            if (0 < lstv.Items.Count)
               id = int.Parse(produto.Max($"{Produto.Fields[0]}")) + 1;
                       else
                id = 0;

            DadosDispensa dados = new DadosDispensa(this,"Adicionar", id);
            dados.Show();

        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto();

            while(lstv.SelectedIndices.Count > 0)
            {
                produto.Delete($"idProduto={lstv.SelectedItems[0].SubItems[0].Text}");
                lstv.Items.RemoveAt(lstv.SelectedIndices[0]);
            }
            LoadProdutoListView(ref lstv, "*".Split()); 

        }



        // Remove Function (Use DELETE with a condition on the idProduto)

        // Alter Function (Use AfterLabelEdit to detect changes to the listview and enable update button)

        // Add Function (Use Insert)



    }
}
