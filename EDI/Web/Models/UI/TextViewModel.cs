﻿using System;
using System.ComponentModel.DataAnnotations;

namespace EDI.Web.Models
{
    public class TextViewModel
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public string Placeholder { get; set; }
    }
}
