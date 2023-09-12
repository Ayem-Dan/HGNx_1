using Microsoft.AspNetCore.Mvc;

namespace Stage_One.Controllers;

[ApiController]
[Route("[controller]")]
public class Controller : ControllerBase
{
   

    [HttpGet("api")]
    public IActionResult GetInfo(string slack_name = "Daniel", string track = "Backend")
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
            github_file_url = "https://github.com/Ayem-Dan/HGNx_1/blob/master/Stage-One/Program.cs",
            github_repo_url = "https://github.com/Ayem-Dan/HGNx_1",
            status_code = 200
        };

        return Ok(response);
    }
}
