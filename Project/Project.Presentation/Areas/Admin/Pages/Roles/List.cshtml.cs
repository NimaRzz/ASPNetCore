using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Project.Domain.Entities.Roles;

namespace Project.Presentation.Areas.Admin.Pages.Roles
{
    [Authorize("Admin")]
    public class ListModel : PageModel
    {
        private readonly RoleManager<Role> _roleManager;

        public ListModel(RoleManager<Role> roleManager)
        {
            _roleManager = roleManager;
        }

     
        public List<Role> Roles { get; set; }
        public void OnGet()
        {
            Roles = _roleManager.Roles.Where(p => p.IsRemoved == false).ToList();
        }

        public async Task<IActionResult> OnPostAsync(string Name)
        {
            var role = await _roleManager.FindByNameAsync(Name);
            
            if (role != null)
            {
             await _roleManager.DeleteAsync(role);  
            }
            return RedirectToPage();
        }
    }
}
