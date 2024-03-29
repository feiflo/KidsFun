using KidsFun.Models;
using KidsFun.WebApi.Dtos;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata;

namespace KidsFun.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AssignmentController : ControllerBase
    {
        private readonly ILogger<AssignmentController> _logger;
        private readonly IAssignmentManager _manager;

        public AssignmentController(IAssignmentManager manager, ILogger<AssignmentController> logger)
        {
            _manager = manager;
            _logger = logger;
        }

        [HttpGet(Name = "GetAssignments")]
        public async Task<IActionResult> GetAsync(int kidId)
        {
            if (kidId <= 0)
                return BadRequest("Invalid kid Id");
            var assignments = await _manager.LoadAsync(kidId);
            return Ok(assignments.Select(d=> new TaskAssignmentDto { TaskTypeId = d.Type.Id, Due = d.Due}).ToList());
        }

        [HttpPost(Name = "GetAssignments")]
        public void Assign(TaskAssignmentDto assignment)
        {
            throw new NotImplementedException();
        }

    }
}