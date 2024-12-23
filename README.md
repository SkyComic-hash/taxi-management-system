**Rentit: Streamlined Taxi Management System**

## Overview

**Rentit** is a comprehensive and streamlined Taxi Management System designed and developed in **C#**. This system aims to simplify the management and operation of taxi fleets, providing features for booking, dispatch, driver management, trip tracking, and payment handling. The system is built with robust design principles and uses a **SQL Database** for storing data, ensuring secure, scalable, and efficient operations.

This project follows solid object-oriented design principles, such as **SOLID principles**, and incorporates **design patterns** to ensure scalability, maintainability, and ease of use. The system has been developed with a focus on efficiency and user-friendly interfaces for both drivers and administrators.

## Table of Contents

1. [Features](#features)
2. [Technologies Used](#technologies-used)
3. [System Architecture](#system-architecture)
4. [Database Schema](#database-schema)
5. [Usage](#usage)
6. [Licenses](#licenses)
7. [Acknowledgements](#acknowledgements)

---

## Features

- **User Management:**
  - Admin accounts with full system control.
  - Driver accounts with restricted access.
  - Customer registration and login for booking taxis.
  
- **Booking Management:**
  - Customers can book taxis via the app.
  - Real-time booking status updates.
  
- **Fleet Management:**
  - Admin can add/remove/manage taxis.
  - Assign taxis to available drivers.
  
- **Trip Tracking:**
  - Real-time tracking of trips.
  - Driver location tracking using GPS data (optional feature).
  - Trip history for both customers and drivers.
  
- **Payment Processing:**
  - Integration with payment gateways for secure transactions.
  - Fare calculation based on distance, time, and type of vehicle.
  
- **Reporting:**
  - Admin can view reports of completed trips, earnings, driver performance, and more.

---

## Technologies Used

- **C#**: Main programming language used for backend development.
- **SQL Server**: Database management system used to store system data.
- **ASP.NET Core**: For building the backend APIs (if applicable).
- **Windows Forms/WPF**: For user interface (if applicable).
- **Entity Framework**: ORM for database interactions.
- **Microsoft Visual Studio**: IDE used for development.
- **Git**: Version control system.

---

## System Architecture

The Rentit Taxi Management System follows a **layered architecture** for clean separation of concerns and better maintainability. The primary layers include:

1. **Presentation Layer** (UI):
   - Handles user interaction through forms or web pages.
   
2. **Business Logic Layer** (BLL):
   - Contains all business logic such as fare calculations, trip assignments, and payment processing.
   
3. **Data Access Layer** (DAL):
   - Manages interactions with the SQL database using **Entity Framework** for ORM-based data operations.

4. **Database**:
   - SQL Server used to store data regarding users, bookings, trips, taxis, payments, etc.

---

## Database Schema

The following is the basic schema structure used in the system:

**Admins Table:**

- AdminID (Primary Key)  
- AdminName  
- AdminUsername  
- AdminPassword  
- AdminAddress  
- Gender  

---

**Customers Table:**

- CustomerID (Primary Key, Composite with CustomerName)  
- CustomerName (Primary Key, Composite with CustomerID)  
- CustomerUsername  
- CustomerPassword  
- CustomerAddress  
- CustomerContact  
- Gender  

---

**Drivers Table:**

- DriverID (Primary Key)  
- DriverName  
- DriverPassword  
- DriverAddress  
- DriverContact  
- DriverGender  
- DriverStatus (Default: Available)  

---

**Cars Table:**

- CarID (Primary Key)  
- Make  
- FuelType  
- VehicleType  
- Model  
- PlateNumber  
- ManufactureYear  
- Cost  
- CarStatus (Default: Available)  

---

**Orders Table:**

- OrderID (Primary Key)  
- CustomerID (Foreign Key to Customers)  
- CustomerName (Foreign Key to Customers)  
- DriverID (Foreign Key to Drivers)  
- CarID (Foreign Key to Cars)  
- Destination  
- StartDate  
- EndDate  
- OrderStatus (Default: On Going)  

---

## Usage

- **Admin**: 
  - Log in to the system using an admin account.
  - Manage users, vehicles, and view reports.

- **Driver**: 
  - Log in with a driver account to accept and complete trips.
  - Update trip statuses and manage earnings.

- **Customer**: 
  - Register and log in as a customer.
  - Book taxis, track trips, and make payments.

---

## Licenses

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

---

## Acknowledgements

- [Microsoft](https://www.microsoft.com) for providing development tools and technologies.
- [Stack Overflow](https://stackoverflow.com) for invaluable community support.
- [GitHub](https://github.com) for version control and collaboration.

---
