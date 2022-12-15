using CRM2_MVC.Data;
using CRM2_MVC.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace CRM2_MVC.Repository
{
    public class CourseRepository : ICourseRepository
    {
        private readonly CrmDbContext _context;

        public CourseRepository(CrmDbContext context)
        {
            _context = context;
        }

       public  List<CourseModel> GetAll()
        {
            return  _context.Courses.Include(c => c.Leads).ToList();
        }

        public CourseModel? GetById(int courseId)
        {
            return _context.Courses.Find(courseId);
        }

        public CourseModel AddOne(CourseModel CourseData)
        {
            _context.Courses.Add(CourseData);
            _context.SaveChanges(); 
            return CourseData;
        }

        public CourseModel? AddEnrollment(int courseId, int userId)
        {
            CourseModel? course = _context.Courses.Include(c => c.Leads).First(c => c.CourseId == courseId);
            LeadModel? lead = _context.Leads.Include(c => c.Courses).First(u => u.LeadId == userId);

            if (lead == null || course == null)
            {
                return null;
            }

            if(course.Leads == null)
            {
                course.Leads = new List<LeadModel>();
                course.Leads.Add(lead);
                _context.SaveChanges();
                return course;
            }
            else
            {
                course.Leads.Add(lead);
                _context.SaveChanges();
                return course;
            }
        }
    }
}
