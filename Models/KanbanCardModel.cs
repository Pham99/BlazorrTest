﻿namespace BlazorAppEmpty.Models
{
    public class KanbanCardModel
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public DateOnly? Deadline { get; set; }
        public User User { get; set; }
    }
}
