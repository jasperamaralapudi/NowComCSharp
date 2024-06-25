public class MyClassPrivate
{
    private void PrivateMethod()
    {
        Console.WriteLine("Private method called.");
    }

    public void AccessPrivateMethod()
    {
        PrivateMethod();  // Accessing private method within the class
    }
}
