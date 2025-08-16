# Campaign Dashboard

A full-stack Campaign Dashboard application with a .NET Core Web API backend and an Angular frontend.

## Features

- Campaign listing with expandable campaign item details
- Status badges and summary stats
- Angular Material UI
- Sample data and proxy setup for local development

## Getting Started

### Prerequisites

- [.NET 6 SDK](https://dotnet.microsoft.com/download)
- [Node.js (LTS)](https://nodejs.org/)
- [Angular CLI](https://angular.io/cli)

---

### Backend (.NET Core API)

1. From the `backend` directory:
    ```sh
    dotnet restore
    dotnet run
    ```
   The API runs at `https://localhost:5001`.

---

### Frontend (Angular)

1. From the `frontend` directory:
    ```sh
    npm install
    npm start
    ```
   The app runs at [http://localhost:4200](http://localhost:4200) and proxies `/api` calls to the backend.

---

### Customization

- Add more endpoints, authentication, or connect a real DB as needed!