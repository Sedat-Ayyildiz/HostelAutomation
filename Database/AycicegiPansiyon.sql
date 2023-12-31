USE [AycicegiPansiyon]
GO
/****** Object:  Table [dbo].[AdminGiris]    Script Date: 15.06.2023 04:13:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AdminGiris](
	[KullaniciAdi] [varchar](20) NOT NULL,
	[Sifre] [varchar](20) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Faturalar]    Script Date: 15.06.2023 04:13:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Faturalar](
	[Elektrik] [int] NULL,
	[Su] [int] NULL,
	[Internet] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mesajlar]    Script Date: 15.06.2023 04:13:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mesajlar](
	[Mesajid] [int] IDENTITY(1,1) NOT NULL,
	[AdSoyad] [varchar](50) NULL,
	[Mesaj] [varchar](1500) NULL,
 CONSTRAINT [PK_Mesajlar] PRIMARY KEY CLUSTERED 
(
	[Mesajid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MusteriEkle]    Script Date: 15.06.2023 04:13:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MusteriEkle](
	[Musteriid] [int] IDENTITY(1,1) NOT NULL,
	[Adi] [varchar](20) NULL,
	[Soyadi] [varchar](50) NULL,
	[Cinsiyet] [varchar](5) NULL,
	[Telefon] [varchar](15) NULL,
	[Mail] [varchar](50) NULL,
	[TC] [varchar](12) NULL,
	[OdaNo] [varchar](5) NULL,
	[Ucret] [int] NULL,
	[GirisTarihi] [date] NULL,
	[CikisTarihi] [date] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Oda101]    Script Date: 15.06.2023 04:13:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Oda101](
	[Adi] [varchar](50) NULL,
	[Soyadi] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Oda102]    Script Date: 15.06.2023 04:13:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Oda102](
	[Adi] [varchar](50) NULL,
	[Soyadi] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Oda103]    Script Date: 15.06.2023 04:13:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Oda103](
	[Adi] [varchar](50) NULL,
	[Soyadi] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Oda104]    Script Date: 15.06.2023 04:13:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Oda104](
	[Adi] [varchar](50) NULL,
	[Soyadi] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Oda105]    Script Date: 15.06.2023 04:13:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Oda105](
	[Adi] [varchar](50) NULL,
	[Soyadi] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Oda106]    Script Date: 15.06.2023 04:13:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Oda106](
	[Adi] [varchar](50) NULL,
	[Soyadi] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Oda107]    Script Date: 15.06.2023 04:13:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Oda107](
	[Adi] [varchar](50) NULL,
	[Soyadi] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Oda108]    Script Date: 15.06.2023 04:13:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Oda108](
	[Adi] [varchar](50) NULL,
	[Soyadi] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Oda109]    Script Date: 15.06.2023 04:13:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Oda109](
	[Adi] [varchar](50) NULL,
	[Soyadi] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Stoklar]    Script Date: 15.06.2023 04:13:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Stoklar](
	[Gida] [int] NULL,
	[Icecek] [int] NULL,
	[Cerezler] [int] NULL
) ON [PRIMARY]
GO
INSERT [dbo].[AdminGiris] ([KullaniciAdi], [Sifre]) VALUES (N'Sedat', N'1234')
GO
ALTER TABLE [dbo].[MusteriEkle] ADD  CONSTRAINT [DF_MüsteriEkle_GirisTarihi]  DEFAULT (getdate()) FOR [GirisTarihi]
GO
ALTER TABLE [dbo].[MusteriEkle] ADD  CONSTRAINT [DF_MüsteriEkle_CikisTarihi]  DEFAULT (getdate()) FOR [CikisTarihi]
GO
