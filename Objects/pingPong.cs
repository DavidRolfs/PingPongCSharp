namespace PingPong
{
  class PingPongGenerator
  {
    public string IsPingPong(int number)
    {
      if(number % 15 == 0)
      {
        return "PingPong";
      }
      else if(number % 5 == 0)
      {
        return "Pong";
      }
      else if(number % 3 == 0)
      {
        return "Ping";
      }
      else
        return number.ToString();
      }
    }
  }
