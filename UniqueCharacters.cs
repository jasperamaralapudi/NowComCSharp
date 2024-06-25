class UniqueCharacters{
  public void uniqueCharacters(){
    System.Console.WriteLine("Enter a string: ");
    string input=System.Console.ReadLine();
    bool exists=false;
    int count1=0, count2=0;
    foreach(char ch1 in input){
      count1+=1;
      foreach(char ch2 in input){
        count2+=1;
        if(count1!=count2){
          if(ch1!=ch2&&ch1!=32)
            exists=false;
          else
          {
            exists=true;
            break;
          }
        }
      } 
    if(exists==false)
      System.Console.WriteLine(ch1);
  count2=0; exists=false;
    }
  }
}