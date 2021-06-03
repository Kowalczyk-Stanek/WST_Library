﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WSTLibrary.Models
{
    public class Borrow
    {
        [Key]
        public int borrowId { get; set; }
        public int customerId { get; set; }
        public int bookId { get; set; }
        public DateTime takenDate { get; set; }
        public DateTime broughtDate { get; set; }

        public Customer customer { get; set; }
        public Book book { get; set; }

    }
}