using ps3.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace ps3.Pages
{
    public class ZapisaneModel : PageModel
    {
        public List<string> lista = new List<string>();
        public void OnGet()
       {
            var Data = HttpContext.Session.GetString("Data");
            if (Data != null)
                   lista = JsonConvert.DeserializeObject<List<string>>(Data);
        }
        
    }
}
