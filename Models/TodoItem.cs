using System;
using System.ComponentModel.DataAnnotations;
using AspNetCoreTodo.Data.Migrations;


namespace AspNetCoreTodo.Models
{
    public class TodoItem
    {
        public Guid Id { get; set; } // globally unique IDentifier

        public bool IsDone { get; set; }

        [Required]
        public string Title { get; set; }

        public DateTimeOffset? DueAt { get; set; } // ? marks DueAt Nullable, therefore always required and will have a value 
    }
}