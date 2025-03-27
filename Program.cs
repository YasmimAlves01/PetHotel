string especie, raca, alcunha, pelagem;
int idade;

Console.WriteLine("Bem-vindo ao pet Hotel Dog Small");

Console.WriteLine("Por favor digite a especie: ");
especie = Console.ReadLine()!;

Console.WriteLine("Por favor digite a raça do seu animal:");
raca = Console.ReadLine()!;

Console.WriteLine("Por favor digite o alcunha do seu pet:");
alcunha = Console.ReadLine()!;

Console.WriteLine("Por favor digite a idade do seu pet:");
while (!int.TryParse(Console.ReadLine(), out idade) || idade < 0)
{
    Console.Write("idade não valida. Digite novamente: ");
}

Console.WriteLine("Por favor digite a pelagem do seu cão:");
pelagem = Console.ReadLine()!;

Console.WriteLine("+=========================================================+");
Console.WriteLine("|                 Pet Hotel \"Dog Small\"                  |");
Console.WriteLine("+=========================================================+");
Console.WriteLine($"| Espécie: {especie.PadLeft(18,'.')} | Raça: {raca.PadLeft(19,'.')} |");
Console.WriteLine("+=========================================================+");
Console.WriteLine($"| Atende pela alcunha de: {alcunha.PadLeft(31,'.')} |");
Console.WriteLine($"| Idade: {idade.ToString().PadLeft(2,'0') } ano(s) | Pelagem/cor: {pelagem.PadLeft(23,'.')} |");
Console.WriteLine("+=========================================================+");