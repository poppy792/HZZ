using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Configuration;

namespace REST_api
{
    public class REST
    {
        public static string CallRestMethod(string url)
        {
            HttpWebRequest webrequest = (HttpWebRequest)WebRequest.Create(url);
            webrequest.Method = "GET";
            webrequest.ContentType = "application/x-www-form-urlencoded";
            HttpWebResponse webresponse = (HttpWebResponse)webrequest.GetResponse();
            Encoding enc = System.Text.Encoding.GetEncoding("utf-8");
            StreamReader responseStream = new StreamReader(webresponse.GetResponseStream(), enc);
            string result = string.Empty;
            result = responseStream.ReadToEnd();
            webresponse.Close();
            return result;
        }
        public List<Category> GetWorkCategories()
        {
            List<Category> lRESTCategory = new List<Category>();
            //string sUrl = System.Configuration.ConfigurationManager.AppSettings["RestApiUrl"];
            string url = "https://data.gov.hr/api/2/rest/package/slobodna-radna-mjesta-po-zanimanju";
            string sJson = CallRestMethod(url);
            JObject oJson = JObject.Parse(sJson);
            var oCategories = oJson["resources"].ToList();
            List<Category> lCategories = new List<Category>();
            for (int i = 0; i < oCategories.Count; i++)
            {
                lCategories.Add(new Category
                {
                    nID = (string)oCategories[i]["id"],
                    sDescription = (string)oCategories[i]["description"],
                    sCreated = (string)oCategories[i]["created"],
                    sUrl = (string)oCategories[i]["url"],
                    nPosition = (int)oCategories[i]["position"]
                });          
            }
            return lCategories;
        }
    }
}
    
