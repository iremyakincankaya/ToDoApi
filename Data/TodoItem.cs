﻿namespace ToDoApi.Data
{
    public class TodoItem
    {
        public int Id { get; set; }
        public string Title { get; set; } = "";
        public bool Done { get; set; }
    }
}
