﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ASP_Miron_Robert_Andrei_Rp.Data;
using ASP_Miron_Robert_Andrei_Rp.Models;

namespace ASP_Miron_Robert_Andrei_Rp.Pages.Movies
{
    public class DeleteModel : PageModel
    {
        private readonly ASP_Miron_Robert_Andrei_Rp.Data.ASP_Miron_Robert_Andrei_RpContext _context;

        public DeleteModel(ASP_Miron_Robert_Andrei_Rp.Data.ASP_Miron_Robert_Andrei_RpContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Movie Movie { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Movie = await _context.Movie.FirstOrDefaultAsync(m => m.ID == id);

            if (Movie == null)
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

            Movie = await _context.Movie.FindAsync(id);

            if (Movie != null)
            {
                _context.Movie.Remove(Movie);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
