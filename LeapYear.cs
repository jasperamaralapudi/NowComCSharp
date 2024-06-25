class LeapYear{
  public void isLeap(){
    System.Console.WriteLine("Enter the year in 4 digits :");
    int year=int.Parse(System.Console.ReadLine());
    if((year%4==0&&year%100!=0)||(year%400==0))
      System.Console.WriteLine($"{year} is a leap year.");
    else 
      System.Console.WriteLine($"{year} is not a leap year");
  }
}