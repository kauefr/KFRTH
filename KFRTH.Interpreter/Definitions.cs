using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFRTH.Interpreter;

public static class Definitions
{
    public abstract record CellType;
    public record Tshort(short value) : CellType
    {
        public static implicit operator short(Tshort tshort) => tshort.value;
    }
    public record Tushort(ushort value) : CellType;
    public record Tchar(char value) : CellType;
    public record Tflag(ushort value) : CellType;

    public static readonly Tflag FLAG_FALSE = new(0x_00_00);
    public static readonly Tflag FLAG_TRUE = new(0x_FF_FF);
}
