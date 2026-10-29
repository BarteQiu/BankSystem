# 🏦 BankSystem

A simple console-based banking application written in **C#** as a learning project.

🚀 The project is developed step by step alongside my C# learning roadmap, focusing on programming fundamentals, input validation, object-oriented programming, and clean code.

## 📌 Current Version

**v0.5**

## ✨ Features

- 📋 Interactive console menu
- 💰 Display account balances
- ➕ Deposit money
- ➖ Withdraw money
- 🧾 View transaction history
- 📅 Record transaction dates and times
- 🏷️ Distinguish between deposits and withdrawals
- 🛡️ Input validation using `TryParse()`
- 🚫 Reject zero and negative transaction amounts
- 🔒 Prevent withdrawals exceeding the available balance
- ⚠️ Handle invalid menu selections and incorrect input
- 💵 Use `decimal` for monetary values
- 🏦 Manage multiple bank accounts
- 🆔 Assign a unique identifier to each account
- ➕ Create new bank accounts
- 🔍 Search for accounts by ID
- 📑 Display a list of all accounts
- 🔗 Associate transactions with the correct account
- 🔐 Encapsulate account balance using a private field
- 🧱 Initialize accounts using a constructor
- ✅ Validate transactions inside the account class
- 📚 Store transactions in a collection
- 🔄 Separate account logic from console interaction
- 🖥️ Improve the console UI with consistent formatting and colored messages
- 🕒 Display transaction timestamps in a readable format
- 📭 Handle empty transaction histories

## 🛠️ Technologies

- 💻 C#
- 🧩 Visual Studio
- 🌿 Git and GitHub

## 📂 Project Structure

```text
BankSystem/
├── BankSystem/
│   ├── Program.cs
│   ├── BankSystem.cs
│   ├── BankAccount.cs
│   ├── Transaction.cs
│   └── ConsoleUI.cs
└── README.md
```

- `Program.cs` — application entry point and main console menu.
- `BankSystem.cs` — manages accounts, handles user interaction, and displays account and transaction information.
- `BankAccount.cs` — manages individual account balances, deposits, withdrawals, and transaction history.
- `Transaction.cs` — represents a single transaction, including its amount, type, and date.
- `ConsoleUI.cs` — provides reusable methods for formatting console output and displaying messages.

## 💻 Source Code

👉 [View Program.cs on GitHub](https://github.com/BarteQiu/BankSystem/blob/main/BankSystem/Program.cs)

## ▶️ How to Run

1. 📥 Clone or download this repository.
2. 🖥️ Open the project in Visual Studio.
3. ▶️ Build and run the application.
4. 📋 Follow the instructions displayed in the console.

## 🚧 Project Status

The project is under active development.

**Version v0.5** introduces support for multiple bank accounts and improves the console user interface.

Users can create new accounts, each with a unique identifier, search for accounts by ID, and display a list of all existing accounts. Each account maintains its own balance and transaction history, ensuring that deposits, withdrawals, and recorded transactions belong to the correct account.

The console UI has also been improved with reusable methods for displaying headers, success messages, error messages, and informational messages, helping keep the interface more consistent and readable.

The project continues to evolve alongside my C# learning roadmap, with each version introducing new functionality and opportunities to practise programming concepts.

## 🗺️ Planned Improvements

- 🔄 Implement transfers between accounts
- 💾 Save and load account data from files
- 🧪 Add unit tests
- 🧹 Further improve code organization and maintainability

---

⭐ *Built as a hands-on learning project and improved with every version.*
