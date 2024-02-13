using KodlamaIOClone.Business.Abstracts;
using KodlamaIOClone.Business.Dtos.Requests;
using KodlamaIOClone.Business.Dtos.Response;
using KodlamaIOClone.DataAccess.Abstracts;
using KodlamaIOClone.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIOClone.Business.Concretes
{
    public class CourseManager : ICourseService
    {
        ICourseDal  _courseDal;

        public CourseManager (ICourseDal courseDal)
        {
            _courseDal = courseDal;
        } 
        public void Add(AddCourseRequest course)
        {
           Random rnd = new Random();
            Course dtoToCourse = new Course();
            dtoToCourse.Title = dtoToCourse.Title;
            dtoToCourse.Description = dtoToCourse.Description;
            dtoToCourse.ImageUrl = dtoToCourse.ImageUrl;
            dtoToCourse.Price = dtoToCourse.Price;
            dtoToCourse.Id = (int)rnd.NextInt64(0, 100);
            _courseDal.Add(dtoToCourse);
        }

        public void Delete(DeleteCourseRequest course)
        {
            Course deleteForCourse = new Course();
            deleteForCourse = _courseDal.GetById(course.Id);
            _courseDal.Delete(deleteForCourse);
        }

        public List<GetAllCourseResponse> GetAllCourse()
        {
            List<GetAllCourseResponse> courselist = new List<GetAllCourseResponse>();
            foreach (var item in _courseDal.GetAll())
            {
                courselist.Add ( new GetAllCourseResponse { Id=item.Id, Description=item.Description, Price=item.Price, ImageUrl=item.ImageUrl, Title=item.Title } );
            }
            return courselist;
        }

        public GetByIdCourseResponse GetByIdCourse(int id)
        {
            GetByIdCourseResponse GetAllCourseResponse= new GetByIdCourseResponse();
            Course course = _courseDal.GetById(id);
            GetAllCourseResponse.Id = course.Id;
            GetAllCourseResponse.Title = course.Title;
            return GetAllCourseResponse;
        }

        public void Update(UpdateCourseRequest course)
        {
            Course courseUpdate = new Course();
            courseUpdate.Id = course.Id;
            courseUpdate.Title = course.Title;
            courseUpdate.Description = course.Description;
            courseUpdate.Price = course.Price;
            courseUpdate.ImageUrl = course.ImageUrl;
            _courseDal.Update(courseUpdate);      
        }
    }
}
