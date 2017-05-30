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
    // [Fact]
    // public void GetOutput_GetAllListItems_ReturnOutput()
    // {
    //   //Arrange
    //   string output1 = "1";
    //   string output2 = "2";
    //   string output3 = "Ping";
    //
    //   PingPongGenerator myPing1 = new PingPongGenerator(output1);
    //   PingPongGenerator myPing2 = new PingPongGenerator(output2);
    //
    //   List<string> testList = PingPongGenerator.MakeList(3);
    //
    //   List<string> newList = new List<string> {output1, output2, output3};
    //
    //   //Act
    //   List<string> result = testList.GetOutput();
    //
    //   //Assert
    //   Assert.Equal(newList, result);
    }
  }
