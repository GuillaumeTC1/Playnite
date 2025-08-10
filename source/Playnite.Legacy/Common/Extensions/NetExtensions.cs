using System.Net;

namespace Playnite.Legacy.Common.Extensions
{
    public static class NetExtensions
    {
        public static bool IsSuccess(this HttpStatusCode statusCode)
        {
            return statusCode >= HttpStatusCode.OK && statusCode < HttpStatusCode.MultipleChoices;
        }
    }
}
