Rectangle SoccerLand = new Rectangle(12.53, 19.42);
Rectangle Figure = new Rectangle();
Console.WriteLine($"El área de la cancha es: {SoccerLand.CalculateArea()} mts");
Console.WriteLine($"El área default es: {Figure.CalculateArea()}");

class Rectangle
{
    private double _width;
    private double _height;

	// this() hace refencia a si mismo y depende los parámetros que pase
	// hace referencia a la sobrecarga del constructor correspondiente.
    public Rectangle() : this(12, 32) { }

    public Rectangle(int width, int height)
    {
        _width = width;
        _height = height;
    }

    public Rectangle(double width, double height)
    {
        _width = width;
        _height = height;
    }

    public double CalculateArea() => _width * _height;
}
