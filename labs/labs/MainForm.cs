using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labs
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonCreateArray_Click(object sender, EventArgs e)
        {
            try
            {
                int n = int.Parse(textBoxN.Text);
                int min = int.Parse(textBoxFirstNumberOfRange.Text);
                int max = int.Parse(textBoxSecondNumberOfRange.Text);
                Random random = new Random();
                int[] array = new int[n];
                for (int i = 0; i < n; i++)
                {
                    array[i] = random.Next(min, max + 1);
                }
                textBoxInput.Text = string.Join(" ", array);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при создании массива: " + ex.Message);
            }
        }

        private void buttonCreateMatrix_Click(object sender, EventArgs e)
        {
            try
            {
                int n = int.Parse(textBoxN.Text);
                int m = int.Parse(textBoxM.Text);
                int min = int.Parse(textBoxFirstNumberOfRange.Text);
                int max = int.Parse(textBoxSecondNumberOfRange.Text);
                Random random = new Random();
                int[,] matrix = new int[n, m];
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        matrix[i, j] = random.Next(min, max + 1);
                    }
                }
                textBoxInput.Text = string.Join(" | ", Enumerable.Range(0, n).Select(i => string.Join(" ", Enumerable.Range(0, m).Select(j => matrix[i, j]))));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при создании матрицы: " + ex.Message);
            }
        }

        private void buttonFirstTask_Click(object sender, EventArgs e)
        {
            richTextBoxTask.Text = "Задание 1: Дан целочисленный одномерный массив размера N. Серия – это последовательность элементов массива, идущих друг за другом. Каждый элемент серии больше предыдущего. Серия должна содержать минимум 2 элемента. Длина серии – количество элементов в серии. Найти все серии. Вывести информацию с указанием длины для каждой серий исходного массива.";
        }

        private void buttonSecondTask_Click(object sender, EventArgs e)
        {
            richTextBoxTask.Text = "Задание 2: Дан целочисленный одномерный массив размера N. Переставить в обратном порядке элементы массива, расположенные между первым отрицательным и последним положительным.";
        }

        private void buttonThirdTask_Click(object sender, EventArgs e)
        {
            richTextBoxTask.Text = "Задание 3: Дан целочисленный одномерный массив размера N. Вставить -1 после каждого отрицательного элемента массива.";
        }

        private void buttonFourthTask_Click(object sender, EventArgs e)
        {
            richTextBoxTask.Text = "Задание 4: Дан целочисленный одномерный массив размера N. Удалить из массива все отрицательный элементы.";
        }

        private void buttonFifthTask_Click(object sender, EventArgs e)
        {
            richTextBoxTask.Text = "Задание 5: Дан целочисленный двумерный массив размера N*N. Добавить в массив строку 0 после каждой строки, в которой есть хотя бы один элемент, меньший по модулю среднего арифметического элементов массива.";
        }

        private void buttonSixthTask_Click(object sender, EventArgs e)
        {
            richTextBoxTask.Text = "Задание 6: Дан целочисленный двумерный массив размера N*N. Упорядочить элементы в матрице по возрастанию (слева направо, сверху-вниз)";
        }

        private void buttonPrintResult_Click(object sender, EventArgs e)
        {
            try
            {
                string taskDescription = richTextBoxTask.Text;
                if (taskDescription.Contains("Задание 1"))
                {
                    int[] array = textBoxInput.Text.Split(' ').Select(int.Parse).ToArray();
                    string seriesList = TaskFirst(array);
                    richTextBoxResult.Text = seriesList;
                } 
                else if (taskDescription.Contains("Задание 2"))
                {
                    int[] array = textBoxInput.Text.Split(' ').Select(int.Parse).ToArray();
                    TaskSecond(array);
                    richTextBoxResult.Text = string.Join(" ", array);
                }
                else if (taskDescription.Contains("Задание 3"))
                {
                    int[] array = textBoxInput.Text.Split(' ').Select(int.Parse).ToArray();
                    array = TaskThird(array);
                    richTextBoxResult.Text = string.Join(" ", array);
                }
                else if (taskDescription.Contains("Задание 4"))
                {
                    int[] array = textBoxInput.Text.Split(' ').Select(int.Parse).ToArray();
                    array = TaskFourth(array);
                    richTextBoxResult.Text = string.Join(" ", array);
                }
                else if (taskDescription.Contains("Задание 5"))
                {
                    string matrixString = textBoxInput.Text.Trim();

                    string[] rows = matrixString.Split(new string[] { " | " }, StringSplitOptions.RemoveEmptyEntries);

                    int rowCount = rows.Length;
                    int columnCount = rows[0].Split(' ').Length;

                    int[,] matrix = new int[rowCount, columnCount];

                    for (int i = 0; i < rowCount; i++)
                    {
                        string[] rowValues = rows[i].Split(' ');

                        for (int j = 0; j < columnCount; j++)
                        {
                            matrix[i, j] = int.Parse(rowValues[j]);
                        }
                    }

                    matrix = TaskFifth(matrix);
                    rowCount = matrix.GetLength(0);
                    columnCount = matrix.GetLength(1);
                    string resultText = "";
                    for (int i = 0; i < rowCount; i++)
                    {
                        for (int j = 0; j < columnCount; j++)
                        {
                            resultText += matrix[i, j] + " ";
                        }
                        resultText += "\n"; // Переход на новую строку после каждой строки матрицы
                    }

                    // Выводим результат в richTextBoxResult
                    richTextBoxResult.Text = resultText.Trim();
                }
                else if (taskDescription.Contains("Задание 6"))
                {
                    string matrixString = textBoxInput.Text.Trim();

                    string[] rows = matrixString.Split(new string[] { " | " }, StringSplitOptions.RemoveEmptyEntries);

                    int rowCount = rows.Length;
                    int columnCount = rows[0].Split(' ').Length;

                    int[,] matrix = new int[rowCount, columnCount];

                    for (int i = 0; i < rowCount; i++)
                    {
                        string[] rowValues = rows[i].Split(' ');

                        for (int j = 0; j < columnCount; j++)
                        {
                            matrix[i, j] = int.Parse(rowValues[j]);
                        }
                    }

                    TaskSixth(matrix);
                    
                    string resultText = "";
                    for (int i = 0; i < rowCount; i++)
                    {
                        for (int j = 0; j < columnCount; j++)
                        {
                            resultText += matrix[i, j] + " ";
                        }
                        resultText += "\n"; // Переход на новую строку после каждой строки матрицы
                    }

                    // Выводим результат в richTextBoxResult
                    richTextBoxResult.Text = resultText.Trim();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при выполнении задания: " + ex.Message);
            }
        }

        public string TaskFirst(int[] array)
        {
            int n = array.Length;
            if (n < 2)
            {
                return "Массив слишком мал для серий.";
            }

            int start = 0;
            bool inSeries = false;
            string result = "";
            for (int i = 1; i < n; i++)
            {
                if (array[i] > array[i - 1])
                {
                    if (!inSeries)
                    {
                        start = i - 1;
                        inSeries = true;
                    }
                }
                else
                {
                    if (inSeries)
                    {
                        result += $"Серия с длиной {i - start} начинается с индекса {start} и заканчивается на индексе {i - 1} \n";
                        inSeries = false;
                    }
                }
            }

            if (inSeries)
            {
                result += $"Серия с длиной {n - start} начинается с индекса {start} и заканчивается на индексе {n - 1} \n";
            }

            return result;
        }
        public void TaskSecond(int[] array)
        {
            int n = array.Length;
            int firstNegativeIndex = -1;
            int lastPositiveIndex = -1;

            for (int i = 0; i < n; i++)
            {
                if (array[i] < 0 && firstNegativeIndex == -1)
                {
                    firstNegativeIndex = i;
                }

                if (array[i] > 0)
                {
                    lastPositiveIndex = i;
                }
            }

            if (firstNegativeIndex == -1 || lastPositiveIndex == -1 || firstNegativeIndex >= lastPositiveIndex)
            {
                MessageBox.Show("Не найдено подходящих элементов для перестановки.");
                return;
            }
            firstNegativeIndex++;
            lastPositiveIndex--;
            // Перестановка элементов между firstNegativeIndex и lastPositiveIndex
            while (firstNegativeIndex < lastPositiveIndex)
            {
                int temp = array[firstNegativeIndex];
                array[firstNegativeIndex] = array[lastPositiveIndex];
                array[lastPositiveIndex] = temp;

                firstNegativeIndex++;
                lastPositiveIndex--;
            }
        }
        public int[] TaskThird(int[] array)
        {
            int originalSize = array.Length;
            int newSize = originalSize;

            // Подсчет количества отрицательных элементов для определения нового размера массива
            for (int i = 0; i < originalSize; i++)
            {
                if (array[i] < 0)
                {
                    newSize++;
                }
            }

            // Создание нового массива
            int[] newArray = new int[newSize];
            int j = 0;

            // Копирование элементов и вставка -1 после каждого отрицательного элемента
            for (int i = 0; i < originalSize; i++)
            {
                newArray[j] = array[i];
                j++;
                if (array[i] < 0)
                {
                    newArray[j] = -1;
                    j++;
                }
            }

            return newArray;
        }

        public int[] TaskFourth(int[] array)
        {
            int size = array.Length;
            int count = 0;

            // Подсчет количества неотрицательных элементов
            for (int i = 0; i < size; i++)
            {
                if (array[i] >= 0)
                {
                    count++;
                }
            }

            // Создание нового массива для неотрицательных элементов
            int[] newArray = new int[count];
            int index = 0;

            // Копирование неотрицательных элементов в новый массив
            for (int i = 0; i < size; i++)
            {
                if (array[i] >= 0)
                {
                    newArray[index] = array[i];
                    index++;
                }
            }

            return newArray;
        }
        public static int[,] TaskFifth(int[,] matrix)
        {
            int n = matrix.GetLength(0);
            int m = matrix.GetLength(1);

            // Вычисление среднего арифметического элементов матрицы по модулю
            double sum = 0;
            int count = n * m;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    sum += Math.Abs(matrix[i, j]);
                }
            }
            double average = sum / count;

            // Подсчет количества строк, которые должны быть добавлены
            int newRowCount = n;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (Math.Abs(matrix[i, j]) < average)
                    {
                        newRowCount++;
                        break;
                    }
                }
            }

            // Создание новой матрицы с нужными размерами
            int[,] newMatrix = new int[newRowCount, m];
            int newIndex = 0;

            // Заполнение новой матрицы
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    newMatrix[newIndex, j] = matrix[i, j];
                }

                newIndex++;

                // Проверка, нужно ли добавить строку нулей
                bool addZeroRow = false;
                for (int j = 0; j < m; j++)
                {
                    if (Math.Abs(matrix[i, j]) < average)
                    {
                        addZeroRow = true;
                        break;
                    }
                }

                if (addZeroRow)
                {
                    for (int j = 0; j < m; j++)
                    {
                        newMatrix[newIndex, j] = 0;
                    }
                    newIndex++;
                }
            }

            return newMatrix;
        }

        public void TaskSixth(int[,] matrix)
        {
            int n = matrix.GetLength(0); // Размерность матрицы (N)

            // Проходим по всем элементам матрицы, кроме последнего, потому что последний элемент будет уже отсортирован
            for (int k = 0; k < n * n - 1; k++)
            {
                // Преобразуем k в координаты i и j
                int i = k / n;
                int j = k % n;

                // Проходим по всем парам соседних элементов и меняем их местами, если нужно
                for (int l = k + 1; l < n * n; l++)
                {
                    // Преобразуем l в координаты m и p
                    int m = l / n;
                    int p = l % n;

                    // Сравниваем элементы и меняем их местами, если необходимо
                    if (matrix[i, j] > matrix[m, p])
                    {
                        // Обмен значений элементов матрицы без использования дополнительных массивов
                        int temp = matrix[i, j];
                        matrix[i, j] = matrix[m, p];
                        matrix[m, p] = temp;
                    }
                }
            }
        }

    }
}
