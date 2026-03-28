Menu();

static void Menu()
{
    Console.Clear();
    Console.WriteLine("=============================");
    Console.WriteLine("Bem vindo ao Editor de Texto:");
    Console.WriteLine("=============================");
    Console.WriteLine("O que deseja fazer?");
    Console.WriteLine("=============================");
    Console.WriteLine("1 - Criar Novo Texto");
    Console.WriteLine("2 - Abrir Arquivo:");
    Console.WriteLine("=============================");
    Console.WriteLine("0 - Sair");
    Console.WriteLine("=============================");

    short option = short.Parse(Console.ReadLine()!);

    switch (option)
    {
        case 0:
            Environment.Exit(0);
            break;
        case 1:
            CreateText();
            break;
        case 2:
            OpenFile();
            break;
        default:
            Console.WriteLine("Opção Inválida, pressione ENTER para continuar...");
            Console.ReadLine();
            Menu();
            break;
    }
}


static void CreateFile(string text)
{
    Console.Clear();
    Console.WriteLine("Selecione o local onde o arquivo será salvo:");
    Console.WriteLine("Não é necessário escolher o tipo de Arquivo");
    var path = Console.ReadLine()!.ToUpper();

    using StreamWriter writer = new(path + ".txt");
    writer.WriteLine(text);
}

static void CreateText()
{
    Console.Clear();
    var text = "";
    do
    {
        text += Console.ReadLine()!;
        text += Environment.NewLine;

    } while (Console.ReadKey().Key != ConsoleKey.Escape);
    CreateFile(text);
}

static void OpenFile()
{
    Console.WriteLine("Qual arquivo deseja ler:");
    var path = Console.ReadLine()!.ToUpper();

    using StreamReader reader = new(path);

    string line;
    while ((line = reader.ReadLine()!) != null)
    {
        Console.WriteLine(line);
    }
}
