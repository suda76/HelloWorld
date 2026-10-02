using HelloWorld.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace HelloWorld.Pages
{
    public class IndexModel : PageModel
    {
        public string? Message { get; set; }
        public DateTime Now { get; set; }
        public string? Greet { get; set; }
        public string? DisplayName { get; set; }
        [BindProperty]
        [Required(ErrorMessage = "名前を入力してください")]
        [StringLength(20, ErrorMessage = "名前が長すぎます")]
        public string? InputName { get; set; }
        
        private readonly GreetingService _greetingService;

        public IndexModel(GreetingService greetingService)
        {
            _greetingService = greetingService;
        }
        public void OnGet()
        {
            SetValue();
        }
        
        public void OnPost()
        {
            SetValue();
        }

        private void SetValue()
        {
            if (InputName == null)
            {
                DisplayName = "ゲスト";
            }
            else
            {
                DisplayName = InputName;
            }
            Message = "Hello World!";
            Now = DateTime.Now;
            var hour = Now.Hour;
            Greet = _greetingService.GetGreeting(hour);
        }
    }
}