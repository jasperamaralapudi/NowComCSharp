class LargeNumInArr
{
  public void largeNum(){
    System.Console.WriteLine("Specify the number of items to compare");
    int ub=int.Parse(System.Console.ReadLine());
    System.Console.Clear();
    int[] arr=new int[ub];
    for(int i=0;i<ub;i++){
      System.Console.WriteLine($"Enter Item{i+1}: ");
      arr[i]=int.Parse(Console.ReadLine());
    }
  int largeNumb=arr[0];
  for(int i=1;i<ub;i++){
    if(arr[i]>largeNumb){
      largeNumb=arr[i];
    }
  }
  System.Console.WriteLine("Larger number in the array is: "+largeNumb);
 // Console.ReadLine();
  }
}