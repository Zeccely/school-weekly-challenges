using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ModelBindingExample.Pages
{
    public class IndexModel : PageModel
    {

        public string? Message { get; set; }

        public void OnPost(string value)
        {
            Message = value;
        }

    }
}
