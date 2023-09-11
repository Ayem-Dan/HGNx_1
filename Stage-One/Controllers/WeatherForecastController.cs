using Microsoft.AspNetCore.Mvc;

namespace Stage_One.Controllers;

[ApiController]
[Route("[controller]")]
public class Controller : ControllerBase
{
   

    [HttpGet("api")]
    public IActionResult GetInfo(string slack_name, string track)
    {
        // Get the current day of the week
        var currentDay = DateTime.UtcNow.ToString("dddd");
        var utcTime = DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ssZ");

        var response = new
        {
            slack_name,
            current_day = currentDay,
            utc_time = utcTime,
            track,
            github_file_url = "https://github.com/Ayem-Dan/repo.cs",
            github_repo_url = "https://github.com/Ayem-Dan/repo",
            status_code = 200
        };

        return Ok(response);
    }
}
