using ESDManagerApi.Models.BaseRequest;
using System.ComponentModel.DataAnnotations;

namespace ESDManagerApi.Models.Request
{
    public class UuidRequest : DpsParamBase
    {
       
        public string? Uuid { get; set; }
    }
}
