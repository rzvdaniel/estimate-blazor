using Xunit;

namespace Estimate.Dev.Test
{
    public class EstimateTest
    {
        private readonly decimal optimistic;
        private readonly decimal nominal;
        private readonly decimal pessimistic;
        private readonly IEstimate estimate;

        public EstimateTest()
        {
            optimistic = 1m;
            nominal = 3m;
            pessimistic = 12m;
            estimate = new Estimate(optimistic, nominal, pessimistic);
        }

        [Fact]
        public void CalculateProbabilityDistribution()
        {
            var expectedProbability = 4.2m;
            var actualProbability = estimate.CalculateProbabilityDistribution();

            Assert.Equal(expectedProbability, actualProbability);
        }

        [Fact]
        public void CalculateStandardDeviation()
        {
            var expectedDeviation = 1.8m;
            var actualDeviation = estimate.CalculateStandardDeviation();

            Assert.Equal(expectedDeviation, actualDeviation);
        }
    }
}