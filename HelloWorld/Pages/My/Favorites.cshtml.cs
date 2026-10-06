using HelloWorld.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Net.Http.Headers;

namespace HelloWorld.Pages
{
    public class FavoritesModel : PageModel
    {
        public List<Game> Games{get;set;} = [];
        public void OnGet()
        {
            Games.Add(new Game("ポケモン",2004,3600));
            Games.Add(new Game("マリオ",2009,6000));
            Games.Add(new Game("大神",2009,4000));
        }
    }
}
