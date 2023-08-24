using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loja_de_Eletronicos
{
    public partial class Form4_CadastrarProduto : Form
    {
        public Form4_CadastrarProduto()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txt_id.Text);
                string nome = txt_nome.Text;
                double valor = Convert.ToDouble(txt_valor.Text);
                string datafabricacao = txt_df.Text;
                int qtd = Convert.ToInt32(txt_qtd.Text);
                Cadastro p = new Cadastro(id, nome, valor, datafabricacao, qtd);
                Program.listaCadastro.Add(p);


                Excel xls = new Excel();
                xls.ExcelAdd(id, nome, valor, datafabricacao, qtd);

                Form3_VisualizarEstoque tela = new Form3_VisualizarEstoque();
                this.Visible = false;
                tela.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro, verefique se os parametros foram inseridos corretamente!");

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txt_nome.Clear();
            txt_id.Clear();
            txt_qtd.Clear();
            txt_df.Clear();
            txt_valor.Clear();
          
        }
    }
}
