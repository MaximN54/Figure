using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizm
{
    class Square : Figure
    {
        public Square(uint sideLength)
        {
            if (sideLength == 0)
                throw new ArgumentOutOfRangeException("Длинна стороны квадрата должна быть больше нуля");
            SideLength = sideLength;
        }
        public uint SideLength { get; }//делаю доступным только для чтения, т.к. не вижу смылса менять значения уже созданном объекте значения
        public override double P() => (4 * SideLength);
        public override double S() => (2 * SideLength);
    }
}
