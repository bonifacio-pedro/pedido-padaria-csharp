using System.Data;

namespace Projeto_pedido_padaria_
{
    public partial class Form1 : Form
    {
        protected List<ProdutoPadaria> listaProdutos;
        public void recarregaDados()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Produto", typeof(string));
            dt.Columns.Add("Quantidade", typeof(int));
            dt.Columns.Add("Pre�o", typeof(double));
            dt.Columns.Add("Pre�o final", typeof(double));

            foreach (ProdutoPadaria produto in listaProdutos)
            {
                DataRow nLinha = dt.NewRow();
                nLinha["Produto"] = produto.produto;
                nLinha["Quantidade"] = produto.qntd;
                nLinha["Pre�o"] = produto.preco;
                nLinha["Pre�o final"] = produto.precoFinal;
                dt.Rows.Add(nLinha);

            }

            dataTable.DataSource = dt;
        }
        public Form1()
        {
            InitializeComponent();
            ProdutoPadaria.EncheLista(ref listaProdutos);

            recarregaDados();

        }

        private void calcFinal_Click(object sender, EventArgs e)
        {
            if(quantidade.Value != 0 && preco.MaskCompleted)
            {
                calcFinalLabel.Visible = true;
                calcFinalLabel.Text = (Convert.ToDouble(preco.Text) * Convert.ToDouble(quantidade.Value)).ToString();
            }
            else
            {
                MessageBox.Show("Insira um pre�o e quantidades v�lidos.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void cadastro_Click(object sender, EventArgs e)
        {
            if(calcFinalLabel.Visible && produto.Text != "") 
            {
                ProdutoPadaria produtoObj = new ProdutoPadaria(produto.Text,(int)quantidade.Value, Convert.ToDouble(preco.Text),Convert.ToDouble(calcFinalLabel.Text));
                listaProdutos.Add(produtoObj);
                ProdutoPadaria.Serializador(listaProdutos);
            }
            else
            {
                MessageBox.Show("Produto ou valores inv�lidos.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void recarrega_Click(object sender, EventArgs e)
        {
            recarregaDados();
        }
    }
}