using System;
using Xunit;

namespace Lift_Kata
{
    public class LiftShould
    {
        [Theory]
        [InlineData(2)]
        [InlineData(3)]
        public void ReturnItsCurrentFloor(int currentFloor)
        {
            Lift lift = new Lift();
            
            var result = lift.Floor();
            
            Assert.Equal(result, currentFloor);
        }
    }

    public class Lift
    {
        public int Floor()
        {
            return 2;
        }
    }
}