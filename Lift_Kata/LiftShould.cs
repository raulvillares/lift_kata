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
            Lift lift = new Lift(currentFloor);
            
            var result = lift.Floor();
            
            Assert.Equal(result, currentFloor);
        }
    }

    public class Lift
    {
        private readonly int _currentFloor;

        public Lift(int currentFloor)
        {
            _currentFloor = currentFloor;
        }

        public int Floor()
        {
            return _currentFloor;
        }
    }
}