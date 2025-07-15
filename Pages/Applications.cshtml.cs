using System.Text.Json;
using System.Threading.Tasks;
using HireLog.Data;
using HireLog.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HireLog.Pages;

public class ApplicationsModel : PageModel
{
    private readonly ILogger<ApplicationsModel> _logger;
    private readonly AppDbContext _context;
    private readonly HttpClient _httpClient;
    public List<Application> Applications { get; set; } = new List<Application>();
    public ApplicationsModel(ILogger<ApplicationsModel> logger, AppDbContext context, IHttpClientFactory factory)
    {
        _logger = logger;
        _context = context;
        _httpClient = factory.CreateClient();
    }

    [BindProperty]
    public JobState JobState { get; set; }
    [BindProperty]
    public string Position { get; set; }
    [BindProperty]
    public string Company { get; set; }
    [BindProperty]
    public string Letter { get; set; }

    public async Task OnGetAsync()
    {
        var response = await _httpClient.GetAsync("https://localhost:7267/api/application");
        if (response.IsSuccessStatusCode)
        {
            var json = await response.Content.ReadAsStringAsync();
            Console.WriteLine("JSON received: " + json);  // or use ILogger to log
            Applications = JsonSerializer.Deserialize<List<Application>>(json, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });
        }
        else
        {
            Console.WriteLine($"API call failed with status: {response.StatusCode}");
            Applications = new List<Application>();
        }
    }


    // public async Task<IActionResult> OnPostAsync()
    // {
    //     var application = new Application
    //     {
    //         Position = Position,
    //         Company = Company,
    //         Letter = Letter,
    //         ApplicationDate = DateTime.Now,
    //         State = JobState

    //     };
    // }
}

