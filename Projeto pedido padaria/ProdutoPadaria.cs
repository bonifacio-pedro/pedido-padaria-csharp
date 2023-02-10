using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Projeto_pedido_padaria_
{
    public class ProdutoPadaria
    {
        public string produto;
        public int qntd;
        public double preco;
        public double precoFinal;

        public static List<ProdutoPadaria> EncheLista(ref List<ProdutoPadaria> produtos)
        {
            string caminho = @"banco_de_dados.xml";
            if (File.Exists(caminho))
            {
                XmlSerializer leitor = new XmlSerializer(typeof(List<ProdutoPadaria>));
                FileStream fs = File.Open(caminho, FileMode.Open);
                List<ProdutoPadaria> temp = (List<ProdutoPadaria>)leitor.Deserialize(fs);
                fs.Close();
                return produtos = temp;

            }
            else
            {
                produtos = new List<ProdutoPadaria>();
                return null;
            }
        }
        public static void Serializador(List<ProdutoPadaria> produtos)
        {
            string caminho = @"banco_de_dados.xml";
            XmlSerializer escritor = new XmlSerializer(typeof(List<ProdutoPadaria>));
            if (File.Exists(caminho))
            {
                FileStream fs = File.Open(caminho, FileMode.Open);
                escritor.Serialize(fs, produtos);
                fs.Close();

            }
            else
            {
                FileStream fs = File.Create(caminho);
                escritor.Serialize(fs, produtos);
                fs.Close();
            }
        }

        public ProdutoPadaria(string produto, int quantidade, double preco, double precoFinal)
        {
            this.produto = produto;
            this.qntd = quantidade;
            this.preco = preco;
            this.precoFinal = precoFinal;
        }

        public ProdutoPadaria()
        {

        }
    }
}
