using KidsFun.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata;

namespace KidsFun.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AssignmentController : ControllerBase
    {
        private readonly ILogger<AssignmentController> _logger;

        public AssignmentController(ILogger<AssignmentController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetAssignments")]
        public IEnumerable<AssignmentDto> Get()
        {
            using (var db = new KidsFunContext())
            {
                var query = from b in db.TaskAssignments
                            select b;

                _logger.LogInformation("Load all assignments in the database");
                return query.Select(d=> new AssignmentDto { AssignmentName = d.Type.Name, Due = d.Due, Points = 888 }).ToList();
            }
        }
    }
}