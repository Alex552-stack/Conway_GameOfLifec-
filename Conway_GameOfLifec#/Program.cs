using Conway_GameOfLifec_.Clases;

namespace Conway_GameOfLifec_
{
    internal class Program
    {
        static int? input()
        {
            string str = Console.ReadLine();

            try
            {
                int nr = int.Parse(str);
                return nr;
            }
            catch
            {
                Console.WriteLine("invalid input");
                return null;
            }

        }

        static int AskInput(string message)
        {
            int? var = null;
            Console.WriteLine(message);
            while (var == null)
            {
                var = input();
            }
            return (int)var;
        }

        static void Main(string[] args)
        {
            int lines = AskInput("The desired number of lines:");
            int rows = AskInput("The desired number of rows");
            
            GameBord gameBord = new GameBord(lines, rows);

            int chance = AskInput("The desired percentage of live cells(everything above 100 will fill the wrole bord)");

            gameBord.Generate(chance);
            gameBord.PrintPixels();
            while (true)
                gameBord.Simulate(); 
        }
    }
}