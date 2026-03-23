# Security Policy

## Reporting a Vulnerability

If you discover a security vulnerability in TravelAround, please do **not** open a public GitHub Issue.

Instead, contact the maintainer directly through GitHub private messaging or email.

Please include:
- A description of the vulnerability
- Steps to reproduce it
- Potential impact

You will receive a response within 48 hours.

---

## Known Security Considerations

### Database credentials
The file `db.cs` contains the MySQL connection string including a password.
- **Do not push `db.cs` with a real password to a public repository**
- Consider moving credentials to an environment variable or a gitignored config file

### Password storage
User passwords are hashed with **SHA-256** before being stored.
SHA-256 is a one-way hash — stored passwords cannot be reversed to plain text.

### SQL injection
All database queries in this project use **parameterised inputs** via MySql.Data's `MySqlCommand.Parameters` — raw string concatenation is not used anywhere.
