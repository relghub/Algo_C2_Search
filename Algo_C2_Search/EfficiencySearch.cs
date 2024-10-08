using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace Algo_C2_Search
{
    public class EfficiencySearch
    {
        public static void Starter(TextBox[] textBox)
        {
            int m = int.Parse(textBox[1].Text); // кількість ключів для пошуку
            int n = int.Parse(textBox[2].Text); // розмір масиву

            // Генерація випадкового масиву та ключів
            Random rand = new Random();
            int[] array = new int[n];
            int[] keys = new int[m];

            for (int i = 0; i < n; i++)
                array[i] = rand.Next(0, n); // Випадкові числа в межах від 0 до n - 1

            // Генеруємо ключі для пошуку з інтервалу (0, m - i)
            for (int i = 0; i < m; i++)
                keys[i] = rand.Next(0, m - i); // Випадкові ключі з інтервалу (0, m - i)

            // Сортуємо масив для інтерполяційного пошуку
            Array.Sort(array);

            // Послідовний пошук
            Stopwatch stopwatch = Stopwatch.StartNew();
            int linearComparisons = 0;
            foreach (int key in keys)
            {
                LinearSearch(array, key, ref linearComparisons);
            }
            stopwatch.Stop();
            textBox[0].AppendText($"Послідовний пошук: {(stopwatch.Elapsed.TotalNanoseconds) / 1000} мкс, Порівняння: {linearComparisons}");
            textBox[0].AppendText(Environment.NewLine);

            // Інтерполяційний пошук
            stopwatch.Restart();
            int interpolationComparisons = 0;
            foreach (int key in keys)
            {
                InterpolationSearch(array, key, ref interpolationComparisons);
            }
            stopwatch.Stop();
            textBox[0].AppendText($"Інтерполяційний пошук: {(stopwatch.Elapsed.TotalNanoseconds) / 1000} мкс, Порівняння: {interpolationComparisons}");
            textBox[0].AppendText(Environment.NewLine);
        }

        // Послідовний пошук
        static int LinearSearch(int[] array, int key, ref int comparisons)
        {
            for (int i = 0; i < array.Length; i++)
            {
                comparisons++;
                if (array[i] == key)
                    return i;
            }
            return -1;
        }

        // Інтерполяційний пошук
        static int InterpolationSearch(int[] array, int key, ref int comparisons)
        {
            int low = 0, high = array.Length - 1;

            while (low <= high && key >= array[low] && key <= array[high])
            {
                comparisons++;

                // Інтерполяційна формула для оцінки позиції
                int pos = low + ((key - array[low]) * (high - low)) / (array[high] - array[low]);

                // Перевірка знайденого індексу
                if (array[pos] == key)
                    return pos;

                if (array[pos] < key)
                    low = pos + 1;
                else
                    high = pos - 1;
            }

            return -1;
        }
    }
}
