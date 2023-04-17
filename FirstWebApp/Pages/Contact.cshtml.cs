using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FirstWebApp.Pages
{
    public class ContactModel : PageModel
    {
        public bool hasData = false;
        public string firstName = "";
        public string LastName = "";
        public string message = "";





        public void OnGet()
        {
        }

        public void OnPost()
        {
            hasData = true;
         firstName = Request.Form["firstname"];
         LastName = Request.Form["lastname"];
         message = Request.Form["message"];


    }
}
}
