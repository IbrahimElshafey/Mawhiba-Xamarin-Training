using System.Collections.Generic;
using System.Threading.Tasks;
using MawhibaSample.Models;
using Refit;

namespace MawhibaSample.Services
{
    public interface IGeneralService
    {
        [Get("/Contents/api/Services/GetServices")]
        Task<ApiResult<List<ServiceItem>>> GetServices();
    }
}