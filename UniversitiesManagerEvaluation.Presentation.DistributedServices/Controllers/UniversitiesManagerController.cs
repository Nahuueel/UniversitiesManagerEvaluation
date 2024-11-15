using Microsoft.AspNetCore.Mvc;
using UniversitiesManagerEvaluation.Library.Contracts;

namespace UniversitiesManagerEvaluation.Presentation.DistributedServices.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UniversitiesManagerController : ControllerBase
    {
        private readonly IUniversitiesManagerServices _UniversitiesManagerServices;

        public UniversitiesManagerController(IUniversitiesManagerServices universitiesManagerServices)
        {
            _UniversitiesManagerServices = universitiesManagerServices;
        }

        [HttpGet("PostMigrationOfAPIToDB")]
        public async Task<IActionResult> PostMigrationOfAPIToDB()
        {
            return Ok(await _UniversitiesManagerServices.RetriveListOfUniversitiesFromAPI());
        }
    }
}
