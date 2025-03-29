string especie, raca, alcunha, pelagem;
        int idade;

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Bem-vindo ao Pet Hotel Dog Small");
        Console.ResetColor();

        Console.Write("Por favor, digite a espécie: ");
        especie = Console.ReadLine()!;

        Console.Write("Por favor, digite a raça do seu animal: ");
        raca = Console.ReadLine()!;

        Console.Write("Por favor, digite a alcunha do seu pet: ");
        alcunha = Console.ReadLine()!;

        Console.Write("Por favor, digite a idade do seu pet: ");
        while (!int.TryParse(Console.ReadLine(), out idade) || idade < 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Erro! Digite novamente: ");
            Console.ResetColor();
        }

        Console.Write("Por favor, digite a pelagem do seu animal: ");
        pelagem = Console.ReadLine()!;

        Console.Clear();

        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("+=========================================================+");
        Console.Write("|");    
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("                 Pet Hotel \"Hotel Dog Small\"             ");
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("|");  
        Console.WriteLine("+=========================================================+");

        Console.Write("|"); 
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.Write($" Espécie: ");
         Console.ForegroundColor = ConsoleColor.Gray;
        Console.Write($"{especie.PadLeft(18,'.')} ");
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.Write("| Raça: ");
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.Write($"{raca.PadLeft(19,'.')} ");
        Console.WriteLine("|"); 
        Console.WriteLine("+=========================================================+");
        
        Console.Write("|");
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.Write(" Atende pela alcunha de: ");
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.Write($"{alcunha.PadLeft(31,'.')} ");
        Console.WriteLine("|");

        Console.Write("|");
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.Write(" Idade: ");
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.Write($"{idade.ToString().PadLeft(2,'0')} ano(s)");
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.Write(" | Pelagem/cor: ");
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.Write($"{pelagem.PadLeft(23,'.')} ");
        Console.WriteLine("|");

        Console.WriteLine("+=========================================================+");
        Console.ResetColor();