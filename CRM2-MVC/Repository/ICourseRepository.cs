using CRM2_MVC.Models;

namespace CRM2_MVC.Repository
{
    public interface ICourseRepository
    {
        List<CourseModel> GetAll();
        CourseModel AddOne(CourseModel leadData);
        CourseModel? GetById(int id);
        CourseModel? AddEnrollment(int CourseId, int userID);
    }
}
