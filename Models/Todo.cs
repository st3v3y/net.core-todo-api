using System;

namespace aspnetTest.Models
{
    public class Todo
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public bool Checked { get; set; }
        public DateTimeOffset CreatedAt { get; set; }

        public Todo(string text)
        {
            this.Text = text;
            this.Checked = false;
            this.CreatedAt = DateTime.Now;
        }
    }
}