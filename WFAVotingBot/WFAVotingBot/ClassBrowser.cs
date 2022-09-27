using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;

namespace WFAVotingBot
{
    /*
     * Browser Class for sending request to server and getting the response 
     */
    public class Browser
    {

        private WebRequest request;
        private Stream dataStream;

        private string status;

        public String Status
        {
            get
            {
                return status;                
            }
            set
            {
                status = value;
            }
        }

        public Browser(string url)
        {
            // Create a request using a URL that can receive a post.

            request = WebRequest.Create(url);
            request.Credentials = CredentialCache.DefaultCredentials;
        }

        public Browser(string url, string method)
            : this(url)
        {

            if (method.Equals("GET") || method.Equals("POST") ||method.Equals("HEAD"))
            {
                // Set the Method property of the request to POST.
                request.Method = method;
            }
            else
            {
                throw new Exception("Invalid Method Type");
            }
        }

        public Browser(string url, string method, string data)
            : this(url, method)
        {
            try
            {                
                // Create POST data and convert it to a byte array.
                //string postData = data;
                //byte[] byteArray = Encoding.UTF8.GetBytes(postData);

                // Set the ContentType property of the WebRequest.
                //request.ContentType = "application/x-www-form-urlencoded";

                // Set the ContentLength property of the WebRequest.
                //request.ContentLength = byteArray.Length;

                // Get the request stream.
                //dataStream = request.GetRequestStream();

                // Write the data to the request stream.
                //dataStream.Write(byteArray, 0, byteArray.Length);

                // Close the Stream object.
                //dataStream.Close();
            }catch(Exception e){this.Status=e.Message;}
        }

        public string GetResponse()
        {
            //string responseFromServer = "";
            try
            {
                // Get the original response.
                WebResponse response = request.GetResponse();

                this.Status = ((HttpWebResponse)response).StatusDescription;

                // Get the stream containing all content returned by the requested server.
                //dataStream = response.GetResponseStream();

                // Open the stream using a StreamReader for easy access.
                //StreamReader reader = new StreamReader(dataStream);

                // Read the content fully up to the end.
                //responseFromServer = reader.ReadToEnd();

                // Clean up the streams.
                //reader.Close();
                //dataStream.Close();
                //response.Close();
            
            }catch(Exception e){this.Status=e.Message;}

            return this.Status;
        }
    }
}
