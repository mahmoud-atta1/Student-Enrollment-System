<div align="center">

# 🎓 Student Enrollment System

### A comprehensive student enrollment management system developed in C#

**CS 211 - File Processing Course Project**

---

[![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![.NET](https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)](https://dotnet.microsoft.com/)
[![License](https://img.shields.io/badge/License-MIT-green.svg?style=for-the-badge)](LICENSE)

</div>

---

## 📋 Overview

## 📑 Table of Contents

- [Overview](#-overview)
- [Key Features](#-key-features)
- [Technologies Used](#️-technologies-used)
- [Project Structure](#-project-structure)
- [Requirements](#️-requirements)
- [Installation and Setup](#-installation-and-setup)
- [Usage](#-usage)
- [File Processing Techniques](#-file-processing-techniques)
- [Applied Concepts](#-applied-concepts-from-file-processing-course)
- [Developer](#-developer)

---

This project is a complete student enrollment management system that utilizes file processing techniques in C#. The system provides an efficient interface for managing student data, courses, and enrollment operations with persistent data storage using file-based systems.

## ✨ Key Features

- 👥 **Student Management**: Add, edit, delete, and search for student information
- 📚 **Course Management**: Create and manage available academic courses
- ✅ **Enrollment Operations**: Register students in courses with automatic prerequisite validation
- 💾 **File Processing**: Store and retrieve data using various file processing techniques
- 📊 **Reports**: Display student records and enrolled courses

## 🛠️ Technologies Used

- **Programming Language**: C#
- **Framework**: .NET Framework
- **Data Storage**: File-based storage (CSV, Text Files, Binary Files)

## 📁 Project Structure

```
Student-Enrollment-System/
│
├── project file/
│   ├── Student.cs                  # Student class
│   ├── Course.cs                   # Course class
│   ├── Enrollment.cs               # Enrollment class
│   ├── FileManager.cs              # File operations manager
│   ├── Program.cs                  # Entry point
│   └── Data/                       # Data files
│
└── README.md
```

## ⚙️ Requirements

- .NET Framework 4.7.2 or later
- Visual Studio 2019 or later (optional)

## 🚀 Installation and Setup

1. **Clone the Repository**
   ```bash
   git clone https://github.com/mahmoud-atta1/Student-Enrollment-System.git
   ```

2. **Open the Project**
   - Open the `project file` folder in Visual Studio
   - Or use command line to build and run

3. **Run the Application**
   ```bash
   cd "project file"
   dotnet run
   ```

## 💻 Usage

### Adding a New Student
Select the appropriate function from the main menu and enter the required information:
- Student ID
- Full Name
- Major
- Academic Level

### Enrolling a Student in a Course
- Select the student from the list
- Choose the desired course
- The system automatically validates prerequisites

### Viewing Reports
- Display specific student records
- View course listings
- Display enrollment statistics

## 📂 File Processing Techniques

The system implements multiple file processing techniques:

- **Sequential Files**: For sequential reading and writing of data
- **Random Access Files**: For fast data access
- **Binary Files**: For efficient data storage
- **Text Files**: For easy reading and maintenance

## 🎯 Applied Concepts from File Processing Course

- File Streams
- Sequential vs Random Access
- Binary vs Text Files
- File Pointers and Seeking
- Error Handling in File Operations
- Data Persistence
- File Buffering

## 🤝 Contributing

This project was developed as an academic project for CS 211 course. For inquiries or suggestions, feel free to open an issue on GitHub.

## 📜 License

This project is open source and available for educational use.

## 👨‍💻 Developer

**Mahmoud Atta**

[![GitHub](https://img.shields.io/badge/GitHub-100000?style=for-the-badge&logo=github&logoColor=white)](https://github.com/mahmoud-atta1)

---

<div align="center">

**Note**: This project was developed as part of CS 211 - File Processing course requirements

Made with ❤️ by Mahmoud Atta

</div>
