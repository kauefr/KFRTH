namespace KFRTH.Test.Interpreter;

internal class ConsoleIOProvider : KFRTH.Interpreter.IOProvider
{
    public string ReadLine()
    {
        Console.WriteLine("ReadLine called. Returning \"42\"");
        return "42";
    }

    public void Write(string S)
    {
        Console.WriteLine($"Write called with argument \"{S}\".");
        Console.Write(S);
    }
}