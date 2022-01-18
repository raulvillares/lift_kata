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

        [Fact]
        public void RespondToCalls()
        {
            int sourceFloor = 2;
            int currentFloor = 0;
            var lift = new Lift(currentFloor);

            lift.Call(sourceFloor);

            var result = lift.Floor();
            Assert.Equal(result, sourceFloor);
        }
    }

    public class Lift
    {
        private int _currentFloor;

        public Lift(int currentFloor)
        {
            _currentFloor = currentFloor;
        }

        public int Floor()
        {
            return _currentFloor;
        }

        public void Call(int sourceFloor)
        {
            _currentFloor = sourceFloor;
        }
    }
}