using DesignPatterns.CompositeDesignPattern;
using DesignPatterns.DecoratorDesignPattern;
using Microsoft.AspNetCore.Mvc;

namespace DesignPatterns.Controllers
{
    /// <summary>
    /// DesignPatternController
    /// </summary>
    [ApiController]
    [Route("design-patterns")]
    public class DesignPatternsController : ControllerBase
    {
        private readonly CompositeDesignPatternHandler _compositeDesignPatternHandler;
        private readonly IDecoratorDesignPatternService _decoratorDesignPatternService;
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="decoratorDesignPatternService"></param>
        public DesignPatternsController(IDecoratorDesignPatternService decoratorDesignPatternService)
        {
            _compositeDesignPatternHandler = new CompositeDesignPatternHandler();
            _decoratorDesignPatternService = decoratorDesignPatternService;
        }

        /// <summary>
        /// Hiyerarþik bir data yapýsý oluþturmayý saðlar.
        /// </summary>
        /// <returns></returns>
        [HttpGet("composite/product-hierarchy")]
        public string GetCompositeDesignPatternProductHierarchy()
        {
            return _compositeDesignPatternHandler.GetProductCategoryHieararchy();
        }
        /// <summary>
        /// Var olan objenin/yapýnýn yapýsýný bozmadan geniþletilmesini saðlar
        /// </summary>
        /// <returns></returns>
        [HttpGet("decorator/products")]
        public List<DecoratorDesignPatternProductDto> Get()
        {
            return _decoratorDesignPatternService.GetProducts();
        }
    }
}