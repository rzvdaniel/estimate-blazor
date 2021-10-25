namespace Estimate.Dev
{
    public class Estimate : IEstimate
    {
        private decimal optimistic;
        private decimal nominal;
        private decimal pessimistic;

        public Estimate(decimal optimistic, decimal nominal, decimal pessimistic)
        {
            this.optimistic = optimistic;
            this.nominal = nominal;
            this.pessimistic = pessimistic;
        }

        public decimal CalculateProbabilityDistribution()
        {
            var result = (optimistic + 4 * nominal + pessimistic) / 6;
            return decimal.Round(result, 2, MidpointRounding.ToZero);
        }
    }
}