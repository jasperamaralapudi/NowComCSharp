class reverseString{
  public void reverse1(){
    System.Console.WriteLine("Enter a string to reverse: ");
    string input=Console.ReadLine();
    string reverse="";
    foreach(char ch in  input){
      reverse=ch+reverse;
    }
    System.Console.WriteLine($"Reverse of given string is {input} is: {reverse}");
  }
}