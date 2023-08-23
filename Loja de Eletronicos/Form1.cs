namespace Loja_de_Eletronicos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2_RealizarVenda RV = new Form2_RealizarVenda();
            RV.ShowDialog();
        }
    }
}