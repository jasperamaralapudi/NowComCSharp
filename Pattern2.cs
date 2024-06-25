class Pattern2{
  public void pattern2(){
    Console.WriteLine("Enter a number: ");
    int number=int.Parse(Console.ReadLine());
    Console.Clear();
    for(int i=number;i>=1;i--){
      for(int j=number;j>=i;j--)
        Console.Write(j);
      Console.WriteLine();
    }
  }
}