class LengthString{
  public void lengthOfString(){
    System.Console.WriteLine("Enter a string: ");
    string input=System.Console.ReadLine();
    int length=0;
    foreach(char c in input){
      length+=1;
    }
    System.Console.WriteLine($"The length of the string is: {length}.");
  }
}