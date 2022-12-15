using CRM2_MVC.Models;
using CRM2_MVC.Repository;
using Microsoft.AspNetCore.Mvc;

namespace CRM2_MVC.Controllers
{
    public class LeadsController : Controller
    {
        private readonly ILeadRepository _repository;
        public LeadsController(ILeadRepository repository)
        {
            _repository = repository;
        }
        public IActionResult Index()
        {
            List<LeadModel> leads = _repository.GetAll();
            return View(leads);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(LeadModel leadData)
        {
            LeadModel newLead = _repository.AddOne(leadData);

            // return new ObjectResult(newLead) { StatusCode = StatusCodes.Status201Created };
            // !!!!! Como faz para retornar o status 201 e ainda fazer o redirect?
            return RedirectToAction("Index");
        }
    }
}
