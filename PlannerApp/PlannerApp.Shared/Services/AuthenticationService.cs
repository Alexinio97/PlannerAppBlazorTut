using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AKSoftware.WebApi.Client;
using PlannerApp.Shared.Models;

namespace PlannerApp.Shared.Services
{
    public class AuthenticationService
    {
        private readonly string _baseUrl;

        ServiceClient _client = new ServiceClient();

        public AuthenticationService(string url)
        {
            _baseUrl = url;
        }

        public async Task<UserManagerResponse> RegisterUserAsync(RegisterRequest request)
        {
            try
            {
                var response = await _client.PostAsync<UserManagerResponse>($"{_baseUrl}/api/auth/register", request);
                return response.Result;
            }
            catch(Exception ex)
            {
                Console.WriteLine("Exception caught: " + ex.ToString());
                return null;
            } 
        }

        public async Task<UserManagerResponse> LoginUserAsync(LoginRequest request)
        {
            try
            {
                var response = await _client.PostAsync<UserManagerResponse>($"{_baseUrl}/api/auth/login", request);
                return response.Result;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception caught: " + ex.ToString());
                return null;
            }
        }
    }
}
