﻿using EmiMvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmiMvc.Controllers
{
    public class EmiMonthlyController : Controller
    {
        public IActionResult Output(double principal, double rate, double duration)
        {
            double Result;
            Request request = new Request();
            request.Principal = principal;
            request.InterestRateInPercentage = rate;
            request.LoanDurationInYearCount = duration;
            Result = (double)request.Principal * System.Math.Pow(1 + (request.InterestRateInPercentage / 100) / 12, request.LoanDurationInYearCount * 12);
            request.Result = Math.Round(Result, 2);
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

