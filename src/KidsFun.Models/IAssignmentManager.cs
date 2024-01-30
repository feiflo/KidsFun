using System;
namespace KidsFun.Models
{
	public interface IAssignmentManager
	{
		Task<IEnumerable<TaskAssignment>> LoadAsync(int kidId);

		Task AssignAsync(int taskId, int kidId);//creat

		Task UnassignAsync(int assignmentId);//delete
	}
}

