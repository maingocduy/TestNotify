using ESDManagerApi.Models.Request;

namespace TestNotify.Models.Request
{
    public class saveNotifyRequest : UuidRequest
    {
        public sbyte type { get; set; }
    }
}
