namespace Projeto_pedido_padaria_
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.preco = new System.Windows.Forms.MaskedTextBox();
            this.produto = new System.Windows.Forms.TextBox();
            this.quantidade = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.calcFinalLabel = new System.Windows.Forms.Label();
            this.cadastro = new System.Windows.Forms.Button();
            this.calcFinal = new System.Windows.Forms.Button();
            this.cad = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.recarrega = new System.Windows.Forms.Button();
            this.dataTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.quantidade)).BeginInit();
            this.cad.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // preco
            // 
            this.preco.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.preco.Location = new System.Drawing.Point(104, 92);
            this.preco.Mask = "00.00#";
            this.preco.Name = "preco";
            this.preco.Size = new System.Drawing.Size(211, 23);
            this.preco.TabIndex = 0;
            // 
            // produto
            // 
            this.produto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.produto.Location = new System.Drawing.Point(104, 30);
            this.produto.Name = "produto";
            this.produto.Size = new System.Drawing.Size(211, 23);
            this.produto.TabIndex = 1;
            // 
            // quantidade
            // 
            this.quantidade.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.quantidade.Location = new System.Drawing.Point(104, 59);
            this.quantidade.Name = "quantidade";
            this.quantidade.Size = new System.Drawing.Size(211, 23);
            this.quantidade.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Quantidade:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Preço (uni):";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Produto:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Preço final:";
            // 
            // calcFinalLabel
            // 
            this.calcFinalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.calcFinalLabel.AutoSize = true;
            this.calcFinalLabel.Location = new System.Drawing.Point(104, 128);
            this.calcFinalLabel.Name = "calcFinalLabel";
            this.calcFinalLabel.Size = new System.Drawing.Size(10, 15);
            this.calcFinalLabel.TabIndex = 7;
            this.calcFinalLabel.Text = ".";
            this.calcFinalLabel.Visible = false;
            // 
            // cadastro
            // 
            this.cadastro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cadastro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cadastro.Location = new System.Drawing.Point(170, 178);
            this.cadastro.Name = "cadastro";
            this.cadastro.Size = new System.Drawing.Size(145, 72);
            this.cadastro.TabIndex = 8;
            this.cadastro.Text = "Cadastro";
            this.cadastro.UseVisualStyleBackColor = true;
            this.cadastro.Click += new System.EventHandler(this.cadastro_Click);
            // 
            // calcFinal
            // 
            this.calcFinal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.calcFinal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.calcFinal.Location = new System.Drawing.Point(14, 178);
            this.calcFinal.Name = "calcFinal";
            this.calcFinal.Size = new System.Drawing.Size(145, 72);
            this.calcFinal.TabIndex = 9;
            this.calcFinal.Text = "Calcular preço";
            this.calcFinal.UseVisualStyleBackColor = true;
            this.calcFinal.Click += new System.EventHandler(this.calcFinal_Click);
            // 
            // cad
            // 
            this.cad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cad.Controls.Add(this.tabPage1);
            this.cad.Controls.Add(this.tabPage2);
            this.cad.Location = new System.Drawing.Point(40, 12);
            this.cad.MinimumSize = new System.Drawing.Size(337, 320);
            this.cad.Name = "cad";
            this.cad.SelectedIndex = 0;
            this.cad.Size = new System.Drawing.Size(337, 320);
            this.cad.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cadastro);
            this.tabPage1.Controls.Add(this.calcFinal);
            this.tabPage1.Controls.Add(this.preco);
            this.tabPage1.Controls.Add(this.produto);
            this.tabPage1.Controls.Add(this.calcFinalLabel);
            this.tabPage1.Controls.Add(this.quantidade);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(329, 292);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cadastro";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.recarrega);
            this.tabPage2.Controls.Add(this.dataTable);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(329, 292);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Produtos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // recarrega
            // 
            this.recarrega.Cursor = System.Windows.Forms.Cursors.Hand;
            this.recarrega.Location = new System.Drawing.Point(0, 243);
            this.recarrega.Name = "recarrega";
            this.recarrega.Size = new System.Drawing.Size(329, 40);
            this.recarrega.TabIndex = 1;
            this.recarrega.Text = "Recarregar dados";
            this.recarrega.UseVisualStyleBackColor = true;
            this.recarrega.Click += new System.EventHandler(this.recarrega_Click);
            // 
            // dataTable
            // 
            this.dataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTable.Location = new System.Drawing.Point(-4, 0);
            this.dataTable.Name = "dataTable";
            this.dataTable.ReadOnly = true;
            this.dataTable.RowHeadersWidth = 20;
            this.dataTable.RowTemplate.Height = 20;
            this.dataTable.Size = new System.Drawing.Size(337, 237);
            this.dataTable.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(413, 358);
            this.Controls.Add(this.cad);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(429, 397);
            this.MinimumSize = new System.Drawing.Size(429, 397);
            this.Name = "Form1";
            this.Text = "Sistema padaria";
            ((System.ComponentModel.ISupportInitialize)(this.quantidade)).EndInit();
            this.cad.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaskedTextBox preco;
        private TextBox produto;
        private NumericUpDown quantidade;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label calcFinalLabel;
        private Button cadastro;
        private Button calcFinal;
        private TabControl cad;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dataTable;
        private Button recarrega;
    }
}