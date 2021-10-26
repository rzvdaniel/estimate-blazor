using Estimate.Dev.Resources;

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
            ValidateArguments();

            var result = (optimistic + 4 * nominal + pessimistic) / 6;
            return decimal.Round(result, 1, MidpointRounding.ToEven);
        }

        public decimal CalculateStandardDeviation()
        {
            ValidateArguments();

            var result = (pessimistic - optimistic) / 6;
            return decimal.Round(result, 1, MidpointRounding.ToEven);
        }

        public bool ValidateArguments()
        {
            if (optimistic < 0)
            {
                throw new ArgumentException(Errors.OptimisticNegative);
            }

            if (nominal < 0)
            {
                throw new ArgumentException(Errors.NominalNegative);
            }

            if (pessimistic < 0)
            {
                throw new ArgumentException(Errors.PessimisticNegative);
            }

            if (optimistic > nominal)
            {
                throw new ArgumentException(Errors.OptimisticBiggerThanNominal);
            }

            if (nominal > pessimistic)
            {
                throw new ArgumentException(Errors.NominalBiggerThanPessimistic);
            }

            return true;
        }
    }
}