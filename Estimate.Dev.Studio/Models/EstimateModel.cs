using System.ComponentModel.DataAnnotations;

namespace Estimate.Studio.Models
{
    public class EstimateModel
    {
        [Required]
        [Range(0.0, double.MaxValue, ErrorMessage = "{0} must be greater than {1}.")]
        public decimal Optimistic { get; set; }

        [Required]
        [Range(0.0, double.MaxValue, ErrorMessage = "{0} must be greater than {1}.")]
        public decimal Nominal { get; set; }

        [Required]
        [Range(0.0, double.MaxValue, ErrorMessage = "{0} must be greater than {1}.")]
        public decimal Pessimistic { get; set; }

        public decimal ProbabilityDistribution { get; set; }

        public decimal StandardDeviation { get; set; }

        public decimal Total => ProbabilityDistribution + StandardDeviation;

        public void Clear()
        {
            Optimistic = 0;
            Nominal = 0;
            Pessimistic = 0;
            ProbabilityDistribution = 0;
            StandardDeviation = 0;
        }
    }
}
