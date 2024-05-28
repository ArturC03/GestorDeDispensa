using System;
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

        public void RefreshListView()
        {
            CreateProdutoListView(ref lstv);
            LoadProdutoListView(ref lstv, "*".Split());
        }
  
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            DadosDispensa dados = new DadosDispensa(this,"Alterar", lstv.SelectedIndices[0]);
            dados.Show();


            //Produto produto = new Produto();
            //DBConnect dBConnect = new DBConnect();
            
            //string[][] listViewData = new string[lstv.Items.Count][];
            
            //for (int i = 0; i < lstv.Items.Count; i++)
            //{
            //    ListViewItem item = lstv.Items[i];
            //    listViewData[i] = new string[item.SubItems.Count];
            //    for (int j = 0; j < item.SubItems.Count; j++)
            //    {
            //        listViewData[i][j] = item.SubItems[j].Text;
            //    }
            //}
       
            //for(int i = 0; i<listViewData.Length; i++)
            //    for (int j = 0; j < listViewData[i].Length; j++)
            //    {
            //        string field= Produto.Fields[j];
            //        if ("varchar" == Produto.Type[j])
            //            produto.Update($"{dBConnect.Database}.Produto.{Produto.Fields[j]} = '{listViewData[i][j]}'", $"{dBConnect.Database}.Produto.{Produto.Fields[0]}={listViewData[i][0]}");
            //        else
            //            produto.Update($"{dBConnect.Database}.Produto.{Produto.Fields[j]} = {listViewData[i][j]}", $"{dBConnect.Database}.Produto.{Produto.Fields[0]}={listViewData[i][0]}");
            //    }

            //btnAlterar.Enabled = false;
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
             MessageBox.Show($"{id}");

            DadosDispensa dados = new DadosDispensa(this,"Adicionar", id);
            dados.Show();

        }



        // Remove Function (Use DELETE with a condition on the idProduto)

        // Alter Function (Use AfterLabelEdit to detect changes to the listview and enable update button)

        // Add Function (Use Insert)



    }
}
