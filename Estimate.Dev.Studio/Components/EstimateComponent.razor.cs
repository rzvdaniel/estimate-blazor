using AntDesign.Internal;
using Estimate.Studio.Models;
using Estimate.Studio.Validators;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;

namespace Estimate.Studio.Components
{
    public partial class EstimateComponent : ComponentBase
    {
        private CustomValidation? customValidation;
        private readonly EstimateModel estimateModel = new();
        private IForm estimateForm;

        protected override void OnInitialized()
        {
            base.OnInitialized();
        }

        private void OnFinish(EditContext editContext)
        {
            customValidation?.ClearErrors();

            Calculate();
        }

        private void Calculate()
        {
            try
            {
                var estimate = new Dev.Estimate(estimateModel.Optimistic, estimateModel.Nominal, estimateModel.Pessimistic);
                estimateModel.ProbabilityDistribution = estimate.CalculateProbabilityDistribution();
                estimateModel.StandardDeviation = estimate.CalculateStandardDeviation();
            }
            catch (Exception ex)
            {
                var errors = new Dictionary<string, List<string>>();
                errors.Add(nameof(ex.Message), new() { ex.Message });
                customValidation?.DisplayErrors(errors);
            }
        }

        private void ResetForm()
        {
            estimateModel.Clear();
            estimateForm.Reset();
        }
    }
}
