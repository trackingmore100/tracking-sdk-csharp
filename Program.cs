using System;
using System.Linq;
using System.Web;
using System.Net;
using System.IO;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
namespace Tracker
{
    class Tracking
    {
        static void Main(string[] args)
        {
            Api api = new Api("Your Api Key");

            // Get realtime tracking results of a single tracking
            string post = "{\"tracking_number\": \"EA152563254CN\", \"carrier_code\": \"china-ems\"}";
            HttpResponseMessage response = api.doRequest("realtime", post, "POST");
            Console.WriteLine(response.Content.ReadAsStringAsync().Result);

            // count
            string count = "count?courier=1&limit=100&created_at_min=1521314361&created_at_max=1541314361";
            response = api.doRequest(count);
            Console.WriteLine(response.Content.ReadAsStringAsync().Result);

            // // Get tracking results of a  tracking or List all trackings
            // string get = "get?page=1&limit=100&created_at_min=1521314361&created_at_max=1541314361";
            // response = api.doRequest(get);
            // Console.WriteLine(response.Content.ReadAsStringAsync().Result);

            // // Update Tracking item
            // response = api.doRequest("modifyinfo", post, "PUT");
            // Console.WriteLine(response.Content.ReadAsStringAsync().Result);

            // // archive
            // response = api.doRequest("archive", post, "POST");
            // Console.WriteLine(response.Content.ReadAsStringAsync().Result);

            // // Delete tracking item
            // response = api.doRequest("delete?tracking_number=EA152563254CN", "", "DELETE");
            // Console.WriteLine(response.Content.ReadAsStringAsync().Result);

            // // create  tracking number
            // response = api.doRequest("create", post, "POST");
            // Console.WriteLine(response.Content.ReadAsStringAsync().Result);

            // // manual update
            // response = api.doRequest("manualupdate", post, "POST");
            // Console.WriteLine(response.Content.ReadAsStringAsync().Result);

            // // remote tracking
            // response = api.doRequest("remote", post, "POST");
            // Console.WriteLine(response.Content.ReadAsStringAsync().Result);

            // // Get cost time iterm results
            // response = api.doRequest("transittime", post, "POST");
            // Console.WriteLine(response.Content.ReadAsStringAsync().Result);

            // // detect a carriers by tracking number
            // string post = "{ \"tracking_number\": \"EA152563254CN\" }";
            // response = api.doRequest("detect", post, "POST");
            // Console.WriteLine(response.Content.ReadAsStringAsync().Result);

            // // get all carriers
            // response = api.doRequest("carriers", post, "POST");
            // Console.WriteLine(response.Content.ReadAsStringAsync().Result);

            // // Get status number
            // string status = "status?tracking_number=EA152563254CN";
            // response = api.doRequest(status);
            // Console.WriteLine(response.Content.ReadAsStringAsync().Result);

            // // Set number not update
            // response = api.doRequest("notupdate", post, "POST");
            // Console.WriteLine(response.Content.ReadAsStringAsync().Result);

            // // Modify courier code
            // string post = "{\"tracking_number\": \"EA152563254CN\", \"courier_code\": \"china-ems\", \"new_courier_code\": \"china-post\"}";
            // response = api.doRequest("modifycourier", post, "PUT")
            // Console.WriteLine(response.Content.ReadAsStringAsync().Result);

            // // Get user info
            // response = api.doRequest("userinfo");
            // Console.WriteLine(response.Content.ReadAsStringAsync().Result);

            // // air real time track
            // response = api.doRequest("aircargo", post, "POST");
            // Console.WriteLine(response.Content.ReadAsStringAsync().Result);
        }
    }
}
