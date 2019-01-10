sp_configure 'show advanced options', 1 

GO 
RECONFIGURE; 
GO 
sp_configure 'Ole Automation Procedures', 1 
GO 
RECONFIGURE; 
GO 
sp_configure 'show advanced options', 1 
GO 
RECONFIGURE;


Declare @Object as Int;
Declare @ResponseText as Varchar(8000);


Exec sp_OACreate 'MSXML2.XMLHTTP', @Object OUT;
Exec sp_OAMethod @Object, 'open', NULL, 'post',
                 'https://localhost:44346/api/message?id=10', --Your Web Service Url (invoked)
                 'false'
Exec sp_OAMethod @Object, 'send'
Exec sp_OAMethod @Object, 'responseText', @ResponseText OUTPUT

Select @ResponseText

Exec sp_OADestroy @Object