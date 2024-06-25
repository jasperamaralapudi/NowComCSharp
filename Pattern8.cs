class Pattern8{
  public void pattern8(){
    Console.Write("Enter number of rows: ");
    int num=int.Parse(Console.ReadLine());
    Console.Clear();
    int result=1;
    for(int i=0;i<=num;i++){
      result=1;
      for(int j=i;j<=num-1;j++)
        Console.Write(" ");
      for(int k=0;k<=i;k++){
        Console.Write(result+" ");
        result=(result*(i-k)/(k+1));
      }
      Console.WriteLine();
    }
  }
}