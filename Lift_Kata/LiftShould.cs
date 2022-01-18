using System;
using Xunit;

namespace Lift_Kata
{
    public class LiftShould
    {
        [Fact]
        public void ReturnItsCurrentFloor()
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
            return 2;
        }
    }
}