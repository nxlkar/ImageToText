using System;

namespace AsiiArt
{
    public static class SymbolSelector
    {
        public static string ChooseSymbol(int sb, int tbr)

        {

            var checkbrighness = 0.0f;
            
            

            if (sb <tbr*2-45) return ("#"); //for charcutrie avg = 123
            else return " ";

            //if (sb < 180) return ("#"); //for charcutrie avg = 123
            //else return " ";

            if (sb != 0)
            {
                checkbrighness = ((float)(tbr) / (float)(sb));
            }
            else
            {
                checkbrighness = 0;
            }


            //if (checkbrighness > 0.65 & checkbrighness < 0.9) return ("#"); //for pringles avg = 170
            //if (checkbrighness > 0.75 & checkbrighness < 1.5) return ("#"); //for pringles avg = 170
            //else return " ";

            }
    }
}