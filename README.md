# 🏥 Blood Bank Management System
![C#](https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=c-sharp&logoColor=white) ![.NET Framework](https://img.shields.io/badge/.NET%20Framework-512BD4?style=for-the-badge&logo=dotnet&logoColor=white) ![Visual Studio](https://img.shields.io/badge/Visual%20Studio-5C2D91?style=for-the-badge&logo=visual-studio&logoColor=white) ![SQL Server](https://img.shields.io/badge/SQL%20Server-CC2927?style=for-the-badge&logo=microsoft-sql-server&logoColor=white) ![Windows Forms](https://img.shields.io/badge/UI-Windows_Forms-blue?style=for-the-badge) ![Blood Bank](https://img.shields.io/badge/Life_Saver-Blood_Bank-red?style=for-the-badge&logo=unicef)

A comprehensive Desktop Application designed for managing blood bank operations efficiently. This system handles donor records, manages blood stock levels, and provides advanced search capabilities. Built with **C# (.NET Framework)** and **Microsoft SQL Server**.

---

## 🚀 Key Modules & Features

The application is structured into several functional modules for a seamless user experience:

### 🔐 Authentication & Navigation
* **Login Page:** Secure entry for authorized administrators.
* **Dashboard:** A central hub to navigate through all system features.
* **Logout:** Safely exit the application.

### 🩸 Donor Management
* **Add Donor:** Interface to register new blood donors with detailed data.
* **Update Donor:** Modify and maintain existing donor profiles.
* **Delete Donor:** Remove donor records from the database.
* **All Donors:** A complete list view of all registered donors.

### 🔍 Advanced Search
* **Search Blood Donor Address:** Find donors based on specific locations.
* **Search Blood Group:** Filter donors by their respective blood types.

### 📊 Inventory (Stock) Management
* **Stock Increase:** Add blood units to the existing inventory.
* **Stock Decrease:** Subtract units from the inventory during distributions.
* **All Stock Details:** View real-time availability across all blood groups.

---

## 📸 System Interface Preview

<table style="width: 100%; border-collapse: collapse; border: none;">
  <tr>
    <td style="width: 50%; text-align: center; vertical-align: top; padding: 10px;">
      <b>🔐 Secure Login Page</b><br><br>
      <img src="https://github.com/user-attachments/assets/273a735c-57b8-4ef9-883c-e5cfadc880d6" width="100%" style="border-radius: 8px; border: 1px solid #ddd;" alt="Login Page">
    </td>
    <td style="width: 50%; text-align: center; vertical-align: top; padding: 10px;">
      <b>🏠 Admin Dashboard</b><br><br>
      <img src="https://github.com/user-attachments/assets/95be3434-d038-4a0b-8253-992a5cd5569d" width="100%" style="border-radius: 8px; border: 1px solid #ddd;" alt="Dashboard">
    </td>
  </tr>
  
  <tr>
    <td style="width: 50%; text-align: center; vertical-align: top; padding: 10px;">
      <b>🩸 Add New Donor</b><br><br>
      <img src="https://github.com/user-attachments/assets/d88b56d5-7e52-4d0a-8994-dfd288812c1b" width="100%" style="border-radius: 8px; border: 1px solid #ddd;" alt="Add Donor">
    </td>
    <td style="width: 50%; text-align: center; vertical-align: top; padding: 10px;">
      <b>🔍 Search by Address</b><br><br>
      <img src="https://github.com/user-attachments/assets/c142ce24-8b22-4ade-aef2-6929ac72f6c3" width="100%" style="border-radius: 8px; border: 1px solid #ddd;" alt="Search Address">
    </td>
  </tr>

  <tr>
    <td style="width: 50%; text-align: center; vertical-align: top; padding: 10px;">
      <b>📊 Stock Inventory (Increase)</b><br><br>
      <img src="https://github.com/user-attachments/assets/351a0052-ae99-4fbc-a233-b9e2b332d727" width="100%" style="border-radius: 8px; border: 1px solid #ddd;" alt="Stock Management">
    </td>
    <td style="width: 50%; text-align: center; vertical-align: top; padding: 10px;">
      <b>❌ Delete Records</b><br><br>
      <img src="https://github.com/user-attachments/assets/b80b9d27-d855-45d6-b9cf-b3c218747502" width="100%" style="border-radius: 8px; border: 1px solid #ddd;" alt="Delete Donor">
    </td>
  </tr>
</table>

---

## 🛠️ Technical Stack
* **Language:** C#
* **Framework:** .NET Framework (Windows Forms)
* **Database:** Microsoft SQL Server
* **Architecture:** Structured SQL database connectivity with a dedicated data-access class.

## ⚙️ How to Run
1. Ensure **Visual Studio 2022** and **SQL Server** are installed.
2. Clone the repository or download the source code.
3. Open `BloodProject.slnx` in Visual Studio.
4. Update the connection string in `function.cs` to match your SQL Server settings.
5. Press **F5** to build and run the application.

---

## 👤 Author
**Kaung Htet Zaw**
* Aspiring Software Engineer
