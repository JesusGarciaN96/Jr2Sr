Rectangle SoccerLand = new Rectangle(12.53, 19.42);
Rectangle Figure = new Rectangle();
Console.WriteLine($"El área de la cancha es: {SoccerLand.CalculateArea()} mts");
Console.WriteLine($"El área default es: {Figure.CalculateArea()}");

// nameof(variable) -> retorna el nombre de la variable en string
// Los atributos sin "set" ({get; set;}) su set funciona como readonly - solo se inicializa en su definición y constructor

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


public class Dog
{
	private string _name;
	private string _breed;
	private int _weight;

	public Dog(string name, string breed, int weight)
	{
		_name = name;
		_breed = breed;
		_weight = weight;
	}

	public Dog(string name, int weight, string breed = "mixed-breed")
	{
		_name = name;
		_weight = weight;
		_breed = breed;
	}

	public string Describe()
	{
		string weightDescription = _weight < 5 ? "tiny" : _weight > 4 && _weight < 30 ? "medium" : "large";
		return $"This dog is named {_name}, it's a {_breed}, and it weighs {_weight} kilograms, so it's a {weightDescription} dog.";
	}
}

/*
 * Si se va a condicionar el setter de las propiedades es necesario tener los atributos definidos
 * para poder modificar sus accesos, en caso de solo dejar las propiedades sin atributos estos tendran
 * el setter y getter definidos para usarse fuera de la clase.
 */
public class Order
{
	private DateTime _date;
	private string _item;

	public string Item { 
		get
		{
			return _item;
		}
		private set 
		{
			_item = value;
		}
	}
	public DateTime Date
	{
		get
		{
			return _date;
		}
		set
		{
			if (value.Year != DateTime.Now.Year)
			{
				_date = value;
			}
		}
	}

	public Order(string item, DateTime date)
	{
		Item = item;
		Date = date;
	}
}
