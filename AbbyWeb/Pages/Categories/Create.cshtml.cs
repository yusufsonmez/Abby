using AbbyWeb.Data;
using AbbyWeb.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AbbyWeb.Pages.Categories
{
    [BindProperties]
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public CreateModel(ApplicationDbContext db)
        {
            _db = db;
        }
        //[BindProperty]
        public Category Category { get; set; }
        public void OnGet()
        {
        }

        //public async Task<IActionResult> OnPost(Category category)
        public async Task<IActionResult> OnPost()
        {
            //await _db.Categories.AddAsync(category);
            await _db.Categories.AddAsync(Category); //Because of we are used [BindProperties] we can pass the entity object directly.
            await _db.SaveChangesAsync();
            return RedirectToPage("Index");
        }
    }
}
