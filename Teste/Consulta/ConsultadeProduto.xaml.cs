using MahApps.Metro.Controls;
using System;
using System.Linq;
using System.Windows;
using TesteEntity;

namespace Teste
{
    /// <summary>
    /// Lógica interna para ConsultaServico.xaml
    /// </summary>
    public partial class ConsultadeProduto : Window
    {
        public ConsultadeProduto()
        {
            InitializeComponent();
        }
        private void CarregarProduto()
        {
            try
            {
                using (TesteEntity.testdevEntities db = new TesteEntity.testdevEntities())
                {
                    ProdutoGrid.ItemsSource = db.produto.ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Deu ruim!" + ex.Message);
            }
        }

        private void BtnAdicionar_Click(object sender, RoutedEventArgs e)
        {
            CadastroPdt cadastro = new CadastroPdt();
            cadastro.ShowDialog();
            CarregarProduto();
        }

        private void AlterarProduto()
        {
            if (ProdutoGrid.SelectedItem != null)
            {
                TesteEntity.produto produto = ProdutoGrid.SelectedItem as TesteEntity.produto;
                CadastroPdt cadastro = new CadastroPdt(produto);
                cadastro.ShowDialog();
                CarregarProduto();
            }
        }

        private void BtnAlterar_Click(object sender, RoutedEventArgs e)
        {
            AlterarProduto();
        }

        private void MetroWindow_Loaded(object sender, RoutedEventArgs e)
        {
            CarregarProduto();
        }

        private void btnRemover_Click(object sender, RoutedEventArgs e)
        {
            if (ProdutoGrid.SelectedItem != null)
            {
                TesteEntity.produto produto = ProdutoGrid.SelectedItem as TesteEntity.produto;
                if (MessageBox.Show("Tem certeza que deseja excluir o produto, sua exclusão pode resultar em perdas de dados de venda?", "Aviso", MessageBoxButton.YesNo, MessageBoxImage.Question, MessageBoxResult.No) == MessageBoxResult.Yes)
                {
                    using (testdevEntities db = new testdevEntities())
                    {
                        produto = db.produto.Include("venda_produto").First(i => i.cod == produto.cod);
                        try
                        {
                            if (db.produto.Any())
                            {
                                MessageBox.Show("O produto contem vendas, não foi possivel excluir!", "Aviso", MessageBoxButton.OK);
                                return;
                            }

                            db.produto.Remove(produto);
                            MessageBox.Show("Produto excluído com sucesso!");
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Falha ao tentar exlcuir o produto. Verifique o código do mesmo, e sua conexão.");
                        }
                    }
                }
            }
        }
    }
}
