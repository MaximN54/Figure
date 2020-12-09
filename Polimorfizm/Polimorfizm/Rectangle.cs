using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizm
{
    class Rectangle : Square
    {
        public uint SideALength { get; }//делаю доступным только для чтения, т.к. не вижу смылса менять значения уже созданном объекте значения
        public uint SideBLength { get; }
        public Rectangle(uint sideALength, uint sideBLength) : base(1)//Олег,пожалуйста, объясните зачем эти танцы с бубном??ведь можно было спокойно наследоваться от Figure
        {
            if (sideALength <= 0 || sideBLength <= 0 || sideALength == sideBLength)
                throw new ArgumentOutOfRangeException("Длинна стороны прямоугольника должна быть больше нуля");
            if (sideALength == sideBLength)
                throw new ArgumentOutOfRangeException("Длинна и ширина прямоугольника должны иметь различные значения");
            SideALength = sideALength;
            SideBLength = sideBLength;
        }
        public override double P() => ((2 * SideALength) + (2 * SideBLength));

        public override double S() =>  SideALength * SideBLength;
    }
}
