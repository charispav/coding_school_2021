using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApplication.EF.Context;
using WebApplication.Model;
using WebApplication.Services;

namespace WebApplication.Pages
{
    public class ListModel : PageModel {
        public ICollection<Customer> Items;
        
        private IItemStorage _storage { get; set; }

        public ListModel(IItemStorage storage) {
            _storage = storage;
            
        }

        public void OnGet() {
            Items = _storage.GetAllItems();
        }
  
    }
}
