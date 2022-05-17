using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChroniclesOfManRestClient
{
    public enum httpVerb
    {
        GET, POST, PUT, DELETE
    }
    internal class RestClient
    {
        public string endPoint { get; set; }
        public httpVerb httpMethod { get; set; }  

        public RestClient()
        {
            endPoint = string.Empty;
            httpMethod = httpVerb.GET;
        }

        public string makeRequest()
        {
            string strResponseValue = string.Empty;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(endPoint);
            request.Accept = "application/json";
            request.Method = httpMethod.ToString();



            try
            {
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {

                    

                    using (Stream responseStream = response.GetResponseStream())
                    {
                        if (responseStream != null)
                        {
                            using (StreamReader reader = new StreamReader(responseStream))
                            {
                                strResponseValue = reader.ReadToEnd();
                            }
                        }
                    }

                }
            }
            catch (WebException ex)
            {
                
                        MessageBox.Show($"Error code {ex}", "Response not OK", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            return strResponseValue;
        }
    }
}
