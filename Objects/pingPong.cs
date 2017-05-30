using Nancy;
using System.Collections.Generic;
using System.Diagnostics;

namespace PingPong.Objects
{
  public class PingPongGenerator
  {
    private int _userNumber;
    private List<string> _output = new List<string> {};
    public PingPongGenerator(int userNumber)
    {
      _userNumber = userNumber;
      MakeList(_userNumber);
    }
    public string IsPingPong(int number)
    {
      if(number % 15 == 0)
      {
        return ("PingPong");
      }
      else if(number % 5 == 0)
      {
        return ("Pong");
      }
      else if(number % 3 == 0)
      {
        return ("Ping");
      }
      else
      {
        return (number.ToString());
      }
    }
    public void MakeList(int userNum){
      for(int i = 1; i <= userNum; i++){
        _output.Add(IsPingPong(i));
      }
    }
    public List<string> GetOutput(){
      return _output;
    }
  }
}
