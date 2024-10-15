using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaydensApp
{
    internal class TenSidedDice : Dice
    {
        public override void GenerateNumber()
        {
            _Num = random.Next(1, 10);
        }// End of Generate number Method

        // Object Constructor Methods
        public TenSidedDice()
        {
            _Num = 1;
            _Colour = "Black";
        }// Creates a constructure with fixed values

       
        public TenSidedDice(string inColour) : base(inColour)
        {
            GenerateNumber();
        }// Creates a constructor with randomised values
    }
}