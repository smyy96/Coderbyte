using System;
class MainClass {

  public static int SimpleMode(int[] arr) 
  {
    int mode=0;
    int mostNumCount=0;
    for(var i=0; i<arr.Length; i++)
    {
        int count=0;
        for(var j=0; j<arr.Length; j++)
        {
            if(arr[i] == arr[j] && j!=i)
            {
                count++;
            }
            if(count>mostNumCount)
            {
                mode = arr[i];
                mostNumCount = count;
                count = 0;
            }
        }
    }
    if(mostNumCount==0)
    {
        return -1;    
    }
    return mode;
  }
  static void Main() {  
    Console.WriteLine(SimpleMode(Console.ReadLine()));
    
  } 
}
