using EstoqueComBD.Model.Entidade;
using System;
using System.Collections.Generic;

namespace EstoqueComBD
{
    class Program
    {
        static void Main(string[] args)
        {
            ClienteController clienteController = new ClienteController();

            //Inserir um cliente

            //Atualiza os Dados 
            //Cliente cliente = clienteController.buscaPorId(4);
            Cliente cliente = new Cliente();
            cliente.nome = "Cliente Teste";
            cliente.email = "teste@email.com.br";

            clienteController.salvar(cliente);

            Console.WriteLine("Concluido com Sucesso");

            //Listar um Cliente

            List<Cliente> lista = clienteController.todos();
            Console.WriteLine("");
            Console.WriteLine("****LISTA DE CLIENTES****");
            Console.WriteLine("");
            foreach (Cliente c in lista)
            {
                Console.WriteLine(c.id_cliente + " / " + c.nome + " / " + c.email);
            }

            //Buscando um registro pelo ID

            int id = 2;
            Cliente cli = clienteController.buscaPorId(id);
            Console.WriteLine("");
            Console.WriteLine("****CLIENTE ENCONTRADO PELO ID****");
            Console.WriteLine("");
            Console.WriteLine(cli.id_cliente + " / " + cli.nome + " / " + cli.email);

            

            //Excluir o Cliente
            /*id = 4;
            clienteController.excluir(id);

            lista = clienteController.todos();
            Console.WriteLine("");
            Console.WriteLine("****LISTA DE CLIENTES****");
            Console.WriteLine("");
            foreach (Cliente c in lista)
            {
                Console.WriteLine(c.id_cliente + " / " + c.nome + " / " + c.email);
            }*/

        }
    }
}
