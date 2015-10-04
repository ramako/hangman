using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace hangman
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string wordForHangman;
        string[] lines;
        const string path = @"../../Words/hangman.txt";
        public MainWindow()
        {
            InitializeComponent();
            Random rand = new Random();
            lines = System.IO.File.ReadAllLines(path);
            wordForHangman=lines[rand.Next(lines.Length)];
            showWordTextBlock.Text = wordForHangman;

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            /*  int temp = 0;
              showWordTextBlock.Text = wordForHangman;
              wordTextBlock.Text= wordForHangman.IndexOf(guessTextBox.Text).ToString();
              temp= wordForHangman.IndexOf(guessTextBox.Text);*/
            if (guessTextBox.Text == "")
                return;
            for (int i=0; i< wordForHangman.Length; i++)
                if (wordForHangman[i] == guessTextBox.Text[0])
                {
                    wordTextBlock.Text = "esta";
                    //quitar caracter de wordForHangman que sea igual a c
                    deleteCharacterFromString(i);
                    return;
                }
                else
                { 
                    wordTextBlock.Text = "no esta";
                }


        }

       /// <summary>
       /// 
       /// </summary>
       /// <param name="indexCharacter"> index of the character to be deleted.</param>
        public void deleteCharacterFromString(int indexCharacter)
        {
            wordForHangman=wordForHangman.Remove(indexCharacter,1);
            if (wordForHangman.Length == 0)
                showWordTextBlock.Text = "You've won";
            else
                showWordTextBlock.Text = wordForHangman;
        }
    }
}
