using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendEmail.Helper
{
    public static class AttachmentValidator
    {
         static string  [] allowedMimeTypes = {
    "image/png", "image/jpeg", "image/gif", "image/bmp", "image/tiff",
    "application/pdf",
     "text/plain",
    "application/vnd.ms-excel", // .xls
    "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", // .xlsx
    "application/zip", "application/x-rar-compressed"
};

        public static  (bool ,string) CheckAttachValid(string filePath)
        {

            string mimeType = MimeTypes.GetMimeType(filePath);
            bool flag = allowedMimeTypes.Contains(mimeType);
            return (flag,mimeType) ;
        }
       

    }
}
