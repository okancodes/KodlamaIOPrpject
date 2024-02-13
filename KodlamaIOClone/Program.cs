using KodlamaIOClone.Business.Concretes;
using KodlamaIOClone.Business.Dtos.Requests;
using KodlamaIOClone.Business.Dtos.Response;
using KodlamaIOClone.DataAccess.Abstracts;
using KodlamaIOClone.DataAccess.Concretes;
using KodlamaIOClone.Entities;
using System.Xml.Linq;

CategoryManager categoryManager = new CategoryManager(new InMemoryCategory());
AddCategoryRequest category = new AddCategoryRequest ()  {Name="C#" };
categoryManager.Add(category);


GetByIdCategoryResponse getByIdCategoryResponse = categoryManager.GetById(1);

    getByIdCategoryResponse.Name = "Java ";
    UpdateCategoryRequest updateCategoryRequest = new UpdateCategoryRequest()
    {
        Id = getByIdCategoryResponse.Id,
        Name = getByIdCategoryResponse.Name
    };

    categoryManager.Update(updateCategoryRequest);

foreach (var item in categoryManager.GetAll())
{
    Console.WriteLine(item.Name);
}
Console.WriteLine("Kurs güncelleme işlemi başarılı ! ");
Console.WriteLine("---------------------------");



TutorManager tutorManager = new TutorManager(new InMemoryTutor());
AddTutorRequest tutor = new AddTutorRequest() {FullName="Elanur Parlak" };
tutorManager.Add(tutor);

GetByIdTutorResponse getByIdTutorResponse = tutorManager.GetByIdTutor(2);
getByIdTutorResponse.FullName = "Mücahid Uygun";
UpdateTutorRequest updateTutorRequest = new UpdateTutorRequest()
{
    Id = getByIdTutorResponse.Id,
    FullName = getByIdTutorResponse.FullName,
};

tutorManager.Update(updateTutorRequest);

foreach (var item in tutorManager.GetAllTutor())
{
    Console.WriteLine(item.FullName);
}



Console.WriteLine("Eğitmen güncelleme işlemi başarılı ! ");
Console.WriteLine("---------------------------");

GetByIdCategoryResponse delete = categoryManager.GetById(1);
DeleteCategoryRequest deleteCategoryRequest = new DeleteCategoryRequest()
{
    Id = delete.Id,
    };

categoryManager.Delete(deleteCategoryRequest);

foreach (var item in categoryManager.GetAll())
{
    Console.WriteLine(item.Name);
}
Console.WriteLine("Kategori silme işlemi başarılı ! ");
Console.WriteLine("------------------------");

CourseManager courseManager = new CourseManager(new InMemoryCourse());
GetByIdCourseResponse GetByIdCourseResponse = courseManager.GetByIdCourse(1);

GetByIdCourseResponse.Title = "Kurs güncelleme denemesi. ";
UpdateCourseRequest updateCourseRequest = new UpdateCourseRequest()
{
    Id = GetByIdCourseResponse.Id,
    Title = GetByIdCourseResponse.Title
};

courseManager.Update(updateCourseRequest);

foreach (var item in courseManager.GetAllCourse())
{
    Console.WriteLine(item.Title);
}

Console.WriteLine("Kurs güncelleme başarılı ! ");
Console.WriteLine("------------------------");



categoryManager.Delete(deleteCategoryRequest);

GetByIdTutorResponse tutor1 = tutorManager.GetByIdTutor(1);
DeleteTutorRequest deleteTutorRequest = new DeleteTutorRequest()
{
    Id = tutor1.Id
};
tutorManager.Delete(deleteTutorRequest);
foreach (var item in tutorManager.GetAllTutor())
{
    Console.WriteLine(item.FullName);
}

Console.WriteLine("Eğitmen silme işlemi başarılı ! ");
Console.WriteLine("------------------------");

