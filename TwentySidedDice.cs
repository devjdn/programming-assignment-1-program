using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaydensApp
{
    internal class TwentySidedDice : Dice
    { 

        public override void GenerateNumber()
        {
            _Num = random.Next(1, 20);
        }// End of Generte number Method

        // Object Constructor Methods
        public TwentySidedDice()
        {
            _Num = 1;
            _Colour = "Black";
        }// Creates a constructure with fixed values

        public TwentySidedDice(string inColour) : base(inColour)
        {
            GenerateNumber();
        }// Creates a constructor with randomised values
    }
}