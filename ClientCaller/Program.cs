using PagerDuty.ApiClient.Api;
using PagerDuty.ApiClient.Client;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ClientCaller
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            string accept = "application/vnd.pagerduty+json;version=2";
            string contentType = "application/json";
            string authorization = "Token token=y_NbAkKc66ryYTWUXYEu";

            Configuration config = new Configuration()
            {
                ApiKey = new Dictionary<string, string>()
                {
                    {"Authorization", "Token token=y_NbAkKc66ryYTWUXYEu" }
                },
                BasePath = "https://api.pagerduty.com",
            };


            //await AbilitiesExample(accept, contentType, authorization);
            //await DashboardStatus(accept, config);
            //Ruleset(accept, contentType, authorization);

            Users(accept, contentType, authorization);
        }

        private static void Users(string accept, string contentType, string authorization)
        {
            UsersApi rules = new UsersApi();
            var data = rules.ListUsersWithHttpInfo(accept, contentType, authorization);

            Console.WriteLine("HTTP info");
            Console.WriteLine($"Status code = {data.StatusCode}");
            Console.WriteLine("Headers:");
            foreach (var header in data.Headers)
            {
                Console.WriteLine($"{header.Key}={header.Value}");
            }

            Console.WriteLine(data.Data);
            Console.ReadLine();
        }

        private static void Priorities(string accept, string contentType, string authorization)
        {
            PrioritiesApi rules = new PrioritiesApi();
            var data = rules.ListPrioritiesWithHttpInfo(accept, contentType, authorization);

            Console.WriteLine("HTTP info");
            Console.WriteLine($"Status code = {data.StatusCode}");
            Console.WriteLine("Headers:");
            foreach (var header in data.Headers)
            {
                Console.WriteLine($"{header.Key}={header.Value}");
            }

            Console.WriteLine(data.Data);
            Console.ReadLine();
        }

        private static void Ruleset(string accept, string contentType, string authorization)
        {
            RulesetsApi rules = new RulesetsApi();
            var data = rules.ListRulesetsWithHttpInfo(accept, contentType, authorization);

            Console.WriteLine("HTTP info");
            Console.WriteLine($"Status code = {data.StatusCode}");
            Console.WriteLine("Headers:");
            foreach (var header in data.Headers)
            {
                Console.WriteLine($"{header.Key}={header.Value}");
            }

            Console.WriteLine(data.Data);
            Console.ReadLine();
        }

        private static async Task DashboardStatus(string accept, Configuration config)
        {
            StatusDashboardsApi dash = new StatusDashboardsApi(config);

            var data = await dash.ListStatusDashboardsAsyncWithHttpInfo(accept, "status-dashboards");
            Console.WriteLine("HTTP info");
            Console.WriteLine($"Status code = {data.StatusCode}");
            Console.WriteLine("Headers:");
            foreach (var header in data.Headers)
            {
                Console.WriteLine($"{header.Key}={header.Value}");
            }

            Console.WriteLine(data.Data);
            Console.ReadLine();
        }

        private static async Task AbilitiesExample(string accept, string contentType, string authorization)
        {
            AbilitiesApi abilities = new AbilitiesApi();

            var response = abilities.ListAbilities(accept, contentType, authorization);

            Console.WriteLine("Sync response");
            Console.WriteLine(response);

            Console.ReadLine();

            response = await abilities.ListAbilitiesAsync(accept, contentType, authorization);

            Console.WriteLine("Async response");
            Console.WriteLine(response);

            Console.ReadLine();

            var data = abilities.ListAbilitiesWithHttpInfo(accept, contentType, authorization);

            Console.WriteLine("HTTP info");
            Console.WriteLine($"Status code = {data.StatusCode}");
            Console.WriteLine("Headers:");
            foreach (var header in data.Headers)
            {
                Console.WriteLine($"{header.Key}={header.Value}");
            }
            Console.ReadLine();
        }
    }
}
