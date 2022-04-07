using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EstoqueComBD.Model.Entidade
{
    public class ClienteDao
    {

        private static Contexto contexto;
        

        public ClienteDao()
        {

            contexto = new Contexto();

        }

        public Cliente buscaPorId(int id_cliente)
        {
            return contexto.Cliente.FirstOrDefault(obj => obj.id_cliente == id_cliente);
            
        }

        public void inserir(Cliente cliente)
        {
            contexto.Add(cliente);
            contexto.SaveChanges();
        }

        public void editar(Cliente cliente)
        {
            contexto.Cliente.Any(obj => obj.id_cliente == cliente.id_cliente);
            contexto.Update(cliente);
            contexto.SaveChanges();
        }

        public void excluir(int id_cliente)
        {
            Cliente c = contexto.Cliente.Find(id_cliente);
            contexto.Remove(c);
            contexto.SaveChanges();

        }



        public List<Cliente> todos()
        {
            return contexto.Cliente.ToList();
        }


    }
}
