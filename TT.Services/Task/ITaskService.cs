using System;
using System.Collections.Generic;
using System.Text;

namespace TT.Services.Task
{
    public interface ITaskService
    {
        IList<Core.Domain.Task> GetTasks();
        void InsertTask(Core.Domain.Task Task);
        void DeleteTask(Core.Domain.Task Task);
        void UpdateCustomer(Core.Domain.Task task);
    }
}
