using System.Collections.Generic;

namespace API.Errors
{
    public class ApiValidationErrorResponse : APIResponse
    {
        public ApiValidationErrorResponse() : base(400)
        {

        }
        public IEnumerable<string> Errors { get; set;}
    }
}