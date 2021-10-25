namespace Estimate.Dev
{
    public class Estimate : IEstimate
    {
        private readonly decimal optimistic;
        private readonly decimal nominal;
        private readonly decimal pessimistic;

        public Estimate(decimal optimistic, decimal nominal, decimal pessimistic)
        {
            this.optimistic = optimistic;
            this.nominal = nominal;
            this.pessimistic = pessimistic;
        }

        public decimal CalculateProbabilityDistribution()
        {
            var result = (optimistic + 4 * nominal + pessimistic) / 6;
            return decimal.Round(result, 1, MidpointRounding.ToEven);
        }

        public decimal CalculateStandardDeviation()
        {
            var result = (pessimistic - optimistic) / 6;
            return decimal.Round(result, 1, MidpointRounding.ToEven);
        }
    }
}