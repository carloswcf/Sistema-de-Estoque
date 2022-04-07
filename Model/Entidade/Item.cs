using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EstoqueComBD.Model.Entidade
{
    [Table("item")]
    class Item
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_item { get; set; }
        public int id_produto { get; set; }
        public int id_venda { get; set; }
        public int qtde { get; set; }
        public decimal valor { get; set; }
        public decimal subtotal { get; set; }
    }
}
