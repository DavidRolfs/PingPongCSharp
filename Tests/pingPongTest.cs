using Xunit;
using System.Collections.Generic;

namespace PingPong
{
  public class PingPongGeneratorTest
  {
    [Fact]
    public void IsPingPong_ForNumbersNotModuleThreeAndFiveAndFifteen_Input()
    {
      //Arrange
      PingPongGenerator testPingPong = new PingPongGenerator();
      //Act
      string expected = testPingPong.IsPingPong(7);
      //Assert
      Assert.Equal("7", expected);
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
    // [Fact]

    // public void GetOutput_GetAllListItems_ReturnOutput()
    // {
    //   //Arrange
    //   string output1 = "2";
    //   string output2 = "Ping";
    //
    //   List<string> newList = new List<string> {output1, output2};
    //
    //   //Act
    //   List<string> result = newList.GetOutput();
    //
    //   //Assert
    //   Assert.Equal(newList, result);
    // }
  }
}
