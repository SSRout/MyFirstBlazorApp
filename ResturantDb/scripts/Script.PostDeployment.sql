/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
if not exists (select * from dbo.Food)
begin
    insert into dbo.Food(Title,[Description],Price)
    values('spaghetti','a spaghetti',6),('pizza','a pizza',4.93),('hamburger','a hamburger',6.5),('sausages','a sausages',3.5);
end

