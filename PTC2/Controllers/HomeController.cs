using PTCData;
using System.Collections.Generic;
using System.Web.Mvc;

namespace PTC2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            TrainingProductViewModel viewModel = new TrainingProductViewModel();

            viewModel.HandleRequest();

            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Index(TrainingProductViewModel viewModel)
        {
            viewModel.IsValid = ModelState.IsValid;
            viewModel.HandleRequest();

            if (viewModel.IsValid)
            {
                ModelState.Clear();
            }
            else
            {
                foreach (KeyValuePair<string, string> item in viewModel.ValidationErrors)
                {
                    ModelState.AddModelError(item.Key, item.Value);
                }
            }

            return View(viewModel);
        }

    }
}