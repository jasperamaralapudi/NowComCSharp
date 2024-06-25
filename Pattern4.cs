class Pattern4{
  public void pattern4(){
    System.Console.WriteLine("Enter number of rows: ");
    int rows=int.Parse(Console.ReadLine());
    Console.Clear();
    int x=0, y=0;
    for(int i=1;i<=rows;i++){
      if(i%2==0){
        x=1;
        y=0;
      }else{
        x=0;
        y=1;
      }
      for(int j=1;j<=i;j++){
        if(j%2==0)
          Console.Write(x);
        else
          Console.Write(y);
      }
      Console.WriteLine();
    }
  }
}