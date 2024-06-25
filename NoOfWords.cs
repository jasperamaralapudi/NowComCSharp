class NoOfWords{
  public void count1(){
    System.Console.WriteLine("Enter a string: ");
    string input=System.Console.ReadLine();
    int count=0, charCount=0;
    bool flag=true, endSpaces=false;
    bool startSpaces=false;
    foreach(char ch in input){
      charCount+=1;
      if(charCount==1&&ch==32){
        startSpaces=true;
      }
      if(ch==32&&flag==false){
        continue;
      }else{
        flag=true;
        endSpaces=false;
      }
      if(count==0){
        count=1;
      }
      if(ch==32){
        count+=1;
        flag=false;
        endSpaces=true;
      }
    }
      if(startSpaces==true){
        count-=1;
      }
      if(endSpaces==true){
        count-=1;
      }
      System.Console.WriteLine("No of words in the given string are: "+count);
  }
}