
# 🚀 Blazor Dashboard App

An interactive, real-time **Blazor Server** dashboard application with modern **UI/UX** design using **Bootstrap 5**, **CSS**, and **JavaScript**.  
This app showcases essential features like dynamic data tables, weather forecasts, and interactive components like a counter — all within a modular, responsive layout.



## 📦 Tech Stack

| Layer      | Technology                          |
|------------|-------------------------------------|
| Frontend   | Blazor Server (.NET 7/8)            |
| UI Design  | Bootstrap 5, Font Awesome, Custom CSS |
| Backend    | C# with .NET Runtime                |
| Tools      | Visual Studio / VS Code             |

---

## 📁 Project Structure

```
BlazorDashboardApp/
│
├── Pages/
│   ├── Index.razor        # Home page
│   ├── Dashboard.razor    # Dynamic data grid
│   ├── Weather.razor      # Weather updates
│   └── Counter.razor      # Interactive counter
│
├── Services/
│   └── DashboardService.cs # Sample data provider
│
├── wwwroot/
│   ├── css/custom.css
│   └── js/custom.js
│
├── Shared/
│   └── MainLayout.razor
│
├── App.razor
└── Program.cs
```

---

## ✨ Features

- 📊 **Dashboard View** – Display data in styled, hoverable, responsive tables with dynamic badges.
- 🔢 **Counter Page** – A real-time counter with animated buttons and live update.
- 🌦 **Weather Forecast** – Auto-generated weather data simulating real-time updates.
- 💻 **Responsive Design** – Fully mobile-ready UI using Bootstrap grid and components.
- 💡 **Modular Razor Pages** – Clean structure for easy scalability.
- 🌙 **Dark & Light Compatibility** – Use CSS classes for toggling between modes (optional extension).

---

## 🛠️ Getting Started

### 1. Clone the Repository

```bash
git clone https://github.com/your-username/Blazor-Dashboard-App.git
cd Blazor-Dashboard-App
```

### 2. Run the App

```bash
dotnet run
```

Open in browser:  
🌐 `http://localhost:5000` or `https://localhost:5001`

---

## 📚 Resources & References

- [Blazor Docs (Microsoft)](https://learn.microsoft.com/en-us/aspnet/core/blazor/)
- [Bootstrap 5](https://getbootstrap.com/docs/5.3/getting-started/introduction/)
- [Font Awesome Icons](https://fontawesome.com/icons)
- [ASP.NET Core](https://learn.microsoft.com/en-us/aspnet/core/)
- [Blazor Server vs WebAssembly](https://learn.microsoft.com/en-us/aspnet/core/blazor/hosting-models)

---



## 🔧 Custom Styling

- Use `wwwroot/css/custom.css` for your own theming and overrides.
- Use `wwwroot/js/custom.js` to add interactivity like modals, alerts, etc.
- Link them via `_Layout.razor` or inside `index.html` if needed.

---
