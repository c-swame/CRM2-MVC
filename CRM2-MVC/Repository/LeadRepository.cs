using CRM2_MVC.Data;
using CRM2_MVC.Models;

namespace CRM2_MVC.Repository
{
    public class LeadRepository : ILeadRepository
    {
        private readonly CrmDbContext _context;

        public LeadRepository(CrmDbContext context)
        {
            _context = context;
        }

       public  List<LeadModel> GetAll()
        {
            return _context.Leads.ToList();
        }
        public LeadModel? GetById(int leadId)
        {
            return _context.Leads.Find(leadId);
        }

        public LeadModel AddOne(LeadModel leadData)
        {
            var leadCpf = leadData.Cpf;
            CPFCNPJ.IMain validator = new CPFCNPJ.Main();

            var isValid = validator.IsValidCPFCNPJ(leadCpf);

            if (!isValid)
            {
                throw new InvalidDataException("Invalid CPF");
            }

            _context.Leads.Add(leadData);
            _context.SaveChanges(); 
            return leadData;
        }
    }
}
