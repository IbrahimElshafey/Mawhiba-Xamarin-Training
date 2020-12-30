namespace MawhibaSample.Services
{
    public class ApiResult<T>
    {
        public string ResultCode { get; set; }
        public string ResultMessage { get; set; }
        public string MoreDetails { get; set; }
        public object ValidatonDictionary { get; set; }
        public T ResultObject { get; set; }
    }
}