class SumOfDigits{
  public void Sum(){
    System.Console.WriteLine("Enter a number to find sum of its digits");
    int num=int.Parse(System.Console.ReadLine());
    int reminder, sum=0;
    while(num>0){
      reminder=num%10;
      sum=sum+reminder;
      num=num/10;
    }
    System.Console.WriteLine("Sum of digits of given number is " + sum);
  }
}