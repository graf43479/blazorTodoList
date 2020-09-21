using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoList.Models;

namespace TodoList.Data.Repository
{
    public class TodoRepository : IRepository
    {
        private readonly ApplicationContext _context;

        public TodoRepository(ApplicationContext context)
        {
            _context = context;
        }

        public IEnumerable<TodoItem> GetItems()
        {
            return _context.TodoItems;
        }

        public void Add(string item)
        {
            _context.Add(new TodoItem()
            {
                Title = item
            });
            _context.SaveChanges();
        }

        public void Update(TodoItem item)
        {
            _context.Update(item);
            _context.SaveChanges();
        }

        public void Remove(int id)
        {
            TodoItem item = _context.TodoItems.FirstOrDefault(x => x.Id == id);
            if (item != null)
            {
                _context.Remove(item);
                _context.SaveChanges();
            }
        }
    }
}
