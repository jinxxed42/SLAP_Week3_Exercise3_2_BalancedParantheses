namespace SLAP_Week3_Exercise3_2_BalancedParantheses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Checking [{({[]})}] - Should be true");
            Console.WriteLine(CheckBalancedParantheses.Check("[{({[]})}]"));
            Console.WriteLine("----------");

            Console.WriteLine("Checking [(()}] - Should be false");
            Console.WriteLine(CheckBalancedParantheses.Check("[(()}]"));
            Console.WriteLine("----------");

            Console.WriteLine("Checking (((())) - Should be false");
            Console.WriteLine(CheckBalancedParantheses.Check("(((()))"));
            Console.WriteLine("----------");

            Console.WriteLine("Checking {{}}}} - Should be false");
            Console.WriteLine(CheckBalancedParantheses.Check("{{}}}}"));
            Console.WriteLine("----------");

            Console.WriteLine("Checking [{(({[[{(({[]}))}]]}))}] - Should be true");
            Console.WriteLine(CheckBalancedParantheses.Check("[{(({[[{(({[]}))}]]}))}]"));
            Console.WriteLine("----------");

            Console.WriteLine("Checking ((aa)) - Should be false");
            Console.WriteLine(CheckBalancedParantheses.Check("((a))"));

        }
    }
}