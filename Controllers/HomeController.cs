using bazaDanych.Models;
using bazaDanych.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace bazaDanych.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IGamesService _gamesService;
        
        public HomeController(ILogger<HomeController> logger,IGamesService gamesService)
        {
            _logger = logger;
            _gamesService = gamesService;
        }
        
        public async Task<IActionResult> Index()
        {
            var ksiazki = await _gamesService.PobierzWszystkieGry();
            return View(ksiazki);
        }

        public async Task<IActionResult> Add()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(Game game)
        {
            await _gamesService.Dodaj(game);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Edit(int id)
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Game game)
        {
            await _gamesService.Edit(game);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int id)
        {
            await _gamesService.Usun(id);
            return RedirectToAction("Index");
        }

    }
}
