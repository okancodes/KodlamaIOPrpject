using KodlamaIOClone.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIOClone.DataAccess.Abstracts
{
    public interface ICourseDal
    {
        void Add(Course courses);
        Course GetById(int id);
        List<Course> GetAll();
        void Update(Course courses);
        void Delete(Course courses);
    }
}
