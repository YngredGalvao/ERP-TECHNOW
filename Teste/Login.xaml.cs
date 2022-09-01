using MahApps.Metro.Controls;
using System;
using System.Linq;
using System.Windows;
using Teste;
using TesteEntity;

namespace Teste
{
    public partial class Login
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnAcessar_Click(object sender, RoutedEventArgs e)
        {
            string login = txtLogin.Text;
            string senha = pbSenha.Password;
            try
            {
                if (string.IsNullOrEmpty(txtLogin.Text) || string.IsNullOrEmpty(pbSenha.Password))
                {
                    MessageBox.Show("Informe o login e a senha");
                    return;
                }

                if (login!=null && senha!=null)
                {
                    using (TesteEntity.testdevEntities db = new TesteEntity.testdevEntities())
                        if (db.usuario.Any(i => i.login == login && i.senha == senha))
                        {
                            Caixa caixa = new Caixa();
                            caixa.Show();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Usuario inexistente!");
                        }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Deu ruim!");
            }
        }
    }
}
