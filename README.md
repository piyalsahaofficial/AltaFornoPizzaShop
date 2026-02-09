# Alta Forno Pizza Shop Management System

## Overview
**Alta Forno Pizza Shop Management System** is a desktop C# application designed to manage a pizza restaurant workflow. It handles:

- Orders & order items
- Billing (PDF generation using iText7)
- Revenue, expenses, and salaries
- User management with role-based access

**Roles:** Admin, Restaurant Manager, Cashier, Account Manager

This project demonstrates:

- Real-world software workflow simulation
- Database design with relational integrity
- Role-based security and modular code

---

## Repository Structure
AltaFornoPizzaShop/
├─ AltaFornoPizzaShop.sln
├─ Forms/                      
├─ ProjectDescriptionAndRequirements.docx/pdf
└─ Project Demonstration.mp4

## Getting Started

1. Open `AltaFornoPizzaShop.sln` in **Visual Studio 2019+**  
2. Set up the database `AltaFornoPizzaShopDB` as described in **ProjectDescriptionAndRequirements**  
3. Restore NuGet packages (`iText7`, `System.Data.SqlClient`)  
4. Build and run the project  

**Note:** Seed the **Users table** with the four roles (admin, manager, cashier, accountant) for immediate login.

---

## Demo Video
Watch the [Project Demonstration Video](Project%20Demonstration.mp4)

---

## Key Highlights

- Role-based dashboards & access  
- Dynamic order & billing system  
- PDF bill generation  
- Revenue, expense, and salary tracking  
- Modular and scalable for future features  

---

## Why This Project Is Useful

- Simulates real restaurant workflow  
- Demonstrates relational database and C# skills  
- Clean modular separation of code  
- Fully ready for demonstration or evaluation
