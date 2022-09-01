using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteEntity
{
    public partial class venda
    {
        public List<venda_produto> Items { get; set; } = new List<venda_produto>();
        public decimal TotalVenda()
        {
            decimal sum = 0;
            foreach (venda_produto item in Items)
                sum += item.totalProdutoVenda;

            return sum;
        }

    }
}
