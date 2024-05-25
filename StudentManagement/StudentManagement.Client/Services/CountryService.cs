using StudentManagement.Client.Repository;
using StudentManagement.Shared.Models;
using System.Net.Http.Json;

namespace StudentManagement.Client.Services
{
    public class CountryService : ICountryRepository
    {
        private readonly HttpClient _httpClient;
        public CountryService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<Country> AddAsync(Country mod)
        {
            var data = await _httpClient.PostAsJsonAsync("api/Country/Add-Countries", mod);
            var response = await data.Content.ReadFromJsonAsync<Country>();
            return response;
        }

        public async Task<Country> DeleteAsync(int Id)
        {

            var deletecountry = await _httpClient.PostAsJsonAsync("api/Country/Delete-Countries", Id);
            var response = await deletecountry.Content.ReadFromJsonAsync<Country>();
            return response;
        }

        public async Task<List<Country>> GetAllAsync()
        {
            var data = await _httpClient.GetAsync("api/Country/All-Countries");
            var response = await data.Content.ReadFromJsonAsync<List<Country>>();
            return response;
        }

        public async Task<Country> GetByIdAsync(int Id)
        {
            var data = await _httpClient.GetAsync($"api/Country/Single-Country/{Id}");
            var response = await data.Content.ReadFromJsonAsync<Country>();
            return response;
        }

        public async Task<Country> UpdateAsync(Country mod)
        {
            var data = await _httpClient.PostAsJsonAsync("api/Country/Update-Countries", mod);
            var response = await data.Content.ReadFromJsonAsync<Country>();
            return response;
        }
    }
}
