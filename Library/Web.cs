using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Library
{
    public class ReqObj
    {
        public string WebURL; 
        public string ResultCode;
        public string XMLData; 
        public string Message; 
        public string ItemID; 
    }

    public class Web
    {
        public static async Task<ReqObj> SendWebRequest(ReqObj rec)
        {
            ReqObj rslt = new ReqObj();
            rslt = rec;
            var httpClient = new HttpClient();
            StringContent content = new StringContent(rec.ItemID); 

            try
            {
                HttpResponseMessage response = await httpClient.PostAsync(rec.WebURL, content);

                if (response.IsSuccessStatusCode)
                {

                    HttpContent stream = response.Content;
                    Task<string> data = stream.ReadAsStringAsync();
                    rslt.XMLData = data.Result.ToString();

                    XmlDocument doc = new XmlDocument();
                    doc.LoadXml(rslt.XMLData);
                    XmlNode resultNode = doc.SelectSingleNode("response");
                    string resultStatus = resultNode.InnerText;
                    if (resultStatus == "1")
                        rslt.ResultCode = "OK";
                    else if (resultStatus == "0")
                        rslt.ResultCode = "ERR";
                    rslt.Message = doc.InnerXml;
                }

            }
            catch (Exception ex)
            {
                rslt.ResultCode = "ERR";
                rslt.Message = "Connection error: " + ex.Message;
            }

            return rslt;
        }
    }
}
