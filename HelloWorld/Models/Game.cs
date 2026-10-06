using Microsoft.AspNetCore.Components.Web;

namespace HelloWorld.Models
{
    public class Game
    {
        public string Title{get;set;}
        public int ReleaseYear{get;set;}
        public int Price{get;set;}

        public Game(string title, int releaseYear, int price)
        {
            Title = title;
            ReleaseYear = releaseYear;
            Price = price;
        }
    }
}