public class ExampleClass
{
    private int? _myField; //Using nullable int

    public int? MyProperty
    {
        get { return _myField; }
        set { _myField = value; }
    }

    public void MyMethod()
    {
        // Check for null before accessing MyProperty
        Console.WriteLine(MyProperty.HasValue ? MyProperty.ToString() : "MyProperty is null");
    }
} 