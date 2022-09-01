using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using TesteEntity;
using Teste;
using Teste.Cadastro;
using System.ComponentModel;
using System.Windows.Data;
using Microsoft.Xaml.Behaviors.Core;

namespace Teste
{
    /// <summary>
    /// Interaction logic for Caixa.xaml
    /// </summary>
    public partial class Caixa : Window
    {
        List<venda_produto> produtos = new List<venda_produto>();

        venda_produto produtoAtual;

        public Caixa()
        {
            InitializeComponent();
        }

        decimal totalVenda = 0;
        decimal quantidade = 0;
        Int64 codPdt = 0;

        private void limparTela()
        {
            txtPdt.Text = string.Empty;
            txtQtd.Text = string.Empty;
            txtValorUnd.Text = string.Empty;
            txtPdt.Focus();
            produtoAtual = null;
        }

        private void ListViewMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (((ListViewItem)((ListView)sender).SelectedItem).Name)
            {
                case "ItemSale":
                    Caixa caixa = new Caixa();
                    caixa.Show();
                    break;
                case "ItemCreate":
                    CadastroPdt cadastro = new CadastroPdt();
                    cadastro.Show();
                    break;
                case "ItemProduct":
                    ConsultadeProduto consultadeProduto = new ConsultadeProduto();
                    consultadeProduto.Show();
                    break;
                case "ItemLogout":
                    Application.Current.Shutdown();
                    break;
                default:
                    break;
            }
        }


        private void iniciaVenda()
        {
            try
            {
                tbVenda.Text = "Venda Iniciada";

                if (dgCaixa.Items.Count == 0 && txtPdt.Text == string.Empty)
                {
                    if (MessageBox.Show("Deseja inserir os dados do cliente?", "Aviso", MessageBoxButton.YesNo, MessageBoxImage.Question, MessageBoxResult.No) == MessageBoxResult.Yes)
                    {
                        CadastroDeCliente cadastroDeCliente = new CadastroDeCliente(false, !string.IsNullOrEmpty(produtoAtual.venda.clienteDocumento) ? produtoAtual.venda.clienteDocumento : string.Empty);
                        cadastroDeCliente.ShowDialog();

                        if (cadastroDeCliente.DialogResult.HasValue && cadastroDeCliente.DialogResult.Value)
                        {

                            produtoAtual.venda.clienteDocumento = cadastroDeCliente.getCpf();
                            produtoAtual.venda.clienteDocumento = cadastroDeCliente.Cliente.ToString();
                            produtoAtual.venda.dataHora = DateTime.Now;
                        }
                    }
                }
                gridPdtAtual.DataContext = produtoAtual;

                txtPdt.IsEnabled = true;
                txtValorUnd.IsEnabled = true;
                txtPdt.Focus();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel carregar corretamente a venda.", ex.Message);
            }

        }

        private void txtPdt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter && txtPdt.Text.Length != 0)
            {
                PesquisaProduto();

                txtQtd.IsEnabled = true;
                txtQtd.Focus();
            }
        }

        private void PesquisaProduto()
        {
            produtoAtual = new venda_produto();

            if (!Int64.TryParse(txtPdt.Text, out codPdt))
            {
                MessageBox.Show("Código invalido!");
                txtPdt.Clear();
                return;
            }
            using (testdevEntities db = new testdevEntities())
            {
                if (!db.produto.Any(i => i.cod == codPdt))
                {
                    MessageBox.Show("Produto inexistente!");
                    txtPdt.Clear();
                    return;
                }
                else if (db.produto.Any(i => i.cod == codPdt && !i.ativo))
                {
                    MessageBox.Show("Produto inativo!");
                    txtPdt.Clear();
                    return;
                }
                if (db.produto.Any(i => i.cod == codPdt && i.ativo))
                {
                    produtoAtual.codProduto = codPdt;
                    produtoAtual.nomeProduto = db.produto.Find(codPdt).descricao;
                    txtPdt.Text = produtoAtual.nomeProduto;
                    produtoAtual.precoVenda = db.produto.Find(codPdt).precoVenda;
                    txtValorUnd.Text = produtoAtual.precoVenda.ToString();
                }
            }
            gridPdtAtual.DataContext = produtoAtual;
        }
        private void btnFinalizarVenda_Click(object sender, RoutedEventArgs e)
        {
            inserirVenda();
            limparTela();
        }

        private void txtQtd_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                try
                {

                    if (txtQtd.Text.Length > 0)
                    {
                        quantidade = decimal.Parse(txtQtd.Text);
                    }
                    else
                        quantidade = 1;

                    produtoAtual.quantidade = quantidade;
                    produtoAtual.totalProdutoVenda = produtoAtual.precoVenda * produtoAtual.quantidade;
                    produtos.Add(produtoAtual);
                    dgCaixa.ItemsSource = produtos.ToList();
                    txtTotalVenda.Text = *********;
                    limparTela();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Deu ruim", ex.Message);
                }

                MessageBox.Show("Produto adicionado!");

                limparTela();
            }
        }

        private void Grid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F5)
                iniciaVenda();
        }

        private void inserirVenda()
        {
            produtoAtual.codVenda = produtoAtual.venda.cod;
            produtoAtual.codProduto = long.Parse(txtPdt.Text);
            produtoAtual.precoVenda = decimal.Parse(txtValorUnd.Text);
            produtoAtual.quantidade = int.Parse(txtQtd.Text);

            using (testdevEntities db = new testdevEntities())
            {
                db.venda_produto.Add(produtoAtual);
                db.SaveChanges();
            }
        }
    }
}

