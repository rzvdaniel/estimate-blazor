using AntDesign.Internal;
using Estimate.Studio.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;

namespace Estimate.Studio.Components
{
    public partial class EstimateComponent : ComponentBase
    {
        private readonly EstimateModel estimateModel = new();
        private IForm estimateForm;

        protected override void OnInitialized()
        {
            base.OnInitialized();
        }

        private void OnFinish(EditContext editContext)
        {
            Calculate();
        }

        private void Calculate()
        {
            var estimate = new Dev.Estimate(estimateModel.Optimistic, estimateModel.Nominal, estimateModel.Pessimistic);
            estimateModel.ProbabilityDistribution = estimate.CalculateProbabilityDistribution();
            estimateModel.StandardDeviation = estimate.CalculateStandardDeviation();
        }

        private void ResetForm()
        {
            estimateModel.Clear();
            estimateForm.Reset();
        }
    }
}
