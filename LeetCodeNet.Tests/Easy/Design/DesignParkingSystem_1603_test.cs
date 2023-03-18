using LeetCodeNet.Easy.Design;

namespace LeetCodeNet.Tests.Easy.Design
{
    public sealed class DesignParkingSystem_1603
    {
        [Fact]
        public void Check()
        {
            var solver = new ParkingSystem(1, 1, 0);

            Assert.True(solver.AddCar(1));
            Assert.True(solver.AddCar(2));
            Assert.False(solver.AddCar(3));
            Assert.False(solver.AddCar(1));
        }
    }
}