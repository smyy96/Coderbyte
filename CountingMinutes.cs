using System;

class MainClass {

  public static string CountingMinutes(string str) {

    int num=0;
    string[] pmam=new string[2];
    char[] ayrac = { ':', '-'};
    string[] parcalar = str.Split(ayrac);
    pmam[0]=(parcalar[1][parcalar[1].Length-2]).ToString();
    pmam[1]=(parcalar[3][parcalar[3].Length-2]).ToString();
    parcalar[1]=(parcalar[1].Substring(0, parcalar[1].Length - 2)).ToString();
    parcalar[3]=(parcalar[3].Substring(0, parcalar[3].Length - 2)).ToString();
    
    if(pmam[0]=="p" && pmam[1]=="a" || pmam[0]=="a" && pmam[1]=="p" ){
      int a=Math.Abs(int.Parse(parcalar[0])-int.Parse(parcalar[2]));
      if(a>0){
        num=((12-a)*60)-(int.Parse(parcalar[1])-int.Parse(parcalar[3]));
      }
      else{
        num=(12*60)-int.Parse(parcalar[1])-int.Parse(parcalar[3]);
      }
    }

    else if(pmam[0]==pmam[1]){

      if(int.Parse(parcalar[1])>int.Parse(parcalar[3])){
        num=24*60-(int.Parse(parcalar[1])-int.Parse(parcalar[3]));
      }
      else{
        num=24*60+(int.Parse(parcalar[3])-int.Parse(parcalar[1]));
      }
    }

    else{
      num=0;
    }
    return num.ToString();

  }

  static void Main() {  
    // keep this function call here
    Console.WriteLine(CountingMinutes(Console.ReadLine()));
  } 

}
