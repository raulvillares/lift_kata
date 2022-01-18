using System;
using Xunit;

namespace Lift_Kata
{
    public class Tests
    {
        [Fact]
        public void Test1()
        {
            
            Lift lift = new Lift();
            
            var result = lift.Floor();
            
            Assert.Equal(result, 2);
        }
    }

    public class Lift
    {
        public int Floor()
        {
            throw new NotImplementedException();
        }
    }
}