# 💳 Payment Processor - Factory Design Pattern (ASP.NET MVC)

This project demonstrates how to implement the **Factory Design Pattern** in an **ASP.NET MVC** application. The goal is to decouple object creation from client code by using a factory to create different types of payment method objects dynamically.

---

## 🧠 Objective

To understand and apply the **Factory Design Pattern**:
- Promote modular, reusable, and maintainable code.
- Allow dynamic creation of different classes that share a common interface.
- Apply real-world scenarios in an MVC web application.

---

## 🏗️ Scenario

We simulate a **payment processing system** where users can choose a payment method:
- 💰 PayPal
- 💳 Credit Card
- 🏦 Bank Transfer

Each payment type has a unique processing logic, but all share a common interface: `IPaymentMethod`.

---

## 📁 Project Structure

/Models
├── IPaymentMethod.cs // Interface
├── PayPalPayment.cs // Concrete implementation
├── CreditCardPayment.cs // Concrete implementation
├── BankTransferPayment.cs // Concrete implementation

/Factory
└── PaymentFactory.cs // Factory class to return the correct object

/Controllers
└── PaymentController.cs // Uses the factory to process user request

/Views/Payment
├── Index.cshtml // User form to enter amount and select payment type
└── Result.cshtml // Displays the processed result


## 🚀 How It Works

1. User submits payment form via `Index.cshtml`.
2. `PaymentController` receives input and calls:
   ```csharp
   IPaymentMethod method = PaymentFactory.GetPaymentMethod(paymentType);
PaymentFactory returns a specific payment object (e.g., PayPalPayment).

The selected class executes:

csharp
Copy
Edit
string result = method.ProcessPayment(amount);
The result is shown in Result.cshtml.

🛠️ Technologies Used
ASP.NET Core MVC

C#

Razor Views

Visual Studio 2022 / 2023

✅ Example Use Case
You might use this architecture to:

Dynamically load payment gateways

Switch between logging or database services

Easily extend your system by adding new classes with minimal changes

