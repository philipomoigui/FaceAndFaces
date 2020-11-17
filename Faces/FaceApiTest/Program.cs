using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;

namespace FaceApiTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var imagePath = @"";

            ImageUtility imageUtil = new ImageUtility();
            var bytes = imageUtil.ConvertToBytes(imagePath);

            List<byte[]> FaceList = null;

            var byteContent = new ByteArrayContent(bytes);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");

            using(HttpClient httpClient = new HttpClient())
            {

            }
        }
    }
}
