# 🏥 Hospital Appointment Booking System

A web-based **Hospital Appointment Booking System** developed using **ASP.NET Core MVC** that allows patients to easily schedule appointments with doctors, manage bookings, and streamline hospital scheduling.

The system provides a simple and efficient interface for both patients and administrators to manage appointments digitally.

---

## 📌 Features

* 👩‍⚕️ Patient registration and login
* 🔐 Secure authentication using ASP.NET Identity
* 📅 Book appointments with available doctors
* ❌ Cancel or manage appointments
* 🧑‍💼 Admin management for doctors and schedules
* 📊 Organized database structure for hospital data
* 💻 Responsive and user-friendly interface

---

## 🛠 Tech Stack

**Frontend**

* HTML
* CSS
* JavaScript
* Razor Views

**Backend**

* ASP.NET Core MVC
* C#

**Database**

* SQL Server
* Entity Framework Core

**Authentication**

* ASP.NET Core Identity

---

## 📂 Project Structure

```
Hospital Appointment Booking System
│
├── Areas/Identity          # Authentication and user management
├── Controllers             # Application logic and request handling
├── Models                  # Data models and database entities
├── Views                   # Razor views (UI pages)
├── wwwroot                 # Static files (CSS, JS, images)
├── Properties              # Project configuration files
│
├── Program.cs              # Application entry point
├── appsettings.json        # Configuration settings
├── appsettings.Development.json
├── ResilienceLifescapeHospital.csproj
└── ScaffoldingReadMe.txt
```

---

## ⚙️ Installation & Setup

### 1️⃣ Clone the Repository

```bash
git clone https://github.com/yourusername/hospital-appointment-booking-system.git
```

### 2️⃣ Open the Project

Open the project using:

* **Visual Studio 2022 or later**

---

### 3️⃣ Configure Database

Update the **connection string** inside:

```
appsettings.json
```

Example:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=.;Database=HospitalDB;Trusted_Connection=True;"
}
```

---

### 4️⃣ Apply Migrations

Run the following commands in **Package Manager Console**:

```
Add-Migration InitialCreate
Update-Database
```

---

### 5️⃣ Run the Application

Press:

```
Ctrl + F5
```

or run using:

```
dotnet run
```

The application will start on:

```
https://localhost:xxxx
```

---

## 👩‍💻 Usage

1. Register as a new patient.
2. Login to the system.
3. View available doctors.
4. Book an appointment.
5. Manage or cancel appointments.

Admins can manage doctors, schedules, and appointments.

---

## 📸 Screenshots

(Add screenshots of your application here)

Example:

```
Login Page
Appointment Booking Page
Admin Dashboard
```

---

## 🚀 Future Improvements

* Online payment integration
* Doctor availability calendar
* Email/SMS appointment reminders
* Patient medical records management
* Mobile-friendly interface

---

## 👩‍🎓 Author

**Drashti Sojitra**
Engineering Student – Computer Science
Adani University

GitHub: https://github.com/drashtisojitra2411

---

## 📄 License

This project is developed for **educational purposes**.
