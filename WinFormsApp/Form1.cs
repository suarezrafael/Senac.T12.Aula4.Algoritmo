// forma de organizar o projeto
namespace WinFormsApp
{   //  classe
    public partial class Form1 : Form
    {
        // construtor
        public Form1()
        {
            // método inicializa os componentes
            InitializeComponent();
        }

        // evento de clique do botão novo
        private void btnNovo_Click(object sender, EventArgs e)
        {
            // exibir uma mensagem com o texto informado
            MessageBox.Show("Clicou no botão novo");
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Clicou no botão Editar");
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Clicou no Salvar");
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Clicou no Excluir.");
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Clicou no Imprimir");
        }
    }
}
