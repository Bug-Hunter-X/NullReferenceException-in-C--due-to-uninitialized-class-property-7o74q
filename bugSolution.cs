public class ExampleClass
{
    public int MyProperty { get; set; } = 0; // Initialize with default value

    public void MyMethod()
    {
        int value = MyProperty * 2;
    }

    //Alternative Solution
    public void MyMethodAlternative()
    {
        if (MyProperty != null)
        {
            int value = MyProperty * 2;
        }
        else
        {
            // Handle the case where MyProperty is null
            Console.WriteLine("MyProperty is null");
        }
    }
}