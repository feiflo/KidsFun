using KidsFun.Models;

namespace KidsFun.Core;

public class AssignmentManager : IAssignmentManager
{
    //private readonly IAssignmentRepository _repository;

    public Task AssignAsync(int taskId, int kidId)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<TaskAssignment>> LoadAsync(int kidId)
    {
        throw new NotImplementedException();
    }

    public Task UnassignAsync(int assignmentId)
    {
        throw new NotImplementedException();
    }
}

