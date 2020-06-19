using FeatueFlags;
using Microsoft.AspNetCore.Mvc;
using Microsoft.FeatureManagement;
using Microsoft.FeatureManagement.Mvc;

namespace FeatueFlags.Controllers {
    public class BetaController : Controller {
        private readonly IFeatureManager _featureManager;

        public BetaController (IFeatureManagerSnapshot featureManager) {
            _featureManager = featureManager;
        }

        [FeatureGate (DemoFeatureFlag.Beta)]
        public IActionResult Index () => View ();
    }
}