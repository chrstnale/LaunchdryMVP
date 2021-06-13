CREATE TABLE [dbo].[Order] (
    [No]                 INT             IDENTITY (1, 1) NOT NULL,
    [Jenis_Layanan]      VARCHAR (44)    NOT NULL,
    [Jenis_Pakaian]      VARCHAR (44)    NOT NULL,
    [Hari_Masuk]         DATE            NOT NULL,
    [Hari_Ambil]         DATE            NOT NULL,
    [Metode_Pembayaran]  INT             NOT NULL,
    [Berat/Jumlah]       NUMERIC (20, 2) NOT NULL,
    [Status]             VARCHAR (44)    NOT NULL,
    [Alamat_Pengantaran] VARCHAR (144)   NOT NULL,
    PRIMARY KEY CLUSTERED ([No] ASC)
);

