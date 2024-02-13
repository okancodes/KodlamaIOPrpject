using KodlamaIOClone.Business.Dtos.Requests;
using KodlamaIOClone.Business.Dtos.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIOClone.Business.Abstracts
{
    public interface ICourseService
    {
        void Add (AddCourseRequest course);
        GetByIdCourseResponse GetByIdCourse (int id);
        List<GetAllCourseResponse> GetAllCourse();
        void Update (UpdateCourseRequest course);
        void Delete (DeleteCourseRequest course);
    }
}
