using MyRestaurant.Web.Models;

namespace MyRestaurant.Web.Services.IServices
{
    public interface IBaseService : IDisposable
    {
        ResponseDTO ResponseModel { get; set; }
        Task<T> SendAsync<T>(ApiRequest apiRequest);
    }
}
