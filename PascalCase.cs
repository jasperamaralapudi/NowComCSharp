class PascalCase{
  public void pascalCase(){
    System.Console.WriteLine("Enter a string: ");
    string input=System.Console.ReadLine();
    string lower="";
    foreach(char ch in input){
      if(ch>=65&&ch<=90){
        lower+=(char)(ch+32);
      }else{
        lower+=ch;
      }
    }
    string pascal="";
    bool firstChar=true, flag=false;
    foreach(char ch in lower){
      if(firstChar==true){
        if(ch>=97&&ch<=122)
          pascal+=(char)(ch-32);
          firstChar=false;
          continue;
      }
      if(flag==true){
        if(ch>=97&&ch<=122)
          pascal+=(char)(ch-32);
          flag=false;
      }else
        pascal+=ch;
      if(ch==32)
        flag=true;
    }
    System.Console.WriteLine(pascal);
  }
}