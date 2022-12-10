using CRM2_MVC.Models;

namespace CRM2_MVC.Repository
{
    public interface ILeadRepository
    {
        List<LeadModel> GetAll();
        LeadModel AddOne(LeadModel leadData);
        LeadModel? GetById(int leadId);
    }
}
