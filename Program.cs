using M1S3_SisteminhaBancario;

Cliente CriarConta(){
    Cliente cliente = new Cliente();
    Console.WriteLine("Nome do cliente:");
    cliente.Nome = Console.ReadLine();
    Console.WriteLine("CPF do cliente");
    cliente.CPF = Console.ReadLine();
    Console.WriteLine("Endereço do cliente");
    cliente.Endereço = Console.ReadLine();
    Console.WriteLine("Data de nascimento do cliente:");
    cliente.DataNascimento = DateTime.Parse(Console.ReadLine());
    Console.WriteLine("Telefone do cliente");
    cliente.Telefone = Console.ReadLine();
    Console.WriteLine("Email do cliente");
    cliente.Email = Console.ReadLine();
    Console.WriteLine("Numero da conta do cliente");
    cliente.NumeroConta = int.Parse(Console.ReadLine());
    return cliente;
}
string opcao;


do{
    Console.WriteLine("Bem vindos ao BANCO FULL STACK, escolha uma opção");
    Console.WriteLine("1 - Criar Conta");
    Console.WriteLine("2 - Adicionar Transação");
    Console.WriteLine("3 - Consultar Extrato");
    Console.WriteLine("4 - Sair");
    opcao = Console.ReadLine();

    if(opcao == "1"){
        var novoCliente = CriarConta();
    }
} while(opcao != "3");