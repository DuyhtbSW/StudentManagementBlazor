using StudentManagement.Client.Repository;
using StudentManagement.Shared.Models;
using System.Net.Http.Json;

namespace StudentManagement.Client.Services
{
    public class StudentService : IStudentRepository
    {
        private readonly HttpClient _httpClient;
        public StudentService(HttpClient httpClient) {
            _httpClient = httpClient;
                } 
        public async Task<Student> AddStudentAsync(Student student)
        {
            var newsstudent = await _httpClient.PostAsJsonAsync("api/Student/Add-Student", student);
            var response = await newsstudent.Content.ReadFromJsonAsync<Student>();
            return response;
        }

        public async Task<Student> DeleteStudentAsync(int studentId)
        {
            var deletestudent = await _httpClient.PostAsJsonAsync("api/Student/Delete-Student", studentId);
            var response = await deletestudent.Content.ReadFromJsonAsync<Student>();
            return response;
        }


        public async Task<List<Student>> GetAllStudentsAsync()
        {
            var allstudent = await _httpClient.GetAsync("api/Student/All-Student");
            var response = await allstudent.Content.ReadFromJsonAsync<List<Student>>();
            return response;
        }

        public async Task<Student> GetStudentByIdAsync(int studentId)
        {
            var singletudent = await _httpClient.GetAsync("api/Student/Single-Student");
            var response = await singletudent.Content.ReadFromJsonAsync<Student>();
            return response;
        }

        public async Task<Student> UpdateStudentAsync(Student student)
        {
            var updatestudent = await _httpClient.PostAsJsonAsync("api/Student/Update-Student", student);
            var response = await updatestudent.Content.ReadFromJsonAsync<Student>();
            return response;
        }
    }
}
