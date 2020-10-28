﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Stackoverflow.Domain.Schema
{
    public class QuestCMD
    {
       
         [Required]
        [MaxLength(1000)]
        public string Title{ get; set; }
        [Required]
        public string Body { get; set; }
        public string[] Tags { get; private set; }
        public int Votes { get; private set; }

        public QuestCMD(string title, string body,string[] tags, int votes)
        {
            Title = title;
            Body = body;
            Tags = tags;
            Votes = votes;          
        }
    }
}
