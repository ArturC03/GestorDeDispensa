using CustomControls.RJControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Internal;
using System.Drawing;
using System.Drawing.Drawing2D;
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
            Tabela  categoria = new Categoria();
            cboIdCategoria.Items.Clear();
            List<string>[] categorias = categoria.Select(Categoria.Fields[1].Split(), null, Categoria.Fields[0]);
            for(int i = 0; i < categorias[0].Count; i++) {
                cboIdCategoria.Items.Add(categorias[0][i]);
            }
            txtIdProduto.Texts = id + string.Empty;
        }

        private void DadosDispensa_Load(object sender, EventArgs e)
        {
            DBConnect dBConnect = new DBConnect();
            Tabela produto = new Produto();

            LoadCboIdCategoria();

            List<string>[] fields = produto.Select("*".Split(), $"{dBConnect.Database}.Produto.{Produto.Fields[0]} = {id}");
            if ("Adicionar" != tipoVisualizacao)
            {
                txtIdProduto.Enabled = false;
                txtIdProduto.Texts = fields[0][0];
                cboIdCategoria.SelectedIndex = int.Parse(fields[1][0]);
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

                 btnCancel.Visible = false;
                 btnOk.Visible= false;

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DBConnect dBConnect = new DBConnect();
            Tabela produto = new Produto();
            try
            {
                if ("Alterar" == tipoVisualizacao)
                {
                    string[] changes = new string[Produto.Fields.Length];

                    // Carregar as mudanças para o vetor
                    changes[0] = $"{Produto.Fields[0]}={txtIdProduto.Texts}";
                    changes[1] = $"{Produto.Fields[1]}={cboIdCategoria.SelectedIndex}";
                    changes[2] = $"{Produto.Fields[2]}='{txtNome.Texts}'";
                    changes[3] = $"{Produto.Fields[3]}={txtPreco.Texts.Replace(',', '.')}";
                    changes[4] = $"{Produto.Fields[4]}={txtQuantidade.Texts}";
                    changes[5] = $"{Produto.Fields[5]}='{txtMarca.Texts}'";

                    // Chamar as mudanças
                    produto.Update(changes, $"{Produto.Fields[0]}={txtIdProduto.Texts}");

                }
                else
                    if ("Adicionar" == tipoVisualizacao)
                {
                    if (1 > produto.Count(Produto.Fields[0], $"{Produto.Fields[0]} = {txtIdProduto.Texts.Trim()}"))
                    {
                
                        string[] fields = new string[Produto.Fields.Length];
                        string[] values = new string[Produto.Fields.Length];

                        fields[0] = $"{Produto.Fields[0]}";
                        fields[1] = $"{Produto.Fields[1]}";
                        fields[2] = $"{Produto.Fields[2]}";
                        fields[3] = $"{Produto.Fields[3]}";
                        fields[4] = $"{Produto.Fields[4]}";
                        fields[5] = $"{Produto.Fields[5]}";

                        values[0] = $"{txtIdProduto.Texts}";
                        values[1] = $"{cboIdCategoria.SelectedIndex}";
                        values[2] = $"'{txtNome.Texts}'";
                        values[3] = $"{txtPreco.Texts.Replace(',', '.')}";
                        values[4] = $"{txtQuantidade.Texts}";
                        values[5] = $"'{txtMarca.Texts}'";

                        produto.Insert(fields, values);
                    }
                    else
                    {
                        MessageBox.Show("Erro, IdProduto já se encontra associado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

                    this.formsDispensa.RefreshListView();
                    this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Falha na inserção de Dados:\n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string ApenasDigitos(string Text)
        {
            StringBuilder correto = new StringBuilder();

            foreach (char chr in Text)
                if(char.IsDigit(chr) || chr == '.' || chr == ',')
                    correto.Append(chr);
                
            return correto.ToString();

        }

        private void txtIdProduto__TextChanged(object sender, EventArgs e)
        {
            btnOk.Enabled = true;

            if (string.IsNullOrEmpty(txtIdProduto.Texts.Trim()) || 0 > cboIdCategoria.SelectedIndex|| string.IsNullOrEmpty(txtNome.Texts.Trim()) || string.IsNullOrEmpty(txtPreco.Texts.Trim()) || string.IsNullOrEmpty(txtQuantidade.Texts.Trim()) || string.IsNullOrEmpty(txtMarca.Texts.Trim()))
                btnOk.Enabled = false;
            txtIdProduto.Texts = ApenasDigitos(txtIdProduto.Texts);
        }

        private void txtQuantidade__TextChanged(object sender, EventArgs e)
        {
            
            btnOk.Enabled = true;
            if (string.IsNullOrEmpty(txtIdProduto.Texts.Trim()) || 0 > cboIdCategoria.SelectedIndex || string.IsNullOrEmpty(txtNome.Texts.Trim()) || string.IsNullOrEmpty(txtPreco.Texts.Trim()) || string.IsNullOrEmpty(txtQuantidade.Texts.Trim()) || string.IsNullOrEmpty(txtMarca.Texts.Trim()))
                btnOk.Enabled = false;

            txtQuantidade.Texts = ApenasDigitos(txtQuantidade.Texts);
        }

        private void txtPreco__TextChanged(object sender, EventArgs e)
        {
            btnOk.Enabled = true;
            if (string.IsNullOrEmpty(txtIdProduto.Texts.Trim()) || 0 > cboIdCategoria.SelectedIndex || string.IsNullOrEmpty(txtNome.Texts.Trim()) || string.IsNullOrEmpty(txtPreco.Texts.Trim()) || string.IsNullOrEmpty(txtQuantidade.Texts.Trim()) || string.IsNullOrEmpty(txtMarca.Texts.Trim()))
                btnOk.Enabled = false;

            txtPreco.Texts = ApenasDigitos(txtPreco.Texts);
        }

        private void txtNome__TextChanged(object sender, EventArgs e)
        {
            
            btnOk.Enabled = true;
            if (string.IsNullOrEmpty(txtIdProduto.Texts.Trim()) || 0 > cboIdCategoria.SelectedIndex || string.IsNullOrEmpty(txtNome.Texts.Trim()) || string.IsNullOrEmpty(txtPreco.Texts.Trim()) || string.IsNullOrEmpty(txtQuantidade.Texts.Trim()) || string.IsNullOrEmpty(txtMarca.Texts.Trim()))
                btnOk.Enabled = false;


        }

        private void txtMarca__TextChanged(object sender, EventArgs e)
        {
            btnOk.Enabled = true;
            if (string.IsNullOrEmpty(txtIdProduto.Texts.Trim()) || 0 > cboIdCategoria.SelectedIndex || string.IsNullOrEmpty(txtNome.Texts.Trim()) || string.IsNullOrEmpty(txtPreco.Texts.Trim()) || string.IsNullOrEmpty(txtQuantidade.Texts.Trim()) || string.IsNullOrEmpty(txtMarca.Texts.Trim()))
                btnOk.Enabled = false;

        }

        private void cboIdCategoria_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            btnOk.Enabled = true;
            if (string.IsNullOrEmpty(txtIdProduto.Texts.Trim()) ||  0 > cboIdCategoria.SelectedIndex || string.IsNullOrEmpty(txtNome.Texts.Trim()) || string.IsNullOrEmpty(txtPreco.Texts.Trim()) || string.IsNullOrEmpty(txtQuantidade.Texts.Trim()) || string.IsNullOrEmpty(txtMarca.Texts.Trim()))
                btnOk.Enabled = false;

        }
    }
}
