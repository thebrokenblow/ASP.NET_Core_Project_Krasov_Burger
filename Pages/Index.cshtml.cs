using KrasovBurger.Services;
using KrasovBurger.Model;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace KrasovBurger.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger,
            JsonFileBurgerService burgerService)
        {
            _logger = logger;
            BurgersService = burgerService;
        }

        public JsonFileBurgerService BurgersService { get; }
        public IEnumerable<Burger> Burgers { get; private set; }

        public void OnGet()
        {
            Burgers = BurgersService.GetBurger();
        }
    }
}
