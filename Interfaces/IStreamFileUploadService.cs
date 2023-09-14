using Microsoft.AspNetCore.WebUtilities;

namespace Thuchanh_1.Interfaces
{
    public interface IStreamFileUploadService
    {
        public interface IStreamFileUploadService
        {
            Task<bool> UploadFile(MultipartReader reader, MultipartSection section);
        }
    }
}
