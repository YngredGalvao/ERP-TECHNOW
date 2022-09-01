using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using TesteEntity;

namespace Teste
{
    /// <summary>
    /// Interaction logic for Cadastro.xaml
    /// </summary>
    public partial class CadastroPdt : Window
    {
        produto produto;
        bool cadastrar = true;

        public CadastroPdt()
        {
            InitializeComponent();
            produto = new produto();
        }
        public CadastroPdt(produto produto)
        {
            InitializeComponent();
            this.produto = produto;
            cadastrar = false;
        }

        private void btnCadastrar_Click(object sender, RoutedEventArgs e)
        {
            using (testdevEntities db = new testdevEntities())
            {
                try
                {
                    if (string.IsNullOrEmpty(txtProduto.Text))
                        throw new InvalidOperationException("Preencha o Produto corretamente");

                    if (string.IsNullOrEmpty(txtCusto.Text) || !decimal.TryParse(txtCusto.Text, out decimal preco))
                        throw new InvalidOperationException("O valor de custo não pode ser vazio");

                    if (string.IsNullOrEmpty(txtVenda.Text) || !decimal.TryParse(txtVenda.Text, out decimal precoVenda))
                        throw new InvalidOperationException("O valor de venda não pode ser vazio");

                    if (db.produto.Any(i => i.descricao == produto.descricao && i.cod != produto.cod))
                        throw new InvalidOperationException("Produto já cadastrado");

                    produto.descricao = txtProduto.Text;
                    produto.dataHoraCadastro = DateTime.Now;
                    produto.codGrupo = ((produto_grupo)cbGrupo.SelectedItem).cod;
                    //produto.ativo = cbxAtivo.IsChecked ?? false;
                    produto.codBarra = txtCodBarras.Text;
                    produto.precoVenda = precoVenda;
                    produto.precoCusto = preco;
                    produto.unidadeMedida = cbUn.Text;

                    if (cadastrar)
                        db.produto.Add(produto);
                    else
                        db.Entry(produto).State = System.Data.Entity.EntityState.Modified;

                    db.SaveChanges();

                    MessageBox.Show("Produto cadastrado com sucesso");

                    this.Close();
                }
                catch (InvalidOperationException iex)
                {
                    MessageBox.Show(iex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void cbGrupo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                produto_grupo grupo = ((produto_grupo)cbGrupo.SelectedItem);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            using (testdevEntities db = new testdevEntities())
            {
                cbGrupo.ItemsSource = db.produto_grupo.ToList();
            }
        }
    }
}
