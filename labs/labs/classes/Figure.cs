namespace labs.classes;

public abstract class Figure
{
    public abstract int Width { get; set; }
    public abstract int Height { get; set; }
    public abstract void Draw(PictureBox pictureBox, int x, int y);
}
