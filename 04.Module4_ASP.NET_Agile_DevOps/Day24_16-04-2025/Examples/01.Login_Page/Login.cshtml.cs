using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace WebApplication33.Pages
{
    public class LoginModel : PageModel
    {
       [BindProperty]
       public string UserName {  get; set; }

        [BindProperty] 
        public string Password { get; set; }


        public string Message { get; set; }
        
        public void OnGet()
        {
             
        }

        public IActionResult OnPost() {

             
            if (UserName == "admin" && Password == "admin123")
            {
                // Message = "Welcome to Admin";
                // Redirect to home or dashboard
                  return RedirectToPage("Index");
            }
            else
            {
                Message = "Invalid User Id or Password";
                return Page();
            }

        }    

    }

    
}
