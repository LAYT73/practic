using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace labs
{
    public partial class MainForm : Form
    {
        private Stack<int> stack;
        private Random random;
        private int[] array;
        private MergeSortStep mergeSortStep;
        public MainForm()
        {
            InitializeComponent();
            stack = new Stack<int>();
            array = new int[0];
            random = new Random();
        }

        public class Node<T>
        {
            public T Data { get; set; }
            public Node<T> Next { get; set; }

            public Node(T data)
            {
                Data = data;
                Next = null;
            }
        }

        public class Stack<T>
        {
            private Node<T> top;

            public Stack()
            {
                top = null;
            }

            // Метод для добавления элемента в стек
            public void Push(T data)
            {
                Node<T> newNode = new Node<T>(data);
                newNode.Next = top;
                top = newNode;
            }

            // Метод для удаления элемента из стека
            public T Pop()
            {
                if (top == null)
                    throw new InvalidOperationException("Стек пуст.");

                T value = top.Data;
                top = top.Next;
                return value;
            }

            // Метод для проверки пустоты стека
            public bool IsEmpty()
            {
                return top == null;
            }

            // Метод для просмотра верхнего элемента без его удаления
            public T Peek()
            {
                if (top == null)
                    throw new InvalidOperationException("Стек пуст.");
                return top.Data;
            }

            public override string ToString()
            {
                StringBuilder result = new StringBuilder();
                Node<T> current = top;

                while (current != null)
                {
                    result.Append(current.Data).Append(" ");
                    current = current.Next;
                }

                return result.ToString().Trim();
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int randomValue = random.Next(0, 20); // Генерация случайного числа от 1 до 100
            stack.Push(randomValue);
            textBoxResult.Text = stack.ToString();
        }

        private void buttonPop_Click(object sender, EventArgs e)
        {
            if (stack.IsEmpty())
            {
                MessageBox.Show("Стек пуст.");
            }
            else
            {
                int value = stack.Pop();
                textBoxResult.Text = stack.ToString();
                MessageBox.Show($"Элемент {value} удален из стека.");
            }
        }

        private void buttonGenerateArray_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            array = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 16); // Генерация случайного числа от 0 до 15
            }
            mergeSortStep = new MergeSortStep(array);
            textBoxArray.Text = string.Join(" ", array);
        }

        private void buttonStep_Click(object sender, EventArgs e)
        {
            if (mergeSortStep != null)
            {
                bool sorted = mergeSortStep.NextStep();
                array = mergeSortStep.GetArray();

                textBoxArray.Text = string.Join(" ", array);
                if (sorted)
                {
                    MessageBox.Show("Массив отсортирован.");
                }
            }
            else
            {
                MessageBox.Show("Добавьте элементы для сортировки.");
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string target = textBoxTarget.Text.Trim();
            string[] graphLines = textBoxGraph.Text.Split(new[] { '\r', '\n', ';' }, StringSplitOptions.RemoveEmptyEntries);

            var graph = new Dictionary<string, List<string>>();

            foreach (var line in graphLines)
            {
                var parts = line.Split(' ');
                if (parts.Length > 1)
                {
                    var vertex = parts[0];
                    var neighbors = parts.Skip(1).ToList();
                    graph[vertex] = neighbors;
                }
            }

            bool found = graph.ContainsKey(target);
            string message = found ? $"Вершина {target} найдена в графе." : $"Вершина {target} не найдена в графе.";
            MessageBox.Show(message);
        }

    }
}
