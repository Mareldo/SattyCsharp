using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace saaty
{
    class GridFormValid
    {
        public int Row { get; private set; }
        public int Column { get; private set; }
        public string Value { get; private set; }
        public int Fractal { get; set; }

        public GridFormValid(int Row, int Column, string Value)
        {
            this.Row = Row;
            this.Column = Column;
            this.Value = Value;
        }

        public bool checkIfCellIsRegex()
        {
            string number1 = @"[1-9]";
            string number2 = @"1/[2-9]";
            Match matchNumber1;
            matchNumber1 = Regex.Match(this.Value, number1);
            if (matchNumber1.Success)
            {
                this.Fractal = 1;
            }
            Match matchNumber2;
            matchNumber2 = Regex.Match(this.Value, number2);
            if (matchNumber2.Success)
            {
                this.Fractal = 2;
            }

            if (matchNumber1.Success || matchNumber2.Success) { return false; }
            Fractal = 0;
            return true;
        }

        public bool checkIfCellIsRegex(string Value)
        {
            string number1 = @"[1-9]";
            string number2 = @"1/[2-9]";
            Match matchNumber1;
            matchNumber1 = Regex.Match(Value, number1);
            if(matchNumber1.Success)
            {
                this.Fractal = 1;
            }
            Match matchNumber2;
            matchNumber2 = Regex.Match(Value, number2);
            if (matchNumber2.Success)
            {
                this.Fractal = 2;
            }

            if (matchNumber1.Success || matchNumber2.Success) { return false; }
            Fractal = 0;
            return true;
        }

        public bool Valid()
        {
            if (checkIfCellIsRegex(Value)) { return false; }

            if (Column == Row)
            {
                Value = "1";
                return true;
            }

            if (Value.Length == 3)
            {
                Value = Value[2].ToString();
                int temp = Row;
                Row = Column;
                Column = temp;
                return true;
            }
            else if (Value.Length == 1)
            {
                if (Value == "1")
                {
                    Value = "1";
                    int temp = Row;
                    Row = Column;
                    Column = temp;
                    return true;
                }
                else
                {
                    Value = "1/" + Value;
                    int temp = Row;
                    Row = Column;
                    Column = temp;
                    return true;
                }
            }

            return false;
        }
    }


}
