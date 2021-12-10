using EmiMvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmiMvc.Controllers
{
    public class EmiController : Controller
    {
        public IActionResult Output(double principal, double rate, double duration)
        {
            double MonthlyEmi, ContinousEmi, DailyEmi;
            Request request = new Request();
            request.Principal = principal;
            request.InterestRateInPercentage = rate;
            request.LoanDurationInYearCount = duration;
            double e = 2.7183;

            MonthlyEmi = (double)request.Principal * System.Math.Pow(1 + (request.InterestRateInPercentage / 100) / 12, request.LoanDurationInYearCount * 12);
            ContinousEmi = (double)request.Principal * System.Math.Pow(e, (request.InterestRateInPercentage / 100 * request.LoanDurationInYearCount));
            DailyEmi = ((double)request.Principal * System.Math.Pow(1 + ((request.InterestRateInPercentage / 100) / 365), 365 * request.LoanDurationInYearCount)) - (double)request.Principal;

            request.MonthlyEmi = Math.Round(MonthlyEmi, 2);
            request.ContinousEmi = ContinousEmi;
            request.DailyEmi = DailyEmi;

            return View(request);
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult EmiMonthly()
        {
            return View();
        }
    }


}

