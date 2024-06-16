# Music-Player-App
Welcome to the C# Music Player! This project is a robust and user-friendly music player application designed to provide an enjoyable listening experience. Built with C#, it leverages the power of .NET to deliver high-quality audio playback and an intuitive user interface.



# Creating Table and Using Connection String

## Creating Table in SQL Server

Create a table named `AudioFiles` in SQL Server, execute the following SQL query:

```sql
CREATE TABLE AudioFiles (
    Id INT PRIMARY KEY IDENTITY(1,1),
    FileName VARCHAR(255),
    FileData VARBINARY(MAX),
    MIMEType VARCHAR(100)
);
```

This SQL query creates a table with four columns:
- `Id`: An integer column serving as the primary key with auto-incrementing values.
- `FileName`: A varchar column to store the name of the audio file.
- `FileData`: A varbinary column to store the binary data of the audio file.
- `MIMEType`: A varchar column to store the MIME type of the audio file.

## Using Connection String in C#

To connect to the SQL Server database and perform operations on the `AudioFiles` table in C#, you can use the following connection string:

```csharp
string connectionString = @"Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;";
```

Replace `myServerAddress`, `myDataBase`, `myUsername`, and `myPassword` with the appropriate values for your SQL Server configuration.

Once you have the connection string set up, you can use it to establish a connection to the database and execute SQL commands to interact with the `AudioFiles` table.

```csharp
using System.Data.SqlClient;

// Establish connection
string connectionString = "Your Connection String Goes Here";
SqlConnection conn = new SqlConnection(connectionString);

```

Remember to handle exceptions and close the connection properly to ensure the security and reliability of your application.
