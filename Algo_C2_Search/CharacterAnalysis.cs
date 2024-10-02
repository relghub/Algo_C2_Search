using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo_C2_Search
{
    public class CharacterAnalysis
    {
        public static void Starter(TextBox textInput, TextBox textOutput)
        {
            // Запитуємо рядок у користувача
            string input = textInput.Text;

            // Лічильники
            int lowerCyrillic = 0, upperCyrillic = 0;
            int lowerLatin = 0, upperLatin = 0;
            int digitCount = 0, otherSymbols = 0;

            // Прохід по кожному символу в рядку
            foreach (char c in input)
            {
                if (c >= 'а' && c <= 'я') // Малі кирилічні літери
                    lowerCyrillic++;
                else if (c >= 'А' && c <= 'Я') // Великі кирилічні літери
                    upperCyrillic++;
                else if (c >= 'a' && c <= 'z') // Малі латинські літери
                    lowerLatin++;
                else if (c >= 'A' && c <= 'Z') // Великі латинські літери
                    upperLatin++;
                else if (char.IsDigit(c)) // Цифри
                    digitCount++;
                else if (!char.IsWhiteSpace(c)) // Інші символи, окрім пробілів
                    otherSymbols++;
            }

            textOutput.Clear();
            // Виводимо результати
            textOutput.AppendText("У введеному рядку:");
            textOutput.AppendText(Environment.NewLine);
            textOutput.AppendText($"малих кирилічних букв - {lowerCyrillic}");
            textOutput.AppendText(Environment.NewLine);
            textOutput.AppendText($"великих кирилічних букв - {upperCyrillic}");
            textOutput.AppendText(Environment.NewLine);
            textOutput.AppendText($"малих латинських букв - {lowerLatin}");
            textOutput.AppendText(Environment.NewLine);
            textOutput.AppendText($"великих латинських букв - {upperLatin}");
            textOutput.AppendText(Environment.NewLine);
            textOutput.AppendText($"цифрових символів - {digitCount}");
            textOutput.AppendText(Environment.NewLine);
            textOutput.AppendText($"інших символів - {otherSymbols}");
            textOutput.AppendText(Environment.NewLine);
        }
    }
}
