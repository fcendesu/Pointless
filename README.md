# Pointless App

Pointless App is a simple C# Windows Forms application that allows users to perform various computer operations such as shutdown, restart, sleep, sign off, or lock instantly or with a specified countdown timer. The application provides a user-friendly interface for quick access to these actions.

## Features

- **Instant Actions:** Perform instant shutdown, restart, sleep, sign off, or lock with a click of a button.
- **Countdown Timer:** Set a countdown timer to delay the execution of the chosen action.
- **Lock Computer:** Utilizes `ntDll` to lock the computer instantly or with a timer.

## Getting Started

1. Clone the repository to your local machine.
2. Open the project in Visual Studio or your preferred C# development environment.
3. Build and run the application.

## Usage

1. Launch the Pointless App.
2. Use the buttons to perform instant actions (shutdown, restart, sleep, sign off, or lock).
3. Optionally, enable the countdown timer feature:
    - Check the "Etkinleştir" (Enable) checkbox.
    - Specify the desired time in minutes.
    - Click the "Aktif Et" (Activate) button to start the countdown.
4. To stop the countdown or clear the timer, use the respective buttons provided.

## Dependencies

- The application uses `System.Windows.Forms` for GUI components and interactions.
- The `ntDll` class is used for locking the computer.

## Contributing

If you'd like to contribute to Pointless App, please follow these steps:

1. Fork the repository.
2. Create a new branch for your feature or bug fix.
3. Make your changes and submit a pull request.

