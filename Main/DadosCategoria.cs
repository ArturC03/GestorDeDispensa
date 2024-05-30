using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main
{
    public partial class DadosCategoria : Form
    {
        private string tipoVisualizacao;
        private int id;
        private FormsCategoria formsCategoria;
        public DadosCategoria(FormsCategoria forms, string tipoVisualizacao, int id)
        {
            Categoria categoria = new Categoria();
            InitializeComponent();
            this.tipoVisualizacao = tipoVisualizacao;
            this.id = id;
            formsCategoria = forms;
        }
        public DadosCategoria()
        {
            InitializeComponent();
        }
        
        private string ApenasDigitos(string Text)
        {
            StringBuilder correto = new StringBuilder();

            foreach (char chr in Text)
                if(char.IsDigit(chr) || chr == '.' || chr == ',')
                    correto.Append(chr);
                
            return correto.ToString();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DBConnect dBConnect = new DBConnect();
            Tabela categoria = new Categoria();
            try
            {
                if ("Alterar" == tipoVisualizacao)
                {
                    string[] changes = new string[Categoria.Fields.Length];

                    // Carregar as mudanças para o vetor
                    changes[0] = $"{Categoria.Fields[0]}={txtIdCategoria.Texts}";
                    changes[1] = $"{Categoria.Fields[1]}='{txtCategoria.Texts}'";

                    // Chamar as mudanças
                    categoria.Update(changes, $"{dBConnect.Database}.Categoria.{Categoria.Fields[0]}={txtIdCategoria.Texts}");


                }
                else
                    if ("Adicionar" == tipoVisualizacao)
                {
                    
                    string[] fields = new string[Categoria.Fields.Length];
                    string[] values = new string[Categoria.Fields.Length];

                    fields[0] = $"{Categoria.Fields[0]}";
                    fields[1] = $"{Categoria.Fields[1]}";

                    values[0] = $"{txtIdCategoria.Texts}";
                    values[1] = $"'{txtCategoria.Texts}'";

                    categoria.Insert(fields, values);

                }

                    this.formsCategoria.RefreshListView();
                    this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Falha na inserção de Dados:\n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
      
        private void DadosCategoria_Load(object sender, EventArgs e)
        {
            DBConnect dBConnect = new DBConnect();
            Tabela categoria = new Categoria();

            List<string>[] fields = categoria.Select("*".Split(), $"{dBConnect.Database}.Categoria.{Categoria.Fields[0]} = {id}");
            if ("Adicionar" != tipoVisualizacao)
            {
                txtIdCategoria.Texts = fields[0][0];
                txtCategoria.Texts = fields[1][0];
            }
            if("Adicionar" == tipoVisualizacao)
            {
                txtIdCategoria.Texts = id + string.Empty;
            }
            if ("Alterar" != tipoVisualizacao && "Adicionar" != tipoVisualizacao)
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

        private void txtIdCategoria__TextChanged(object sender, EventArgs e)
        {
            btnOk.Enabled = true;
            if (string.IsNullOrEmpty(txtIdCategoria.Texts.Trim()) || string.IsNullOrEmpty(txtCategoria.Texts.Trim()))
                btnOk.Enabled = false;

            txtIdCategoria.Texts = ApenasDigitos(txtIdCategoria.Texts);
        }

        private void txtCategoria__TextChanged(object sender, EventArgs e)
        {
            btnOk.Enabled = true;
            if (string.IsNullOrEmpty(txtIdCategoria.Texts.Trim()) || string.IsNullOrEmpty(txtCategoria.Texts.Trim()))
                btnOk.Enabled = false;
        }
    }
}
