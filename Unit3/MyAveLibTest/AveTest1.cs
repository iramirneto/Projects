namespace MyAveLibTest;
using Xunit;
using MyAveLib;

public class AveTest1
{
    [Fact]
    public void Test1()
    {
        double a = 3; // arrange
		double b = 2;
        double c = 10;

        double expected = 5;
	
		double actual = Average.Ave(a,b,c); // act
 
		Assert.Equal(expected, actual); //  assert 

    }  
    
} 