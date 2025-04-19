# 🗂️ Task Manager Frontend

This is the frontend MVC application for the Task Manager system built with **ASP.NET Core MVC (Razor Views)**. It allows users (such as HMCTS caseworkers) to create, view, update, and delete tasks through a clean, user-friendly interface.

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

---

## 🛠 Tech Stack

- **ASP.NET Core MVC**
- **Razor Pages**
- **HttpClient** for consuming APIs
- **Bootstrap** (for UI styling)
- **Entity Framework Core** (used in the API backend)

---

## 🚀 How to Run the Project

### ✅ Prerequisites

Make sure you have the following installed:

- [Visual Studio 2022+](https://visualstudio.microsoft.com/)
- [.NET 6 SDK or newer](https://dotnet.microsoft.com/en-us/download)
- The **TaskManagerApi** backend project (see its README/setup first)

---

### 1. Clone Both Repositories

```bash
git clone https://github.com/your-username/TaskManagerApi.git
git clone https://github.com/your-username/TaskManagerFrontend.git
