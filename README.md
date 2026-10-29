# 🏦 BankSystem

A simple console-based banking application written in **C#** as a learning project.

🚀 The project is developed step by step alongside my C# learning roadmap, focusing on programming fundamentals, input validation, object-oriented programming, and clean code.

## 📌 Current Version

**v0.4**

## ✨ Features

- 📋 Interactive console menu
- 💰 Display current account balance
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
- 🏦 Separate `BankAccount` and `BankSystem` classes
- 🔐 Encapsulate account balance using a private field
- 🧱 Initialize accounts using a constructor
- ✅ Validate transactions inside the account class
- 📚 Store successful transactions in a collection
- 🔄 Separate account logic from console interaction
- 🕒 Display transaction timestamps in a readable format
- 📭 Handle empty transaction history

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
│   └── Transaction.cs
└── README.md
```

- `Program.cs` — application entry point and main console menu.
- `BankSystem.cs` — handles user interaction, displays account information, and provides access to transaction history.
- `BankAccount.cs` — manages the account balance, deposits, withdrawals, and transaction history.
- `Transaction.cs` — represents a single transaction, including its amount, type, and date.

## 💻 Source Code

👉 [View Program.cs on GitHub](https://github.com/BarteQiu/BankSystem/blob/main/BankSystem/Program.cs)

## ▶️ How to Run

1. 📥 Clone or download this repository.
2. 🖥️ Open the project in Visual Studio.
3. ▶️ Build and run the application.
4. 📋 Follow the instructions displayed in the console.

## 🚧 Project Status

The project is under active development.

**Version v0.4** introduces transaction history and expands the application's object-oriented structure.

Successful deposits and withdrawals are recorded as individual transactions. Each transaction stores its amount, type (`Deposit` or `Withdraw`), and date and time. Users can view their transaction history through the console menu, including a message when no transactions have been recorded.

The `BankAccount` class manages the account balance and records successful operations, while the `BankSystem` class handles user interaction and displays the results.

Future versions will introduce additional functionality as I progress through my C# learning roadmap.

## 🗺️ Planned Improvements

- 👥 Support multiple bank accounts
- 🔄 Implement transfers between accounts
- 💾 Save and load account data from files
- 🧪 Add unit tests
- 🧹 Further improve code organization and maintainability

## 🎯 Purpose

This project is part of my journey toward becoming a **Junior C#/.NET Backend Developer**.

Its purpose is to practise C# programming, problem-solving, object-oriented programming, and clean code while gradually applying more advanced concepts in a practical project.

---

⭐ *Built as a hands-on learning project and improved with every version.*
