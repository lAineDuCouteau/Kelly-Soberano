using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyPortfolio.Pages;

public class ProjectModel : PageModel
{
    private readonly ILogger<ProjectModel> _logger;

    public ProjectModel(ILogger<ProjectModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}

