namespace labs.classes;

public class Bed
{
    private double width;  // ширина кровати
    private double length; // длина кровати
    private double height; // высота кровати
    private string type;   // тип кровати (например, односпальная, двуспальная и т.д.)

    public Bed(double width, double length, double height, string type)
    {
        SetWidth(width);
        SetLength(length);
        SetHeight(height);
        SetType(type);
    }
    // Метод для установки ширины
    public void SetWidth(double width)
    {
        if (width <= 0)
        {
            throw new ArgumentException("Ширина должна быть положительным числом.");
        }
        this.width = width;
    }

    // Метод для получения ширины
    public double GetWidth()
    {
        return width;
    }

    // Метод для установки длины
    public void SetLength(double length)
    {
        if (length <= 0)
        {
            throw new ArgumentException("Длина должна быть положительным числом.");
        }
        this.length = length;
    }

    // Метод для получения длины
    public double GetLength()
    {
        return length;
    }

    // Метод для установки высоты
    public void SetHeight(double height)
    {
        if (height <= 0)
        {
            throw new ArgumentException("Высота должна быть положительным числом.");
        }
        this.height = height;
    }

    // Метод для получения высоты
    public double GetHeight()
    {
        return height;
    }

    // Метод для установки типа кровати
    public void SetType(string type)
    {
        if (string.IsNullOrWhiteSpace(type))
        {
            throw new ArgumentException("Тип кровати не может быть пустым.");
        }
        this.type = type;
    }

    // Метод для получения типа кровати
    public string GetBedType()
    {
        return type;
    }
}
