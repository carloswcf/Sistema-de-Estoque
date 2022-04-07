using System;
using System.Collections.Generic;
using System.Text;

namespace EstoqueComBD.Model.Entidade
{
    public class ClienteService
    {
        public static Cliente buscarPorId(int id_cliente)
        {
            ClienteDao dao = new ClienteDao();
            return dao.buscaPorId(id_cliente);

        }

        public static List<Cliente> todos()
        {
            ClienteDao dao = new ClienteDao();
            return dao.todos();
        }


        public static void inserir(Cliente cliente)
        {
            ClienteDao dao = new ClienteDao();
             dao.inserir(cliente);
        }

        public static void editar(Cliente cliente)
        {
            ClienteDao dao = new ClienteDao();
            dao.editar(cliente);
        }

        public static void excluir(int id)
        {
            ClienteDao dao = new ClienteDao();
            dao.excluir(id);
        }

    }
}
