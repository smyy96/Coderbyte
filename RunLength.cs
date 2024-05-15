using System;

class MainClass {
  public static string RunLength(string str) 
  {
    char firstLetter=str[0];
    int count=0;
    string runLen="";

    for(int i=0;i<str.Length;i++)
    {
      if(firstLetter==str[i])
      {
          count++;
      }
      else
      {  
        runLen=runLen+count.ToString()+firstLetter;
        firstLetter=str[i];
        count=1;
      }
    }
    runLen=runLen+count.ToString()+firstLetter;
    return runLen;
  }

  static void Main() {  

    // keep this function call here
    Console.WriteLine(RunLength(Console.ReadLine()));    
  } 

}
