// See https://aka.ms/new-console-template for more information
using KFRTH.Interpreter;
Console.WriteLine("Hello, World!");

CoreWordset core = new Runtime();

core.BL();
Console.WriteLine(((Runtime)core).dataStack.Peek());