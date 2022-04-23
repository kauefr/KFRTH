namespace KFRTH.Interpreter;

using static Definitions;
public class Runtime : CoreWordset
{
    public readonly Stack<CellType> dataStack = new();

    void CoreWordset.BL()
    {
        dataStack.Push(new Tchar(' '));
    }
}
