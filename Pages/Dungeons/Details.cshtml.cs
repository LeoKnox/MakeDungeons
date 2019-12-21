using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DungeonMaker.Models;

namespace DungeonMaker.Pages.Dungeons
{
    public class DetailsModel : PageModel
    {
        private readonly DungeonMaker.Models.DungeonMakerContext _context;

        public DetailsModel(DungeonMaker.Models.DungeonMakerContext context)
        {
            _context = context;
        }

        public Dungeon Dungeon { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Dungeon = await _context.Dungeon.FirstOrDefaultAsync(m => m.ID == id);

            if (Dungeon == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
