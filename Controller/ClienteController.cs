using System;
using System.Collections.Generic;
using System.Text;

namespace EstoqueComBD.Model.Entidade
{
    public class ClienteController
    {
        public Cliente buscaPorId(int id_cliente)
        {
            return ClienteService.buscarPorId(id_cliente);
        }

        public List<Cliente> todos()
        {
            return ClienteService.todos();
        }

        public void salvar(Cliente cliente)
        {
            if(cliente.id_cliente != 0)
                ClienteService.editar(cliente);
            else
                ClienteService.inserir(cliente);
        }

        

        public void excluir(int id)
        {
            ClienteService.excluir(id);
        }
    }
}
