Rectangle SoccerLand = new Rectangle(12.53, 19.42);
Console.WriteLine($"El área de la cancha es: {SoccerLand.area()} mts");

class Rectangle
{
    private double _width;
    private double _height;

    public Rectangle() { }

    public Rectangle(int width, int height)
    {
        this._width = width;
        this._height = height;
    }

    public Rectangle(double width, double height)
    {
        this._width = width;
        this._height = height;
    }

    public double area()
    {
        return this._width * this._height;
    }
}
