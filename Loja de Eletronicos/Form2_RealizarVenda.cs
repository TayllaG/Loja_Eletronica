using Eletros;
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
    public partial class Form2_RealizarVenda : Form
    {
        public Form2_RealizarVenda()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Venda v = new Venda();
            
                try
                {

                    v.Id = Convert.ToInt32(txt_id.Text);

                }

                catch (Exception erro)
                {
                    MessageBox.Show("Erro: " + erro.Message + "\n Tente digitar novamente");
                }

                try
                {
                    v.Nome = txt_nome.Text;
                }

                catch (Exception erro)
                {
                    MessageBox.Show("Erro: " + erro.Message + "\n Tente digitar novamente");
                }

                try
                {
                    v.Valor = Convert.ToDouble(txt_valor.Text);
                }

                catch (Exception erro)
                {
                    MessageBox.Show("Erro: " + erro.Message + "\n Tente digitar novamente");
                }


                try
                {
                    v.Lucro = Convert.ToDouble(txt_lucro.Text);
                }

                catch (Exception erro)
                {
                    MessageBox.Show("Erro: " + erro.Message + "\n Tente digitar novamente");
                }
            

                txt_venda.Text = (v.Lucro * v.Valor / 100 + v.Valor).ToString();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_nome.Clear();
            txt_id.Clear();
            txt_valor.Clear();
            txt_lucro.Clear();
            txt_venda.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            menu.ShowDialog();
        }
    }
}
