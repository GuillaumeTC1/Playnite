using System.Net;

namespace Playnite.Common.Extensions
{
    public static class NetExtensions
    {
        public static bool IsSuccess(this HttpStatusCode statusCode)
        {
            return statusCode >= HttpStatusCode.OK && statusCode < HttpStatusCode.MultipleChoices;
        }
    }
}
