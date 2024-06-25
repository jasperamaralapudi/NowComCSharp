using System;
class Prime{
  public void isPrime(){
    System.Console.WriteLine("Enter a number: ");
    string numStr=System.Console.ReadLine();
    int num=int.Parse(numStr);
    bool iPrime =true;
    int HalfNumber=num/2;
    for(int i=2;i<=HalfNumber;i++){
      if(num%i==0){
        iPrime = false;
        break;
      }
    }
    if(iPrime==true){
      System.Console.WriteLine("Given number is prime");
    }else{
      System.Console.WriteLine("Given number is not prime");
    }
  }
}