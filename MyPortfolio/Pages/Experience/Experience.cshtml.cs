using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyPortfolio.Pages;

public class ExperienceModel : PageModel
{
    private readonly ILogger<ExperienceModel> _logger;

    public ExperienceModel(ILogger<ExperienceModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}