using System;
using System.ComponentModel.DataAnnotations;
using AspNetCoreTodo.Models;
using AspNetCoreTodo.Services;

namespace AspNetCoreTodo.Models
{
    public class TodoViewModel
    {
       public TodoItem[] Items { get; set; }
    }
}