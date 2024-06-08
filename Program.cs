using EmpresaClassList;

Console.WriteLine("<Lista de Empresas> \n");

// Criando objeto para receber dados da empresa
Dado empresa1 = new Dado();
empresa1.Nome = "ETAS EMPRESA DE TRANSPORTE AÉREO COM SEGURANÇA";
empresa1.Telefone = 19988350857;
empresa1.Cnpj = 45234277000186;
empresa1.Endereco = "Rua Valdir Silva 12";

Dado empresa2 = new Dado();
empresa2.Nome = "CO. GROTA";
empresa2.Telefone = 2199176345201;
empresa2.Cnpj = 329862345000176;
empresa2.Endereco = "Rua Alerrandro de Souza 320";

Dado empresa3 = new Dado();
empresa3.Nome="INDUSTRIA ROTATIVA DE VEÍCULOS";
empresa3.Telefone = 3176489329811;
empresa3.Cnpj = 439765431000154;
empresa3.Endereco = "Rua Marcos Gomes 97";

//Adicionando os dados das empresas no DadosRepository
DadosRepository.Dados.Add(empresa1);
DadosRepository.Dados.Add(empresa2);
DadosRepository.Dados.Add(empresa3);


foreach (var dado in DadosRepository.Dados)
{
    Console.WriteLine($"Nome:{dado.Nome} | Telefone:{dado.Telefone} | CNPJ:{dado.Cnpj} | ENDEREÇO: {dado.Endereco}\n");
}

Console.WriteLine("----------------------------------------------------------------------------------");

//Remove a empresa 1
DadosRepository.Dados.Remove(empresa1);

foreach (var dado in DadosRepository.Dados)
{
    Console.WriteLine($"Nome:{dado.Nome} | Telefone:{dado.Telefone} | CNPJ:{dado.Cnpj} | ENDEREÇO: {dado.Endereco}\n");
}
