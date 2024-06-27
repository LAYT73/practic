using labs.classes;
using Rectangle = labs.classes.Rectangle;

namespace labs;

public partial class MainForm : Form
{
    private List<Bed> beds; // Используем List вместо массива для удобства добавления новых элементов
    private List<Figure> figuresList = new List<Figure>();
    public MainForm()
    {
        InitializeComponent();
        beds = new List<Bed>();
    }

    private void buttonCreateObject_Click(object sender, EventArgs e)
    {
        try
        {
            double width = double.Parse(textBoxWidth.Text);
            double length = double.Parse(textBoxLength.Text);
            double height = double.Parse(textBoxHeight.Text);
            string type = textBoxType.Text;

            Bed newBed = new Bed(width, length, height, type);
            beds.Add(newBed);

            listBoxObjects.Items.Add($"Кровать {beds.Count}"); // Добавляем в ListBox описание объекта
        }
        catch (FormatException)
        {
            MessageBox.Show("Пожалуйста, введите корректные значения.");
        }
        catch (ArgumentException ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    private void buttonOutput_Click(object sender, EventArgs e)
    {
        if (listBoxObjects.SelectedIndex >= 0)
        {
            Bed selectedBed = beds[listBoxObjects.SelectedIndex];

            textBoxWidth.Text = selectedBed.GetWidth().ToString();
            textBoxLength.Text = selectedBed.GetLength().ToString();
            textBoxHeight.Text = selectedBed.GetHeight().ToString();
            textBoxType.Text = selectedBed.GetBedType();
        }
        else
        {
            MessageBox.Show("Пожалуйста, выберите объект из списка.");
        }
    }

    private void buttonCreateRectangle_Click(object sender, EventArgs e)
    {
        if (int.TryParse(textBoxWidthRectangle.Text, out int width) && int.TryParse(textBoxHeightRectangle.Text, out int height))
        {
            Rectangle rectangle = new Rectangle
            {
                Width = width,
                Height = height
            };
            figuresList.Add(rectangle);
            listBoxFigures.Items.Add($"Rectangle ({rectangle.Width}x{rectangle.Height})");
        }
        else
        {
            MessageBox.Show("Please enter valid dimensions for the rectangle.");
        }
    }

    // Обработчик для buttonCreateCircle
    private void buttonCreateCircle_Click(object sender, EventArgs e)
    {
        if (int.TryParse(textBoxWidthCircle.Text, out int width) && int.TryParse(textBoxHeightCircle.Text, out int height))
        {
            FilledCircle circle = new FilledCircle
            {
                Width = width,
                Height = height
            };
            figuresList.Add(circle);
            listBoxFigures.Items.Add($"Filled Circle ({circle.Width}x{circle.Height})");
        }
        else
        {
            MessageBox.Show("Please enter valid dimensions for the circle.");
        }
    }

    private void buttonDrawFigures_Click(object sender, EventArgs e)
    {
        Random random = new Random();
        pictureBoxFigures.Refresh(); // Очистить PictureBox перед рисованием

        foreach (Figure figure in figuresList)
        {
            int x = random.Next(0, pictureBoxFigures.Width - figure.Width);
            int y = random.Next(0, pictureBoxFigures.Height - figure.Height);

            figure.Draw(pictureBoxFigures, x, y);
        }
    }

    private void buttonCalculateDifference_Click(object sender, EventArgs e)
    {
        if (int.TryParse(textBoxXDifference.Text, out int x) && int.TryParse(textBoxYDifference.Text, out int y))
        {
            DifferenceCalculator calculator = new DifferenceCalculator(); // Создание экземпляра DifferenceCalculator
            int difference = calculator.CalculateDifference(x, y);
            textBoxOutputDifference.Text = difference.ToString();
        }
        else
        {
            MessageBox.Show("Please enter valid integers for X and Y.");
        }
    }

    private void buttonCalculateSquare_Click(object sender, EventArgs e)
    {
        if (int.TryParse(textBoxXSquare.Text, out int x) && int.TryParse(textBoxYSquare.Text, out int y))
        {
            SquareRootDifferenceCalculator calculator = new SquareRootDifferenceCalculator(); // Создание экземпляра SquareRootDifferenceCalculator
            double squareRootDifference = calculator.CalculateSquareRootDifference(x, y);
            textBoxOutputSquare.Text = squareRootDifference.ToString();
        }
        else
        {
            MessageBox.Show("Please enter valid integers for X and Y.");
        }
    }
}
