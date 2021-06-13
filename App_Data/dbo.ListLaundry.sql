CREATE TABLE [dbo].[ListLaundry] (
    [ID]              INT            NOT NULL,
    [Name]            VARCHAR (44)   NOT NULL,
    [Alamat]          VARCHAR (142)  NOT NULL,
    [No_Telepon]      VARCHAR (15)   NOT NULL,
    [Rating]          NUMERIC (3, 1) NOT NULL,
    [Jumlah_Reviewer] INT    NOT NULL,
    [Jam_buka]        VARCHAR (5)    NOT NULL,
    [Jam_tutup]       VARCHAR (5)    NOT NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC)
);

