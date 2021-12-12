CREATE TABLE [dbo].[Customer]
(
	CustomerNo			INT			NOT NULL  PRIMARY KEY,
	CustomerForename	VARCHAR		NOT NULL,
	CustomerSurname		VARCHAR		NOT NULL,
	CustomerDOB			DATETIME	NOT NULL,
	CustomerStreet		VARCHAR		NOT NULL,
	CustomerTown		VARCHAR		NOT NULL,
	CustomerCounty		VARCHAR		NOT NULL,
	CustomerCountry		VARCHAR		NOT NULL,
	CustomerPostcode	VARCHAR		NOT NULL,
	CustomerTel			INT			NOT NULL,
	CustomerEmail		VARCHAR		NOT NULL,

)
