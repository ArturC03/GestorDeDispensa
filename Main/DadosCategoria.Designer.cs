namespace Main
{
    partial class DadosCategoria
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
            this.lblIdCategoria = new System.Windows.Forms.Label();
            this.txtIdCategoria = new CustomControls.RJControls.RJTextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.txtCategoria = new CustomControls.RJControls.RJTextBox();
            this.btnOk = new CustomControls.RJControls.RJButton();
            this.btnCancel = new CustomControls.RJControls.RJButton();
            this.SuspendLayout();
            // 
            // lblIdCategoria
            // 
            this.lblIdCategoria.AutoSize = true;
            this.lblIdCategoria.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblIdCategoria.Location = new System.Drawing.Point(12, 9);
            this.lblIdCategoria.Name = "lblIdCategoria";
            this.lblIdCategoria.Size = new System.Drawing.Size(20, 16);
            this.lblIdCategoria.TabIndex = 11;
            this.lblIdCategoria.Text = "Id";
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
            this.txtIdCategoria.Location = new System.Drawing.Point(15, 29);
            this.txtIdCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdCategoria.Multiline = false;
            this.txtIdCategoria.Name = "txtIdCategoria";
            this.txtIdCategoria.Padding = new System.Windows.Forms.Padding(7);
            this.txtIdCategoria.PasswordChar = false;
            this.txtIdCategoria.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtIdCategoria.PlaceholderText = "";
            this.txtIdCategoria.Size = new System.Drawing.Size(250, 31);
            this.txtIdCategoria.TabIndex = 10;
            this.txtIdCategoria.Texts = "";
            this.txtIdCategoria.UnderlinedStyle = false;
            this.txtIdCategoria._TextChanged += new System.EventHandler(this.txtIdProduto__TextChanged);
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblCategoria.Location = new System.Drawing.Point(12, 75);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(73, 16);
            this.lblCategoria.TabIndex = 17;
            this.lblCategoria.Text = "Categoria";
            // 
            // txtCategoria
            // 
            this.txtCategoria.BackColor = System.Drawing.SystemColors.Window;
            this.txtCategoria.BorderColor = System.Drawing.Color.Crimson;
            this.txtCategoria.BorderFocusColor = System.Drawing.Color.Crimson;
            this.txtCategoria.BorderRadius = 0;
            this.txtCategoria.BorderSize = 2;
            this.txtCategoria.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoria.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCategoria.Location = new System.Drawing.Point(15, 92);
            this.txtCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.txtCategoria.Multiline = false;
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Padding = new System.Windows.Forms.Padding(7);
            this.txtCategoria.PasswordChar = false;
            this.txtCategoria.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCategoria.PlaceholderText = "";
            this.txtCategoria.Size = new System.Drawing.Size(250, 31);
            this.txtCategoria.TabIndex = 16;
            this.txtCategoria.Texts = "";
            this.txtCategoria.UnderlinedStyle = false;
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
            this.btnOk.Location = new System.Drawing.Point(144, 146);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(121, 40);
            this.btnOk.TabIndex = 27;
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
            this.btnCancel.Location = new System.Drawing.Point(17, 146);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(121, 40);
            this.btnCancel.TabIndex = 26;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.TextColor = System.Drawing.Color.White;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // DadosCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 198);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.lblIdCategoria);
            this.Controls.Add(this.txtIdCategoria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DadosCategoria";
            this.Text = "DadosCategoria";
            this.Load += new System.EventHandler(this.DadosCategoria_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdCategoria;
        private CustomControls.RJControls.RJTextBox txtIdCategoria;
        private System.Windows.Forms.Label lblCategoria;
        private CustomControls.RJControls.RJTextBox txtCategoria;
        private CustomControls.RJControls.RJButton btnOk;
        private CustomControls.RJControls.RJButton btnCancel;
    }
}