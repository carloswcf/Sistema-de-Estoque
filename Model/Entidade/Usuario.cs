using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EstoqueComBD.Model.Entidade
{
    [Table("usuario")]
    class Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_usuario { get; set; }
        public string nome { get; set; }
        public string usuario { get; set; }
        public string senha { get; set; }


    }
}
