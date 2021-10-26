using AntDesign.Internal;
using Estimate.Dev.Studio.Models;
using Microsoft.AspNetCore.Components;

namespace Estimate.Dev.Studio.Components
{
    public partial class EstimateComponent : ComponentBase
    {
        IForm? _form;
        EstimateForm formData = new();

        protected override void OnInitialized()
        {
            base.OnInitialized();
        }
    }
}
