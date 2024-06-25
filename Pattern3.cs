class Pattern3{
  public void pattern3(){
    Console.WriteLine("Enter number of rows: ");
    int rows=int.Parse(Console.ReadLine());
    Console.Clear();
    int x=1;
    for(int i=1;i<=rows;i++){
      for(int j=1;j<=i;j++)
        Console.Write($"{x++} ");
      Console.WriteLine();
    }
  }
}