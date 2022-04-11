using ps3.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;


namespace ps3.Pages
{
    public class IndexModel : PageModel
    {
        List<string> lista = new List<string>();
        [BindProperty]
        public Dane dane { get; set; }
        private readonly ILogger<IndexModel> _logger;
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {

        }
        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                var Data = HttpContext.Session.GetString("Data");
                if (Data != null)
                    lista = JsonConvert.DeserializeObject<List<string>>(Data);
                if(dane.Rok%4 == 0)
                {
                    lista.Add(dane.Imie + " urodził/a się w " + dane.Rok + " roku. To był rok przestępny.");
                }
                else
                {
                    lista.Add(dane.Imie + " urodził/a się w " + dane.Rok + " roku. To nie był rok przestępny.");
                }
                HttpContext.Session.SetString("Data", JsonConvert.SerializeObject(lista));
                
            }
            return Page();
        }

    }
}