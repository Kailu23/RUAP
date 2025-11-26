// .NET Framework 4.7.1 or greater must be used

using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CallRequestResponseService {
    class Program {
        static void Main(string[] args) {
            InvokeRequestResponseService().Wait();
        }

        static async Task InvokeRequestResponseService() {
            var handler = new HttpClientHandler() {
                ClientCertificateOptions = ClientCertificateOption.Manual,
                ServerCertificateCustomValidationCallback =
                        (httpRequestMessage, cert, cetChain, policyErrors) => { return true; }
            };
            using (var client = new HttpClient(handler)) {
                // Request data goes here
                // The example below assumes JSON formatting which may be updated
                // depending on the format your endpoint expects.
                // More information can be found here:
                // https://docs.microsoft.com/azure/machine-learning/how-to-deploy-advanced-entry-script
                var requestBody = "{\r\n  \"Inputs\": {\r\n    \"data\": [\r\n      {\r\n        \"age\": 57,\r\n        \"job\": \"technician\",\r\n        \"marital\": \"married\",\r\n        \"education\": \"high.school\",\r\n        \"default\": \"no\",\r\n        \"housing\": \"no\",\r\n        \"loan\": \"yes\",\r\n        \"contact\": \"cellular\",\r\n        \"month\": \"may\",\r\n        \"duration\": 371,\r\n        \"campaign\": 1,\r\n        \"pdays\": 999,\r\n        \"previous\": 1,\r\n        \"poutcome\": \"failure\",\r\n        \"emp.var.rate\": -1.8,\r\n        \"cons.price.idx\": 92.89299999999999,\r\n        \"cons.conf.idx\": -46.2,\r\n        \"euribor3m\": 1.2990000000000002,\r\n        \"nr.employed\": 5099.1\r\n      },\r\n      {\r\n        \"age\": 55,\r\n        \"job\": \"unknown\",\r\n        \"marital\": \"married\",\r\n        \"education\": \"unknown\",\r\n        \"default\": \"unknown\",\r\n        \"housing\": \"yes\",\r\n        \"loan\": \"no\",\r\n        \"contact\": \"telephone\",\r\n        \"month\": \"may\",\r\n        \"duration\": 285,\r\n        \"campaign\": 2,\r\n        \"pdays\": 999,\r\n        \"previous\": 0,\r\n        \"poutcome\": \"nonexistent\",\r\n        \"emp.var.rate\": 1.1,\r\n        \"cons.price.idx\": 93.994,\r\n        \"cons.conf.idx\": -36.4,\r\n        \"euribor3m\": 4.86,\r\n        \"nr.employed\": 5191\r\n      },\r\n      {\r\n        \"age\": 33,\r\n        \"job\": \"blue-collar\",\r\n        \"marital\": \"married\",\r\n        \"education\": \"basic.9y\",\r\n        \"default\": \"no\",\r\n        \"housing\": \"no\",\r\n        \"loan\": \"no\",\r\n        \"contact\": \"cellular\",\r\n        \"month\": \"may\",\r\n        \"duration\": 52,\r\n        \"campaign\": 1,\r\n        \"pdays\": 999,\r\n        \"previous\": 1,\r\n        \"poutcome\": \"failure\",\r\n        \"emp.var.rate\": -1.8,\r\n        \"cons.price.idx\": 92.89299999999999,\r\n        \"cons.conf.idx\": -46.2,\r\n        \"euribor3m\": 1.3130000000000002,\r\n        \"nr.employed\": 5099.1\r\n      },\r\n      {\r\n        \"age\": 36,\r\n        \"job\": \"admin.\",\r\n        \"marital\": \"married\",\r\n        \"education\": \"high.school\",\r\n        \"default\": \"no\",\r\n        \"housing\": \"no\",\r\n        \"loan\": \"no\",\r\n        \"contact\": \"telephone\",\r\n        \"month\": \"jun\",\r\n        \"duration\": 355,\r\n        \"campaign\": 4,\r\n        \"pdays\": 999,\r\n        \"previous\": 0,\r\n        \"poutcome\": \"nonexistent\",\r\n        \"emp.var.rate\": 1.4,\r\n        \"cons.price.idx\": 94.465,\r\n        \"cons.conf.idx\": -41.8,\r\n        \"euribor3m\": 4.967,\r\n        \"nr.employed\": 5228.1\r\n      },\r\n      {\r\n        \"age\": 27,\r\n        \"job\": \"housemaid\",\r\n        \"marital\": \"married\",\r\n        \"education\": \"high.school\",\r\n        \"default\": \"no\",\r\n        \"housing\": \"yes\",\r\n        \"loan\": \"no\",\r\n        \"contact\": \"cellular\",\r\n        \"month\": \"jul\",\r\n        \"duration\": 189,\r\n        \"campaign\": 2,\r\n        \"pdays\": 999,\r\n        \"previous\": 0,\r\n        \"poutcome\": \"nonexistent\",\r\n        \"emp.var.rate\": 1.4,\r\n        \"cons.price.idx\": 93.91799999999999,\r\n        \"cons.conf.idx\": -42.7,\r\n        \"euribor3m\": 4.963,\r\n        \"nr.employed\": 5228.1\r\n      },\r\n      {\r\n        \"age\": 58,\r\n        \"job\": \"retired\",\r\n        \"marital\": \"married\",\r\n        \"education\": \"professional.course\",\r\n        \"default\": \"no\",\r\n        \"housing\": \"yes\",\r\n        \"loan\": \"yes\",\r\n        \"contact\": \"cellular\",\r\n        \"month\": \"jul\",\r\n        \"duration\": 605,\r\n        \"campaign\": 1,\r\n        \"pdays\": 999,\r\n        \"previous\": 0,\r\n        \"poutcome\": \"nonexistent\",\r\n        \"emp.var.rate\": 1.4,\r\n        \"cons.price.idx\": 93.91799999999999,\r\n        \"cons.conf.idx\": -42.7,\r\n        \"euribor3m\": 4.962,\r\n        \"nr.employed\": 5228.1\r\n      },\r\n      {\r\n        \"age\": 48,\r\n        \"job\": \"services\",\r\n        \"marital\": \"married\",\r\n        \"education\": \"high.school\",\r\n        \"default\": \"unknown\",\r\n        \"housing\": \"yes\",\r\n        \"loan\": \"no\",\r\n        \"contact\": \"telephone\",\r\n        \"month\": \"may\",\r\n        \"duration\": 243,\r\n        \"campaign\": 1,\r\n        \"pdays\": 999,\r\n        \"previous\": 0,\r\n        \"poutcome\": \"nonexistent\",\r\n        \"emp.var.rate\": 1.1,\r\n        \"cons.price.idx\": 93.994,\r\n        \"cons.conf.idx\": -36.4,\r\n        \"euribor3m\": 4.856,\r\n        \"nr.employed\": 5191\r\n      }\r\n    ]\r\n  }\r\n}";

                client.BaseAddress = new Uri("http://0c5e7d0c-9af8-43a4-a956-1fa4ff7cfe02.germanywestcentral.azurecontainer.io/score");

                var content = new StringContent(requestBody);
                client.DefaultRequestHeaders.Add("Accept", "application/json");
                content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                // WARNING: The 'await' statement below can result in a deadlock
                // if you are calling this code from the UI thread of an ASP.Net application.
                // One way to address this would be to call ConfigureAwait(false)
                // so that the execution does not attempt to resume on the original context.
                // For instance, replace code such as:
                //      result = await DoSomeTask()
                // with the following:
                //      result = await DoSomeTask().ConfigureAwait(false)
                HttpResponseMessage response = await client.PostAsync("", content);

                if (response.IsSuccessStatusCode) {
                    string result = await response.Content.ReadAsStringAsync();
                    Console.WriteLine("Result: {0}", result);
                } else {
                    Console.WriteLine(string.Format("The request failed with status code: {0}", response.StatusCode));

                    // Print the headers - they include the requert ID and the timestamp,
                    // which are useful for debugging the failure
                    Console.WriteLine(response.Headers.ToString());

                    string responseContent = await response.Content.ReadAsStringAsync();
                    Console.WriteLine(responseContent);
                }
            }
        }
    }
}