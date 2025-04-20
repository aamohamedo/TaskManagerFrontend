# 🗂️ Task Manager Frontend

This is the frontend MVC application for the Task Manager system built with **ASP.NET Core MVC (Razor Views)**. It allows users to create, view, update, and delete tasks through a clean, user-friendly interface. The project also includes comprehensive **unit testing** using **xUnit** and **Moq**, and has been built with a focus on validation, error handling, and clean separation of concerns.

> ⚠️ **Note:** This frontend is designed to connect to a separate backend API project (`TaskManagerApi`). You **must run the API project first** before launching the frontend to enable all features to work correctly.

---

## 📋 Features

✅ View a list of tasks  
✅ Create a new task  
✅ Edit existing tasks  
✅ View task details  
✅ Delete tasks with confirmation  
✅ Color-coded status badges  
✅ Formatted, readable due date display  
✅ Responsive and styled UI using Bootstrap  
✅ Frontend unit tests using **xUnit** and **Moq**  
✅ Validation and error handling  
✅ API service abstraction layer for clean HTTP integration

---

## 🧪 Unit Testing

Unit tests were created for the service layer to test API methods such as:
- `GetTasksAsync`
- `GetTaskAsync(int id)`
- `CreateTaskAsync(TaskItemModel task)`

Mocked HTTP responses using **Moq** and **HttpMessageHandler** to isolate service logic and verify behavior.

---

## 🛠 Tech Stack

- **ASP.NET Core MVC**
- **Razor Pages**
- **HttpClient** for consuming APIs
- **Bootstrap** (for UI styling)
- **Entity Framework Core** (used in the API backend)
- **xUnit** and **Moq** for unit testing

---

## 🚀 How to Run the Project

### ✅ Prerequisites

Make sure you have the following installed:

- [Visual Studio 2022+](https://visualstudio.microsoft.com/)
- [.NET 6 SDK or newer](https://dotnet.microsoft.com/en-us/download)
- The **TaskManagerApiNew** backend project (see its README)

---

### 1. Clone Both Repositories

```bash
git clone https://github.com/aamohamedo/TaskManagerApiNew.git
git clone https://github.com/aamohamedo/TaskManagerFrontend.git
```

---

### 2. Run the Backend API

Navigate to the TaskManagerApiNew project in Visual Studio and run it. It will start on a localhost port like `https://localhost:7017`.

Make sure Swagger loads and endpoints are accessible before starting the frontend.

---

### 3. Run the Frontend MVC App

Open `TaskManagerFrontend` in Visual Studio and ensure the API URL in your TaskService matches the backend port.

Then run the project. The app will start and allow you to interact with tasks via the API.

---

## 📦 Future Improvements

- Refactor and clean up code for improved maintainability
- Add task filtering and sorting
- Introduce client-side validation and error messages
- Expand unit tests to cover controller logic
- Enhance design and responsiveness further
- Implement authentication (optional stretch goal)
