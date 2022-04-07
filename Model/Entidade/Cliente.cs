using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EstoqueComBD.Model.Entidade
{
    [Table("cliente")]
    public class Cliente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_cliente { get; set; }
        public string nome { get; set; }
        public string email { get; set; }

        public Cliente()
        {

        }

        public Cliente(int id_cliente, string nome, string email)
        {
            this.id_cliente = id_cliente;
            this.nome = nome;
            this.email = email;
        }
    }

}
