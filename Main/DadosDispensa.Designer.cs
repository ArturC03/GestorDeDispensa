namespace Main
{
    partial class DadosDispensa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblUser = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnOk = new CustomControls.RJControls.RJButton();
            this.btnCancel = new CustomControls.RJControls.RJButton();
            this.txtMarca = new CustomControls.RJControls.RJTextBox();
            this.txtQuantidade = new CustomControls.RJControls.RJTextBox();
            this.txtPreco = new CustomControls.RJControls.RJTextBox();
            this.txtIdCategoria = new CustomControls.RJControls.RJTextBox();
            this.txtNome = new CustomControls.RJControls.RJTextBox();
            this.txtIdProduto = new CustomControls.RJControls.RJTextBox();
            this.SuspendLayout();
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblUser.Location = new System.Drawing.Point(10, 20);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(20, 16);
            this.lblUser.TabIndex = 9;
            this.lblUser.Text = "Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(12, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(10, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "idCategoria";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(12, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Preço";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(10, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "Quantidade";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(10, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 16);
            this.label5.TabIndex = 23;
            this.label5.Text = "Marca";
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.Crimson;
            this.btnOk.BackgroundColor = System.Drawing.Color.Crimson;
            this.btnOk.BorderColor = System.Drawing.Color.PapayaWhip;
            this.btnOk.BorderRadius = 7;
            this.btnOk.BorderSize = 0;
            this.btnOk.FlatAppearance.BorderSize = 0;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.btnOk.ForeColor = System.Drawing.Color.White;
            this.btnOk.Location = new System.Drawing.Point(142, 398);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(121, 40);
            this.btnOk.TabIndex = 25;
            this.btnOk.Text = "Ok";
            this.btnOk.TextColor = System.Drawing.Color.White;
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Crimson;
            this.btnCancel.BackgroundColor = System.Drawing.Color.Crimson;
            this.btnCancel.BorderColor = System.Drawing.Color.PapayaWhip;
            this.btnCancel.BorderRadius = 7;
            this.btnCancel.BorderSize = 0;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(15, 398);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(121, 40);
            this.btnCancel.TabIndex = 24;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.TextColor = System.Drawing.Color.White;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtMarca
            // 
            this.txtMarca.BackColor = System.Drawing.SystemColors.Window;
            this.txtMarca.BorderColor = System.Drawing.Color.Crimson;
            this.txtMarca.BorderFocusColor = System.Drawing.Color.Crimson;
            this.txtMarca.BorderRadius = 0;
            this.txtMarca.BorderSize = 2;
            this.txtMarca.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarca.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtMarca.Location = new System.Drawing.Point(13, 346);
            this.txtMarca.Margin = new System.Windows.Forms.Padding(4);
            this.txtMarca.Multiline = false;
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Padding = new System.Windows.Forms.Padding(7);
            this.txtMarca.PasswordChar = false;
            this.txtMarca.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMarca.PlaceholderText = "";
            this.txtMarca.Size = new System.Drawing.Size(250, 31);
            this.txtMarca.TabIndex = 5;
            this.txtMarca.Texts = "";
            this.txtMarca.UnderlinedStyle = false;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.BackColor = System.Drawing.SystemColors.Window;
            this.txtQuantidade.BorderColor = System.Drawing.Color.Crimson;
            this.txtQuantidade.BorderFocusColor = System.Drawing.Color.Crimson;
            this.txtQuantidade.BorderRadius = 0;
            this.txtQuantidade.BorderSize = 2;
            this.txtQuantidade.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidade.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtQuantidade.Location = new System.Drawing.Point(13, 283);
            this.txtQuantidade.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuantidade.Multiline = false;
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Padding = new System.Windows.Forms.Padding(7);
            this.txtQuantidade.PasswordChar = false;
            this.txtQuantidade.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtQuantidade.PlaceholderText = "";
            this.txtQuantidade.Size = new System.Drawing.Size(250, 31);
            this.txtQuantidade.TabIndex = 4;
            this.txtQuantidade.Texts = "";
            this.txtQuantidade.UnderlinedStyle = false;
            // 
            // txtPreco
            // 
            this.txtPreco.BackColor = System.Drawing.SystemColors.Window;
            this.txtPreco.BorderColor = System.Drawing.Color.Crimson;
            this.txtPreco.BorderFocusColor = System.Drawing.Color.Crimson;
            this.txtPreco.BorderRadius = 0;
            this.txtPreco.BorderSize = 2;
            this.txtPreco.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreco.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPreco.Location = new System.Drawing.Point(15, 223);
            this.txtPreco.Margin = new System.Windows.Forms.Padding(4);
            this.txtPreco.Multiline = false;
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Padding = new System.Windows.Forms.Padding(7);
            this.txtPreco.PasswordChar = false;
            this.txtPreco.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPreco.PlaceholderText = "";
            this.txtPreco.Size = new System.Drawing.Size(250, 31);
            this.txtPreco.TabIndex = 3;
            this.txtPreco.Texts = "";
            this.txtPreco.UnderlinedStyle = false;
            // 
            // txtIdCategoria
            // 
            this.txtIdCategoria.BackColor = System.Drawing.SystemColors.Window;
            this.txtIdCategoria.BorderColor = System.Drawing.Color.Crimson;
            this.txtIdCategoria.BorderFocusColor = System.Drawing.Color.Crimson;
            this.txtIdCategoria.BorderRadius = 0;
            this.txtIdCategoria.BorderSize = 2;
            this.txtIdCategoria.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdCategoria.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtIdCategoria.Location = new System.Drawing.Point(13, 102);
            this.txtIdCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdCategoria.Multiline = false;
            this.txtIdCategoria.Name = "txtIdCategoria";
            this.txtIdCategoria.Padding = new System.Windows.Forms.Padding(7);
            this.txtIdCategoria.PasswordChar = false;
            this.txtIdCategoria.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtIdCategoria.PlaceholderText = "";
            this.txtIdCategoria.Size = new System.Drawing.Size(250, 31);
            this.txtIdCategoria.TabIndex = 1;
            this.txtIdCategoria.Texts = "";
            this.txtIdCategoria.UnderlinedStyle = false;
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.SystemColors.Window;
            this.txtNome.BorderColor = System.Drawing.Color.Crimson;
            this.txtNome.BorderFocusColor = System.Drawing.Color.Crimson;
            this.txtNome.BorderRadius = 0;
            this.txtNome.BorderSize = 2;
            this.txtNome.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNome.Location = new System.Drawing.Point(15, 163);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.Multiline = false;
            this.txtNome.Name = "txtNome";
            this.txtNome.Padding = new System.Windows.Forms.Padding(7);
            this.txtNome.PasswordChar = false;
            this.txtNome.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNome.PlaceholderText = "";
            this.txtNome.Size = new System.Drawing.Size(250, 31);
            this.txtNome.TabIndex = 2;
            this.txtNome.Texts = "";
            this.txtNome.UnderlinedStyle = false;
            // 
            // txtIdProduto
            // 
            this.txtIdProduto.BackColor = System.Drawing.SystemColors.Window;
            this.txtIdProduto.BorderColor = System.Drawing.Color.Crimson;
            this.txtIdProduto.BorderFocusColor = System.Drawing.Color.Crimson;
            this.txtIdProduto.BorderRadius = 0;
            this.txtIdProduto.BorderSize = 2;
            this.txtIdProduto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdProduto.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtIdProduto.Location = new System.Drawing.Point(13, 40);
            this.txtIdProduto.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdProduto.Multiline = false;
            this.txtIdProduto.Name = "txtIdProduto";
            this.txtIdProduto.Padding = new System.Windows.Forms.Padding(7);
            this.txtIdProduto.PasswordChar = false;
            this.txtIdProduto.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtIdProduto.PlaceholderText = "";
            this.txtIdProduto.Size = new System.Drawing.Size(250, 31);
            this.txtIdProduto.TabIndex = 0;
            this.txtIdProduto.Texts = "";
            this.txtIdProduto.UnderlinedStyle = false;
            // 
            // DadosDispensa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 450);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIdCategoria);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.txtIdProduto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DadosDispensa";
            this.Text = "DadosDispensa";
            this.Load += new System.EventHandler(this.DadosDispensa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUser;
        private CustomControls.RJControls.RJTextBox txtIdProduto;
        private System.Windows.Forms.Label label3;
        private CustomControls.RJControls.RJTextBox txtNome;
        private System.Windows.Forms.Label label1;
        private CustomControls.RJControls.RJTextBox txtIdCategoria;
        private System.Windows.Forms.Label label2;
        private CustomControls.RJControls.RJTextBox txtPreco;
        private System.Windows.Forms.Label label4;
        private CustomControls.RJControls.RJTextBox txtQuantidade;
        private System.Windows.Forms.Label label5;
        private CustomControls.RJControls.RJTextBox txtMarca;
        private CustomControls.RJControls.RJButton btnCancel;
        private CustomControls.RJControls.RJButton btnOk;
    }
}