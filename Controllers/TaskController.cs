using Microsoft.AspNetCore.Mvc;
using TaskManagerFrontend.Models;
using TaskManagerFrontend.Services;

namespace TaskManagerFrontend.Controllers
{
    public class TaskController : Controller
    {
        private readonly TaskService _taskService;

        public TaskController(TaskService taskService)
        {
            _taskService = taskService;
        }

        // List all tasks
        public async Task<IActionResult> Index()
        {
            var tasks = await _taskService.GetTasksAsync();
            return View(tasks);
        }

        // View task details
        public async Task<IActionResult> Details(int id)
        {
            var task = await _taskService.GetTaskAsync(id);
            return task == null ? NotFound() : View(task);
        }

        // GET: Create form
        public IActionResult Create()
        {
            return View();
        }

        // POST: Create task
        [HttpPost]
        public async Task<IActionResult> Create(TaskItemModel task)
        {
            if (!ModelState.IsValid) return View(task);

            await _taskService.CreateTaskAsync(task);
            return RedirectToAction(nameof(Index));
        }

        // GET: Edit form
        public async Task<IActionResult> Edit(int id)
        {
            var task = await _taskService.GetTaskAsync(id);
            return task == null ? NotFound() : View(task);
        }

        // POST: Update task
        [HttpPost]
        public async Task<IActionResult> Edit(int id, TaskItemModel task)
        {
            if (id != task.Id || !ModelState.IsValid) return View(task);

            await _taskService.UpdateTaskAsync(id, task);
            return RedirectToAction(nameof(Index));
        }

        // GET: Delete confirmation page
        public async Task<IActionResult> Delete(int id)
        {
            var task = await _taskService.GetTaskAsync(id);
            return task == null ? NotFound() : View(task);
        }

        // POST: Confirm delete
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _taskService.DeleteTaskAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
