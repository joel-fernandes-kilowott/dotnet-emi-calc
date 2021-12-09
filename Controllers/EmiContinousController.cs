using EmiMvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmiMvc.Controllers
{
    public class EmiContinousController : Controller
    {
        public IActionResult Output(double principal, double rate, double duration)
        {
            double Result;
            Request request = new Request();
            request.Principal = principal;
            request.InterestRateInPercentage = rate;
            request.LoanDurationInYearCount = duration;
            double e = 2.7183;
            Result = (double)request.Principal * System.Math.Pow(e, ((request.InterestRateInPercentage / 100) * request.LoanDurationInYearCount));
            request.Result = Math.Round(Result, 2);
            return View(request);
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult EmiDaily()
        {
            return View();
        }
    }
}
