using System.Windows;

namespace Aries.WPF.Views.Cliente
{
    public partial class ucCadastrarCliente : Window
    {
        private ucCadastrarCliente()
        {
            InitializeComponent();
            DataContext = new ClienteViewModel();
        }

        public static void Cadastrar() => new ucCadastrarCliente().ShowDialog();
    }
}