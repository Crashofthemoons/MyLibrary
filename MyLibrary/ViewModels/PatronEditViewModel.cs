﻿using Microsoft.AspNetCore.Mvc.Rendering;
using MyLibrary.Data;
using MyLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyLibrary.ViewModels
{
    public class PatronEditViewModel
    {
        public Patron Patron { get; set; }

        public List<SelectListItem> Libraries { get; set; }

        public List<SelectListItem> Books { get; set; }

        public PatronEditViewModel(ApplicationDbContext context)
        {
            Libraries = context.Library.Select(library =>
            new SelectListItem { Text = library.Name, Value = library.LibraryId.ToString() }).ToList();

            Books = context.Book.Select(book =>
            new SelectListItem { Text = book.Title, Value = book.BookId.ToString() }).ToList();
        }

    }
}
