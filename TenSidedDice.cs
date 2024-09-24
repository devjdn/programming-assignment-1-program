using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaydensApp
{
    internal class TenSidedDice
    {
        protected string _Colour;
        protected int _Num;

        public string Colour
        {
            get
            {
                return _Colour;
            }
            set
            {
                if ((value.Length > 0) && (value.Length <= 10))
                {
                    _Colour = value;
                }
                else
                {
                    throw new Exception("Bad colour: " + value);
                }
            }
        }// End colour property

        public virtual int Num
        {
            get { return _Num; } // Underscore represents a Read Only property
        }// End Num property

        // 3 Methods
        protected static Random random = new Random();

        public virtual void GenerateNumber()
        {
            _Num = random.Next(1, 10);
        }// End of Generte number Method

        // 4 Override Methods
        public override string ToString()
        {
            return _Colour + " " + _Num;
        }// End of ToString Method

        // Object Constructor Methods
        public TenSidedDice()
        {
            _Num = 1;
            _Colour = "Black";
        }// Creates a constructure with fixed values

        public TenSidedDice(string inColour, int inNum)
        {
            _Colour = inColour;
            _Num = inNum;
        }// Creates a constructor with randomised values

        public TenSidedDice(string inColour)
        {
            Colour = inColour;
            GenerateNumber();
        }// Creates a constructor with randomised values
    }
}