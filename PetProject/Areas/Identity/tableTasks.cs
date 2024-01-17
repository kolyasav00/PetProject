﻿using System;
using System.ComponentModel.DataAnnotations.Schema;

//TODO rename name pages tableTasks -> TaskList
namespace PetProject.Areas.Identity
{
    [Table("TableTasks", Schema = "data")]
    public class TableTasks
    {
        public int Id { get; set; }

        public string? Status { get; set; }

        public string? NameTask { get; set; }

        public string? NameProject { get; set; }

        //TODO rename var
        public string? Work {  get; set; }

        public DateTime DateStart { get; set; }

        public DateTime DateEnd { get; set; }

        public string? Performer { get; set; }

    }
}
