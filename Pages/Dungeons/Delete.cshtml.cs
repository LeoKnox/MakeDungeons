﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DungeonMaker.Models;

namespace DungeonMaker.Pages.Dungeons
{
    public class DeleteModel : PageModel
    {
        private readonly DungeonMaker.Models.DungeonMakerContext _context;

        public DeleteModel(DungeonMaker.Models.DungeonMakerContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Dungeon = await _context.Dungeon.FindAsync(id);

            if (Dungeon != null)
            {
                _context.Dungeon.Remove(Dungeon);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
