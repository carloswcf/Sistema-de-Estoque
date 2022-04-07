using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EstoqueComBD.Model.Entidade
{
    [Table("venda")]
    class Venda
    {   
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_venda { get; set; }
        public int id_cliente { get; set; }
        public DateTime data_venda { get; set; }
        public decimal total { get; set; }
    }
}
