using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFRTH.Interpreter;

public class ShortOnlyInterpreter
{
    public readonly Stack<short> dataStack = new();
    public static readonly Dictionary<string, Action<ShortOnlyInterpreter>> BaseWords = new()
    {
        ["POP"] = r => r.dataStack.Pop()
    };
}