using KFRTH.Interpreter;

namespace KFRTH.Test.Interpreter;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello, World!");

        Runtime r = new(new ConsoleIOProvider());
        r.executeWord("3");
        r.executeWord("5");
        r.executeWord("dump");
        r.executeWord("+");
        r.executeWord("dump");
    }
}
