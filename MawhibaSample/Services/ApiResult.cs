namespace MawhibaSample.Services
{
    public class ApiResult
    {
        public string ResultCode { get; set; }
        public string ResultMessage { get; set; }
        public string MoreDetails { get; set; }
        public object ValidatonDictionary { get; set; }
        public Resultobject ResultObject { get; set; }
    }
}