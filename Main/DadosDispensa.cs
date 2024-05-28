using CustomControls.RJControls;
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
    public partial class DadosDispensa : Form
    {
        private string tipoVisualizacao;
        private int id;
        private FormsDispensa formsDispensa;
        public DadosDispensa(FormsDispensa forms, string tipoVisualizacao, int id)
        {
            InitializeComponent();
            this.tipoVisualizacao = tipoVisualizacao;
            this.id = id;
            formsDispensa = forms;
        }

        private void LoadCboIdCategoria()
        {
            Categoria categoria = new Categoria();
            cboIdCategoria.Items.Clear();
            List<string>[] categorias = categoria.Select(Categoria.Fields[1].Split(), null, Categoria.Fields[0]);
            for(int i = 0; i < categorias[0].Count; i++) {
                cboIdCategoria.Items.Add(categorias[0][i]);
            }            
        }

        private void DadosDispensa_Load(object sender, EventArgs e)
        {
            DBConnect dBConnect = new DBConnect();
            Produto produto = new Produto();

            LoadCboIdCategoria();

            List<string>[] fields = produto.Select("*".Split(), $"{dBConnect.Database}.Produto.{Produto.Fields[0]} = {id}");
            if ("Adicionar" != tipoVisualizacao)
            {
                txtIdProduto.Texts = fields[0][0];
                txtIdCategoria.Texts = fields[1][0];
                txtNome.Texts = fields[2][0];
                txtPreco.Texts = fields[3][0];
                txtQuantidade.Texts = fields[4][0];
                txtMarca.Texts = fields[5][0];
            }

            if("Alterar" != tipoVisualizacao && "Adicionar" != tipoVisualizacao)
            {
                 foreach (Control control in this.Controls)
                    if (control is Label)
                        control.Enabled = true;
                    else
                        control.Enabled = false;

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DBConnect dBConnect = new DBConnect();
            Produto produto = new Produto();

            if ("Alterar" == tipoVisualizacao)
            {
                string[] changes = new string[Produto.Fields.Length];
                int i = 0;
                foreach (RJTextBox control in this.Controls.OfType<RJTextBox>().OrderBy(c => c.TabIndex))
                {
                    if (Produto.Type[i] == "double")

                        changes[i] = $"Produto.{Produto.Fields[i]} = {control.Texts.Replace(',', '.')}";

                    else
                        if (Produto.Type[i] != "varchar")
                    {

                        changes[i] = $"Produto.{Produto.Fields[i]} = {control.Texts}";
                    }
                    else
                        changes[i] = $"Produto.{Produto.Fields[i]} = \'{control.Texts}\'";
                    i++;
                }
                produto.Update(changes, $"{dBConnect.Database}.Produto.{Produto.Fields[0]}={id}");

                this.formsDispensa.RefreshListView();
                this.Close();

            }
            else
                if ("Adicionar" == tipoVisualizacao)
            {
                txtIdProduto.Texts = id + string.Empty;
                txtIdProduto.Enabled = false;
            }
        }
    }
}
