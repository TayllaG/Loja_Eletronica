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
            Form4_CadastrarProduto cp = new Form4_CadastrarProduto();
            cp.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2_RealizarVenda rv = new Form2_RealizarVenda();
            rv.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3_VisualizarEstoque ve = new Form3_VisualizarEstoque();
            ve.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult dialg = new DialogResult();
            dialg = MessageBox.Show("Deseja mesmo sair?","Alerta!",MessageBoxButtons.YesNo);

            if (dialg == DialogResult.Yes)
            {
                Application.Exit();
            }
            this.Visible = false;
        }
        
    }
}