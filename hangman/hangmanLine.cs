using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;


namespace hangman
{
    class hangmanLine
    {
        public Line myLine { get; set; } 
        static int counterLinesDrawn = 0;
        public  Ellipse head { get; set; }
        public static int CounterLinesDrawn  {
            get
            {
                return counterLinesDrawn;
            }
            private set
            {
                counterLinesDrawn = value;
            }
                
        }

    public hangmanLine() {
            myLine = new Line();
            
            myLine.Stroke = System.Windows.Media.Brushes.LightSteelBlue;
            myLine.StrokeThickness = 2;
            counterLinesDrawn++;

        }


        public Shape drawHangmanLine()
        {
            switch (counterLinesDrawn)
            {
                case 1:
                    myLine.X1 = 40;
                    myLine.Y1 = 100;

                    myLine.X2 = 40;
                    myLine.Y2 = 40;
                    break;
                case 2:
                    myLine.X1 = 40;
                    myLine.Y1 = 40;

                    myLine.X2 = 80;
                    myLine.Y2 = 40;                   
                    break;
                case 3:
                    myLine.X1 = 80;
                    myLine.Y1 = 40;

                    myLine.X2 = 80;
                    myLine.Y2 = 50;
                    break;
                case 4:
                    head = new Ellipse();
                    head.Height = 15;
                    head.Width = 20;
                    head.StrokeThickness = 2;
                    head.Stroke = new SolidColorBrush(Colors.Black);
                    head.Margin = new Thickness(69,50,0,0);
                    return head;
                case 5:
                    myLine.X1 = 78;
                    myLine.Y1 = 65;

                    myLine.X2 = 78;
                    myLine.Y2 = 80;
                    break;
                case 6:
                    myLine.X1 = 78;
                    myLine.Y1 = 80;

                    myLine.X2 = 68;
                    myLine.Y2 = 90;
                    break;
                case 7:
                    myLine.X1 = 78;
                    myLine.Y1 = 80;

                    myLine.X2 = 88;
                    myLine.Y2 = 90;
                    break;
            }
       
            return myLine;
        }
   
    }



}
