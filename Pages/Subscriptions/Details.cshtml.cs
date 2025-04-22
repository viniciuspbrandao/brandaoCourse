using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using brandaoCourse.Data;
using brandaoCourse.Models;

namespace brandaoCourse.Pages_Subscriptions
{
    public class DetailsModel : PageModel
    {
        private readonly brandaoCourse.Data.ApplicationDbContext _context;

        public DetailsModel(brandaoCourse.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Subscription Subscription { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var subscription = await _context.Subscriptions.FirstOrDefaultAsync(m => m.Id == id);

            if (subscription is not null)
            {
                Subscription = subscription;

                return Page();
            }

            return NotFound();
        }
    }
}
