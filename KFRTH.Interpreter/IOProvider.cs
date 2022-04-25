using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFRTH.Interpreter
{
    public interface IOProvider
    {
        string ReadLine();
        void Write(string S);
    }
}
