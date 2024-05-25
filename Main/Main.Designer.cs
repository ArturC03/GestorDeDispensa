namespace Main
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panelHome = new System.Windows.Forms.Panel();
            this.btnHome = new CustomControls.RJControls.RJButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.panelGestDispensa = new System.Windows.Forms.Panel();
            this.btnGestDispensa = new CustomControls.RJControls.RJButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelGestCategoria = new System.Windows.Forms.Panel();
            this.btnGestCategoria = new CustomControls.RJControls.RJButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panelLogOut = new System.Windows.Forms.Panel();
            this.btnLogOut = new CustomControls.RJControls.RJButton();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panelExit = new System.Windows.Forms.Panel();
            this.btnExit = new CustomControls.RJControls.RJButton();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.lstv = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.idCategoria = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.preco = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.quantidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.marca = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnMenu = new CustomControls.RJControls.RJButton();
            this.panelHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.panelGestDispensa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelGestCategoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panelLogOut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panelExit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHome
            // 
            this.panelHome.BackColor = System.Drawing.Color.White;
            this.panelHome.Controls.Add(this.btnHome);
            this.panelHome.Controls.Add(this.pictureBox1);
            this.panelHome.Location = new System.Drawing.Point(3, 10);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(200, 45);
            this.panelHome.TabIndex = 1;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnHome.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnHome.BorderRadius = 0;
            this.btnHome.BorderSize = 0;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.btnHome.ForeColor = System.Drawing.Color.Crimson;
            this.btnHome.Location = new System.Drawing.Point(47, 2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(150, 40);
            this.btnHome.TabIndex = 3;
            this.btnHome.Text = "HOME";
            this.btnHome.TextColor = System.Drawing.Color.Crimson;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.MouseEnter += new System.EventHandler(this.btnHome_MouseEnter);
            this.btnHome.MouseLeave += new System.EventHandler(this.btnHome_MouseLeave);
            this.btnHome.MouseHover += new System.EventHandler(this.btnHome_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 41);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Crimson;
            this.panelMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMenu.Controls.Add(this.panelHome);
            this.panelMenu.Controls.Add(this.panelGestDispensa);
            this.panelMenu.Controls.Add(this.panelGestCategoria);
            this.panelMenu.Controls.Add(this.panelLogOut);
            this.panelMenu.Controls.Add(this.panelExit);
            this.panelMenu.Location = new System.Drawing.Point(8, 58);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Padding = new System.Windows.Forms.Padding(0, 7, 0, 7);
            this.panelMenu.Size = new System.Drawing.Size(211, 271);
            this.panelMenu.TabIndex = 0;
            this.panelMenu.Visible = false;
            // 
            // panelGestDispensa
            // 
            this.panelGestDispensa.BackColor = System.Drawing.Color.White;
            this.panelGestDispensa.Controls.Add(this.btnGestDispensa);
            this.panelGestDispensa.Controls.Add(this.pictureBox2);
            this.panelGestDispensa.Location = new System.Drawing.Point(3, 61);
            this.panelGestDispensa.Name = "panelGestDispensa";
            this.panelGestDispensa.Size = new System.Drawing.Size(200, 45);
            this.panelGestDispensa.TabIndex = 2;
            // 
            // btnGestDispensa
            // 
            this.btnGestDispensa.BackColor = System.Drawing.Color.Transparent;
            this.btnGestDispensa.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnGestDispensa.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnGestDispensa.BorderRadius = 0;
            this.btnGestDispensa.BorderSize = 0;
            this.btnGestDispensa.FlatAppearance.BorderSize = 0;
            this.btnGestDispensa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestDispensa.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.btnGestDispensa.ForeColor = System.Drawing.Color.Crimson;
            this.btnGestDispensa.Location = new System.Drawing.Point(47, 2);
            this.btnGestDispensa.Name = "btnGestDispensa";
            this.btnGestDispensa.Size = new System.Drawing.Size(150, 40);
            this.btnGestDispensa.TabIndex = 3;
            this.btnGestDispensa.Text = "DISPENSA";
            this.btnGestDispensa.TextColor = System.Drawing.Color.Crimson;
            this.btnGestDispensa.UseVisualStyleBackColor = false;
            this.btnGestDispensa.Click += new System.EventHandler(this.btnGestDispensa_Click);
            this.btnGestDispensa.MouseEnter += new System.EventHandler(this.btnGestDispensa_MouseEnter);
            this.btnGestDispensa.MouseLeave += new System.EventHandler(this.btnGestDispensa_MouseLeave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 41);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // panelGestCategoria
            // 
            this.panelGestCategoria.BackColor = System.Drawing.Color.White;
            this.panelGestCategoria.Controls.Add(this.btnGestCategoria);
            this.panelGestCategoria.Controls.Add(this.pictureBox3);
            this.panelGestCategoria.Location = new System.Drawing.Point(3, 112);
            this.panelGestCategoria.Name = "panelGestCategoria";
            this.panelGestCategoria.Size = new System.Drawing.Size(200, 45);
            this.panelGestCategoria.TabIndex = 3;
            // 
            // btnGestCategoria
            // 
            this.btnGestCategoria.BackColor = System.Drawing.Color.Transparent;
            this.btnGestCategoria.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnGestCategoria.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnGestCategoria.BorderRadius = 0;
            this.btnGestCategoria.BorderSize = 0;
            this.btnGestCategoria.FlatAppearance.BorderSize = 0;
            this.btnGestCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestCategoria.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.btnGestCategoria.ForeColor = System.Drawing.Color.Crimson;
            this.btnGestCategoria.Location = new System.Drawing.Point(47, 2);
            this.btnGestCategoria.Name = "btnGestCategoria";
            this.btnGestCategoria.Size = new System.Drawing.Size(150, 40);
            this.btnGestCategoria.TabIndex = 3;
            this.btnGestCategoria.Text = "CATEGORIAS";
            this.btnGestCategoria.TextColor = System.Drawing.Color.Crimson;
            this.btnGestCategoria.UseVisualStyleBackColor = false;
            this.btnGestCategoria.Click += new System.EventHandler(this.btnGestCategoria_Click);
            this.btnGestCategoria.MouseEnter += new System.EventHandler(this.btnGestCategoria_MouseEnter);
            this.btnGestCategoria.MouseLeave += new System.EventHandler(this.btnGestCategoria_MouseLeave);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 41);
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // panelLogOut
            // 
            this.panelLogOut.BackColor = System.Drawing.Color.White;
            this.panelLogOut.Controls.Add(this.btnLogOut);
            this.panelLogOut.Controls.Add(this.pictureBox4);
            this.panelLogOut.Location = new System.Drawing.Point(3, 163);
            this.panelLogOut.Name = "panelLogOut";
            this.panelLogOut.Size = new System.Drawing.Size(200, 45);
            this.panelLogOut.TabIndex = 4;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Transparent;
            this.btnLogOut.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnLogOut.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnLogOut.BorderRadius = 0;
            this.btnLogOut.BorderSize = 0;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.btnLogOut.ForeColor = System.Drawing.Color.Crimson;
            this.btnLogOut.Location = new System.Drawing.Point(47, 2);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(150, 40);
            this.btnLogOut.TabIndex = 3;
            this.btnLogOut.Text = "LOG OUT";
            this.btnLogOut.TextColor = System.Drawing.Color.Crimson;
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            this.btnLogOut.MouseEnter += new System.EventHandler(this.btnLogOut_MouseEnter);
            this.btnLogOut.MouseLeave += new System.EventHandler(this.btnLogOut_MouseLeave);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(3, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(40, 41);
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            // 
            // panelExit
            // 
            this.panelExit.BackColor = System.Drawing.Color.White;
            this.panelExit.Controls.Add(this.btnExit);
            this.panelExit.Controls.Add(this.pictureBox5);
            this.panelExit.Location = new System.Drawing.Point(3, 214);
            this.panelExit.Name = "panelExit";
            this.panelExit.Size = new System.Drawing.Size(200, 45);
            this.panelExit.TabIndex = 5;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnExit.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnExit.BorderRadius = 0;
            this.btnExit.BorderSize = 0;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.Crimson;
            this.btnExit.Location = new System.Drawing.Point(47, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(150, 40);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "SAIR";
            this.btnExit.TextColor = System.Drawing.Color.Crimson;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.MouseEnter += new System.EventHandler(this.btnExit_MouseEnter);
            this.btnExit.MouseLeave += new System.EventHandler(this.btnExit_MouseLeave);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(3, 2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(40, 41);
            this.pictureBox5.TabIndex = 1;
            this.pictureBox5.TabStop = false;
            // 
            // lstv
            // 
            this.lstv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.idCategoria,
            this.nome,
            this.preco,
            this.quantidade,
            this.marca});
            this.lstv.GridLines = true;
            this.lstv.HideSelection = false;
            this.lstv.Location = new System.Drawing.Point(259, 58);
            this.lstv.Name = "lstv";
            this.lstv.Size = new System.Drawing.Size(456, 271);
            this.lstv.TabIndex = 2;
            this.lstv.UseCompatibleStateImageBehavior = false;
            this.lstv.View = System.Windows.Forms.View.List;
            // 
            // ID
            // 
            this.ID.Text = "idProduto";
            // 
            // idCategoria
            // 
            this.idCategoria.Text = "Categoria";
            // 
            // nome
            // 
            this.nome.Text = "Nome";
            // 
            // preco
            // 
            this.preco.Text = "Preço";
            // 
            // quantidade
            // 
            this.quantidade.Text = "Quantidade";
            // 
            // marca
            // 
            this.marca.Text = "Marca";
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnMenu.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMenu.BackgroundImage")));
            this.btnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMenu.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnMenu.BorderRadius = 0;
            this.btnMenu.BorderSize = 0;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.Location = new System.Drawing.Point(12, 12);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(42, 40);
            this.btnMenu.TabIndex = 1;
            this.btnMenu.TextColor = System.Drawing.Color.White;
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(922, 450);
            this.Controls.Add(this.lstv);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.panelHome.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelGestDispensa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelGestCategoria.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panelLogOut.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panelExit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHome;
        private CustomControls.RJControls.RJButton btnHome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel panelMenu;
        private System.Windows.Forms.Panel panelGestDispensa;
        private CustomControls.RJControls.RJButton btnGestDispensa;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panelGestCategoria;
        private CustomControls.RJControls.RJButton btnGestCategoria;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panelLogOut;
        private CustomControls.RJControls.RJButton btnLogOut;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panelExit;
        private CustomControls.RJControls.RJButton btnExit;
        private System.Windows.Forms.PictureBox pictureBox5;
        private CustomControls.RJControls.RJButton btnMenu;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader idCategoria;
        public System.Windows.Forms.ListView lstv;
        private System.Windows.Forms.ColumnHeader nome;
        private System.Windows.Forms.ColumnHeader preco;
        private System.Windows.Forms.ColumnHeader quantidade;
        private System.Windows.Forms.ColumnHeader marca;
    }
}