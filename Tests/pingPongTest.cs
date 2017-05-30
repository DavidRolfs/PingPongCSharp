using Xunit;

namespace PingPong
{
  public class PingPongGeneratorTest
  {
    [Fact]
    public void IsPingPong_ForNumbersNotModuleThreeAndFiveAndFifteen_Input()
    {
      PingPongGenerator testPingPong = new PingPongGenerator();
      Assert.Equal("7", testPingPong.IsPingPong(7));
    }
    [Fact]
    public void IsPingPong_ForNumbersDivisibleByFifteen_PingPong()
    {
      PingPongGenerator testPingPong = new PingPongGenerator();
      Assert.Equal("PingPong", testPingPong.IsPingPong(30));
    }
    [Fact]
    public void IsPingPong_ForNumbersDivisibleByFive_Pong()
    {
      PingPongGenerator testPingPong = new PingPongGenerator();
      Assert.Equal("Pong", testPingPong.IsPingPong(5));
    }
    [Fact]
    public void IsPingPong_ForNumbersDivisibleByThree_Ping()
    {
      PingPongGenerator testPingPong = new PingPongGenerator();
      Assert.Equal("Ping", testPingPong.IsPingPong(3));
    }
  }
}
