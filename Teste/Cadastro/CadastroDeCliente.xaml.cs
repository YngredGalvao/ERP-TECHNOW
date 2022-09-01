using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Input;
using TesteEntity;

namespace Teste.Cadastro
{
    /// <summary>
    /// Interaction logic for CadastroDeCliente.xaml
    /// </summary>
    public partial class CadastroDeCliente : Window
    {
        venda cliente;

        bool semDoc = false;

        public CadastroDeCliente(bool semDoc = false, string doc = "")
        {
            InitializeComponent();
            cliente = new venda();


            this.semDoc = semDoc;
            txtCpf.Focus();
        }

        public venda Cliente
        {
            get
            {
                return cliente ;
            }
        }


        private void txtCpf_KeyUp(object sender, KeyEventArgs e)
        {
            txtCpf.Text = formataCpfCnpj(txtCpf.Text);
            txtCpf.SelectionStart = txtCpf.Text.Length + 1;
            txtCpf.SelectionLength = 0;
        }

        public static string formataCpfCnpj(string cpfcnpj)
        {
            cpfcnpj = Regex.Replace(cpfcnpj.Replace("_", ""), @"[^\d]", "");
            string formatado = string.Empty;
            if (cpfcnpj.Length <= 11)
            {
                for (int i = 0; i < cpfcnpj.Length; i++)
                {
                    if (i == 3 || i == 6)
                        formatado += '.';
                    else if (i == 9)
                        formatado += '-';

                    formatado += cpfcnpj[i];
                }
            }
            else
            {
                for (int i = 0; i < cpfcnpj.Length; i++)
                {
                    if (i == 2 || i == 5)
                        formatado += '.';
                    else if (i == 8)
                        formatado += '/';
                    else if (i == 12)
                        formatado += '-';

                    formatado += cpfcnpj[i];
                }
            }
            return formatado.Length > 18 ? formatado.Substring(0, 18) : formatado;
        }

        private void btnSalvar_Click(object sender, RoutedEventArgs e)
        {
            string cpf = txtCpf.Text;
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            btOk();
        }

        private void btOk()
        {
            if (btnOk.IsEnabled == true)
                this.DialogResult = true;
        }
        public string getCpf()
        {
            if (cliente != null && !string.IsNullOrEmpty(Cliente.clienteDocumento))
                return Cliente.clienteDocumento;
            else
                return txtCpf.Text;
        }
    }
}
