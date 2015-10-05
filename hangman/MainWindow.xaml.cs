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
            //showWordTextBlock.Text = wordForHangman;
            for (int i = 0; i <= wordForHangman.Length; i++)
                showWordTextBlock.Text+= " _";


        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            bool encontrado = false;
            string wordFromGuessTextBox=guessTextBox.Text;
            guessTextBox.Text = "";

            if (wordFromGuessTextBox == "")
                return;
            for (int i = 0; i < wordForHangman.Length; i++)
            {
                if (wordForHangman[i] == wordFromGuessTextBox[0])
                {
                    encontrado = true;
                    wordTextBlock.Text = "esta";
                    //Update guessWord with the letter guessed
                    // showWordTextBlock.Text.Insert(i, wordForHangman[i]);

                    //quitar caracter de wordForHangman que sea igual a c
                    //cuando hay dos juntas pp al quitar un elemento y reducir
                    //el tamaño, esta sera saltada..
                    deleteCharacterFromString(i);

                }
            }
            if (encontrado==false)
                {
                     wordTextBlock.Text = "no esta";
                     hangmanCanvas.Children.Add(new hangmanLine().drawHangmanLine());
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
            {
                 MessageBox.Show("You have won!!","Result", MessageBoxButton.OK,MessageBoxImage.Question);
            }
            else
                showWordTextBlock.Text = wordForHangman;
        }
    }
}
