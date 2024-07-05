# Game List App

This is my first application built using ASP.NET and C#. It performs full CRUD (Create, Read, Update, Delete) operations, allowing users to manage a list of games.

## Table of Contents

- [Game List App](#game-list-app)
  - [Table of Contents](#table-of-contents)
  - [Overview](#overview)
  - [Features](#features)
  - [Technologies Used](#technologies-used)
  - [Installation](#installation)
  - [Usage](#usage)
  - [Contributing](#contributing)
  - [License](#license)

## Overview

The Game List App is a simple ASP.NET application that allows users to manage a list of games. Users can create, read, update, and delete game entries. This project was developed to practice and demonstrate skills in ASP.NET and C#.

## Features

- Add new games
- View a list of all games
- Update existing game details
- Delete games from the list

## Technologies Used

- ASP.NET Core
- C#
- Entity Framework Core
- SQL Server
- HTML/CSS
- JavaScript

## Installation

To set up the project locally, follow these steps:

1. **Clone the repository:**
    ```bash
    git clone https://github.com/taricov/GameListApp.git
    cd GameListApp
    ```

2. **Set up the database:**
    - Make sure you have SQL Server installed and running.
    - Update the connection string in `appsettings.json` to match your SQL Server configuration.
    - Run the following commands to apply migrations and seed the database:
      ```bash
      dotnet ef database update
      ```

3. **Run the application:**
    ```bash
    dotnet run
    ```

## Usage

Once the application is running, you can access it via your web browser at `http://localhost:5000`. Use the navigation bar to access different features of the app:

- **Add Game:** Add a new game to the list.
- **Game List:** View all games in the list.
- **Edit Game:** Update details of an existing game.
- **Delete Game:** Remove a game from the list.

## Contributing

Contributions are welcome! Please fork this repository and submit pull requests with your changes.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for more details.
