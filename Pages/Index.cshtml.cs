using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Pages;

public class IndexModel : PageModel
{
    public ISampleInterface InterfaceInstance { get; } = new ImplementationClass();
    public ImplementationClass ClassInstance { get; } = new ImplementationClass();

    public void OnGet() { }
}
