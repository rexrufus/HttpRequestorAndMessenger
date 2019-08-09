using System;
using System.IO;
using System.Net;


namespace HttpRequestorAndMessenger 
{
    class HttpWebRequestor
    {
        public static String sMakeHTTPCall(String sURL)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(sURL);  
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            String ver = response.ProtocolVersion.ToString();
            StreamReader reader = new StreamReader(response.GetResponseStream());
            String sOut = "";
            string str = reader.ReadLine();
            while (str != null)
            {
                Console.WriteLine(str);
                str = reader.ReadLine();
                sOut += str;
            }

            return sOut;
        }


    }
}
