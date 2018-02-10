using System;

class Plus {
  string name = "files";
  
  public static void Plus(string[] args) {
    bool good = CheckLength();
    
    if(good) {
      Console.WriteLine("Your name's length is " + name.Length + ".");
    }
    else {
      Console.WriteLine("Too short!");
    }
  }
  
  bool CheckLength() {
    if(name.Length >= 5) {
      return true;
    }
    else {
      return false;
    }
  }
}
