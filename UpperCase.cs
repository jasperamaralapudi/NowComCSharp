class UpperCase{
  public void upperCase(){
    System.Console.WriteLine("Enter a string: ");
    string input = System.Console.ReadLine();
    string output="";
    foreach(char ch in input){
      if(ch>=97&&ch<=122){
        output+=(char)(ch-32);
      }else{
        output+=ch;
      }

    }
    System.Console.WriteLine(output);
  }
}