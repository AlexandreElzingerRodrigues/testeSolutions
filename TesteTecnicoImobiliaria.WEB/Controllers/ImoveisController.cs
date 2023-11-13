using Microsoft.AspNetCore.Mvc;
using TesteTecnicoImobiliaria.Modelo.Interfaces.Regra;
using TesteTecnicoImobiliaria.WEB.Models;

namespace TesteTecnicoImobiliaria.WEB.Controllers
{
    public class ImoveisController : Controller
    {
        private readonly ImovelViewModel _imovelViewModel;
        public ImoveisController(ImovelViewModel imovelViewModel)
        {
            _imovelViewModel = new ImovelViewModel();
        }
        public IActionResult Index()
        {
            _imovelViewModel.Imoveis = new List<ImovelModel>();
            _imovelViewModel.Imoveis.Add(new ImovelModel()
            {

            });
            return View(_imovelViewModel);
        }
    }
}