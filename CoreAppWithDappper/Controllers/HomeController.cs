using Microsoft.AspNetCore.Mvc;
using Models;
using Repository;

namespace CoreAppWithDappper.Controllers
{
    public class HomeController : Controller
    {
        private readonly IGetData _getData;

        public HomeController(IGetData getData)
        {
            _getData = getData;
        }

        [Route("/")]
        public IActionResult Index()
        {
            IEnumerable<PatientModel> patientsData = _getData.GetData();
            return View(patientsData);
        }
    }
}
