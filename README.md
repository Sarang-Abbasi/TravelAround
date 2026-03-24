# 🗺️ TravelAround

A **C# Windows Forms** desktop application for planning and managing UK travel routes. Users can register, log in, create routes between cities, add stops, and save their journeys — with full accessibility support including font scaling and high-contrast mode.

---

<img width="287" height="402" alt="Picture1" src="https://github.com/user-attachments/assets/d5cac091-e287-4325-b2e8-ee77a17d8fc6" />

<img width="287" height="386" alt="Picture2" src="https://github.com/user-attachments/assets/18997755-6d32-44c3-b4a4-9bafa5850353" />

<img width="288" height="322" alt="Picture3" src="https://github.com/user-attachments/assets/409d5e78-e147-4cb0-afb4-755f55b5ecc7" />

<img width="334" height="410" alt="Picture4" src="https://github.com/user-attachments/assets/e4139704-1c98-4cb7-b1a2-0d5a885a124f" />

<img width="234" height="381" alt="Picture5" src="https://github.com/user-attachments/assets/68725f25-4864-4fba-b8dd-1572db3e64ad" />

<img width="336" height="336" alt="Picture6" src="https://github.com/user-attachments/assets/b15231e8-6c75-4a0f-b070-94caffdc3b1f" />

<img width="465" height="397" alt="Picture7" src="https://github.com/user-attachments/assets/0a6c6179-2116-4775-8e55-714caabbee95" />

<img width="196" height="266" alt="Picture8" src="https://github.com/user-attachments/assets/562f33b2-fa99-40e9-8a99-94ab4c5338fe" />

---

## ✨ Features

- 🔐 **User authentication** — secure registration and login with SHA-256 password hashing
- 🗺️ **Route planning** — two modes:
  - **Default Cities** — choose from predefined UK cities with automatic distance lookup
  - **Custom Route** — enter any location and distance manually
- 🚏 **Multi-stop routes** — add intermediate stops with automatic detour distance calculation
- 🚗 **Transport types** — Car, Train, Bus, Bike, Walk, Plane (each with accurate speed)
- 💾 **Save & manage routes** — view, edit, and delete saved journeys
- 🎨 **Card view** — visually styled route cards with rounded borders
- ♿ **Accessibility** — font size scaling (5 levels) and high-contrast dark mode
- 🏙️ **UK city database** — preloaded with cities and road distances

---

## 🛠️ Tech Stack

| Component | Detail |
|-----------|--------|
| Language | C# (.NET Framework 4.7.2) |
| UI Framework | Windows Forms (WinForms) |
| Database | MySQL |
| ORM / Data Access | MySql.Data 9.6.0 (ADO.NET) |
| IDE | Visual Studio 2022 |
| Password Security | SHA-256 (System.Security.Cryptography) |

---

## 📋 Prerequisites

Before running the project, make sure you have:

- [Visual Studio 2022](https://visualstudio.microsoft.com/) with **.NET desktop development** workload
- [MySQL Server 8.0+](https://dev.mysql.com/downloads/mysql/)
- [MySQL Workbench](https://dev.mysql.com/downloads/workbench/) _(optional but recommended)_
- .NET Framework 4.7.2 (included with Windows 10/11)

---

## ⚙️ Database Setup

### 1. Create the database

Run this SQL in MySQL Workbench or your MySQL client:

```sql
CREATE DATABASE travelaround;
USE travelaround;
```

### 2. Create the tables

```sql
-- Users
CREATE TABLE tblUsers (
    userID       INT          AUTO_INCREMENT PRIMARY KEY,
    userName     VARCHAR(100) NOT NULL UNIQUE,
    userEmail    VARCHAR(200) NOT NULL UNIQUE,
    userPassword VARCHAR(64)  NOT NULL
);

-- Transport types
CREATE TABLE tblTransport (
    transportID   INT          AUTO_INCREMENT PRIMARY KEY,
    transportType VARCHAR(50)  NOT NULL
);

-- Routes
CREATE TABLE tblroutes (
    routeID        INT            AUTO_INCREMENT PRIMARY KEY,
    userID         INT            NOT NULL,
    startLocation  VARCHAR(200)   NOT NULL,
    endLocation    VARCHAR(200)   NOT NULL,
    stopLocations  VARCHAR(1000),
    routeDistance  DECIMAL(10,2)  NOT NULL,
    routeTime      DECIMAL(10,4)  NOT NULL,
    transportID    INT            NOT NULL,
    FOREIGN KEY (userID)      REFERENCES tblUsers(userID),
    FOREIGN KEY (transportID) REFERENCES tblTransport(transportID)
);

-- Saved routes (user's saved list)
CREATE TABLE tblsavedroutes (
    savedRouteID INT          AUTO_INCREMENT PRIMARY KEY,
    userID       INT          NOT NULL,
    routeID      INT          NOT NULL,
    savedName    VARCHAR(300),
    FOREIGN KEY (userID)  REFERENCES tblUsers(userID),
    FOREIGN KEY (routeID) REFERENCES tblroutes(routeID)
);

-- Predefined UK cities
CREATE TABLE tblCities (
    cityID   INT          AUTO_INCREMENT PRIMARY KEY,
    cityName VARCHAR(100) NOT NULL UNIQUE
);

-- City-to-city road distances
CREATE TABLE tblCityDistances (
    distanceID  INT            AUTO_INCREMENT PRIMARY KEY,
    cityA       VARCHAR(100)   NOT NULL,
    cityB       VARCHAR(100)   NOT NULL,
    distanceKm  DECIMAL(10,2)  NOT NULL
);

-- Accessibility settings per user
CREATE TABLE tblAccessibility (
    accessID     INT     AUTO_INCREMENT PRIMARY KEY,
    userID       INT     NOT NULL UNIQUE,
    fontSize     INT     NOT NULL DEFAULT 3,
    highContrast TINYINT NOT NULL DEFAULT 0,
    FOREIGN KEY (userID) REFERENCES tblUsers(userID)
);
```

### 3. Seed transport types

```sql
INSERT INTO tblTransport (transportType) VALUES
('Car'), ('Train'), ('Bus'), ('Bike'), ('Walk'), ('Plane');
```

### 4. Seed UK cities _(add your own or import a CSV)_

```sql
INSERT INTO tblCities (cityName) VALUES
('London'), ('Birmingham'), ('Manchester'), ('Leeds'), ('Sheffield'),
('Liverpool'), ('Bristol'), ('Newcastle'), ('Cardiff'), ('Edinburgh'),
('Glasgow'), ('Nottingham'), ('Leicester'), ('Coventry'), ('Brighton');
-- Add more cities and corresponding distances in tblCityDistances
```

---

## 🔧 Configuration

Open `db.cs` and update the connection string to match your MySQL setup:

```csharp
private static string cs = "server=localhost;database=travelaround;uid=root;pwd=YOUR_PASSWORD;";
```

> ⚠️ **Never commit your real password to GitHub.** See the [Security](#-security) section below.

---

## 🚀 Running the Project

1. Clone the repository:
   ```bash
   git clone https://github.com/YOUR_USERNAME/TravelAround.git
   ```

2. Open `TravelAround.slnx` in Visual Studio 2022

3. Restore NuGet packages:
   - Right-click the solution → **Restore NuGet Packages**

4. Update `db.cs` with your database credentials

5. Run the database setup SQL (see above)

6. Press **F5** or click **Start** to run

---

## 📁 Project Structure

```
TravelAround/
│
├── Program.cs                  # Entry point
├── db.cs                       # Database connection helper
│
├── Models/
│   ├── Route.cs                # Route data model
│   ├── Transport.cs            # Transport type model
│   └── AppSettings.cs          # Accessibility settings model
│
├── Data/
│   ├── RouteStorage.cs         # All route database operations
│   └── SettingsStorage.cs      # Settings database operations
│
├── Forms/
│   ├── FrmLogin.cs             # Login form
│   ├── FrmSignup.cs            # Registration form
│   ├── MainMenu.cs             # Main navigation menu
│   ├── Routes.cs               # Routes hub
│   ├── FrmCreateRoute.cs       # Create / edit route
│   ├── FrmEditSavedRoute.cs    # Edit saved routes (grid)
│   ├── FrmSavedRoutes.cs       # View saved routes (cards)
│   └── FrmSettings.cs          # Accessibility settings
│
├── Utilities/
│   ├── PasswordHelper.cs       # SHA-256 password hashing
│   └── UITheme.cs              # Application-wide colour theme engine
│
└── Properties/
    └── AssemblyInfo.cs
```

---

## 🔒 Security

- Passwords are hashed with **SHA-256** before storage — never stored in plain text
- All database queries use **parameterised inputs** to prevent SQL injection
- The connection string in `db.cs` contains a password — **do not push it to a public repo without removing it first**

To keep credentials safe, consider using an environment variable or `App.config` with `.gitignore`:

```bash
# Add to .gitignore
db.cs
App.config
```

Or replace the hardcoded string with:
```csharp
private static string cs = Environment.GetEnvironmentVariable("TRAVELAROUND_DB") ?? "fallback";
```

---

## 🤝 Contributing

1. Fork the repository
2. Create a feature branch: `git checkout -b feature/your-feature`
3. Commit your changes: `git commit -m "Add your feature"`
4. Push the branch: `git push origin feature/your-feature`
5. Open a Pull Request

---

## 📄 License

This project is licensed under the **MIT License** — see the [LICENSE](LICENSE) file for details.

---

## 👤 Author

**Sarang Abbasi**

Available for freelance projects — [Connect on LinkedIn](https://www.linkedin.com/in/sarang-abbasi-6a7a30232)

---

> Built as part of a coursework project — C# WinForms with MySQL backend.
