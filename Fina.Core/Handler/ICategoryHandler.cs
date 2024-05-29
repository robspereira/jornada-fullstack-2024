using Fina.Core.Responses;
using Fina.Core.Requests.Categories;
using Fina.Core.Models;

namespace Fina.Core.Handler;

public interface ICategoryHandler
{
    Task<Response<Category?>> CreateAsync(CreateCategoryRequest request);
    
    Task<Response<Category?>> UpdateAsync(UpdateCategoryRequest request);
    
    Task<Response<Category?>> DeleteAsync(DeleteCategoryRequest request);
    
    Task<Response<Category?>> GetByIdAsync(GetCategoryByIdRequest request);

    Task<PagedResponse<List<Category>?>> GetAllAsync(GetAllCategoriesRequest request);

}