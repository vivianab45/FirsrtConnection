﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FirsrtConnection.Models;
using FirstConnection.Models;

namespace FirsrtConnection.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    //add context
    private MyContext _context;

    public HomeController(ILogger<HomeController> logger, MyContext context)
    {
        _logger = logger;
        _context= context;
    }

    [HttpGet ("")]
    public IActionResult Index()
    {
        List<Pet> AllPets= _context.Pets.ToList();
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
