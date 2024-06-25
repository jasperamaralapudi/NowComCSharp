class Pattern10{
  public void pattern10(){
    Console.Write("Enter number of rows: ");
    int num=int.Parse(Console.ReadLine());
    Console.Clear();
    for(int i=0; i<num; i++){
      for(int j=0; j<i; j++)
        Console.Write("*");
      Console.Write(" ");
      for(int j=0;j<=i;j++)
        Console.Write("*");
      Console.WriteLine();
    }
  }
}