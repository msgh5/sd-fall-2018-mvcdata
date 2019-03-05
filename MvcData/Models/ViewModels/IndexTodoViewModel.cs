﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcData.Models.ViewModels
{
    public class IndexTodoViewModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime DateCreated { get; set; }
    }
}