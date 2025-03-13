# 📚 Book Library Management System

## 📝 **About the Project**

This project is an **ASP.NET Core MVC-based library management system** utilizing **SQLite** as its database. The system allows users to **add, edit, delete, preview, and download books**. Books can have **cover images and TXT file links**.

---

### **Project Name:** Book Library Management System  
### **Group Name:** Dimlingane  
### **Team Members:**  
- **Member 1:** Ean Umoralsk support  
- **Member 2:** Stian S. / Programmer  
- **Member 3:** Arvid / Programmer  

### **GitHub Repository Link:** [BookLibraryManagement](https://github.com/ArvidKodehode/BookLibraryManagement)

### **Work Log**
| Date | Hours Worked | Team Member | Task Description |
|------|-------------|-------------|------------------|
| Mar 5, 2025 | 3 hrs | Group discussion | Team leader is Ean, hurra gjeng and organizer |
| Mar 7, 2025 | 2 hrs | All | Self-study |
| Mar 11, 2025 | 2 hrs | All | Self-study |
| Mar 12, 2025 | 4 hrs | All | Assembling the project, control, and finalization |
| Mar 13, 2025 | 2 hrs | Stian S, Arvid | Final touch-ups and submission |

---

# 🚀 **How to Download and Run the Project**

## **1️⃣ Download the Project**
You can either **clone the repository from GitHub** or **download the ZIP file**.

### **Option 1: Clone from GitHub**
Open a terminal or **Git Bash** and run:
```sh
 git clone https://github.com/YOUR-USERNAME/BookLibraryManagement.git
```
Then, navigate to the project folder:
```sh
 cd BookLibraryManagement
```

### **Option 2: Download ZIP File**
1. Go to the GitHub repository: [BookLibraryManagement](https://github.com/ArvidKodehode/BookLibraryManagement)
2. Click **"Code"** → **"Download ZIP"**.
3. Extract the ZIP file to a preferred location.
4. Open the extracted folder in **Visual Studio**.

---

## **2️⃣ Open the Project in Visual Studio**
1. **Open Visual Studio 2022**.
2. Click **"Open a project or solution"**.
3. Locate `BookLibraryManagement.sln` and open it.

---

## **3️⃣ Install Dependencies**
Before running the project, install **NuGet packages**.

### 📦 **Install packages**
Open **Package Manager Console** (`Tools` → `NuGet Package Manager` → `Package Manager Console`) and run:
```powershell
 dotnet restore
```
This will download all necessary dependencies, including **Entity Framework Core** and **SQLite**.

---

## **4️⃣ Check if the Database Exists**
The project uses **SQLite**, and the database should be included in the project folder. To verify:
1. **Navigate to the project folder**.
2. **Check for the file `BookLibrary.db`** in the `Data` folder.

### ❌ **If the database is missing, create it with these commands:**

Open **Package Manager Console** and run:
```powershell
Add-Migration InitialCreate
Update-Database
```
This will **generate the database and create tables**.

---

## **5️⃣ Run the Project** 🚀
Once everything is set up, start the project:
```sh
 dotnet run
```
Or, in **Visual Studio**:
1. Click **"Start" (Ctrl + F5)**.
2. The browser will open, and you will see the **library management system**.

---

# ✅ **Project Features**
- **CRUD functionality** (Add, edit, delete books).
- **Bootstrap 5 design** for a clean and user-friendly UI.
- **SQLite database** for easy data management.
- **Book covers and TXT file handling**.
- **Project Gutenberg as the book source**.

🔗 **Book Source:** [Project Gutenberg](https://www.gutenberg.org/)

---

# 📌 **How to Contribute?**
1. **Fork the project on GitHub**.
2. **Create a new branch** for your changes:
   ```sh
   git checkout -b feature-name
   ```
3. **Make changes and commit**:
   ```sh
   git commit -m "Added new feature"
   ```
4. **Push the changes to GitHub**:
   ```sh
   git push origin feature-name
   ```
5. **Create a Pull Request (PR)** on GitHub.

---

# 🛠 **Troubleshooting**
### 🔴 **Project is not running?**
- Make sure **NuGet packages are installed** (`dotnet restore`).
- Check if **`BookLibrary.db` exists**.
- If the database is missing, run:
  ```powershell
  Update-Database
  ```

### 🔴 **Unable to download books?**
- Verify that `PdfUrl` in the database points to a valid `.txt` file.
- Test a working link, for example:  
  ```
  https://www.gutenberg.org/files/1342/1342-0.txt
  ```

---

# 🏆 **Thank You for Using the Book Library Management System!** 🎉

---

## 📸 **Screenshots**
![Front Page](https://arvja.no/img/Front.jpg)
![Book List](https://arvja.no/img/Liste.jpg)
![Add Book](https://arvja.no/img/Add.jpg)
![Edit Book](https://arvja.no/img/edit.jpg)
