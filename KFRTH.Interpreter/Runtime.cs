namespace KFRTH.Interpreter;

using System;
using static Definitions;
public class Runtime
{
    private readonly IOProvider io;

    internal Stack<Cell> DataStack { get; } = new();

    internal Dictionary<string, Action<Runtime>> DefinedWords { get; } = new();

    public Runtime(IOProvider io)
    {
        this.io = io;
        DefinedWords["+"] = r =>
        {
            var b = r.DataStack.Pop();
            var a = r.DataStack.Pop();
            r.DataStack.Push(new Cell(DataType.N, (short)(b.Value + a.Value)));
        };
        DefinedWords["dump"] = r =>
        {
            Console.WriteLine(string.Join(' ', r.DataStack.AsEnumerable()));
        };
    }

    public void run()
    {
        var input = io.ReadLine();
        if (input == "42")
        {
            DataStack.Push(new Cell(DataType.N, 42));
            io.Write(DataStack.Peek().ToString());
        }
    }
    public void executeWord(string word)
    {
        short number;
        if (DefinedWords.ContainsKey(word))
        {
            DefinedWords[word](this);
        }
        else if (Int16.TryParse(word, out number))
        {
            DataStack.Push(new Cell(DataType.N, number));
        }
        else
        {
            throw new ArgumentException("Invalid word.", nameof(word));
        }
    }

    static short AsShort(CellType ct)
    {
        switch (ct)
        {
            case Tchar c: return (short)c.value;
            case Tushort u: return (short)u.value;
            case Tshort s: return s.value;
            case Tflag f: return (short)f.value;
            default: throw new ArgumentOutOfRangeException(nameof(ct));
        }
    }
}
