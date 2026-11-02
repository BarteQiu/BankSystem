# 🏦 BankSystem

A simple console-based banking application written in **C#** as a learning project.

🚀 The project is developed step by step alongside my C# learning roadmap, focusing on programming fundamentals, input validation, object-oriented programming, and clean code.

## 📌 Current Version

**v0.6**

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
- `BankAccount.cs` — manages individual account balances, deposits, withdrawals, transfers, and transaction history.
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

**Version v0.6** introduces money transfers between bank accounts and improves transaction history filtering.

Users can transfer money between existing accounts. The application validates account IDs, prevents transfers to the same account, rejects invalid amounts, and checks whether the source account has sufficient funds before processing a transfer.

Each successful transfer is recorded in both accounts: as an outgoing transfer for the sender and an incoming transfer for the recipient. Users can view the complete transaction history, filter it to show deposits and incoming transfers or withdrawals and outgoing transfers, and inspect transaction records when searching for an account.

The project also supports multiple bank accounts, individual account balances, deposits, withdrawals, and account-specific transaction histories. The console UI uses reusable methods for displaying headers, success messages, error messages, and informational messages.

The project continues to evolve alongside my C# learning roadmap, with each version introducing new functionality and opportunities to practise programming concepts.

## 🗺️ Planned Improvements

- 💾 Save and load account data from files
- 🧪 Add unit tests
- 🧹 Further improve code organization and maintainability

---

⭐ *Built as a hands-on learning project and improved with every version.*
