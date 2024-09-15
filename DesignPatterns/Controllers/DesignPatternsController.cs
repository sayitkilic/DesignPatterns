using DesignPatterns.CompositeDesignPattern;
using Microsoft.AspNetCore.Mvc;

namespace DesignPatterns.Controllers
{
    [ApiController]
    [Route("design-patterns")]
    public class DesignPatternsController : ControllerBase
    {
        private readonly CompositeDesignPatternHandler _handler;

        public DesignPatternsController()
        {
            _handler = new CompositeDesignPatternHandler();
        }

        [HttpGet(Name = "composite/product-hierarchy")]
        public string Get()
        {
            return _handler.GetProductCategoryHieararchy();
        }
    }
}