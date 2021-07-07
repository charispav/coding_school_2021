using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.EF.Context;
using WebApplication.Model;

namespace WebApplication.Services {

    public interface IItemStorage {

       
        public void AddItem(Customer item);
        public void RemoveItem(int id);
        public ICollection<Customer> GetAllItems();
        public Customer GetById(int id);
    }
    public class ItemStorage : IItemStorage {



        private ICollection<Customer> innerList { get; set; }
        

        public ItemStorage() {
            innerList = new List<Customer>();
        }
        public void AddItem(Customer item) {
            if (item.ID == 0) {
                item.ID = innerList.Count() + 1;
                
                innerList.Add(item);
                
                return;
            }

            var selectedItem = GetById(item.ID);
            selectedItem.Name = item.Name;
            selectedItem.Surname = item.Surname;
            selectedItem.AFM = item.AFM;
            selectedItem.Active = item.Active;
        }

        public ICollection<Customer> GetAllItems() {
           
            return innerList;
                
        }

        public Customer GetById(int id) {

            return innerList.FirstOrDefault(item => item.ID == id);
        }

        public void RemoveItem(int id) {
            var selectedItem = GetById(id);
            if (selectedItem == null)
                throw new Exception(string.Format("Item with ID '{0}' was not found.", id));

           innerList.Remove(selectedItem);
            
        }


    }
}
