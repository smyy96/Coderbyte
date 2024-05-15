using System;

class MainClass {

  public static int SimpleAdding(int num) {

    int sum = 0;

    if(num>0 && num<=1000){
      for(int i = 1; i <= num; i++)
      {
        sum+=i;
      }
    }
    return sum;

  }

  static void Main() {  

    // keep this function call here
    Console.WriteLine(SimpleAdding(Console.ReadLine()));
    
  } 

}
