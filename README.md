Trackingmore-CSHARP
=================

The PHP SDK of Trackingmore API
## Official document

[Document](https://www.trackingmore.com/v3/api-index)

##Init
```
Api api = new Api("Your Api Key");
```


Quick Start
--------------
- Put your ApiKey in the constructor of the Api class
- All returns are in Json format String.
- After instantiating the Api class, you can use its interface methods
- You can set the sandbox of the Api instance to true to turn on the sandbox mode: <code>api.sandbox=true;</code>
- Most Api params receive multiple tracking numbers

**Get a list of the couriers in Trackingmore**

    string courier = "courier?lang=en";
    response = api.doRequest(courier);
    Console.WriteLine(response.Content.ReadAsStringAsync().Result);

**Detect which couriers defined in your account match a tracking number**

    string post = "{ \"tracking_number\": \"EA152563254CN\" }";
    response = api.doRequest("detect", post, "POST");
    Console.WriteLine(response.Content.ReadAsStringAsync().Result);


**Post trackings to your account**

    //Create single tracking numbers
    string post = "{\"tracking_number\" => \"RP325552475CN\", \"carrier_code\" => \"china-post\"}";
    //Create multiple tracking numbers
    string post = "[{\"tracking_number\" => \"RP325552475CN\", \"carrier_code\" => \"china-post\"}",
        "{\"tracking_number\" => \"LZ448865302CN\", \"carrier_code\" => \"china-ems\"}]";
    response = api.doRequest("create", post, "POST");
    Console.WriteLine(response.Content.ReadAsStringAsync().Result);

**Summary of Connection API Methods with all the api and Methods**

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
            // response = api.doRequest("delete?num=EA152563254CN", "", "DELETE");
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
            // string post = "{ \"num\": \"EA152563254CN\" }";
            // response = api.doRequest("detect", post, "POST");
            // Console.WriteLine(response.Content.ReadAsStringAsync().Result);

            // // get all carriers
            // response = api.doRequest("carriers", post, "POST");
            // Console.WriteLine(response.Content.ReadAsStringAsync().Result);

            // // Get status number
            // string status = "status?num=EA152563254CN";
            // response = api.doRequest(status);
            // Console.WriteLine(response.Content.ReadAsStringAsync().Result);

            // // Set number not update
            // response = api.doRequest("notupdate", post, "POST");
            // Console.WriteLine(response.Content.ReadAsStringAsync().Result);

            // // Modify courier code
            // string post = "{\"num\": \"EA152563254CN\", \"express\": \"china-ems\", \"new_express\": \"china-post\"}";
            // response = api.doRequest("modifycourier", post, "PUT")
            // Console.WriteLine(response.Content.ReadAsStringAsync().Result);

            // // Get user info
            // response = api.doRequest("userinfo");
            // Console.WriteLine(response.Content.ReadAsStringAsync().Result);

            // // air real time track
            // response = api.doRequest("aircargo", post, "POST");
            // Console.WriteLine(response.Content.ReadAsStringAsync().Result);

## Typical Server Responses

We will respond with one of the following status codes.

Code|Type | Message
----|--------------|-------------------------------
200    | <code>Success</code>|    Request response is successful
203    | <code>PaymentRequired</code>|  API service is only available for paid account Please subscribe paid plan to unlock API services                                                             ul
204    | <code>No Content</code>|    Request was successful, but no data returned Tracking NO. or target data possibly do not exist
400    | <code>Bad Request</code>| Request type error Please check the API documentation for the request type of this API
401    | <code>Unauthorized</code>|    Authentication failed or has no permission Please check and ensure your API Key is correct
403    | <code>Bad Request</code>|    Page does not exist Please check and ensure your link is correct                                                                                             ul
404    | <code>Not Found</code>|    Page does not exist Please check and ensure your link is correct
408    | <code>Time Out</code>|    Request timeout The official website did not return data, please try again later
411    | <code>Bad Request</code>|    Specified request parameter length exceeds length limit Please check and ensure that the request parameters are of the required length
412    | <code>Bad Request</code>|    Specified request parameter format doesn't meet requirements Please check and ensure that the request parameters are in the required format
413    | <code>Out limited</code>|    The number of request parameters exceeds the limit Please check the API documentation for the limit of this API
417    | <code>Bad Request</code>|    Missing request parameters or request parameters cannot be parsed Please check and ensure that the request parameters are complete and correctly formatted
421    | <code>Bad Request</code>|    Some of required parameters are empty Some couriers need special parameters to track logistics information (Special Couriers)
422    | <code>Bad Request</code>|    Unidentifiable courier code Please check and ensure that the courier code are correct(Courier code)
423    | <code>Bad Request</code>|    Tracking No. already exists
424    | <code>Bad Request</code>|    Tracking No. no exists Please use 「Create trckings」 API first to create trackings
429    | <code>Bad Request</code>|    Exceeded API request limits, please try again later Please check the API documentation for the limit of this API
511    | <code>Server Error</code>|    Server error Please contact us: service@trackingmore.org.
512    | <code>Server Error</code>|    Server error Please contact us: service@trackingmore.org.
513    | <code>Server Error</code>|    Server error Please contact us: service@trackingmore.org.        