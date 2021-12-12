CREATE TABLE [dbo].[Treatment]
(
	TreatmentNo			INT	NOT NULL,
	TreatmentPrice		INT	NOT NULL,
	TreatmentDuration	INT	NOT NULL,
	TreatmentType		INT NOT NULL, 
    CONSTRAINT [FKTreatmentType] FOREIGN KEY (TreatmentType) REFERENCES TreatmentType(TreatmentType),

)
