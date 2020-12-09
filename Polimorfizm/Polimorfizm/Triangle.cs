using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizm
{
    class Triangle:Figure
    {
        public uint SideALength { get; }
        public uint SideBLength { get; }
        public uint SideCLength { get; }
        public Triangle(uint sideALength, uint sideBLength, uint sideCLength)
        {
            if (sideALength == 0 || sideBLength==0 || sideCLength==0)
                throw new ArgumentOutOfRangeException("Длинна стороны треугольника должна быть больше нуля");
            uint a = sideALength;
            uint b = sideBLength;
            uint c = sideCLength;

            if (a < b)
                (a, b) = (b, a);

            if (a < c)
                (a, c) = (c, a);

            if (a >= b + c)
                throw new ArithmeticException("Треугольник создать невозможно. Длинна стороны тругольника должна быть больше суммы двух других. ");
            SideALength = sideALength;
            SideBLength = sideBLength;
            SideCLength = sideCLength;
        }
        public override double S()
        {
            double p = (P() / 2);
            return Math.Sqrt(p * (p - SideALength) * (p - SideBLength) * (p - SideCLength));
        }
        public override double P() => SideALength + SideBLength + SideCLength;
    }
}
