using orbis.iim.core.Models;
using orbis.iim.core.Requests.Categories;
using orbis.iim.core.Responses;

namespace orbis.iim.core.Handlers
{
    public interface ICategoryHandler
    {
        Task<Response<Category?>> CreateAsync(CreateCategoryRequest request);
        Task<Response<Category?>> UpdateAsync(UpdateCategoryRequest request);
        Task<Response<Category?>> DeleteAsync(DeleteCategoryRequest request);
        Task<Response<Category?>> GetByIdAsync(GetCategoryByIdRequest request);
        Task<PagedResponse<List<Category>>> GetAllAsync(GetAllCategoriesRequest request);
    }
}
