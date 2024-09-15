using DesignPatterns.AdapterDesignPattern;
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
        private readonly IAdapterDesignExistService _adapterDesignExistService;
        /// <summary>
        /// Design Pattern Controller Constructor
        /// </summary>
        /// <param name="decoratorDesignPatternService"></param>
        /// <param name="adapterDesignExistService"></param>
        public DesignPatternsController(IDecoratorDesignPatternService decoratorDesignPatternService, IAdapterDesignExistService adapterDesignExistService)
        {
            _compositeDesignPatternHandler = new CompositeDesignPatternHandler();
            _decoratorDesignPatternService = decoratorDesignPatternService;
            _adapterDesignExistService = adapterDesignExistService;
        }

        /// <summary>
        /// Hiyerar�ik bir data yap�s� olu�turmay� sa�lar.
        /// </summary>
        /// <returns></returns>
        [HttpGet("composite/product-hierarchy")]
        public string GetCompositeDesignPatternProductHierarchy()
        {
            return _compositeDesignPatternHandler.GetProductCategoryHieararchy();
        }
        /// <summary>
        /// Var olan objenin/yap�n�n yap�s�n� bozmadan geni�letilmesini sa�lar
        /// </summary>
        /// <returns></returns>
        [HttpGet("decorator/products")]
        public List<DecoratorDesignPatternProductDto> DecoratorGetProducts()
        {
            return _decoratorDesignPatternService.GetProducts();
        }


        /// <summary>
        /// Farkl� interfaceleri uyumlu hale getirir.
        /// </summary>
        /// <returns></returns>
        [HttpPost("adapter/multiply")]
        public int AdapterDesignMultiply(AdapterDesignMultiplyRequest request)
        {
            return _adapterDesignExistService.MultiplyBySum(request.Number, request.Multiplier);
        }
    }
}