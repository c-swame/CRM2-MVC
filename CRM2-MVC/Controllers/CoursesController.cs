using CRM2_MVC.Models;
using CRM2_MVC.Repository;
using Microsoft.AspNetCore.Mvc;

namespace CRM2_MVC.Controllers
{
    public class CoursesController : Controller
    {
        private readonly ICourseRepository _repository;
        public CoursesController(ICourseRepository repository)
        {
            _repository = repository;
        }
        public IActionResult Index()
        {
            List<CourseModel> courses = _repository.GetAll();
            return View(courses);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CourseModel courseData)
        {
            CourseModel newCourse = _repository.AddOne(courseData);

            // return new ObjectResult(newCourse) { StatusCode = StatusCodes.Status201Created };
            // !!!!! Como faz para retornar o status 201 e ainda fazer o redirect?
            return RedirectToAction("Index");
        }

        public IActionResult Enrollments()
        {
            List<CourseModel> courses = _repository.GetAll();

            return View(courses);
        }

        public IActionResult CreateEnrollment()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateEnrollment(EnrollmentModel enrollmentData)
        {
            CourseModel newCourse = _repository.AddEnrollment(enrollmentData.CourseId, enrollmentData.LeadId);

            // return new ObjectResult(newCourse) { StatusCode = StatusCodes.Status201Created };
            // !!!!! Como faz para retornar o status 201 e ainda fazer o redirect?
            return RedirectToAction("Enrollments");
        }
    }
}
