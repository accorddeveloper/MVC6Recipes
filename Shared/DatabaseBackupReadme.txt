The SQL Server database back up file Mvc6SharedDatabaseBackup.bak contains the database used in many samples in the book ASP.NET MVC 6 Recipes Second Edition by John Ciliberti.

This database backup can be used with Microsoft SQL Server 2014 Express Edition or better.

You can download and install Express edition free of charge fom the following website
http://www.microsoft.com/en-us/server-cloud/products/sql-server-editions/sql-server-express.aspx

You will need to sign-in with your Microsoft account to access the download. I recommend downloading the SQL Server tools rather then the stand alone version. The tools are helpful for performing administrative functions such as backing up and restoring databases as well as browsing your databases.

--------------------------
RESTORE BACKUP
--------------------------
The database can be restored using SQL Server Manager using the following steps:
1. Open SQL Server Management Studio
2. Connect to the local server using . as the server name
3. Right Click Databases in the Object Explorer and select Restore Database
4. Under Source click Device then click the "..." button
5. Click the Add button in the Select backup Devices dialog
6. Browse to the backup file location, select it, then click OK
7. Click OK again
8. Click OK to restore the database

