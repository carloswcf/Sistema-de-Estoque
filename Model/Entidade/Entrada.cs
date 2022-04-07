using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EstoqueComBD.Model.Entidade
{
    [Table("entrada")]
    class Entrada
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_entrada { get; set; }
        public int id_produto { get; set; }
        public DateTime data_entrada { get; set; }
        public decimal valor_entrada { get; set; }
        public int qtde_entrada { get; set; }
    }
}
