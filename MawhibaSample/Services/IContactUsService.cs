using System.Threading.Tasks;
using MawhibaSample.Models;
using Newtonsoft.Json.Linq;
using Refit;

namespace MawhibaSample.Services
{
    public interface IContactUsService
    {
        [Post("/UserProfile/api/ContactUs/SaveContactUs")]
        Task<ApiResult<JObject>> SaveContactUs(ContactUsModel model);
    }
}