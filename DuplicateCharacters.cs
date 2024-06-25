class DuplicateChars{
  public void duplicateChars(){
    System.Console.WriteLine("Enter a string: ");
    string input=System.Console.ReadLine();
    int length=0;
    foreach(char ch in input)
      length+=1;
    char[] arr=new char[length];
    int index=0;
    foreach(char ch in input){
      arr[index]=ch;
      index+=1;
    }
    int count1=0, count2=0;
    foreach(char ch1 in arr){
      count1+=1;
      foreach(char ch2 in arr){
        count2+=1;
        if(count1!=count2){
          if(ch1==ch2&&ch1!=32){
            System.Console.WriteLine(ch1);
            arr[count1-1]=' ';
            arr[count2-1]=' ';
            break;
          }
        }
      }
      count2=0;
    }
  }
}