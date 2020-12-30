using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Refit;

namespace MawhibaSample.Services
{
    public interface ILoginService
    {
        [Get("/Login/Login")]
        Task<ApiResult<User>> Login(string username, string password);
    }
}
