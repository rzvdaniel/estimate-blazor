namespace Estimate.Studio.Models
{
    public class EstimateForm
    {
        public decimal Optimistic { get; set; }
        public decimal Nominal { get; set; }
        public decimal Pessimistic { get; set; }
        public decimal ProbabilityDistribution { get; set; }
        public decimal StandardDeviation { get; set; }
    }
}
