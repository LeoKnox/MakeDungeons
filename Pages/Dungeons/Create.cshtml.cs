using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using DungeonMaker.Models;

namespace DungeonMaker.Pages.Dungeons
{
    public class CreateModel : PageModel
    {
        private readonly DungeonMaker.Models.DungeonMakerContext _context;

        public CreateModel(DungeonMaker.Models.DungeonMakerContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Dungeon Dungeon { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Dungeon.Add(Dungeon);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}