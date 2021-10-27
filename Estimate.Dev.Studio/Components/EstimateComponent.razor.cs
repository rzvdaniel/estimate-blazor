using AntDesign.Internal;
using Estimate.Studio.Models;
using Microsoft.AspNetCore.Components;

namespace Estimate.Studio.Components
{
    public partial class EstimateComponent : ComponentBase
    {
        IForm? _form;
        EstimateForm formData = new();

        protected override void OnInitialized()
        {
            base.OnInitialized();
        }

        private void CalculateClick()
        {
            var estimate = new Dev.Estimate(formData.Optimistic, formData.Nominal, formData.Pessimistic);
            formData.ProbabilityDistribution = estimate.CalculateProbabilityDistribution();
            formData.StandardDeviation = estimate.CalculateStandardDeviation();
        }
    }
}
