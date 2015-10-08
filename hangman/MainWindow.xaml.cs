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
        char[] tempWord;
        int wordForHangmanLenght;


        public MainWindow()
        {
            InitializeComponent();
            Random rand = new Random();
            lines = System.IO.File.ReadAllLines(path);
            wordForHangman=lines[rand.Next(lines.Length)];
            tempWord = new char[wordForHangman.Length*2];
            //  tempWord = wordForHangman.ToCharArray();
            //showWordTextBlock.Text = wordForHangman;          
            wordForHangmanLenght = wordForHangman.Length;
            for (int i=0; i<wordForHangman.Length*2; i++)
            {
                if (i % 2 == 0)
                    tempWord[i] = ' ';
                else
                    tempWord[i] = '_';


            }
            showWordTextBlock.Text = new string(tempWord);
        }
        //transformar tempWord en p_e_p_p_e_r
        private void button_Click(object sender, RoutedEventArgs e)
        {
            bool encontrado = false;
            string wordFromGuessTextBox = guessTextBox.Text;

            for (int i = 0; i < wordForHangman.Length; i++)
            {

                if (Convert.ToChar(wordFromGuessTextBox) == wordForHangman.ToCharArray()[i])
                {
                    encontrado = true;
                    tempWord[i + i + 1] = Convert.ToChar(guessTextBox.Text);
                    wordForHangmanLenght--;
                }


            }
            if (encontrado == false)
            {
                wordTextBlock.Text = "no esta";
                hangmanCanvas.Children.Add(new hangmanLine().drawHangmanLine());
            }

            showWordTextBlock.Text = new string(tempWord);
            if (wordForHangmanLenght == 0)
            {
                MessageBox.Show("You have won!!", "Result", MessageBoxButton.OK, MessageBoxImage.Question);
            }
        }
    } //class
} //namespace
