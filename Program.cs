using M1S3_SisteminhaBancario;

List<Cliente> clientes = new List<Cliente>();

clientes.Add(new Cliente("vito", "1234567", "henrys@gmail", "123", "rua", new DateTime(2007,05,06), 1 ));

clientes.Add(new Cliente("viato", "12345678", "henryd@gmail", "1234", "rua", new DateTime(2006,05,06), 2 ));

clientes.Add(new Cliente("vouito", "12345679", "henryf@gmail", "1235", "rua", new DateTime(2005,05,06), 3 ));

clientes.Add(new Cliente("vaeiito", "12345670", "henrgy@gmail", "1236", "rua", new DateTime(2004,05,06), 4 ));


string opcao;
do{
    Console.WriteLine("Bem vindos ao BANCO FULL STACK, escolha uma opção");
    Console.WriteLine("1 - Criar Conta");
    Console.WriteLine("2 - Adicionar Transação");
    Console.WriteLine("3 - Consultar Extrato");
    Console.WriteLine("4 - Exibir Clientes");
    Console.WriteLine("5 - Verificar compatibilidade");
    Console.WriteLine("6 - Sair");
    opcao = Console.ReadLine();

    if(opcao == "1"){
        CriarConta();
    }
    if(opcao == "2"){
        AdicionarTransaçao();
    }
    if(opcao == "4"){
        ExibirClientes();
    }
    if(opcao == "5"){
        VerificarCompatibilidade();
    }
    Console.WriteLine("Enter para continuar");
    Console.ReadLine();
} while(opcao != "6");

void AdicionarTransaçao(){
        Console.WriteLine("Qual a conta?");
        int NumeroConta = int.Parse(Console.ReadLine());

Cliente contaCliente = BuscarClientePorNumeroDeConta(NumeroConta);

    if (contaCliente == null){
            Console.WriteLine("Connta nao cadastrada, favor cadastrar antes");
            return;
        }
    Console.WriteLine("Qual o valor da transação?");
        double valor = double.Parse(Console.ReadLine());
        Transaçao transacao = new Transaçao(DateTime.Now, valor);

        contaCliente.Extrato.Add(transacao);
}
Cliente BuscarClientePorNumeroDeConta(int NumeroConta){
    foreach(var cliente in clientes){
        if(cliente.NumeroConta == NumeroConta){
            return cliente;
        }
        //ou, ja q sao a mesma coisa
    /*for(int i = 0 ; i < clientes.Count; i++){
        if(clientes[i].NumeroConta == NumeroConta){
            contaCliente = clientes[i];
            break;
            //break é similar ao return, so q o return erve so pra metodos
        }*/
    }
    return null;
}

        


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
    Console.WriteLine("CPF do cliente:");
    cliente.CPF = Console.ReadLine();
    Console.WriteLine("Endereço do cliente:");
    cliente.Endereço = Console.ReadLine();
    Console.WriteLine("Banco do cliente:");
    cliente.TipoBancario = Console.ReadLine();
    Console.WriteLine("Telefone do cliente:");
    cliente.Telefone = Console.ReadLine();
    Console.WriteLine("Email do cliente:");
    cliente.Email = Console.ReadLine();
    Console.WriteLine("Numero da conta do cliente:");
    cliente.NumeroConta = int.Parse(Console.ReadLine());
    clientes.Add(cliente);
}
void VerificarCompatibilidade(){
    Cliente cliente = new Cliente();
    Console.WriteLine("Qual sua Agencia Bancaria?");
    cliente.TipoBancario = Console.ReadLine();
    if(cliente.TipoBancario == "itau"){
        Console.WriteLine("Sua conta é compativel");
    }else if(cliente.TipoBancario == "Caixa" ){
        Console.WriteLine("Sua conta é compativel");
    }else{
        Console.WriteLine("Desculpe, não trabalhamos com essa agencia");
    }
}