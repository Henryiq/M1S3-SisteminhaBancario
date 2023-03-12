using M1S3_SisteminhaBancario;

List<Cliente> clientes = new List<Cliente>();
string opcao;
do{
    Console.WriteLine("Bem vindos ao BANCO FULL STACK, escolha uma opção");
    Console.WriteLine("1 - Criar Conta");
    Console.WriteLine("2 - Adicionar Transação");
    Console.WriteLine("3 - Consultar Extrato");
    Console.WriteLine("4 - Exibir Clientes");
    Console.WriteLine("5 - Sair");
    opcao = Console.ReadLine();

    if(opcao == "1"){
        CriarConta();
    }
    if(opcao == "4"){
    ExibirClientes();
    }
    Console.WriteLine("Enter para continuar");
    Console.ReadLine();
} while(opcao != "5");


void ExibirClientes(){
    Console.WriteLine("| Numero da Conta          | Nome         | CPF         |");
    for(int mal = 0; mal < clientes.Count; mal++){
        Console.WriteLine(clientes[mal].ResumoCliente());
    }
}


void CriarConta(){
    Cliente cliente = new Cliente();
    Console.WriteLine("Data de nascimento do cliente:");
    cliente.DataNascimento = DateTime.Parse(Console.ReadLine());
    var idade = (DateTime.Now - cliente.DataNascimento).TotalDays / 365.25;
    if (!cliente.EhMaior()){
    Console.WriteLine("Nao é possivel abrir a conta pois o cliente é menor de idade");
    return;
    }
    Console.WriteLine("A idade do cliente é:" + cliente.Idade);
    
    Console.WriteLine("Nome do cliente:");
    cliente.Nome = Console.ReadLine();
    Console.WriteLine("CPF do cliente");
    cliente.CPF = Console.ReadLine();
    Console.WriteLine("Endereço do cliente");
    cliente.Endereço = Console.ReadLine();
    
    Console.WriteLine("Telefone do cliente");
    cliente.Telefone = Console.ReadLine();
    Console.WriteLine("Email do cliente");
    cliente.Email = Console.ReadLine();
    Console.WriteLine("Numero da conta do cliente");
    cliente.NumeroConta = int.Parse(Console.ReadLine());
    clientes.Add(cliente);
}