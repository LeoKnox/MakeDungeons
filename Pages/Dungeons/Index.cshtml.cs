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
    public class IndexModel : PageModel
    {
        private readonly DungeonMaker.Models.DungeonMakerContext _context;

        public IndexModel(DungeonMaker.Models.DungeonMakerContext context)
        {
            _context = context;
        }

        public IList<Dungeon> Dungeon { get;set; }

        public async Task OnGetAsync()
        {
            Dungeon = await _context.Dungeon.ToListAsync();
        }
    }
}
