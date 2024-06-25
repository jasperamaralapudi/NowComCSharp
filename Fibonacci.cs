class Fibonacci
{
  public void Fib(){
    System.Console.WriteLine("Enter number of fibonacci numbers you want");
    int n=int.Parse(System.Console.ReadLine());
    int n1=0, n2=1, n3;
    System.Console.WriteLine(n1+" "+n2+" ");
    for (int i=2; i<n;i++){
      n3=n1+n2;
      System.Console.WriteLine(n3+" ");
      n1=n2;
      n2=n3;
    }
    //System.Console.ReadLine();
  }
}