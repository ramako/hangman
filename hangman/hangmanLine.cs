using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;

namespace hangman
{
    class hangmanLine
    {
        public Line myLine { get; set; }
        static int counterLinesDrawn=0;


        public hangmanLine() {
            myLine = new Line();
            myLine.Stroke = System.Windows.Media.Brushes.LightSteelBlue;
            myLine.StrokeThickness = 2;
            counterLinesDrawn++;

        }


        public Line drawHangmanLine()
        {
            switch (counterLinesDrawn)
            {
                case 1:
                    myLine.X1 = 1;
                    myLine.X2 = 50;
                    myLine.Y1 = 1;
                    myLine.Y2 = 50;
                    break;
                case 2:
                    myLine.X1 = 10;
                    myLine.X2 = 25;
                    myLine.Y1 = 60;
                    myLine.Y2 = 90;                   
                    break;
                case 3:
                    myLine.X1 = 30;
                    myLine.X2 = 40;
                    myLine.Y1 = 10;
                    myLine.Y2 = 40;
                    break;
                case 4:
                    myLine.X1 = 30;
                    myLine.X2 = 40;
                    myLine.Y1 = 10;
                    myLine.Y2 = 40;
                    break;
            }
       
            return myLine;
        }
   
    }



}
