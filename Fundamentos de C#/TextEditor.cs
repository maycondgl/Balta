namespace TextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine(">> EDITOR DE TEXTO << ");

            Console.WriteLine("------------------------");

            Console.WriteLine("");


            Console.WriteLine("1 - Abrir arquivo");
            Console.WriteLine("2 - Criar novo arquivo");
            Console.WriteLine("0 - Sair");

            Console.WriteLine("");

            Console.WriteLine("------------------------");


            Console.WriteLine("Escolha uma opção:");

#pragma warning disable CS8604 
            short option = short.Parse(Console.ReadLine());
#pragma warning restore CS8604

            switch (option)
            {
                case 0:
                    Console.WriteLine("Tenha um Bom dia, Volte sempre!");
                    System.Environment.Exit(0); break;
                case 1: Abrir(); break;
                case 2: Editar(); break;
                default: Menu(); break;
            }
        }

        static void Abrir()
        {
            Console.Clear();
            Console.WriteLine("Qual caminho do arquivo?");
#pragma warning disable CS8600 
            string path = Console.ReadLine();
#pragma warning restore CS8600

#pragma warning disable CS8604 
            using (var file = new StreamReader(path))
            {
                string text = file.ReadToEnd();
                Console.WriteLine(text);
            }
#pragma warning restore CS8604 
            Console.WriteLine("");
            Console.ReadLine();
            Menu();
        }

        static void Editar()
        {
            Console.Clear();

            Console.WriteLine("Digite seu texto abaixo (ESC para sair)");
            Console.WriteLine("-------------------------");
            string text = "";

            do
            {
                text += Console.ReadLine();
                text += Environment.NewLine;
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);

            Salvar(text);
        }

        static void Salvar(string text)
        {
            Console.Clear();
            Console.WriteLine("Qual caminho para salvar o arquivo?");

            var path = Console.ReadLine();

#pragma warning disable CS8604 
            using (var file = new StreamWriter(path))
            {
                file.Write(text);
            }
#pragma warning restore CS8604

            Console.WriteLine($"Arquivo [{path}] salvo com sucesso!");
            Console.ReadLine();
            Menu();
        }

    }
}
