using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EstoqueComBD.Model.Entidade
{    
    [Table("produto")]
    class Produto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_produto { get; set; }
        public string produto { get; set; }
        public decimal preco { get; set; }
        public int estoque { get; set; }
    }
}
