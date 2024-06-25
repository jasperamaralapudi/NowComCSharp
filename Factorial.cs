class Factorial{
  public void Fact(){
    System.Console.WriteLine("Enter a number to find factorial: ");
    uint num=uint.Parse(System.Console.ReadLine());
    uint res=1;
    for(uint i=1;i<=num;i++){
      res=res*i;
    }
    System.Console.WriteLine("Factorial of a given number is "+res);
    //System.Console.ReadLine();
  }
}