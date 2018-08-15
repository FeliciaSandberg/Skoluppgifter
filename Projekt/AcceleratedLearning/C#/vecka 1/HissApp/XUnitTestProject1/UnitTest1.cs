using System;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

            [TestClass]
        public class UnitTest1
        {
            const int bottomfloor = -2;
            const int topfloor = 3;
            private const int untilmaintainance = 6;

            readonly Elevator elevator = new Elevator("Kalle", bottomfloor, topfloor, startFloor: 1, untilMaintainance: 6);

            // Testar "Should [be in some state] [after/before/when] [action takes place]"

            [TestMethod]
            public void elevator_should_be_at_floor_one_when_thats_its_startfloor()
            {
                Assert.AreEqual(1, elevator.CurrentFloor);
            }

            [TestMethod]
            public void floor_count_should_be_six_when_bottomfloor_is_negative2_and_topfloor_is_3()
            {
                Assert.AreEqual(6, elevator.CountFloors);
            }

            [TestMethod]
            public void elevator_should_be_at_level_2_when_it_starts_at_1_and_go_up_one_floor()
            {
                elevator.GoUp();
                Assert.AreEqual(2, elevator.CurrentFloor);
            }

            [TestMethod]
            public void elevator_should_be_at_level_0_when_it_starts_at_1_and_go_down_one_floor()
            {
                elevator.GoDown();
                Assert.AreEqual(0, elevator.CurrentFloor);
            }

            [TestMethod]
            public void elevaror_should_be_at_level_3_when_it_starts_at_1_and_go_up_is_called_twice()
            {
                elevator.GoUp();
                elevator.GoUp();
                Assert.AreEqual(3, elevator.CurrentFloor);
            }

            [TestMethod]
            public void elevator_should_be_at_top_floor_when_go_up_is_called_really_many_times()
            {
                for (int i = 0; i < 1000; i++)
                    elevator.GoUp();

                Assert.AreEqual(topfloor, elevator.CurrentFloor);
            }

            [TestMethod]
            public void elevator_should_be_at_bottom_floor_when_go_down_is_called_really_many_times()
            {
                for (int i = 0; i < 100; i++)
                    elevator.GoDown();

                Assert.AreEqual(bottomfloor, elevator.CurrentFloor);
            }

            [TestMethod]
            public void elever_should_still_have_power_after_going_up_and_down_five_times_if_maintainlevel_is_six()
            {
                elevator.GoDown();
                elevator.GoUp();

                elevator.GoDown();
                elevator.GoUp();

                elevator.GoDown();

                Assert.IsTrue(elevator.PowerIsOn);
            }

            [TestMethod]
            public void elever_should_power_down_after_going_up_and_down_six_times_if_maintainlevel_is_six()
            {
                elevator.GoDown();
                elevator.GoUp();

                elevator.GoDown();
                elevator.GoUp();

                elevator.GoDown();
                elevator.GoUp();

                Assert.IsFalse(elevator.PowerIsOn);
            }

            [TestMethod]
            public void argumentexception_should_be_raised_when_highest_floor_is_below_lowest_floor()
            {
                var ex = Assert.ThrowsException<ArgumentException>(
                    () => new Elevator("Laban", 100, 10));

                Assert.AreEqual(Elevator.ErrorHighestFloorIsTooLow, ex.Message);
            }

            [TestMethod]
            public void argumentexception_should_be_raised_when_start_floor_is_higher_than_top_floor()
            {
                var ex = Assert.ThrowsException<ArgumentException>(
                    () => new Elevator("Laban", 10, 15, 15 + 1, 1000));

                Assert.AreEqual(Elevator.ErrorStartFloorOutsideOfBounds, ex.Message);
            }


            [TestMethod]
            public void argumentexception_should_be_raised_when_start_floor_is_lower_than_bottom_floor()
            {
                var ex = Assert.ThrowsException<ArgumentException>(
                    () => new Elevator("Laban", 10, 15, 10 - 1, 100));

                Assert.AreEqual(Elevator.ErrorStartFloorOutsideOfBounds, ex.Message);
            }
        }

    }
    
}
