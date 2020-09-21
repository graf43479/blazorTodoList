using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoList.Models;

namespace TodoList.Data.Repository
{
    public interface IRepository
    {
        IEnumerable<TodoItem> GetItems();

        void Add(string item);
        void Update(TodoItem item);
        void Remove(int id);
    }
}
