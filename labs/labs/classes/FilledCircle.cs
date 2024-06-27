namespace labs.classes;

public class FilledCircle : Figure
{
    public override int Width { get; set; }
    public override int Height { get; set; }

    public override void Draw(PictureBox pictureBox, int x, int y)
    {
        Graphics g = pictureBox.CreateGraphics();
        Brush brush = new SolidBrush(Color.Red); // Example brush color
        g.FillEllipse(brush, x, y, Width, Height);
    }
}