# 🧠 C# LINQ Training  
This project contains a complete set of LINQ exercises covering the most important LINQ operators, including:

- Restriction Operators (Where)
- Ordering Operators (OrderBy / ThenBy)
- Transformation Operators (Select / SelectMany)

Each question is implemented inside the project using `#region` blocks for easy navigation and testing.

---

## 📚 Project Structure
The project includes:

- `Program.cs` → contains all LINQ exercises.
- `ListGenerators.cs` → provides sample data for Products, Customers, and Orders.
- `Customers.xml` → contains the Customers + Orders seed data.

Each LINQ question is grouped inside a `#region Q1`, `#region Q2`, … for better organization.

---

## 🧩 Topics Covered

### 🔹 **Restriction Operators**
(Q1 → Q3)

#### **Q1 – Find Out-of-Stock Products**
Goal: Filter all products where `UnitsInStock == 0`  
Key Concepts:
- Using `.Where()`
- Basic filtering with predicates

#### **Q2 – In-Stock Products Priced > 3.00**
Goal: Find all items that are:
- In stock  
- Price > 3.00  
Key Concepts:
- Combining multiple conditions inside Where

#### **Q3 – Digits Whose Name Length < Index**
Given digit names array, return values where:
- `string.Length < index`  
Key Concepts:
- Using Where with element + index  
- Custom filtering logic

---

### 🔹 **Ordering Operators**
(Q1 → Q8)

#### **Q1 – Sort Products by Name**
Goal: Sort alphabetically by product name  
Key Concepts:
- `OrderBy()`

#### **Q2 – Case-Insensitive Word Sorting**
Goal: Sort array ignoring letter case  
Key Concepts:
- Using `StringComparer.OrdinalIgnoreCase`

#### **Q3 – Sort by Units in Stock (Descending)**
Goal: Highest → Lowest stock  
Key Concepts:
- `OrderByDescending()`

#### **Q4 – Sort Digits by Name Length, Then Alphabetically**
Goal: Multi-level sort  
Key Concepts:
- `OrderBy().ThenBy()`

#### **Q5 – Sort Words by Length, Then Case-Insensitive**
Key Concepts:
- Using custom comparer with `.ThenBy()`

#### **Q6 – Sort Products by Category, Then Price (Descending)**
Goal: Category ASC, then price DESC  
Key Concepts:
- Compound sorting

#### **Q7 – Sort Words by Length, Then Case-Insensitive (Descending)**
Key Concepts:
- Multi-level descending sorting

#### **Q8 – Reverse Digits Whose Second Letter Is 'i'**
Goal: Filter → Reverse original order  
Key Concepts:
- `.Where()` + `.Reverse()`

---

### 🔹 **Transformation Operators**
(Q1 → Q7)

#### **Q1 – Select Product Names Only**
Goal: Return only the string names  
Key Concepts:
- `Select()` projection

#### **Q2 – Uppercase & Lowercase Versions of Words (Anonymous Types)**
Goal: Create anonymous objects containing:
- word.ToUpper()
- word.ToLower()

Key Concepts:
- Anonymous types
- Multiple projections

#### **Q3 – Select Product Properties With Renaming (Price)**
Goal: Select subset of properties  
Key Concepts:
- Using `new { }`  
- Property renaming

#### **Q4 – Check If Number == Index**
Goal: Return:
- number
- a boolean indicating match

Key Concepts:
- Using `Select((value, index) => ...)`

#### **Q5 – All Pairs A < B Between Two Arrays**
Goal: All (a,b) where a < b  
Key Concepts:
- LINQ query syntax  
- Cartesian product logic

#### **Q6 – Orders With Total < 500**
Data Source: Customers.xml  
Goal: Flatten customers → orders  
Key Concepts:
- `SelectMany()`

#### **Q7 – Orders Made in 1998 or Later**
Goal: Filter orders by date year  
Key Concepts:
- DateTime filtering  
- SelectMany projection

---

## 📘 Learning Outcomes

By completing all exercises, you will fully understand:

- LINQ Restriction operators (Where)
- LINQ Ordering operators (OrderBy / ThenBy)
- LINQ Transformation operators (Select / SelectMany)
- Anonymous Types
- Combined filtering + projection
- Working with XML-based customer data
- Query vs Method syntax

---

## 🧩 Technologies & Concepts Used

- C# 10 / .NET 6
- LINQ Query Operators
- Anonymous Types
- Data Filtering & Projection
- Sorting & Multi-level Ordering
- Nested Collections (Customers → Orders)

---

## 📂 Repository Purpose
This repository is great for:

- Students learning LINQ  
- Developers preparing for .NET interviews  
- Anyone who wants a clean, practical LINQ reference  
- Practicing LINQ operators on real structured data

---

## ⚙️ Requirements
- .NET SDK **6.0+**
- Any C# IDE (Visual Studio / VS Code / Rider)

---

## 👨‍💻 Author  
**Abdalla Adel Aboaziz**  
Backend Developer (.NET)

