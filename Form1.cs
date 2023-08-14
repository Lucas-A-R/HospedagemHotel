using HotelSheraton.Alimentos;
using HotelSheraton.Clientes;
using HotelSheraton.Quartos;

namespace HotelSheraton
{
    public partial class Form1 : Form
    {
        Hotel Sheraton = new Hotel();

        public Form1()
        {
            InitializeComponent();
            AtualizaTela();
            MessageBox.Show($"Quantos quartos: {Quarto.QtdQuartos}");

        }

        public void AtualizaTela()
        {
            textBox1.Text = "";
            comboBox1.Items.Clear();
            foreach (Quarto quarto in Sheraton.QuartosVagos())
            {
                comboBox1.Items.Add(quarto.Id);
            }
            listBox1.Items.Clear();
            foreach (Quarto quarto in Sheraton.quartos)
            {
                if (quarto.cliente == null)
                    listBox1.Items.Add($"{quarto.Id} - Vago");
                else
                    listBox1.Items.Add($"{quarto.Id} - {quarto.cliente.Name}");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarListaProduto();
        }

        public void AtualizarListaProduto()
        {
            AtualizarListaProduto(Sheraton);
        }

        public void AtualizarListaProduto(Hotel hotel)
        {
            comboBox2.Items.Clear();
            dynamic quarto = hotel.quartos[listBox1.SelectedIndex];
            if (quarto is Frigobar)
            {
                foreach (Alimento produto in quarto.frigobar)
                {
                    comboBox2.Items.Add($"{produto.nome} + ({produto.preco})");
                }
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Adicionar_Click(object sender, EventArgs e)
        {
            string nome = textBox1.Text;
            foreach (Quarto quarto in Sheraton.quartos)
            {
                if (quarto.Id == comboBox1.SelectedItem)
                {
                    if (Premium.Checked)
                        quarto.Ocupar(new Premium(nome));
                    else
                        quarto.Ocupar(new Regular(nome));
                }
            }
            AtualizaTela();
        }

        private void Premium_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}