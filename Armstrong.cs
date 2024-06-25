class Armstrong{
  public void isArmstrong(){
    System.Console.WriteLine("Enter a number to find it is armstrong: ");
    int num=int.Parse(System.Console.ReadLine());
    int original = num;
    int reminder, sum=0;
    while(num>0){
      reminder=num%10;
      sum=sum+(reminder*reminder*reminder);
      num=num/10;

    }
    if(original==sum){
      System.Console.WriteLine($"{original} is an armstrong");
    }else{
      System.Console.WriteLine($"{original} is not an armstrong");
    }
  }
}