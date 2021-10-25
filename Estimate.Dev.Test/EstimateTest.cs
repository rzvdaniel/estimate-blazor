using Xunit;

namespace Estimate.Dev.Test
{
    public class EstimateTest
    {
        [Fact]
        public void ProbabilityDistributionFormula()
        {
            var optimistic = 1;
            var nominal = 3;
            var pessimistic = 12;

            var estimate = new Estimate(optimistic, nominal, pessimistic);

            var expectedProbability = 4.2;
            var actualProbability = estimate.CalculateProbabilityDistribution();

            Assert.Equal(expectedProbability, actualProbability);
        }
    }
}