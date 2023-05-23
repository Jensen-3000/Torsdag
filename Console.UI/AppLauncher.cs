namespace UI
{
    internal class AppLauncher
    {
        public void Run(string[] args)
        {

            while (true)
            {
                Console.Clear();

                Console.WriteLine("1: Kør Week 1 Torsdag");
                Console.WriteLine("2: Kør Week 1 Fredag");
                Console.WriteLine("3: Kør Week 2 Mandag");
                Console.WriteLine("4: Kør Week 2 Tirsdag");
                Console.WriteLine("5: Kør Week 2 Onsdag");
                Console.WriteLine("6: Kør Week 3 Reflection");
                Console.WriteLine("7: Kør Entity Framework");
                Console.WriteLine("Indtast hvilken ugedag du vil køre (eller 'q' for at afslutte):");

                var key = Console.ReadKey(true).KeyChar;

                switch (key)
                {
                    case '1':
                        Week1Torsdag.Program.Main(args);
                        break;
                    case '2':
                        Week1Fredag.Program.Main(args);
                        break;
                    case '3':
                        Week2Mandag.Program.Main(args);
                        break;
                    case '4':
                        Week2Tirsdag.Program.Main(args);
                        break;
                    case '5':
                        Week2Onsdag.Program.Main(args);
                        break;
                    case '6':
                        Week3Reflection.Program.Main(args);
                        break;
                    case '7':
                        new EFUI().Run();
                        break;
                    case 'q':
                        return;
                    default:
                        Console.WriteLine("Ugyldigt input, prøv igen...");
                        break;
                }

                Console.WriteLine(); 
                Console.WriteLine("Tryk på en tast for at fortsætte...");
                Console.ReadKey();
            }
        }
    }
}
