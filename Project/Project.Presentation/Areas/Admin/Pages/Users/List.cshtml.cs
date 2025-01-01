using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Project.Domain.Entities.Users;

namespace Project.Presentation.Areas.Admin.Pages.Users
{
    [Authorize("Admin")]
    public class ListModel : PageModel
    {
        private readonly UserManager<User> _userManager;

        public ListModel(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        [BindProperty]
        public List<User> Users { get; set; }
       

        public void OnGet()
        {
            Users = _userManager.Users.ToList();
        }

        public async Task<IActionResult> OnPostAsync(string Id)
        {

            var user = await _userManager.FindByIdAsync(Id);

            if (user != null)
            {
                await _userManager.DeleteAsync(user);
            }
            return RedirectToPage();


        }
    }
}
