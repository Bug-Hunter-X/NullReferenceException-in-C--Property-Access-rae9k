public class ExampleClass
{
    private int _myField;

    public int MyProperty
    {
        get { return _myField; }
        set { _myField = value; }
    }

    public void MyMethod()
    {
        // This line will throw a NullReferenceException if MyProperty is not set
        Console.WriteLine(MyProperty.ToString());
    }
}