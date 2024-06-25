class Pattern5{
  public void pattern5(){
    Console.Write("Enter number of rows: ");
    int num=int.Parse(Console.ReadLine());
    Console.Clear();
    for(int i=1;i<num;i++){
      for(int j=1;j<=i;j++)
        Console.Write(j);
      Console.WriteLine();
    }
    for(int i=num;i>=0;i--){
      for(int j=1;j<=i;j++)
        Console.Write(j);
      Console.WriteLine();
    }
  }
}