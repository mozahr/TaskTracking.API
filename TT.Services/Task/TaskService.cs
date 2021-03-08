using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TT.Core.Data;

namespace TT.Services.Task
{
    public class TaskService: ITaskService
    {
        #region Fields
        IRepository<Core.Domain.Task> _taskRepository;
        #endregion
        #region Ctor
        public TaskService(IRepository<Core.Domain.Task> taskRepository)
        {
            _taskRepository = taskRepository;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Get Tasks
        /// </summary>
        /// <param name="customer">Tasks</param>
        public IList<Core.Domain.Task>  GetTasks()
        {

           var Tasks =  _taskRepository.Table.ToList();
            return Tasks;
        }
        /// <summary>
        /// Insert a customer
        /// </summary>
        /// <param name="customer">Customer</param>
        public virtual void InsertTask(Core.Domain.Task Task)
        {
            if (Task == null)
                throw new ArgumentNullException(nameof(Task));

            _taskRepository.Insert(Task);
        }


        /// <summary>
        /// Delete a Task
        /// </summary>
        /// <param name="Task">Task</param>
        public virtual void DeleteTask(Core.Domain.Task Task)
        {
            if (Task == null)
                throw new ArgumentNullException(nameof(Task));

            _taskRepository.Delete(Task);

 

        }
        #endregion

    }
}
