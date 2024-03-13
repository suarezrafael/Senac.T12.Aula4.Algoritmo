// forma de organizar o projeto
namespace WinFormsApp
{   //  classe
    public partial class Form1 : Form
    {
        // construtor
        public Form1()
        {
            // m�todo inicializa os componentes
            InitializeComponent();
        }

        // evento de clique do bot�o novo
        private void btnNovo_Click(object sender, EventArgs e)
        {
            // exibir uma mensagem com o texto informado
            MessageBox.Show("Clicou no bot�o novo");
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Clicou no bot�o Editar");
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
