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
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public void Add(AddCategoryRequest category)
        {
            Random rnd = new Random();

            Category dtoToCategory = new Category();
            dtoToCategory.Name = category.Name;
            dtoToCategory.Id = (int)rnd.NextInt64(0, 100);

            _categoryDal.Add(dtoToCategory);
        }

        public void Delete(DeleteCategoryRequest category)
        {
            Category deleteForCategory = new Category();
            deleteForCategory = _categoryDal.GetById(category.Id);
            _categoryDal.Delete(deleteForCategory);
        }

        public List<GetAllCategoryResponse> GetAll()
        {
            List<GetAllCategoryResponse> categoryList = new List<GetAllCategoryResponse>();

            foreach (var item in _categoryDal.GetAll())
            {
                categoryList.Add
                    (
                        new GetAllCategoryResponse { Id=item.Id,Name=item.Name}
                    );
            }
            return categoryList;
        }

        public GetByIdCategoryResponse GetById(int id)
        {
            GetByIdCategoryResponse getAllCategoryResponse = new GetByIdCategoryResponse();
            Category category = _categoryDal.GetById(id);
            getAllCategoryResponse.Id = category.Id;
            getAllCategoryResponse.Name = category.Name;
            return getAllCategoryResponse;
        }

        public void Update(UpdateCategoryRequest category)
        {
            Category categoryToUpdate = new Category();
            categoryToUpdate.Id = category.Id;
            categoryToUpdate.Name = category.Name;
            _categoryDal.Update(categoryToUpdate);
        }
    }
}
