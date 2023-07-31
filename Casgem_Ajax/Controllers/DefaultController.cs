using Casgem_Ajax.DAL;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace Casgem_Ajax.Controllers
{
    public class DefaultController : Controller
    {
        Context context = new Context();
        public IActionResult Index()
        {
            return View();
        }
        //public IActionResult CustomerList()
        //{
        //    var jsonCustomer=JsonConverter.
        //}
        public IActionResult CustomerList()
        {
            var jsonCustomer = JsonConvert.SerializeObject(context.Customers.ToList());
            return Json(jsonCustomer);
        }
        [HttpPost]
        public IActionResult AddCustomer(Customer customer)
        {
            context.Customers.Add(customer);
            context.SaveChanges();
            var values = JsonConvert.SerializeObject(customer);
            return Json(values);
        }
        public IActionResult DeleteCustomer(int id)
        {
            var value = context.Customers.Find(id);
            context.Customers.Remove(value);
            context.SaveChanges();  
            return NoContent(); 
        }
        public IActionResult GetCustomer(int CustomerId)
        {
            var values=context.Customers.Find(CustomerId);
            var jsonValues= JsonConvert.SerializeObject(values);    
            return Json(jsonValues);
        }
        public IActionResult UpdateCustomer(Customer customer)
        {
            context.Customers.Update(customer);
            context.SaveChanges();
            return NoContent(); 
        }
    }
}
