//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TesteEntity
{
    using System;
    using System.Collections.Generic;
    
    public partial class produto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public produto()
        {
            this.venda_produto = new HashSet<venda_produto>();
        }
    
        public long cod { get; set; }
        public string descricao { get; set; }
        public int codGrupo { get; set; }
        public string codBarra { get; set; }
        public decimal precoCusto { get; set; }
        public decimal precoVenda { get; set; }
        public System.DateTime dataHoraCadastro { get; set; }
        public bool ativo { get; set; }
        public string unidadeMedida { get; set; }
    
        public virtual produto_grupo produto_grupo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<venda_produto> venda_produto { get; set; }
    }
}
