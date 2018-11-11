using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aspnetTest.Database;
using aspnetTest.Models;
using Microsoft.AspNetCore.Mvc;

namespace aspnetTest.Controllers.Api.v1
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        private TodoTestDatabaseContext _dbContext;

        public TodoController(TodoTestDatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        // GET api/v1/todo
        [HttpGet]
        public ActionResult<IEnumerable<Todo>> Get()
        {
            return _dbContext.Todos.ToArray();
        }

        // GET api/v1/todo/5
        [HttpGet("{id}")]
        public ActionResult<Todo> Get(int id)
        {
            return _dbContext.Todos.Find(id);
        }

        // POST api/v1/todo/
        [HttpPost]
        public void Post([FromBody]Todo todo)
        {
            _dbContext.Todos.Add(todo);
            _dbContext.SaveChanges();
        }

        // PUT api/v1/todo/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Todo todo)
        {
            var updateTodo = _dbContext.Todos.Find(id);
            if(updateTodo == null){
                NotFound();
                return;
            }

            _dbContext.Update(updateTodo);

            updateTodo.Checked = todo.Checked;
            if(String.IsNullOrEmpty(todo.Text)) {
                updateTodo.Text = todo.Text;
            }

            _dbContext.SaveChanges();
        }

        // DELETE api/v1/todo/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var deleteTodo = _dbContext.Todos.Find(id);
            if(deleteTodo == null){
                NotFound();
                return;
            }
            _dbContext.Remove(deleteTodo);
            _dbContext.SaveChanges();
        }
    }
}
