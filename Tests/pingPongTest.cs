using Xunit;
using System.Collections.Generic;

namespace PingPong.Objects
{
  public class PingPongGeneratorTest
  {
    [Fact]
    public void IsPingPong_ForNumbersNotModuleThreeAndFiveAndFifteen_Input()
    {
      //Arrange
      PingPongGenerator testPingPong = new PingPongGenerator(7);
      //Act
      string expected = testPingPong.IsPingPong(7);
      //Assert
      Assert.Equal("7", expected);
    }
    [Fact]
    public void IsPingPong_ForNumbersDivisibleByFifteen_PingPong()
    {
      PingPongGenerator testPingPong = new PingPongGenerator(30);
      Assert.Equal("PingPong", testPingPong.IsPingPong(30));
    }
    [Fact]
    public void IsPingPong_ForNumbersDivisibleByFive_Pong()
    {
      PingPongGenerator testPingPong = new PingPongGenerator(5);
      Assert.Equal("Pong", testPingPong.IsPingPong(5));
    }
    [Fact]
    public void IsPingPong_ForNumbersDivisibleByThree_Ping()
    {
      PingPongGenerator testPingPong = new PingPongGenerator(3);
      Assert.Equal("Ping", testPingPong.IsPingPong(3));
    }
    [Fact]

    public void GetOutput_GetAllListItems_ReturnEmptyList()
    {
      //Arrange
      List<string> newList = new List<string>{};
      PingPongGenerator ping1 = new PingPongGenerator(3);
      //Act
      List<string> output = ping1.GetOutput();

      //Assert
      Assert.Equal(newList, output);
    }
  }
}
//
// [Fact]
//
// public void GetOutput_GetAllListItems_ReturnOutput()
// {
//   //Arrange
//   PingPongGenerator ping1 = new PingPongGenerator(1);
//
//   ping1.MakeList();
//
//   List<string> newList = List<string>{ping1};
//
//
//   //Act
//
//   //Assert
//
// }
