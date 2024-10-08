using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество элементов массива (K): ");
            int K = int.Parse(Console.ReadLine());
            
            char[] alphabet = "абвгдежзийклмнопрстуфхцчшщъыьэюя".ToCharArray();// Создание символьного массива
            char[] charArray = new char[K];
            Random rand = new Random();
            for (int i = 0; i < K; i++)// Заполнение массива случайными буквами русского алфавита
            {
                charArray[i] = alphabet[rand.Next(alphabet.Length)];
            }

            char[] consonantsArray = Array.FindAll(charArray, IsConsonant);// Создание нового массива для согласных бук

            Console.WriteLine("Символьный массив:");// Вывод элементов первого массива
            foreach (char c in charArray)
            {
                Console.Write(c + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Массив согласных букв:"); // Вывод элементов второго массива
            foreach (char c in consonantsArray)
            {
                Console.Write(c + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Нажмите Enter, чтобы закрыть программу.");
            Console.ReadLine();
        }
        static bool IsConsonant(char c)// Метод для проверки, является ли буква согласной
        {
            // Согласные буквы русского алфавита
            char[] consonants = { 'б', 'в', 'г', 'д', 'ж', 'з', 'й', 'к', 'л', 'м', 'н', 'п', 'р', 'с', 'т', 'ф', 'х', 'ц', 'ч', 'ш', 'щ' };
            return Array.Exists(consonants, element => element == c);
        }
    }
}
