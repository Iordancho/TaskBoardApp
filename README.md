# TaskBoardApp

## Overview
TaskBoardApp is a task management web application that allows users to create, organize, and track tasks efficiently. It offers a clean and intuitive interface for managing personal or team tasks across multiple boards.

## Key Features

### For Employees
- **Task Creation and Management**: Add new tasks, set due dates, assign priority levels, and update the status of each task.
- **Multiple Task Boards**: Organize tasks into separate boards for different projects or categories.
- **Task Assignment**: Assign tasks to different team members and track the progress of each task.
- **Task Filtering**: Filter tasks by priority, due date, and status for easy navigation.

### For Users
- **User Authentication**: Register and log in to manage tasks specific to your account.
- **Progress Tracking**: Monitor the completion status of tasks to ensure deadlines are met.
- **Customizable Views**: Switch between different views to see tasks in a list or board format.

## Technical Details
This application is built using the following technologies:
- **ASP.NET Core**: For handling server-side logic, routing, and backend functionality.
- **Razor Pages**: For rendering dynamic views and connecting front-end logic with back-end data.
- **Entity Framework Core**: Used as the Object-Relational Mapper (ORM) to manage database interactions and persistence of data.
- **SQL Server**: A relational database for storing user information, tasks, and board data.
- **Identity Framework**: Manages user authentication, authorization, and session security using JWT (JSON Web Tokens).
- **Bootstrap**: For creating a responsive, mobile-friendly user interface with minimal effort.
- **REST API**: The application follows RESTful principles to handle tasks, boards, and user-related operations.
