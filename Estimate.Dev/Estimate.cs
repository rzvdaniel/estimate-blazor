namespace Estimate.Dev
{
    public class Estimate
    {
        private int optimistic;
        private int nominal;
        private int pessimistic;

        public Estimate(int optimistic, int nominal, int pessimistic)
        {
            this.optimistic = optimistic;
            this.nominal = nominal;
            this.pessimistic = pessimistic;
        }

        public object CalculateProbabilityDistribution()
        {
            throw new NotImplementedException();
        }
    }
}