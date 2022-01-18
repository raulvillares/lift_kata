using System;
using System.Collections.Generic;
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
            var ticker = new TickerMock();
            Lift lift = new Lift(currentFloor, ticker);

            var result = lift.Floor();

            Assert.Equal(result, currentFloor);
        }

        [Fact]
        public void RespondToCalls()
        {
            int sourceFloor = 2;
            int currentFloor = 0;
            var ticker = new TickerMock();
            var lift = new Lift(currentFloor, ticker);

            lift.Call(new CallRequest(sourceFloor));

            var result = lift.Floor();
            Assert.Equal(result, sourceFloor);
        }
        
        [Fact]
        public void MoveToRequestedFloor()
        {
            int requestedFloor = 2;
            int currentFloor = 0;
            var ticker = new TickerMock();
            var lift = new Lift(currentFloor, ticker);

            lift.Move(new MoveRequest(requestedFloor));

            var result = lift.Floor();
            Assert.Equal(result, requestedFloor);
        }
        
        [Fact]
        public void AttendASecondCallRequest()
        {
            int requestedFloor = 2;
            int anotherRequestedFloor = 1;
            int currentFloor = 0;
            var ticker = new TickerMock();
            var lift = new Lift(currentFloor, ticker);

            lift.Call(new CallRequest(requestedFloor));
            ticker.Tick();
            lift.Call(new CallRequest(anotherRequestedFloor));
            
            var result = lift.Log();
            Assert.Equal(result[1], anotherRequestedFloor);
            Assert.Equal(result[2], requestedFloor);
        }
    }

    public class TickerMock:ITicker
    {
        public void Tick()
        {
            throw new NotImplementedException();
        }
    }

    public class MoveRequest
    {
        public readonly int RequestedFloor;

        public MoveRequest(int requestedFloor)
        {
            RequestedFloor = requestedFloor;
        }
    }

    public class CallRequest
    {
        public readonly int SourceFloor;

        public CallRequest(int sourceFloor)
        {
            SourceFloor = sourceFloor;
        }
    }

    public class Lift
    {
        private int _currentFloor;

        public Lift(int currentFloor, ITicker ticker)
        {
            _currentFloor = currentFloor;
        }

        public int Floor()
        {
            return _currentFloor;
        }

        public void Call(CallRequest callRequest)
        {
            _currentFloor = callRequest.SourceFloor;
        }

        public void Move(MoveRequest moveRequest)
        {
            _currentFloor = moveRequest.RequestedFloor;
        }

        public List<int> Log()
        {
            throw new NotImplementedException();
        }
    }

    public interface ITicker
    {
        void Tick();
    }
}