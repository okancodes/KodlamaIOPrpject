using KodlamaIOClone.DataAccess.Abstracts;
using KodlamaIOClone.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIOClone.DataAccess.Concretes
{
    public class InMemoryTutor : ITutorDal
    {
        List<Tutor> tutors = new List<Tutor>();

        public InMemoryTutor()
        {
            tutors.Add(new Tutor { Id = 1, FullName = "Engin Demirog" , TutorImageUrl = "ımage.png" });
            tutors.Add(new Tutor { Id = 2, FullName = "Halit Enes Kalaycı", TutorImageUrl = "ımage.png" });

        }
        public void Add(Tutor tutor)
        {
            tutors.Add(tutor);
        }
        public void Delete(Tutor tutor)
        {
            tutors.Remove(tutor);
        }
        public List<Tutor> GetAll()
        {
            return tutors;
        }
        public Tutor GetById(int id)
        {
            return tutors.Where(t => t.Id == id).FirstOrDefault();

        }
        public void Update(Tutor tutor)
        {
            Tutor courseToUpdate = GetById(tutor.Id);
            courseToUpdate.FullName = tutor.FullName;

        }


    }
}
