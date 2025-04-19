using System.Net.Http;
using System.Net.Http.Json;
using TaskManagerFrontend.Models;

namespace TaskManagerFrontend.Services
{
    public class TaskService
    {
        private readonly HttpClient _httpClient;
        private readonly string apiUrl = "https://localhost:7017/api/tasks"; // fixed API port

        public TaskService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<TaskItemModel>> GetTasksAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<TaskItemModel>>(apiUrl) ?? new List<TaskItemModel>();
        }

        public async Task<TaskItemModel?> GetTaskAsync(int id)
        {
            return await _httpClient.GetFromJsonAsync<TaskItemModel>($"{apiUrl}/{id}");
        }

        public async Task CreateTaskAsync(TaskItemModel task)
        {
            await _httpClient.PostAsJsonAsync(apiUrl, task);
        }

        public async Task UpdateTaskAsync(int id, TaskItemModel task)
        {
            await _httpClient.PutAsJsonAsync($"{apiUrl}/{id}", task);
        }

        public async Task DeleteTaskAsync(int id)
        {
            await _httpClient.DeleteAsync($"{apiUrl}/{id}");
        }
    }
}
