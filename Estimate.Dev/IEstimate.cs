namespace Estimate.Dev
{
    public interface IEstimate
    {
        public decimal CalculateProbabilityDistribution();
        public decimal CalculateStandardDeviation();
    }
}