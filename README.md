# QRUtilityApp.API

A simple .NET 8 Web API for generating and managing QR codes.  
This project is intended to provide QR code generation functionality that can be used by other systems for various business processes, such as generating QR codes for authentication, payments, or product tagging.

---

## 🔧 Tech Stack

- **.NET 8 Web API**  
- **NuGet Packages**:  
  - `QRCoder`: QR code generation
  - `System.Drawing.Common`: for image creation and manipulation
- **SQL Server (optional)** — for storing generated codes and their metadata
- Built using **Visual Studio 2022**

---

## 🚀 Features

- Generate QR codes in PNG/Base64 format
- Return QR codes via HTTP response
- Easily integrate into other APIs or frontend apps
- Flexible QR content (URLs, tokens, text)
- Extendable architecture for future enhancements

---

## 🛠️ Setup Instructions

### Prerequisites
- .NET 8 SDK
- Visual Studio 2022
- SQL Server (optional, for saving QR metadata)

### Running Locally

1. **Clone the repository:**

```bash
git clone https://github.com/HlamuloMabunda/QRUtilityApp.API.git
cd QRUtilityApp.API
