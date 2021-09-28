using CardLab.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace CardLab.Controllers
{
    public class CardDeckController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> shufflecards(int deckcount)
        {
            string domain = "https://deckofcardsapi.com/";
            string path = $"/api/deck/new/shuffle/?deck_count={deckcount}";

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(domain);
            var connection = await client.GetAsync(path);

            Root result = await connection.Content.ReadAsAsync<Root>();
            return View(result);
        }

        public async Task<IActionResult> drawcard(int deckcount)
        {
            string domain = "https://deckofcardsapi.com/";
            string path = $"/api/deck/new/draw/?count={deckcount}";

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(domain);
            var connection = await client.GetAsync(path);

            Cards result = await connection.Content.ReadAsAsync<Cards>();
            return View(result);
        }
    }
}
