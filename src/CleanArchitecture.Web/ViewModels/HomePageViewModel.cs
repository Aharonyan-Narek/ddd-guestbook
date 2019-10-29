﻿using CleanArchitecture.Core.Entities;
using System.Collections.Generic;

namespace CleanArchitecture.Web.ViewModels
{
    public class HomePageViewModel
    {
        public string GuestbookName { get; set; }
        public List<GuestbookEntry> PreviousEntries { get; } = new List<GuestbookEntry>();
    }
}
