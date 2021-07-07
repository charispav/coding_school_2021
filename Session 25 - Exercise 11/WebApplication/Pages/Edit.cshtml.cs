using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication.Model;
using WebApplication.Services;

namespace WebApplication.Pages
{
    public class EditModel : PageModel
    {
        [BindProperty]
        public Customer SelectedListItem { get; set; }

        private IItemStorage _storage { get; set; }

        public EditModel(IItemStorage storage) {
            _storage = storage;
        }

        public void OnGet(int id) {
            if (id == 0) {
                SelectedListItem = new Customer();
                return;
            }

            SelectedListItem = _storage.GetById(id);
        }

        public IActionResult OnPost() {
            _storage.AddItem(SelectedListItem);

            return RedirectToPage("List");
        }

        public IActionResult OnPostCancel() {
            return RedirectToPage("List");
        }

        public IActionResult OnPostDelete() {
            _storage.RemoveItem(SelectedListItem.ID);
            return RedirectToPage("List");
        }
    }
}
