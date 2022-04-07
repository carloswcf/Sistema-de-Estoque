using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EstoqueComBD.Model.Entidade
{
    [Table("saida")]
    class Saida
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_saida { get; set; }
        public int id_produto { get; set; }
        public DateTime data_saida { get; set; }
        public decimal valor_saida { get; set; }
        public int qtde_saida { get; set; }
    }
}
