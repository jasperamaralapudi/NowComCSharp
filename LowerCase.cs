class LowerCase
{
  public void lowerCase(){
    System.Console.WriteLine("Enter a string: ");
    string input = System.Console.ReadLine();
    string output="";
    foreach(char ch in input){
      if(ch>=65&&ch<=90){
        output+=(char)(ch+32);
      }else{
        output+=ch;
      }
    }
      System.Console.WriteLine(output);
  }
}