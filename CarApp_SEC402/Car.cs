namespace CarApp_SEC402;

internal class Car
{
    private int year;
    private string manufacturer;
    private string model;
    private bool isDrivable;
    private double price;

    public int Year
    {
        get { return year; }
        set { year = value; }
    }
    public int Manufacturer
    {
        get { return year; }
        set { year = value; }
    }
    public int Model
    {
        get { return year; }
        set { year = value; }
    }
    public int Price
    {
        get { return year; }
        set { year = value; }
    }
    
    
    public Car(
        int year,
        string manufacturer,
        string model,
        double price,
        bool isDrivable = true)
    {
        this.year = year;
        this.manufacturer = manufacturer;
        this.model = model;
        this.price = price;
        this.isDrivable = isDrivable;
    }
    // constructors dont have return type - that is what seperates them from methods

    public override string ToString()
    {
       return $"Year: {year} - Manufacturer: {manufacturer} - Model: {model} - Price: {price:C} - isDrivable: {isDrivable}";
    }
}