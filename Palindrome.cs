using System;

class MainClass {

  public static string Palindrome(string str) {

    string status="false";
    string pali=str.Trim().Replace(" ", string.Empty);
    
    for(int i=0; i<pali.Length/2; i++){

      if(pali[i] == pali[pali.Length-1-i])
      {
        status="true";
      }
      else{
        status="false";
      }

    }
    return status;
    
  }

  static void Main() {  
    // keep this function call here
    Console.WriteLine(Palindrome(Console.ReadLine()));
  } 

}
