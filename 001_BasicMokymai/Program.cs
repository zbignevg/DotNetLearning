namespace _001_BasicMokymai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*UZDUOTIS 1
            Console.WriteLine("Zbignev");
            Console.WriteLine("Iveskite varda");
            var vardas = Console.ReadLine();
            var asciiFirstChar = (byte)vardas[0];
            Console.WriteLine("Vardo pirmos raides ASCII kodas");
            Console.WriteLine($"{asciiFirstChar}");


            Console.WriteLine("Iveskite bet koki skaiciu");
            var skaicius = Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine($"ASCII ir skaiciaus suma: {int.Parse(asciiFirstChar.ToString()) + int.Parse(skaicius.KeyChar.ToString())}");
            Console.WriteLine($"ASCII ir skaiciaus suma (string): {asciiFirstChar.ToString() + skaicius.KeyChar.ToString()}");


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Meniu:");
            Console.WriteLine("(1) Pirkti");
            Console.WriteLine("(2) Parduoti");
            Console.WriteLine("(3) Likuciai");

            var pasirinkimas = Console.ReadKey();

            Console.WriteLine();
            Console.WriteLine($"Jusu pasirinkimas: {pasirinkimas.KeyChar.ToString()}");

            Console.WriteLine("----------Press any key to continue---------");
            Console.ReadKey();*/


            /*UZDUOTIS 2
            Console.WriteLine($"L{Environment.NewLine}A{Environment.NewLine}B{Environment.NewLine}A{Environment.NewLine}S");
            Console.WriteLine();

            Console.WriteLine("L\tA\tB\tA\tS");
            Console.WriteLine();

            Console.WriteLine("\u0022\u004C\u0041\u0042\u0041\u0053\u0022");
            Console.WriteLine("\"LABAS\"");
            */


            /*UZDUOTIS 3
            Console.WriteLine("Jusu vardas");
            var vardas = Console.ReadLine();

            Console.WriteLine($"Vardo antra raide: {vardas[1].ToString()}");

            Console.WriteLine($"Vardo raidziu kiekis: {vardas.Length}");

            Console.WriteLine();
            Console.WriteLine($"{vardas}{Environment.NewLine}{vardas.Length}{Environment.NewLine}|\t{vardas}|\t{vardas.Length}|");

            Console.WriteLine($"{Environment.NewLine}{Environment.NewLine}{Environment.NewLine}{vardas}");
            */

            var smile = @"
               ************************
           **                            **
          **        ()          ()         **
         **                |                **
        **                 |                 **
         **         *      |     *          **
          **         *          *          **
           **         *  *  *  *          **
            **                           **
             ***************************
";

            Console.WriteLine(smile);
            Console.WriteLine(smile.Replace('*', '"'));

            /*Console.WriteLine("Iveskite pirmus 2 skaicius");
            var pirmasSk = (byte)Console.ReadKey().KeyChar;
            var antrasSk = (byte)Console.ReadKey().KeyChar;
            Console.WriteLine();
            Console.WriteLine("Skaiciu suma: {0}", (pirmasSk - 48) + (antrasSk - 48));


            Console.WriteLine("Iveskite antrus 2 skaicius");
            var treciasSk = (byte)Console.ReadKey().KeyChar;
            var ketvirtasSk = (byte)Console.ReadKey().KeyChar;
            Console.WriteLine();
            Console.WriteLine("Skaiciu atimtis: {0}", (pirmasSk - 48) - (antrasSk - 48));

            Console.WriteLine("Iveskite trecius 2 skaicius");
            var penktasSk = (byte)Console.ReadKey().KeyChar;
            var sestasSk = (byte)Console.ReadKey().KeyChar;
            Console.WriteLine();
            Console.WriteLine("Skaiciu daugyba: {0}", (pirmasSk - 48) * (antrasSk - 48));

            Console.WriteLine("Iveskite ketvirtus 2 skaicius");
            var septintasSk = (byte)Console.ReadKey().KeyChar;
            var astuntasSk = (byte)Console.ReadKey().KeyChar;
            Console.WriteLine();
            Console.WriteLine("Skaiciu dalyba: {0}", (pirmasSk - 48) / (antrasSk - 48));*/

        }
    }
}