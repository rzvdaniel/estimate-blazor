using Xunit;

namespace Estimate.Dev.Test
{
    public class EstimateTest
    {
        [Fact]
        public void CalculateProbabilityDistribution()
        {
            var optimistic = 1m;
            var nominal = 3m;
            var pessimistic = 12m;
            var estimate = new Estimate(optimistic, nominal, pessimistic);

            var expectedProbability = 4.16m;
            var actualProbability = estimate.CalculateProbabilityDistribution();

            Assert.Equal(expectedProbability, actualProbability);
        }
    }
}