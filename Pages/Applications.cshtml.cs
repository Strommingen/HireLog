using HireLog.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace hirelog.Pages;

public class ApplicationsModel : PageModel
{
    private readonly ILogger<ApplicationsModel> _logger;

    public ApplicationsModel(ILogger<ApplicationsModel> logger)
    {
        _logger = logger;
    }

    [BindProperty]
    public JobState JobState { get; set; }
    [BindProperty]
    public string Position { get; set; }
    [BindProperty]
    public string Company { get; set; }
    [BindProperty]
    public string Letter { get; set; }
    
    public void OnGet()
    {
    }

    public void OnPost()
    {
        _logger.LogInformation("JobState: {JobState}, Position: {Position}, Company: {Company}, Letter: {Letter}",
        JobState, Position, Company, Letter);
    }
}

