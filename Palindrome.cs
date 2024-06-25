class Palindrome{
  public void isPalindrome(){
    System.Console.WriteLine("Enter a number: ");
    string numStr=System.Console.ReadLine();
    int num=int.Parse(numStr);
    int oldNum=num;
    int reminder, Reverse=0;
    while(num!=0){
      reminder=num%10;
      Reverse=(Reverse*10)+reminder;
      num=num/10;
    }
    if(oldNum==Reverse){
      System.Console.WriteLine($"{oldNum} is a palindrome");
    }else{
      System.Console.WriteLine($"{num} is not a palindrome");
    }
  }
}