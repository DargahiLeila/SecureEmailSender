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

🔒 Use the Encrypt Password form to generate a secure value for EmailPasswordEecrypt.



