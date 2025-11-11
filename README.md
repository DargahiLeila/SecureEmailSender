# SecureEmailWinForms

A lightweight C# Windows Forms application for securely sending emails with encrypted credentials and attachment validation.

---

## ✨ Features

- 🔐 **Password Encryption**: Encrypt your email password using AES and store it securely in `App.config`.
- 📧 **Send Email Form**:
  - Sender, recipient, subject, and body fields
  - File attachment support with file type validation
  - DataGridView to list attachments with delete buttons
- 🧪 **Password Encryption Form**:
  - Input plain password and get encrypted output
  - Copy the encrypted password to use in configuration
- 🛡️ **Static utility classes**:
  - `CryptoHelper`: AES-based `Encrypt` and `Decrypt` methods
  - `FileValidator`: Checks for allowed file types before attaching

---

## 🖼️ UI Overview

- **Main Form**: Menu with `Send Email`, `Encrypt Password`, and `Exit`
- **Send Email Form**: Email fields + attachment grid + send button
- **Encrypt Password Form**: Input + encrypted output

---

## ⚙️ Configuration

Update your `App.config` with the following keys:

```xml
<appSettings>
  <add key="SmtpServer" value="mail.example.com"/>
  <add key="SmtpPort" value="465"/>
  <add key="EmailPasswordEecrypt" value="YourEncryptedPasswordHere"/>
</appSettings>



## 🔒 Use the Encrypt Password form to generate a secure value for EmailPasswordEecrypt.





## 🛠️Requirements
.NET Framework 4.7.2 or later

Visual Studio 2019 or newer

🚀 How to Run
Clone the repository

Open the solution in Visual Studio

Update App.config with your SMTP settings

Build and run the project

Use the menu to encrypt your password and send emails

## 📁 Project Structure
/Forms
  ├── MainForm.cs
  ├── SendEmailForm.cs
  └── EncryptPasswordForm.cs
/Helpers
  ├── CryptoHelper.cs
  └── FileValidator.cs
App.config
Program.cs

## 📌 Notes
This project is for educational/demo purposes. Do not hardcode real credentials in production.

For production use, consider secure storage like Windows Credential Manager or Azure Key Vault.

