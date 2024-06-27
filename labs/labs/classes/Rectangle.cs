namespace labs.classes;

public class Rectangle : Figure
{
    public override int Width { get; set; }
    public override int Height { get; set; }

    public override void Draw(PictureBox pictureBox, int x, int y)
    {
        Graphics g = pictureBox.CreateGraphics();
        Pen pen = new Pen(Color.Black);
        g.DrawRectangle(pen, x, y, Width, Height);
    }
}
