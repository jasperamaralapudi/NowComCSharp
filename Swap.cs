class SwapNumbers
{
  public void Swap(int num1, int num2){
    System.Console.WriteLine($"Numbers before swap: {num1} and {num2}");
    num1=num1^num2;
    num2=num1^num2;
    num1=num1^num2;
    System.Console.WriteLine($"Numbers after swap: {num1} and {num2}");
  }
}