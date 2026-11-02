# 🏦 BankSystem

A simple console-based banking application written in **C#** as a learning project.

🚀 The project is developed step by step alongside my C# learning roadmap, focusing on programming fundamentals, input validation, object-oriented programming, error handling, and automated testing.

## 📌 Current Version

**v0.7**

## ✨ Features

- 📋 Interactive console menu
- 💰 Display account balances
- ➕ Deposit money
- ➖ Withdraw money
- 🔄 Transfer money between accounts
- 🧾 View transaction history
- 📥 Track incoming transfers
- 📤 Track outgoing transfers
- 🔎 Filter transaction history by transaction type
- 📅 Record transaction dates and times
- 🏷️ Distinguish between deposits, withdrawals, and transfers
- 🛡️ Input validation using `TryParse()`
- 🚫 Reject zero and negative transaction amounts
- 🔒 Prevent withdrawals and transfers exceeding the available balance
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
- 🧪 Include automated unit tests using xUnit
- 🛡️ Provide consistent input validation across application operations
- ⚠️ Display clear and understandable error messages

## 🛠️ Technologies

- 💻 C#
- 🧪 xUnit
- 🖥️ Visual Studio
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
├── BankSystem.Tests/
│   └── UnitTest1.cs
└── README.md
```

- `Program.cs` — application entry point and main console menu.
- `BankSystem.cs` — manages accounts, handles user interaction, and displays account and transaction information.
- `BankAccount.cs` — manages individual account balances, deposits, withdrawals, transfers, and transaction history.
- `Transaction.cs` — represents a single transaction, including its amount, type, and date.
- `ConsoleUI.cs` — provides reusable methods for formatting console output and displaying messages.
- `BankSystem.Tests/` — contains automated unit tests for bank account operations.

## 💻 Source Code

👉 [View Program.cs on GitHub](https://github.com/BarteQiu/BankSystem/blob/main/BankSystem/Program.cs)

## ▶️ How to Run

1. 📥 Clone or download this repository.
2. 🖥️ Open the solution in Visual Studio.
3. ▶️ Build and run the application.
4. 📋 Follow the instructions displayed in the console.

To run the automated tests, open Test Explorer in Visual Studio and select **Run All Tests**.

## 🚧 Project Status

The project is under active development.

**Version v0.7** focuses on improving input validation, error handling, and code reliability through automated unit testing.

This version introduces consistent input validation across application operations and clearer error messages displayed to users through the console UI.

The project also includes an xUnit test project with automated tests covering basic bank account functionality, including account initialization, deposits, withdrawals, and money transfers.

The application continues to support multiple bank accounts, individual account balances, deposits, withdrawals, money transfers, and account-specific transaction histories.

The project continues to evolve alongside my C# learning roadmap, with each version introducing new functionality and opportunities to practise programming concepts.

---

⭐ *Built as a hands-on learning project and improved with every version.*
