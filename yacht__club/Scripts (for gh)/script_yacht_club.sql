USE [master]
GO
/****** Object:  Database [yacht_club]    Script Date: 23.12.2023 21:07:01 ******/
CREATE DATABASE [yacht_club]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'yacht_club', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\yacht_club.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'yacht_club_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\yacht_club_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [yacht_club] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [yacht_club].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [yacht_club] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [yacht_club] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [yacht_club] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [yacht_club] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [yacht_club] SET ARITHABORT OFF 
GO
ALTER DATABASE [yacht_club] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [yacht_club] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [yacht_club] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [yacht_club] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [yacht_club] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [yacht_club] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [yacht_club] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [yacht_club] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [yacht_club] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [yacht_club] SET  DISABLE_BROKER 
GO
ALTER DATABASE [yacht_club] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [yacht_club] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [yacht_club] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [yacht_club] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [yacht_club] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [yacht_club] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [yacht_club] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [yacht_club] SET RECOVERY FULL 
GO
ALTER DATABASE [yacht_club] SET  MULTI_USER 
GO
ALTER DATABASE [yacht_club] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [yacht_club] SET DB_CHAINING OFF 
GO
ALTER DATABASE [yacht_club] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [yacht_club] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [yacht_club] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [yacht_club] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'yacht_club', N'ON'
GO
ALTER DATABASE [yacht_club] SET QUERY_STORE = ON
GO
ALTER DATABASE [yacht_club] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [yacht_club]
GO
/****** Object:  Table [dbo].[ClubMembership]    Script Date: 23.12.2023 21:07:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ClubMembership](
	[membership_id] [int] IDENTITY(1,1) NOT NULL,
	[participant_id] [int] NULL,
	[join_date] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[membership_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Competition]    Script Date: 23.12.2023 21:07:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Competition](
	[competition_id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](100) NULL,
	[date] [date] NULL,
	[time] [time](7) NULL,
	[location] [varchar](100) NULL,
	[type] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[competition_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Participant]    Script Date: 23.12.2023 21:07:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Participant](
	[participant_id] [int] IDENTITY(1,1) NOT NULL,
	[full_name] [varchar](100) NULL,
	[birth_date] [date] NULL,
	[gender] [varchar](10) NULL,
	[phone_number] [varchar](20) NULL,
	[email] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[participant_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Participation]    Script Date: 23.12.2023 21:07:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Participation](
	[participation_id] [int] IDENTITY(1,1) NOT NULL,
	[competition_id] [int] NULL,
	[participant_id] [int] NULL,
	[yacht_id] [int] NULL,
	[result] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[participation_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Service]    Script Date: 23.12.2023 21:07:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Service](
	[service_id] [int] IDENTITY(1,1) NOT NULL,
	[yacht_id] [int] NULL,
	[start_date] [date] NULL,
	[end_date] [date] NULL,
	[work_type] [varchar](100) NULL,
	[cost] [decimal](10, 2) NULL,
	[specialist] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[service_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Trainer]    Script Date: 23.12.2023 21:07:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Trainer](
	[trainer_id] [int] IDENTITY(1,1) NOT NULL,
	[full_name] [varchar](100) NULL,
	[birth_date] [date] NULL,
	[gender] [varchar](10) NULL,
	[phone_number] [varchar](20) NULL,
	[email] [varchar](50) NULL,
	[experience] [int] NULL,
	[specialization] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[trainer_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Training]    Script Date: 23.12.2023 21:07:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Training](
	[training_id] [int] IDENTITY(1,1) NOT NULL,
	[participant_id] [int] NULL,
	[trainer_id] [int] NULL,
	[yacht_id] [int] NULL,
	[date] [date] NULL,
	[start_time] [time](7) NULL,
	[end_time] [time](7) NULL,
	[cost] [decimal](10, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[training_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Yacht]    Script Date: 23.12.2023 21:07:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Yacht](
	[yacht_id] [int] IDENTITY(1,1) NOT NULL,
	[model] [varchar](50) NULL,
	[yacht_type] [varchar](50) NULL,
	[condition] [varchar](50) NULL,
	[manufacturing_year] [int] NULL,
	[rental_cost] [decimal](10, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[yacht_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[ClubMembership] ON 

INSERT [dbo].[ClubMembership] ([membership_id], [participant_id], [join_date]) VALUES (1, 1, CAST(N'2019-05-20' AS Date))
INSERT [dbo].[ClubMembership] ([membership_id], [participant_id], [join_date]) VALUES (2, 2, CAST(N'2018-03-15' AS Date))
INSERT [dbo].[ClubMembership] ([membership_id], [participant_id], [join_date]) VALUES (3, 5, CAST(N'2020-06-01' AS Date))
INSERT [dbo].[ClubMembership] ([membership_id], [participant_id], [join_date]) VALUES (4, 8, CAST(N'2017-09-10' AS Date))
INSERT [dbo].[ClubMembership] ([membership_id], [participant_id], [join_date]) VALUES (5, 9, CAST(N'2019-11-23' AS Date))
INSERT [dbo].[ClubMembership] ([membership_id], [participant_id], [join_date]) VALUES (6, 12, CAST(N'2018-01-05' AS Date))
INSERT [dbo].[ClubMembership] ([membership_id], [participant_id], [join_date]) VALUES (7, 13, CAST(N'2020-07-22' AS Date))
INSERT [dbo].[ClubMembership] ([membership_id], [participant_id], [join_date]) VALUES (8, 14, CAST(N'2019-02-16' AS Date))
INSERT [dbo].[ClubMembership] ([membership_id], [participant_id], [join_date]) VALUES (9, 15, CAST(N'2018-12-10' AS Date))
SET IDENTITY_INSERT [dbo].[ClubMembership] OFF
GO
SET IDENTITY_INSERT [dbo].[Competition] ON 

INSERT [dbo].[Competition] ([competition_id], [name], [date], [time], [location], [type]) VALUES (1, N'Чемпіонат Весняного Кубку', CAST(N'2023-06-01' AS Date), CAST(N'09:00:00' AS Time), N'Одеса, Україна', N'Гоночні')
INSERT [dbo].[Competition] ([competition_id], [name], [date], [time], [location], [type]) VALUES (2, N'Літній Марафон', CAST(N'2023-07-15' AS Date), CAST(N'10:00:00' AS Time), N'Миколаїв, Україна', N'Марафон')
INSERT [dbo].[Competition] ([competition_id], [name], [date], [time], [location], [type]) VALUES (3, N'Осінній Кубок Яхтсменів', CAST(N'2023-09-10' AS Date), CAST(N'11:00:00' AS Time), N'Херсон, Україна', N'Гоночні')
INSERT [dbo].[Competition] ([competition_id], [name], [date], [time], [location], [type]) VALUES (4, N'Зимовий Турнір', CAST(N'2023-12-05' AS Date), CAST(N'12:00:00' AS Time), N'Київ, Україна', N'Витривалість')
INSERT [dbo].[Competition] ([competition_id], [name], [date], [time], [location], [type]) VALUES (5, N'Відкриття Сезону', CAST(N'2023-05-20' AS Date), CAST(N'09:30:00' AS Time), N'Ізмаїл, Україна', N'Спринт')
INSERT [dbo].[Competition] ([competition_id], [name], [date], [time], [location], [type]) VALUES (6, N'Кубок Чорного Моря', CAST(N'2023-08-22' AS Date), CAST(N'10:30:00' AS Time), N'Севастополь, Україна', N'Марафон')
INSERT [dbo].[Competition] ([competition_id], [name], [date], [time], [location], [type]) VALUES (7, N'Осіння Регата', CAST(N'2023-10-13' AS Date), CAST(N'11:30:00' AS Time), N'Бердянськ, Україна', N'Регата')
INSERT [dbo].[Competition] ([competition_id], [name], [date], [time], [location], [type]) VALUES (8, N'Змагання на Кубок Капітана', CAST(N'2023-11-07' AS Date), CAST(N'12:30:00' AS Time), N'Чорноморськ, Україна', N'Гоночні')
INSERT [dbo].[Competition] ([competition_id], [name], [date], [time], [location], [type]) VALUES (9, N'Весняна Регата 2024', CAST(N'2023-04-18' AS Date), CAST(N'09:00:00' AS Time), N'Євпаторія, Україна', N'Регата')
INSERT [dbo].[Competition] ([competition_id], [name], [date], [time], [location], [type]) VALUES (10, N'Чемпіонат Південного Берега', CAST(N'2024-07-20' AS Date), CAST(N'08:00:00' AS Time), N'Скадовськ, Україна', N'Гоночні')
SET IDENTITY_INSERT [dbo].[Competition] OFF
GO
SET IDENTITY_INSERT [dbo].[Participant] ON 

INSERT [dbo].[Participant] ([participant_id], [full_name], [birth_date], [gender], [phone_number], [email]) VALUES (1, N'Олексій Володимирович Мельник', CAST(N'2001-04-14' AS Date), N'Чоловік', N'0501112222', N'o.melnik@email.com')
INSERT [dbo].[Participant] ([participant_id], [full_name], [birth_date], [gender], [phone_number], [email]) VALUES (2, N'Марина Анатоліївна Коваль', CAST(N'2003-08-22' AS Date), N'Жінка', N'0673334444', N'm.koval@email.com')
INSERT [dbo].[Participant] ([participant_id], [full_name], [birth_date], [gender], [phone_number], [email]) VALUES (3, N'Дмитро Ігорович Лисенко', CAST(N'1999-01-05' AS Date), N'Чоловік', N'0635556666', N'd.lysenko@email.com')
INSERT [dbo].[Participant] ([participant_id], [full_name], [birth_date], [gender], [phone_number], [email]) VALUES (4, N'Ірина Олександрівна Сидоренк', CAST(N'1998-12-30' AS Date), N'Жінка', N'0957778888', N'i.sydorenko@email.com')
INSERT [dbo].[Participant] ([participant_id], [full_name], [birth_date], [gender], [phone_number], [email]) VALUES (5, N'Вадим Петрович Шевченко', CAST(N'2000-03-18' AS Date), N'Чоловік', N'0979990000', N'v.shevchenko@email.com')
INSERT [dbo].[Participant] ([participant_id], [full_name], [birth_date], [gender], [phone_number], [email]) VALUES (6, N'Олена Вікторівна Кравчук', CAST(N'2004-05-24' AS Date), N'Жінка', N'0991011213', N'o.kravchuk@email.com')
INSERT [dbo].[Participant] ([participant_id], [full_name], [birth_date], [gender], [phone_number], [email]) VALUES (7, N'Сергій Олегович Мороз', CAST(N'2002-07-16' AS Date), N'Чоловік', N'0501415161', N's.moroz@email.com')
INSERT [dbo].[Participant] ([participant_id], [full_name], [birth_date], [gender], [phone_number], [email]) VALUES (8, N'Катерина Юріївна Петренко', CAST(N'1997-09-09' AS Date), N'Жінка', N'0671718191', N'k.petrenko@email.com')
INSERT [dbo].[Participant] ([participant_id], [full_name], [birth_date], [gender], [phone_number], [email]) VALUES (9, N'Андрій Васильович Кузнєцов', CAST(N'1996-11-11' AS Date), N'Чоловік', N'0632122232', N'a.kuznetsov@email.com')
INSERT [dbo].[Participant] ([participant_id], [full_name], [birth_date], [gender], [phone_number], [email]) VALUES (10, N'Наталія Миколаївна Захарченко', CAST(N'2005-02-20' AS Date), N'Жінка', N'0952425262', N'n.zakharchenko@email.com')
INSERT [dbo].[Participant] ([participant_id], [full_name], [birth_date], [gender], [phone_number], [email]) VALUES (11, N'Ігор Романович Бондар', CAST(N'2001-06-25' AS Date), N'Чоловік', N'0972728292', N'i.bondar@email.com')
INSERT [dbo].[Participant] ([participant_id], [full_name], [birth_date], [gender], [phone_number], [email]) VALUES (12, N'Людмила Сергіївна Гриценко', CAST(N'1999-10-30' AS Date), N'Жінка', N'0993031333', N'l.grytsenko@email.com')
INSERT [dbo].[Participant] ([participant_id], [full_name], [birth_date], [gender], [phone_number], [email]) VALUES (13, N'Павло Андрійович Кучер', CAST(N'2000-04-04' AS Date), N'Чоловік', N'0503435353', N'p.kucher@email.com')
INSERT [dbo].[Participant] ([participant_id], [full_name], [birth_date], [gender], [phone_number], [email]) VALUES (14, N'Світлана Вікторівна Литвин', CAST(N'2003-08-08' AS Date), N'Жінка', N'0673839383', N's.lytvyn@email.com')
INSERT [dbo].[Participant] ([participant_id], [full_name], [birth_date], [gender], [phone_number], [email]) VALUES (15, N'Олександра Олександрівна Ткаченко', CAST(N'1998-12-12' AS Date), N'Жінка', N'0634242424', N'v.tkachenko@email.com')
INSERT [dbo].[Participant] ([participant_id], [full_name], [birth_date], [gender], [phone_number], [email]) VALUES (17, N'Моргунов Ігор Сергійович', CAST(N'2004-12-11' AS Date), N'Чоловік', N'0662415335', N'igor.morhunov@gmail.com')
INSERT [dbo].[Participant] ([participant_id], [full_name], [birth_date], [gender], [phone_number], [email]) VALUES (18, N'Володимир Михайлович Астаф''єв', CAST(N'1990-05-16' AS Date), N'Чоловік', N'0996876976', N'astafiev@gmail.com')
INSERT [dbo].[Participant] ([participant_id], [full_name], [birth_date], [gender], [phone_number], [email]) VALUES (19, N'Марина Олександрівна Жуковська', CAST(N'1985-08-24' AS Date), N'Жінка', N'0989652436', N'zhukovska.marynochka@gmail.com')
INSERT [dbo].[Participant] ([participant_id], [full_name], [birth_date], [gender], [phone_number], [email]) VALUES (20, N'Максим Романович Олексійчук', CAST(N'1992-03-15' AS Date), N'Чоловік', N'0665254963', N'maks_romanovich@gmail.com')
INSERT [dbo].[Participant] ([participant_id], [full_name], [birth_date], [gender], [phone_number], [email]) VALUES (21, N'Олександра Сергіївна Блага', CAST(N'2005-06-23' AS Date), N'Жінка', N'0504132786', N'blaga.sasha@gmail.com')
INSERT [dbo].[Participant] ([participant_id], [full_name], [birth_date], [gender], [phone_number], [email]) VALUES (22, N'Роман Романович Умриш', CAST(N'2004-03-20' AS Date), N'Чоловік', N'0635269736', N'roman_romanovich@gmail.com')
INSERT [dbo].[Participant] ([participant_id], [full_name], [birth_date], [gender], [phone_number], [email]) VALUES (23, N'Тарас Олексійович Донець', CAST(N'1987-10-15' AS Date), N'Чоловік', N'0556362451', N'tarasdonez@gmail.com')
INSERT [dbo].[Participant] ([participant_id], [full_name], [birth_date], [gender], [phone_number], [email]) VALUES (24, N'Аліса Олегівна Кумиш', CAST(N'1986-11-30' AS Date), N'Жінка', N'0663233332', N'kumyshalisa@gmail.com')
INSERT [dbo].[Participant] ([participant_id], [full_name], [birth_date], [gender], [phone_number], [email]) VALUES (25, N'Деник Володимирович Тімошенко', CAST(N'2005-04-12' AS Date), N'Чоловік', N'0509876245', N'timoshenkodenis@gmail.com')
INSERT [dbo].[Participant] ([participant_id], [full_name], [birth_date], [gender], [phone_number], [email]) VALUES (26, N'Павло Павлович Павлов', CAST(N'1998-04-22' AS Date), N'Чоловік', N'0669898198', N'pavlov@gmail.com')
INSERT [dbo].[Participant] ([participant_id], [full_name], [birth_date], [gender], [phone_number], [email]) VALUES (28, N'Роман Сергійович Ланов', CAST(N'1990-10-10' AS Date), N'Чоловік', N'0665251351', N'lanov@gmail.com')
INSERT [dbo].[Participant] ([participant_id], [full_name], [birth_date], [gender], [phone_number], [email]) VALUES (30, N'Сергій Степанович Іванов', CAST(N'1990-10-10' AS Date), N'Чоловік', N'0665251351', N'lanov@gmail.com')
INSERT [dbo].[Participant] ([participant_id], [full_name], [birth_date], [gender], [phone_number], [email]) VALUES (31, N'Олександр Григорович Антонюк', CAST(N'1993-08-19' AS Date), N'Чоловік', N'0985623147', N'lolantonyuk@gmail.com')
INSERT [dbo].[Participant] ([participant_id], [full_name], [birth_date], [gender], [phone_number], [email]) VALUES (32, N'Іванна Олексіївна Кобзаренко', CAST(N'1999-12-20' AS Date), N'Жінка', N'0632624895', N'ivannka@gmail.com')
SET IDENTITY_INSERT [dbo].[Participant] OFF
GO
SET IDENTITY_INSERT [dbo].[Participation] ON 

INSERT [dbo].[Participation] ([participation_id], [competition_id], [participant_id], [yacht_id], [result]) VALUES (1, 1, 1, 1, N'1 місце')
INSERT [dbo].[Participation] ([participation_id], [competition_id], [participant_id], [yacht_id], [result]) VALUES (2, 1, 2, 2, N'2 місце')
INSERT [dbo].[Participation] ([participation_id], [competition_id], [participant_id], [yacht_id], [result]) VALUES (3, 1, 3, 3, N'3 місце')
INSERT [dbo].[Participation] ([participation_id], [competition_id], [participant_id], [yacht_id], [result]) VALUES (4, 1, 4, 4, N'Щаслива участь')
INSERT [dbo].[Participation] ([participation_id], [competition_id], [participant_id], [yacht_id], [result]) VALUES (5, 1, 5, 5, N'Щаслива участь')
INSERT [dbo].[Participation] ([participation_id], [competition_id], [participant_id], [yacht_id], [result]) VALUES (6, 2, 6, 6, N'1 місце')
INSERT [dbo].[Participation] ([participation_id], [competition_id], [participant_id], [yacht_id], [result]) VALUES (7, 2, 7, 7, N'2 місце')
INSERT [dbo].[Participation] ([participation_id], [competition_id], [participant_id], [yacht_id], [result]) VALUES (8, 2, 8, 8, N'3 місце')
INSERT [dbo].[Participation] ([participation_id], [competition_id], [participant_id], [yacht_id], [result]) VALUES (9, 2, 9, 9, N'Щаслива участь')
INSERT [dbo].[Participation] ([participation_id], [competition_id], [participant_id], [yacht_id], [result]) VALUES (10, 2, 10, 10, N'Дискваліфіковано')
INSERT [dbo].[Participation] ([participation_id], [competition_id], [participant_id], [yacht_id], [result]) VALUES (11, 3, 11, 1, N'Щаслива участь')
INSERT [dbo].[Participation] ([participation_id], [competition_id], [participant_id], [yacht_id], [result]) VALUES (12, 3, 12, 2, N'Щаслива участь')
INSERT [dbo].[Participation] ([participation_id], [competition_id], [participant_id], [yacht_id], [result]) VALUES (13, 3, 13, 3, N'3 місце')
INSERT [dbo].[Participation] ([participation_id], [competition_id], [participant_id], [yacht_id], [result]) VALUES (14, 3, 14, 4, N'2 місце')
INSERT [dbo].[Participation] ([participation_id], [competition_id], [participant_id], [yacht_id], [result]) VALUES (15, 3, 15, 5, N'1 місце')
INSERT [dbo].[Participation] ([participation_id], [competition_id], [participant_id], [yacht_id], [result]) VALUES (16, 4, 1, 6, N'Щаслива участь')
INSERT [dbo].[Participation] ([participation_id], [competition_id], [participant_id], [yacht_id], [result]) VALUES (17, 4, 2, 7, N'Щаслива участь')
INSERT [dbo].[Participation] ([participation_id], [competition_id], [participant_id], [yacht_id], [result]) VALUES (18, 4, 3, 8, N'3 місце')
INSERT [dbo].[Participation] ([participation_id], [competition_id], [participant_id], [yacht_id], [result]) VALUES (19, 4, 4, 9, N'2 місце')
INSERT [dbo].[Participation] ([participation_id], [competition_id], [participant_id], [yacht_id], [result]) VALUES (20, 4, 5, 10, N'1 місце')
INSERT [dbo].[Participation] ([participation_id], [competition_id], [participant_id], [yacht_id], [result]) VALUES (21, 5, 6, 1, N'3 місце')
INSERT [dbo].[Participation] ([participation_id], [competition_id], [participant_id], [yacht_id], [result]) VALUES (22, 5, 7, 2, N'2 місце')
INSERT [dbo].[Participation] ([participation_id], [competition_id], [participant_id], [yacht_id], [result]) VALUES (23, 5, 8, 3, N'1 місце')
INSERT [dbo].[Participation] ([participation_id], [competition_id], [participant_id], [yacht_id], [result]) VALUES (24, 5, 9, 4, N'Щаслива участь')
INSERT [dbo].[Participation] ([participation_id], [competition_id], [participant_id], [yacht_id], [result]) VALUES (25, 5, 10, 5, N'Дискваліфіковано')
INSERT [dbo].[Participation] ([participation_id], [competition_id], [participant_id], [yacht_id], [result]) VALUES (26, 6, 11, 6, N'3 місце')
INSERT [dbo].[Participation] ([participation_id], [competition_id], [participant_id], [yacht_id], [result]) VALUES (27, 6, 12, 7, N'2 місце')
INSERT [dbo].[Participation] ([participation_id], [competition_id], [participant_id], [yacht_id], [result]) VALUES (28, 6, 13, 8, N'1 місце')
INSERT [dbo].[Participation] ([participation_id], [competition_id], [participant_id], [yacht_id], [result]) VALUES (29, 6, 14, 9, N'Щаслива участь')
INSERT [dbo].[Participation] ([participation_id], [competition_id], [participant_id], [yacht_id], [result]) VALUES (30, 6, 15, 10, N'Щаслива участь')
INSERT [dbo].[Participation] ([participation_id], [competition_id], [participant_id], [yacht_id], [result]) VALUES (31, 7, 1, 1, N'2 місце')
INSERT [dbo].[Participation] ([participation_id], [competition_id], [participant_id], [yacht_id], [result]) VALUES (32, 7, 2, 2, N'1 місце')
INSERT [dbo].[Participation] ([participation_id], [competition_id], [participant_id], [yacht_id], [result]) VALUES (33, 7, 3, 3, N'Щаслива участь')
INSERT [dbo].[Participation] ([participation_id], [competition_id], [participant_id], [yacht_id], [result]) VALUES (34, 7, 4, 4, N'3 місце')
INSERT [dbo].[Participation] ([participation_id], [competition_id], [participant_id], [yacht_id], [result]) VALUES (35, 7, 5, 5, N'Щаслива участь')
INSERT [dbo].[Participation] ([participation_id], [competition_id], [participant_id], [yacht_id], [result]) VALUES (36, 8, 6, 6, N'Щаслива участь')
INSERT [dbo].[Participation] ([participation_id], [competition_id], [participant_id], [yacht_id], [result]) VALUES (37, 8, 7, 7, N'2 місце')
INSERT [dbo].[Participation] ([participation_id], [competition_id], [participant_id], [yacht_id], [result]) VALUES (38, 8, 8, 8, N'1 місце')
INSERT [dbo].[Participation] ([participation_id], [competition_id], [participant_id], [yacht_id], [result]) VALUES (39, 8, 9, 9, N'Щаслива участь')
INSERT [dbo].[Participation] ([participation_id], [competition_id], [participant_id], [yacht_id], [result]) VALUES (40, 8, 10, 10, N'Щаслива участь')
INSERT [dbo].[Participation] ([participation_id], [competition_id], [participant_id], [yacht_id], [result]) VALUES (42, 1, 6, 11, N'Щаслива участь')
INSERT [dbo].[Participation] ([participation_id], [competition_id], [participant_id], [yacht_id], [result]) VALUES (43, 1, 7, 12, N'Щаслива участь')
INSERT [dbo].[Participation] ([participation_id], [competition_id], [participant_id], [yacht_id], [result]) VALUES (45, 1, 9, 6, N'Щаслива участь')
INSERT [dbo].[Participation] ([participation_id], [competition_id], [participant_id], [yacht_id], [result]) VALUES (46, 1, 10, 7, N'Щаслива участь')
INSERT [dbo].[Participation] ([participation_id], [competition_id], [participant_id], [yacht_id], [result]) VALUES (47, 2, 11, 1, N'Щаслива участь')
INSERT [dbo].[Participation] ([participation_id], [competition_id], [participant_id], [yacht_id], [result]) VALUES (48, 2, 12, 2, N'Щаслива участь')
INSERT [dbo].[Participation] ([participation_id], [competition_id], [participant_id], [yacht_id], [result]) VALUES (49, 2, 13, 3, N'Щаслива участь')
INSERT [dbo].[Participation] ([participation_id], [competition_id], [participant_id], [yacht_id], [result]) VALUES (50, 2, 14, 4, N'Щаслива участь')
INSERT [dbo].[Participation] ([participation_id], [competition_id], [participant_id], [yacht_id], [result]) VALUES (51, 2, 15, 5, N'Щаслива участь')
INSERT [dbo].[Participation] ([participation_id], [competition_id], [participant_id], [yacht_id], [result]) VALUES (52, 3, 17, 11, N'Щаслива участь')
INSERT [dbo].[Participation] ([participation_id], [competition_id], [participant_id], [yacht_id], [result]) VALUES (53, 3, 18, 12, N'Щаслива участь')
INSERT [dbo].[Participation] ([participation_id], [competition_id], [participant_id], [yacht_id], [result]) VALUES (55, 3, 20, 6, N'Щаслива участь')
INSERT [dbo].[Participation] ([participation_id], [competition_id], [participant_id], [yacht_id], [result]) VALUES (56, 3, 21, 7, N'Щаслива участь')
INSERT [dbo].[Participation] ([participation_id], [competition_id], [participant_id], [yacht_id], [result]) VALUES (57, 4, 22, 11, N'Щаслива участь')
INSERT [dbo].[Participation] ([participation_id], [competition_id], [participant_id], [yacht_id], [result]) VALUES (58, 4, 23, 12, N'Щаслива участь')
INSERT [dbo].[Participation] ([participation_id], [competition_id], [participant_id], [yacht_id], [result]) VALUES (60, 4, 7, 3, N'Щаслива участь')
INSERT [dbo].[Participation] ([participation_id], [competition_id], [participant_id], [yacht_id], [result]) VALUES (61, 4, 8, 4, N'Щаслива участь')
INSERT [dbo].[Participation] ([participation_id], [competition_id], [participant_id], [yacht_id], [result]) VALUES (62, 5, 1, 6, N'Щаслива участь')
INSERT [dbo].[Participation] ([participation_id], [competition_id], [participant_id], [yacht_id], [result]) VALUES (63, 5, 2, 7, N'Щаслива участь')
INSERT [dbo].[Participation] ([participation_id], [competition_id], [participant_id], [yacht_id], [result]) VALUES (64, 5, 3, 8, N'Щаслива участь')
INSERT [dbo].[Participation] ([participation_id], [competition_id], [participant_id], [yacht_id], [result]) VALUES (65, 5, 4, 9, N'Щаслива участь')
INSERT [dbo].[Participation] ([participation_id], [competition_id], [participant_id], [yacht_id], [result]) VALUES (66, 5, 5, 10, N'Щаслива участь')
INSERT [dbo].[Participation] ([participation_id], [competition_id], [participant_id], [yacht_id], [result]) VALUES (67, 6, 6, 11, N'Щаслива участь')
INSERT [dbo].[Participation] ([participation_id], [competition_id], [participant_id], [yacht_id], [result]) VALUES (68, 6, 7, 12, N'Щаслива участь')
INSERT [dbo].[Participation] ([participation_id], [competition_id], [participant_id], [yacht_id], [result]) VALUES (70, 6, 9, 2, N'Щаслива участь')
INSERT [dbo].[Participation] ([participation_id], [competition_id], [participant_id], [yacht_id], [result]) VALUES (71, 6, 10, 3, N'Щаслива участь')
INSERT [dbo].[Participation] ([participation_id], [competition_id], [participant_id], [yacht_id], [result]) VALUES (72, 7, 11, 7, N'Щаслива участь')
INSERT [dbo].[Participation] ([participation_id], [competition_id], [participant_id], [yacht_id], [result]) VALUES (73, 7, 12, 8, N'Щаслива участь')
INSERT [dbo].[Participation] ([participation_id], [competition_id], [participant_id], [yacht_id], [result]) VALUES (74, 7, 13, 9, N'Щаслива участь')
INSERT [dbo].[Participation] ([participation_id], [competition_id], [participant_id], [yacht_id], [result]) VALUES (75, 7, 14, 10, N'Щаслива участь')
INSERT [dbo].[Participation] ([participation_id], [competition_id], [participant_id], [yacht_id], [result]) VALUES (77, 8, 17, 11, N'Щаслива участь')
INSERT [dbo].[Participation] ([participation_id], [competition_id], [participant_id], [yacht_id], [result]) VALUES (78, 8, 18, 12, N'Щаслива участь')
INSERT [dbo].[Participation] ([participation_id], [competition_id], [participant_id], [yacht_id], [result]) VALUES (79, 8, 19, 1, N'Щаслива участь')
INSERT [dbo].[Participation] ([participation_id], [competition_id], [participant_id], [yacht_id], [result]) VALUES (80, 8, 20, 2, N'Щаслива участь')
INSERT [dbo].[Participation] ([participation_id], [competition_id], [participant_id], [yacht_id], [result]) VALUES (81, 8, 21, 4, N'Щаслива участь')
SET IDENTITY_INSERT [dbo].[Participation] OFF
GO
SET IDENTITY_INSERT [dbo].[Service] ON 

INSERT [dbo].[Service] ([service_id], [yacht_id], [start_date], [end_date], [work_type], [cost], [specialist]) VALUES (2, 1, CAST(N'2021-07-01' AS Date), CAST(N'2021-07-15' AS Date), N'Покраска корпусу', CAST(600.00 AS Decimal(10, 2)), N'Олександр Іванов')
INSERT [dbo].[Service] ([service_id], [yacht_id], [start_date], [end_date], [work_type], [cost], [specialist]) VALUES (3, 2, CAST(N'2021-07-01' AS Date), CAST(N'2021-07-15' AS Date), N'Заміна вітрил', CAST(450.00 AS Decimal(10, 2)), N'Ігор Михайлов')
INSERT [dbo].[Service] ([service_id], [yacht_id], [start_date], [end_date], [work_type], [cost], [specialist]) VALUES (4, 2, CAST(N'2022-04-20' AS Date), CAST(N'2022-04-30' AS Date), N'Ремонт двигуна', CAST(300.00 AS Decimal(10, 2)), N'Віталій Ковальчук')
INSERT [dbo].[Service] ([service_id], [yacht_id], [start_date], [end_date], [work_type], [cost], [specialist]) VALUES (5, 3, CAST(N'2021-08-05' AS Date), CAST(N'2021-08-20' AS Date), N'Ремонт корпусу', CAST(800.00 AS Decimal(10, 2)), N'Павло Лисенко')
INSERT [dbo].[Service] ([service_id], [yacht_id], [start_date], [end_date], [work_type], [cost], [specialist]) VALUES (6, 3, CAST(N'2022-06-10' AS Date), CAST(N'2022-06-24' AS Date), N'Заміна електроніки', CAST(1200.00 AS Decimal(10, 2)), N'Олена Сидоренко')
INSERT [dbo].[Service] ([service_id], [yacht_id], [start_date], [end_date], [work_type], [cost], [specialist]) VALUES (7, 4, CAST(N'2021-09-01' AS Date), CAST(N'2021-09-10' AS Date), N'Обслуговування рульової системи', CAST(400.00 AS Decimal(10, 2)), N'Сергій Кравчук')
INSERT [dbo].[Service] ([service_id], [yacht_id], [start_date], [end_date], [work_type], [cost], [specialist]) VALUES (8, 5, CAST(N'2022-05-22' AS Date), CAST(N'2022-06-05' AS Date), N'Заміна навігаційної системи', CAST(700.00 AS Decimal(10, 2)), N'Марина Коваль')
INSERT [dbo].[Service] ([service_id], [yacht_id], [start_date], [end_date], [work_type], [cost], [specialist]) VALUES (9, 6, CAST(N'2021-10-15' AS Date), CAST(N'2021-10-25' AS Date), N'Ремонт палуби', CAST(550.00 AS Decimal(10, 2)), N'Дмитро Лисенко')
INSERT [dbo].[Service] ([service_id], [yacht_id], [start_date], [end_date], [work_type], [cost], [specialist]) VALUES (10, 7, CAST(N'2022-07-07' AS Date), CAST(N'2022-07-17' AS Date), N'Заміна обладнання', CAST(500.00 AS Decimal(10, 2)), N'Ірина Сидоренко')
INSERT [dbo].[Service] ([service_id], [yacht_id], [start_date], [end_date], [work_type], [cost], [specialist]) VALUES (11, 8, CAST(N'2021-11-20' AS Date), CAST(N'2021-11-30' AS Date), N'Технічне обслуговування', CAST(450.00 AS Decimal(10, 2)), N'Вадим Шевченко')
INSERT [dbo].[Service] ([service_id], [yacht_id], [start_date], [end_date], [work_type], [cost], [specialist]) VALUES (12, 9, CAST(N'2022-08-15' AS Date), CAST(N'2022-08-25' AS Date), N'Обслуговування двигуна', CAST(650.00 AS Decimal(10, 2)), N'Олена Кравчук')
INSERT [dbo].[Service] ([service_id], [yacht_id], [start_date], [end_date], [work_type], [cost], [specialist]) VALUES (14, 11, CAST(N'2022-09-05' AS Date), CAST(N'2022-09-15' AS Date), N'Заміна рульової системи', CAST(600.00 AS Decimal(10, 2)), N'Катерина Петренко')
INSERT [dbo].[Service] ([service_id], [yacht_id], [start_date], [end_date], [work_type], [cost], [specialist]) VALUES (15, 12, CAST(N'2021-07-25' AS Date), CAST(N'2021-08-05' AS Date), N'Загальний ремонт', CAST(1110.00 AS Decimal(10, 2)), N'Андрій Кузнєцов')
INSERT [dbo].[Service] ([service_id], [yacht_id], [start_date], [end_date], [work_type], [cost], [specialist]) VALUES (16, 1, CAST(N'2023-10-18' AS Date), CAST(N'2023-10-25' AS Date), N'Технічне обслуговування', CAST(750.00 AS Decimal(10, 2)), N'Володимир Дрозд')
INSERT [dbo].[Service] ([service_id], [yacht_id], [start_date], [end_date], [work_type], [cost], [specialist]) VALUES (17, 10, CAST(N'2023-11-01' AS Date), CAST(N'2023-11-10' AS Date), N'Ремонт палуби', CAST(470.00 AS Decimal(10, 2)), N'Олексій Степаненко')
INSERT [dbo].[Service] ([service_id], [yacht_id], [start_date], [end_date], [work_type], [cost], [specialist]) VALUES (18, 1, CAST(N'2023-09-14' AS Date), CAST(N'2023-09-29' AS Date), N'Загальний ремонт', CAST(1700.00 AS Decimal(10, 2)), N'Іван Дмитрик')
INSERT [dbo].[Service] ([service_id], [yacht_id], [start_date], [end_date], [work_type], [cost], [specialist]) VALUES (19, 2, CAST(N'2023-04-05' AS Date), CAST(N'2023-04-15' AS Date), N'Заміна навігаційного обладнання', CAST(950.00 AS Decimal(10, 2)), N'Григорій Іванов')
INSERT [dbo].[Service] ([service_id], [yacht_id], [start_date], [end_date], [work_type], [cost], [specialist]) VALUES (20, 3, CAST(N'2023-05-10' AS Date), CAST(N'2023-05-20' AS Date), N'Обслуговування двигуна', CAST(1350.00 AS Decimal(10, 2)), N'Віктор Грищенко')
INSERT [dbo].[Service] ([service_id], [yacht_id], [start_date], [end_date], [work_type], [cost], [specialist]) VALUES (21, 4, CAST(N'2023-06-01' AS Date), CAST(N'2023-06-11' AS Date), N'Ремонт електричної системи', CAST(600.00 AS Decimal(10, 2)), N'Марія Кузненко')
INSERT [dbo].[Service] ([service_id], [yacht_id], [start_date], [end_date], [work_type], [cost], [specialist]) VALUES (22, 5, CAST(N'2023-07-01' AS Date), CAST(N'2023-07-25' AS Date), N'Технічне обслуговування', CAST(800.00 AS Decimal(10, 2)), N'Вадим Шевченко')
INSERT [dbo].[Service] ([service_id], [yacht_id], [start_date], [end_date], [work_type], [cost], [specialist]) VALUES (23, 6, CAST(N'2023-08-03' AS Date), CAST(N'2023-08-13' AS Date), N'Заміна вітрил', CAST(700.00 AS Decimal(10, 2)), N'Євгеній Горбачов')
INSERT [dbo].[Service] ([service_id], [yacht_id], [start_date], [end_date], [work_type], [cost], [specialist]) VALUES (24, 7, CAST(N'2023-09-01' AS Date), CAST(N'2023-09-10' AS Date), N'Ремонт корпусу', CAST(1200.00 AS Decimal(10, 2)), N'Павло Лисенко')
INSERT [dbo].[Service] ([service_id], [yacht_id], [start_date], [end_date], [work_type], [cost], [specialist]) VALUES (25, 8, CAST(N'2023-10-20' AS Date), CAST(N'2023-10-30' AS Date), N'Покраска корпусу', CAST(650.00 AS Decimal(10, 2)), N'Олександр Іванов')
INSERT [dbo].[Service] ([service_id], [yacht_id], [start_date], [end_date], [work_type], [cost], [specialist]) VALUES (26, 9, CAST(N'2023-11-05' AS Date), CAST(N'2023-11-15' AS Date), N'Обслуговування рульової системи', CAST(550.00 AS Decimal(10, 2)), N'Сергій Кравчук')
INSERT [dbo].[Service] ([service_id], [yacht_id], [start_date], [end_date], [work_type], [cost], [specialist]) VALUES (27, 11, CAST(N'2023-03-12' AS Date), CAST(N'2023-03-22' AS Date), N'Заміна електроніки', CAST(1300.00 AS Decimal(10, 2)), N'Олена Сидоренко')
INSERT [dbo].[Service] ([service_id], [yacht_id], [start_date], [end_date], [work_type], [cost], [specialist]) VALUES (28, 12, CAST(N'2023-02-07' AS Date), CAST(N'2023-02-17' AS Date), N'Обслуговування двигуна', CAST(750.00 AS Decimal(10, 2)), N'Олена Кравчук')
INSERT [dbo].[Service] ([service_id], [yacht_id], [start_date], [end_date], [work_type], [cost], [specialist]) VALUES (30, 2, CAST(N'2023-09-10' AS Date), CAST(N'2023-09-20' AS Date), N'Ремонт керма', CAST(620.00 AS Decimal(10, 2)), N'Світлана Борисів')
INSERT [dbo].[Service] ([service_id], [yacht_id], [start_date], [end_date], [work_type], [cost], [specialist]) VALUES (31, 3, CAST(N'2023-01-15' AS Date), CAST(N'2023-01-25' AS Date), N'Заміна палубного обладнання', CAST(950.00 AS Decimal(10, 2)), N'Артем Макшаєв')
INSERT [dbo].[Service] ([service_id], [yacht_id], [start_date], [end_date], [work_type], [cost], [specialist]) VALUES (32, 4, CAST(N'2023-02-05' AS Date), CAST(N'2023-02-15' AS Date), N'Технічне обслуговування двигуна', CAST(1100.00 AS Decimal(10, 2)), N'Вадим Шевченко')
INSERT [dbo].[Service] ([service_id], [yacht_id], [start_date], [end_date], [work_type], [cost], [specialist]) VALUES (33, 5, CAST(N'2023-04-10' AS Date), CAST(N'2023-04-20' AS Date), N'Оновлення навігаційної системи', CAST(840.00 AS Decimal(10, 2)), N'Григорій Іванов')
INSERT [dbo].[Service] ([service_id], [yacht_id], [start_date], [end_date], [work_type], [cost], [specialist]) VALUES (34, 6, CAST(N'2023-05-01' AS Date), CAST(N'2023-06-25' AS Date), N'Заміна вітрил', CAST(780.00 AS Decimal(10, 2)), N'Іван Дмитрик')
INSERT [dbo].[Service] ([service_id], [yacht_id], [start_date], [end_date], [work_type], [cost], [specialist]) VALUES (35, 7, CAST(N'2023-07-05' AS Date), CAST(N'2023-07-15' AS Date), N'Ремонт електроніки', CAST(1250.00 AS Decimal(10, 2)), N'Марія Кузненко')
INSERT [dbo].[Service] ([service_id], [yacht_id], [start_date], [end_date], [work_type], [cost], [specialist]) VALUES (36, 8, CAST(N'2023-08-10' AS Date), CAST(N'2023-08-20' AS Date), N'Ремонт рульової системи', CAST(700.00 AS Decimal(10, 2)), N'Сергій Кравчук')
INSERT [dbo].[Service] ([service_id], [yacht_id], [start_date], [end_date], [work_type], [cost], [specialist]) VALUES (37, 9, CAST(N'2023-09-03' AS Date), CAST(N'2023-09-18' AS Date), N'Загальний технічний огляд', CAST(890.00 AS Decimal(10, 2)), N'Володимир Дрозд')
INSERT [dbo].[Service] ([service_id], [yacht_id], [start_date], [end_date], [work_type], [cost], [specialist]) VALUES (38, 10, CAST(N'2023-01-25' AS Date), CAST(N'2023-02-04' AS Date), N'Заміна радіообладнання', CAST(560.00 AS Decimal(10, 2)), N'Олена Сидоренко')
INSERT [dbo].[Service] ([service_id], [yacht_id], [start_date], [end_date], [work_type], [cost], [specialist]) VALUES (39, 11, CAST(N'2023-02-15' AS Date), CAST(N'2023-02-25' AS Date), N'Ремонт палуби', CAST(1350.00 AS Decimal(10, 2)), N'Артем Макшаєв')
INSERT [dbo].[Service] ([service_id], [yacht_id], [start_date], [end_date], [work_type], [cost], [specialist]) VALUES (40, 12, CAST(N'2023-03-01' AS Date), CAST(N'2023-03-11' AS Date), N'Обновлення салону', CAST(1600.00 AS Decimal(10, 2)), N'Олексій Степаненко')
INSERT [dbo].[Service] ([service_id], [yacht_id], [start_date], [end_date], [work_type], [cost], [specialist]) VALUES (42, 1, CAST(N'2023-08-11' AS Date), CAST(N'2023-08-30' AS Date), N'Ремонт мачти', CAST(750.00 AS Decimal(10, 2)), N'Олексій Степаненко')
SET IDENTITY_INSERT [dbo].[Service] OFF
GO
SET IDENTITY_INSERT [dbo].[Trainer] ON 

INSERT [dbo].[Trainer] ([trainer_id], [full_name], [birth_date], [gender], [phone_number], [email], [experience], [specialization]) VALUES (1, N'Василь Петрович Кравчук', CAST(N'1975-03-13' AS Date), N'Чоловік', N'050-123-4567', N'v.kravchuk@email.com', 9, N'Підготовка до регат')
INSERT [dbo].[Trainer] ([trainer_id], [full_name], [birth_date], [gender], [phone_number], [email], [experience], [specialization]) VALUES (2, N'Людмила Іванівна Павленко', CAST(N'1982-07-25' AS Date), N'Жінка', N'067-234-5678', N'l.pavlenko@email.com', 12, N'Вітрильний спорт')
INSERT [dbo].[Trainer] ([trainer_id], [full_name], [birth_date], [gender], [phone_number], [email], [experience], [specialization]) VALUES (3, N'Андрій Миколайович Савченко', CAST(N'1980-11-02' AS Date), N'Чоловік', N'063-345-6789', N'a.savchenko@email.com', 7, N'Олімпійський вітрильний спорт')
INSERT [dbo].[Trainer] ([trainer_id], [full_name], [birth_date], [gender], [phone_number], [email], [experience], [specialization]) VALUES (4, N'Тетяна Олексіївна Кучер', CAST(N'1990-05-17' AS Date), N'Жінка', N'095-456-7890', N't.kucher@email.com', 5, N'Тактика вітрильного спорту')
INSERT [dbo].[Trainer] ([trainer_id], [full_name], [birth_date], [gender], [phone_number], [email], [experience], [specialization]) VALUES (5, N'Олександр Віталійович Мороз', CAST(N'1968-09-14' AS Date), N'Чоловік', N'097-567-8901', N'o.moroz@email.com', 6, N'Круїзний вітрильний спорт')
INSERT [dbo].[Trainer] ([trainer_id], [full_name], [birth_date], [gender], [phone_number], [email], [experience], [specialization]) VALUES (6, N'Ірина Василівна Бондар', CAST(N'1978-12-30' AS Date), N'Жінка', N'099-678-9012', N'i.bondar@email.com', 19, N'Фізична підготовка вітрильників')
INSERT [dbo].[Trainer] ([trainer_id], [full_name], [birth_date], [gender], [phone_number], [email], [experience], [specialization]) VALUES (7, N'Петро Юрійович Гончар', CAST(N'1985-03-21' AS Date), N'Чоловік', N'050-789-0123', N'p.gonchar@email.com', 10, N'Матч-рейсинг')
INSERT [dbo].[Trainer] ([trainer_id], [full_name], [birth_date], [gender], [phone_number], [email], [experience], [specialization]) VALUES (8, N'Наталія Романівна Литвин', CAST(N'1992-08-05' AS Date), N'Жінка', N'067-890-1234', N'n.lytvyn@email.com', 11, N'Вітрильний спорт')
INSERT [dbo].[Trainer] ([trainer_id], [full_name], [birth_date], [gender], [phone_number], [email], [experience], [specialization]) VALUES (9, N'Ігор Олегович Шевченко', CAST(N'1971-01-15' AS Date), N'Чоловік', N'063-901-2345', N'i.shevchenko@email.com', 15, N'Олімпійський вітрильний спорт')
INSERT [dbo].[Trainer] ([trainer_id], [full_name], [birth_date], [gender], [phone_number], [email], [experience], [specialization]) VALUES (10, N'Олена Сергіївна Кравець', CAST(N'1986-04-27' AS Date), N'Жінка', N'095-012-3456', N'o.kravets@email.com', 5, N'Фізична підготовка вітрильників')
INSERT [dbo].[Trainer] ([trainer_id], [full_name], [birth_date], [gender], [phone_number], [email], [experience], [specialization]) VALUES (11, N'Юрій Васильович Ткаченко', CAST(N'1973-06-19' AS Date), N'Чоловік', N'097-123-4567', N'y.tkachenko@email.com', 12, N'Олімпійський вітрильний спорт')
INSERT [dbo].[Trainer] ([trainer_id], [full_name], [birth_date], [gender], [phone_number], [email], [experience], [specialization]) VALUES (12, N'Марія Анатоліївна Захарченко', CAST(N'1988-10-08' AS Date), N'Жінка', N'099-234-5678', N'm.zakharchenko@email.com', 6, N'Вітрильний спорт')
SET IDENTITY_INSERT [dbo].[Trainer] OFF
GO
SET IDENTITY_INSERT [dbo].[Training] ON 

INSERT [dbo].[Training] ([training_id], [participant_id], [trainer_id], [yacht_id], [date], [start_time], [end_time], [cost]) VALUES (1, 1, 1, 1, CAST(N'2023-11-09' AS Date), CAST(N'08:00:00' AS Time), CAST(N'10:00:00' AS Time), CAST(300.00 AS Decimal(10, 2)))
INSERT [dbo].[Training] ([training_id], [participant_id], [trainer_id], [yacht_id], [date], [start_time], [end_time], [cost]) VALUES (2, 1, 1, 1, CAST(N'2023-11-11' AS Date), CAST(N'08:00:00' AS Time), CAST(N'10:00:00' AS Time), CAST(300.00 AS Decimal(10, 2)))
INSERT [dbo].[Training] ([training_id], [participant_id], [trainer_id], [yacht_id], [date], [start_time], [end_time], [cost]) VALUES (3, 1, 1, 1, CAST(N'2023-11-13' AS Date), CAST(N'08:00:00' AS Time), CAST(N'10:00:00' AS Time), CAST(300.00 AS Decimal(10, 2)))
INSERT [dbo].[Training] ([training_id], [participant_id], [trainer_id], [yacht_id], [date], [start_time], [end_time], [cost]) VALUES (4, 2, 2, 4, CAST(N'2023-11-09' AS Date), CAST(N'10:30:00' AS Time), CAST(N'12:30:00' AS Time), CAST(320.00 AS Decimal(10, 2)))
INSERT [dbo].[Training] ([training_id], [participant_id], [trainer_id], [yacht_id], [date], [start_time], [end_time], [cost]) VALUES (5, 2, 2, 4, CAST(N'2023-11-12' AS Date), CAST(N'10:30:00' AS Time), CAST(N'12:30:00' AS Time), CAST(320.00 AS Decimal(10, 2)))
INSERT [dbo].[Training] ([training_id], [participant_id], [trainer_id], [yacht_id], [date], [start_time], [end_time], [cost]) VALUES (6, 3, 3, 2, CAST(N'2023-11-09' AS Date), CAST(N'13:00:00' AS Time), CAST(N'15:00:00' AS Time), CAST(280.00 AS Decimal(10, 2)))
INSERT [dbo].[Training] ([training_id], [participant_id], [trainer_id], [yacht_id], [date], [start_time], [end_time], [cost]) VALUES (7, 3, 3, 2, CAST(N'2023-11-11' AS Date), CAST(N'13:00:00' AS Time), CAST(N'15:00:00' AS Time), CAST(280.00 AS Decimal(10, 2)))
INSERT [dbo].[Training] ([training_id], [participant_id], [trainer_id], [yacht_id], [date], [start_time], [end_time], [cost]) VALUES (8, 3, 3, 2, CAST(N'2023-11-13' AS Date), CAST(N'13:00:00' AS Time), CAST(N'15:00:00' AS Time), CAST(280.00 AS Decimal(10, 2)))
INSERT [dbo].[Training] ([training_id], [participant_id], [trainer_id], [yacht_id], [date], [start_time], [end_time], [cost]) VALUES (9, 4, 4, 5, CAST(N'2023-11-10' AS Date), CAST(N'08:00:00' AS Time), CAST(N'10:00:00' AS Time), CAST(300.00 AS Decimal(10, 2)))
INSERT [dbo].[Training] ([training_id], [participant_id], [trainer_id], [yacht_id], [date], [start_time], [end_time], [cost]) VALUES (10, 4, 4, 5, CAST(N'2023-11-12' AS Date), CAST(N'08:00:00' AS Time), CAST(N'10:00:00' AS Time), CAST(300.00 AS Decimal(10, 2)))
INSERT [dbo].[Training] ([training_id], [participant_id], [trainer_id], [yacht_id], [date], [start_time], [end_time], [cost]) VALUES (11, 5, 5, 6, CAST(N'2023-11-10' AS Date), CAST(N'10:30:00' AS Time), CAST(N'12:30:00' AS Time), CAST(310.00 AS Decimal(10, 2)))
INSERT [dbo].[Training] ([training_id], [participant_id], [trainer_id], [yacht_id], [date], [start_time], [end_time], [cost]) VALUES (12, 5, 5, 6, CAST(N'2023-11-13' AS Date), CAST(N'10:30:00' AS Time), CAST(N'12:30:00' AS Time), CAST(310.00 AS Decimal(10, 2)))
INSERT [dbo].[Training] ([training_id], [participant_id], [trainer_id], [yacht_id], [date], [start_time], [end_time], [cost]) VALUES (13, 5, 5, 6, CAST(N'2023-11-15' AS Date), CAST(N'10:30:00' AS Time), CAST(N'12:30:00' AS Time), CAST(310.00 AS Decimal(10, 2)))
INSERT [dbo].[Training] ([training_id], [participant_id], [trainer_id], [yacht_id], [date], [start_time], [end_time], [cost]) VALUES (14, 6, 6, 3, CAST(N'2023-11-10' AS Date), CAST(N'13:00:00' AS Time), CAST(N'15:00:00' AS Time), CAST(285.00 AS Decimal(10, 2)))
INSERT [dbo].[Training] ([training_id], [participant_id], [trainer_id], [yacht_id], [date], [start_time], [end_time], [cost]) VALUES (15, 6, 6, 3, CAST(N'2023-11-13' AS Date), CAST(N'13:00:00' AS Time), CAST(N'15:00:00' AS Time), CAST(285.00 AS Decimal(10, 2)))
INSERT [dbo].[Training] ([training_id], [participant_id], [trainer_id], [yacht_id], [date], [start_time], [end_time], [cost]) VALUES (16, 7, 7, 7, CAST(N'2023-11-11' AS Date), CAST(N'15:30:00' AS Time), CAST(N'17:30:00' AS Time), CAST(275.00 AS Decimal(10, 2)))
INSERT [dbo].[Training] ([training_id], [participant_id], [trainer_id], [yacht_id], [date], [start_time], [end_time], [cost]) VALUES (17, 7, 7, 7, CAST(N'2023-11-14' AS Date), CAST(N'15:30:00' AS Time), CAST(N'17:30:00' AS Time), CAST(275.00 AS Decimal(10, 2)))
INSERT [dbo].[Training] ([training_id], [participant_id], [trainer_id], [yacht_id], [date], [start_time], [end_time], [cost]) VALUES (18, 8, 8, 10, CAST(N'2023-11-09' AS Date), CAST(N'18:00:00' AS Time), CAST(N'20:00:00' AS Time), CAST(295.00 AS Decimal(10, 2)))
INSERT [dbo].[Training] ([training_id], [participant_id], [trainer_id], [yacht_id], [date], [start_time], [end_time], [cost]) VALUES (19, 8, 8, 10, CAST(N'2023-11-12' AS Date), CAST(N'18:00:00' AS Time), CAST(N'20:00:00' AS Time), CAST(295.00 AS Decimal(10, 2)))
INSERT [dbo].[Training] ([training_id], [participant_id], [trainer_id], [yacht_id], [date], [start_time], [end_time], [cost]) VALUES (20, 9, 9, 8, CAST(N'2023-11-10' AS Date), CAST(N'16:30:00' AS Time), CAST(N'18:30:00' AS Time), CAST(290.00 AS Decimal(10, 2)))
INSERT [dbo].[Training] ([training_id], [participant_id], [trainer_id], [yacht_id], [date], [start_time], [end_time], [cost]) VALUES (21, 9, 9, 8, CAST(N'2023-11-14' AS Date), CAST(N'16:30:00' AS Time), CAST(N'18:30:00' AS Time), CAST(290.00 AS Decimal(10, 2)))
INSERT [dbo].[Training] ([training_id], [participant_id], [trainer_id], [yacht_id], [date], [start_time], [end_time], [cost]) VALUES (22, 10, 10, 9, CAST(N'2023-11-11' AS Date), CAST(N'08:30:00' AS Time), CAST(N'10:30:00' AS Time), CAST(280.00 AS Decimal(10, 2)))
INSERT [dbo].[Training] ([training_id], [participant_id], [trainer_id], [yacht_id], [date], [start_time], [end_time], [cost]) VALUES (23, 10, 10, 9, CAST(N'2023-11-13' AS Date), CAST(N'08:30:00' AS Time), CAST(N'10:30:00' AS Time), CAST(280.00 AS Decimal(10, 2)))
INSERT [dbo].[Training] ([training_id], [participant_id], [trainer_id], [yacht_id], [date], [start_time], [end_time], [cost]) VALUES (24, 10, 10, 9, CAST(N'2023-11-15' AS Date), CAST(N'08:30:00' AS Time), CAST(N'10:30:00' AS Time), CAST(280.00 AS Decimal(10, 2)))
INSERT [dbo].[Training] ([training_id], [participant_id], [trainer_id], [yacht_id], [date], [start_time], [end_time], [cost]) VALUES (25, 11, 11, 2, CAST(N'2023-11-09' AS Date), CAST(N'19:00:00' AS Time), CAST(N'21:00:00' AS Time), CAST(290.00 AS Decimal(10, 2)))
INSERT [dbo].[Training] ([training_id], [participant_id], [trainer_id], [yacht_id], [date], [start_time], [end_time], [cost]) VALUES (26, 11, 11, 2, CAST(N'2023-11-12' AS Date), CAST(N'19:00:00' AS Time), CAST(N'21:00:00' AS Time), CAST(290.00 AS Decimal(10, 2)))
INSERT [dbo].[Training] ([training_id], [participant_id], [trainer_id], [yacht_id], [date], [start_time], [end_time], [cost]) VALUES (27, 12, 12, 3, CAST(N'2023-11-10' AS Date), CAST(N'08:00:00' AS Time), CAST(N'10:00:00' AS Time), CAST(275.00 AS Decimal(10, 2)))
INSERT [dbo].[Training] ([training_id], [participant_id], [trainer_id], [yacht_id], [date], [start_time], [end_time], [cost]) VALUES (28, 12, 12, 3, CAST(N'2023-11-13' AS Date), CAST(N'08:00:00' AS Time), CAST(N'10:00:00' AS Time), CAST(275.00 AS Decimal(10, 2)))
INSERT [dbo].[Training] ([training_id], [participant_id], [trainer_id], [yacht_id], [date], [start_time], [end_time], [cost]) VALUES (29, 12, 12, 3, CAST(N'2023-11-15' AS Date), CAST(N'08:00:00' AS Time), CAST(N'10:00:00' AS Time), CAST(275.00 AS Decimal(10, 2)))
INSERT [dbo].[Training] ([training_id], [participant_id], [trainer_id], [yacht_id], [date], [start_time], [end_time], [cost]) VALUES (32, 14, 1, 9, CAST(N'2023-11-11' AS Date), CAST(N'13:00:00' AS Time), CAST(N'15:00:00' AS Time), CAST(280.00 AS Decimal(10, 2)))
INSERT [dbo].[Training] ([training_id], [participant_id], [trainer_id], [yacht_id], [date], [start_time], [end_time], [cost]) VALUES (33, 14, 1, 9, CAST(N'2023-11-15' AS Date), CAST(N'13:00:00' AS Time), CAST(N'15:00:00' AS Time), CAST(280.00 AS Decimal(10, 2)))
INSERT [dbo].[Training] ([training_id], [participant_id], [trainer_id], [yacht_id], [date], [start_time], [end_time], [cost]) VALUES (34, 15, 2, 4, CAST(N'2023-11-09' AS Date), CAST(N'15:30:00' AS Time), CAST(N'17:30:00' AS Time), CAST(300.00 AS Decimal(10, 2)))
INSERT [dbo].[Training] ([training_id], [participant_id], [trainer_id], [yacht_id], [date], [start_time], [end_time], [cost]) VALUES (35, 15, 2, 4, CAST(N'2023-11-13' AS Date), CAST(N'15:30:00' AS Time), CAST(N'17:30:00' AS Time), CAST(300.00 AS Decimal(10, 2)))
INSERT [dbo].[Training] ([training_id], [participant_id], [trainer_id], [yacht_id], [date], [start_time], [end_time], [cost]) VALUES (36, 1, 1, 1, CAST(N'2023-10-02' AS Date), CAST(N'08:00:00' AS Time), CAST(N'09:00:00' AS Time), CAST(280.00 AS Decimal(10, 2)))
INSERT [dbo].[Training] ([training_id], [participant_id], [trainer_id], [yacht_id], [date], [start_time], [end_time], [cost]) VALUES (37, 1, 1, 1, CAST(N'2023-10-06' AS Date), CAST(N'08:00:00' AS Time), CAST(N'09:00:00' AS Time), CAST(280.00 AS Decimal(10, 2)))
INSERT [dbo].[Training] ([training_id], [participant_id], [trainer_id], [yacht_id], [date], [start_time], [end_time], [cost]) VALUES (38, 1, 1, 1, CAST(N'2023-10-09' AS Date), CAST(N'08:00:00' AS Time), CAST(N'09:00:00' AS Time), CAST(280.00 AS Decimal(10, 2)))
INSERT [dbo].[Training] ([training_id], [participant_id], [trainer_id], [yacht_id], [date], [start_time], [end_time], [cost]) VALUES (39, 1, 1, 1, CAST(N'2023-10-13' AS Date), CAST(N'08:00:00' AS Time), CAST(N'09:00:00' AS Time), CAST(280.00 AS Decimal(10, 2)))
INSERT [dbo].[Training] ([training_id], [participant_id], [trainer_id], [yacht_id], [date], [start_time], [end_time], [cost]) VALUES (40, 1, 1, 1, CAST(N'2023-10-16' AS Date), CAST(N'08:00:00' AS Time), CAST(N'09:00:00' AS Time), CAST(280.00 AS Decimal(10, 2)))
INSERT [dbo].[Training] ([training_id], [participant_id], [trainer_id], [yacht_id], [date], [start_time], [end_time], [cost]) VALUES (41, 1, 1, 1, CAST(N'2023-10-20' AS Date), CAST(N'08:00:00' AS Time), CAST(N'09:00:00' AS Time), CAST(280.00 AS Decimal(10, 2)))
INSERT [dbo].[Training] ([training_id], [participant_id], [trainer_id], [yacht_id], [date], [start_time], [end_time], [cost]) VALUES (42, 1, 1, 1, CAST(N'2023-10-23' AS Date), CAST(N'08:00:00' AS Time), CAST(N'09:00:00' AS Time), CAST(280.00 AS Decimal(10, 2)))
INSERT [dbo].[Training] ([training_id], [participant_id], [trainer_id], [yacht_id], [date], [start_time], [end_time], [cost]) VALUES (43, 1, 1, 1, CAST(N'2023-10-27' AS Date), CAST(N'08:00:00' AS Time), CAST(N'09:00:00' AS Time), CAST(280.00 AS Decimal(10, 2)))
INSERT [dbo].[Training] ([training_id], [participant_id], [trainer_id], [yacht_id], [date], [start_time], [end_time], [cost]) VALUES (44, 1, 1, 1, CAST(N'2023-10-30' AS Date), CAST(N'08:00:00' AS Time), CAST(N'09:00:00' AS Time), CAST(280.00 AS Decimal(10, 2)))
INSERT [dbo].[Training] ([training_id], [participant_id], [trainer_id], [yacht_id], [date], [start_time], [end_time], [cost]) VALUES (45, 2, 2, 2, CAST(N'2023-10-03' AS Date), CAST(N'08:00:00' AS Time), CAST(N'10:00:00' AS Time), CAST(320.00 AS Decimal(10, 2)))
INSERT [dbo].[Training] ([training_id], [participant_id], [trainer_id], [yacht_id], [date], [start_time], [end_time], [cost]) VALUES (46, 2, 2, 2, CAST(N'2023-10-05' AS Date), CAST(N'08:00:00' AS Time), CAST(N'10:00:00' AS Time), CAST(320.00 AS Decimal(10, 2)))
INSERT [dbo].[Training] ([training_id], [participant_id], [trainer_id], [yacht_id], [date], [start_time], [end_time], [cost]) VALUES (47, 2, 2, 2, CAST(N'2023-10-07' AS Date), CAST(N'08:00:00' AS Time), CAST(N'10:00:00' AS Time), CAST(320.00 AS Decimal(10, 2)))
INSERT [dbo].[Training] ([training_id], [participant_id], [trainer_id], [yacht_id], [date], [start_time], [end_time], [cost]) VALUES (48, 2, 2, 2, CAST(N'2023-10-10' AS Date), CAST(N'08:00:00' AS Time), CAST(N'10:00:00' AS Time), CAST(320.00 AS Decimal(10, 2)))
INSERT [dbo].[Training] ([training_id], [participant_id], [trainer_id], [yacht_id], [date], [start_time], [end_time], [cost]) VALUES (49, 2, 2, 2, CAST(N'2023-10-12' AS Date), CAST(N'08:00:00' AS Time), CAST(N'10:00:00' AS Time), CAST(320.00 AS Decimal(10, 2)))
INSERT [dbo].[Training] ([training_id], [participant_id], [trainer_id], [yacht_id], [date], [start_time], [end_time], [cost]) VALUES (50, 2, 2, 2, CAST(N'2023-10-14' AS Date), CAST(N'08:00:00' AS Time), CAST(N'10:00:00' AS Time), CAST(320.00 AS Decimal(10, 2)))
INSERT [dbo].[Training] ([training_id], [participant_id], [trainer_id], [yacht_id], [date], [start_time], [end_time], [cost]) VALUES (51, 2, 2, 2, CAST(N'2023-10-17' AS Date), CAST(N'08:00:00' AS Time), CAST(N'10:00:00' AS Time), CAST(320.00 AS Decimal(10, 2)))
INSERT [dbo].[Training] ([training_id], [participant_id], [trainer_id], [yacht_id], [date], [start_time], [end_time], [cost]) VALUES (52, 2, 2, 2, CAST(N'2023-10-19' AS Date), CAST(N'08:00:00' AS Time), CAST(N'10:00:00' AS Time), CAST(320.00 AS Decimal(10, 2)))
INSERT [dbo].[Training] ([training_id], [participant_id], [trainer_id], [yacht_id], [date], [start_time], [end_time], [cost]) VALUES (53, 2, 2, 2, CAST(N'2023-10-21' AS Date), CAST(N'08:00:00' AS Time), CAST(N'10:00:00' AS Time), CAST(320.00 AS Decimal(10, 2)))
INSERT [dbo].[Training] ([training_id], [participant_id], [trainer_id], [yacht_id], [date], [start_time], [end_time], [cost]) VALUES (54, 2, 2, 2, CAST(N'2023-10-24' AS Date), CAST(N'08:00:00' AS Time), CAST(N'10:00:00' AS Time), CAST(320.00 AS Decimal(10, 2)))
INSERT [dbo].[Training] ([training_id], [participant_id], [trainer_id], [yacht_id], [date], [start_time], [end_time], [cost]) VALUES (55, 2, 2, 2, CAST(N'2023-10-26' AS Date), CAST(N'08:00:00' AS Time), CAST(N'10:00:00' AS Time), CAST(320.00 AS Decimal(10, 2)))
INSERT [dbo].[Training] ([training_id], [participant_id], [trainer_id], [yacht_id], [date], [start_time], [end_time], [cost]) VALUES (56, 2, 2, 2, CAST(N'2023-10-28' AS Date), CAST(N'08:00:00' AS Time), CAST(N'10:00:00' AS Time), CAST(320.00 AS Decimal(10, 2)))
INSERT [dbo].[Training] ([training_id], [participant_id], [trainer_id], [yacht_id], [date], [start_time], [end_time], [cost]) VALUES (57, 3, 3, 3, CAST(N'2023-10-04' AS Date), CAST(N'09:00:00' AS Time), CAST(N'12:00:00' AS Time), CAST(350.00 AS Decimal(10, 2)))
INSERT [dbo].[Training] ([training_id], [participant_id], [trainer_id], [yacht_id], [date], [start_time], [end_time], [cost]) VALUES (58, 3, 3, 3, CAST(N'2023-10-08' AS Date), CAST(N'09:00:00' AS Time), CAST(N'12:00:00' AS Time), CAST(350.00 AS Decimal(10, 2)))
INSERT [dbo].[Training] ([training_id], [participant_id], [trainer_id], [yacht_id], [date], [start_time], [end_time], [cost]) VALUES (59, 3, 3, 3, CAST(N'2023-10-11' AS Date), CAST(N'09:00:00' AS Time), CAST(N'12:00:00' AS Time), CAST(350.00 AS Decimal(10, 2)))
INSERT [dbo].[Training] ([training_id], [participant_id], [trainer_id], [yacht_id], [date], [start_time], [end_time], [cost]) VALUES (60, 3, 3, 3, CAST(N'2023-10-15' AS Date), CAST(N'09:00:00' AS Time), CAST(N'12:00:00' AS Time), CAST(350.00 AS Decimal(10, 2)))
INSERT [dbo].[Training] ([training_id], [participant_id], [trainer_id], [yacht_id], [date], [start_time], [end_time], [cost]) VALUES (61, 3, 3, 3, CAST(N'2023-10-18' AS Date), CAST(N'09:00:00' AS Time), CAST(N'12:00:00' AS Time), CAST(350.00 AS Decimal(10, 2)))
INSERT [dbo].[Training] ([training_id], [participant_id], [trainer_id], [yacht_id], [date], [start_time], [end_time], [cost]) VALUES (62, 3, 3, 3, CAST(N'2023-10-22' AS Date), CAST(N'09:00:00' AS Time), CAST(N'12:00:00' AS Time), CAST(350.00 AS Decimal(10, 2)))
INSERT [dbo].[Training] ([training_id], [participant_id], [trainer_id], [yacht_id], [date], [start_time], [end_time], [cost]) VALUES (63, 3, 3, 3, CAST(N'2023-10-25' AS Date), CAST(N'09:00:00' AS Time), CAST(N'12:00:00' AS Time), CAST(350.00 AS Decimal(10, 2)))
INSERT [dbo].[Training] ([training_id], [participant_id], [trainer_id], [yacht_id], [date], [start_time], [end_time], [cost]) VALUES (64, 3, 3, 3, CAST(N'2023-10-29' AS Date), CAST(N'09:00:00' AS Time), CAST(N'12:00:00' AS Time), CAST(350.00 AS Decimal(10, 2)))
INSERT [dbo].[Training] ([training_id], [participant_id], [trainer_id], [yacht_id], [date], [start_time], [end_time], [cost]) VALUES (65, 4, 4, 4, CAST(N'2023-10-02' AS Date), CAST(N'10:00:00' AS Time), CAST(N'12:00:00' AS Time), CAST(300.00 AS Decimal(10, 2)))
INSERT [dbo].[Training] ([training_id], [participant_id], [trainer_id], [yacht_id], [date], [start_time], [end_time], [cost]) VALUES (66, 4, 4, 4, CAST(N'2023-10-06' AS Date), CAST(N'10:00:00' AS Time), CAST(N'12:00:00' AS Time), CAST(300.00 AS Decimal(10, 2)))
INSERT [dbo].[Training] ([training_id], [participant_id], [trainer_id], [yacht_id], [date], [start_time], [end_time], [cost]) VALUES (67, 4, 4, 4, CAST(N'2023-10-09' AS Date), CAST(N'10:00:00' AS Time), CAST(N'12:00:00' AS Time), CAST(300.00 AS Decimal(10, 2)))
INSERT [dbo].[Training] ([training_id], [participant_id], [trainer_id], [yacht_id], [date], [start_time], [end_time], [cost]) VALUES (68, 4, 4, 4, CAST(N'2023-10-13' AS Date), CAST(N'10:00:00' AS Time), CAST(N'12:00:00' AS Time), CAST(300.00 AS Decimal(10, 2)))
INSERT [dbo].[Training] ([training_id], [participant_id], [trainer_id], [yacht_id], [date], [start_time], [end_time], [cost]) VALUES (69, 4, 4, 4, CAST(N'2023-10-16' AS Date), CAST(N'10:00:00' AS Time), CAST(N'12:00:00' AS Time), CAST(300.00 AS Decimal(10, 2)))
INSERT [dbo].[Training] ([training_id], [participant_id], [trainer_id], [yacht_id], [date], [start_time], [end_time], [cost]) VALUES (70, 4, 4, 4, CAST(N'2023-10-20' AS Date), CAST(N'10:00:00' AS Time), CAST(N'12:00:00' AS Time), CAST(300.00 AS Decimal(10, 2)))
INSERT [dbo].[Training] ([training_id], [participant_id], [trainer_id], [yacht_id], [date], [start_time], [end_time], [cost]) VALUES (71, 4, 4, 4, CAST(N'2023-10-23' AS Date), CAST(N'10:00:00' AS Time), CAST(N'12:00:00' AS Time), CAST(300.00 AS Decimal(10, 2)))
INSERT [dbo].[Training] ([training_id], [participant_id], [trainer_id], [yacht_id], [date], [start_time], [end_time], [cost]) VALUES (72, 4, 4, 4, CAST(N'2023-10-27' AS Date), CAST(N'10:00:00' AS Time), CAST(N'12:00:00' AS Time), CAST(300.00 AS Decimal(10, 2)))
INSERT [dbo].[Training] ([training_id], [participant_id], [trainer_id], [yacht_id], [date], [start_time], [end_time], [cost]) VALUES (73, 5, 5, 5, CAST(N'2023-10-01' AS Date), CAST(N'14:00:00' AS Time), CAST(N'18:00:00' AS Time), CAST(500.00 AS Decimal(10, 2)))
INSERT [dbo].[Training] ([training_id], [participant_id], [trainer_id], [yacht_id], [date], [start_time], [end_time], [cost]) VALUES (74, 5, 5, 5, CAST(N'2023-10-08' AS Date), CAST(N'14:00:00' AS Time), CAST(N'18:00:00' AS Time), CAST(500.00 AS Decimal(10, 2)))
INSERT [dbo].[Training] ([training_id], [participant_id], [trainer_id], [yacht_id], [date], [start_time], [end_time], [cost]) VALUES (75, 5, 5, 5, CAST(N'2023-10-15' AS Date), CAST(N'14:00:00' AS Time), CAST(N'18:00:00' AS Time), CAST(500.00 AS Decimal(10, 2)))
INSERT [dbo].[Training] ([training_id], [participant_id], [trainer_id], [yacht_id], [date], [start_time], [end_time], [cost]) VALUES (76, 5, 5, 5, CAST(N'2023-10-22' AS Date), CAST(N'14:00:00' AS Time), CAST(N'18:00:00' AS Time), CAST(500.00 AS Decimal(10, 2)))
INSERT [dbo].[Training] ([training_id], [participant_id], [trainer_id], [yacht_id], [date], [start_time], [end_time], [cost]) VALUES (77, 6, 6, 6, CAST(N'2023-10-02' AS Date), CAST(N'18:00:00' AS Time), CAST(N'19:30:00' AS Time), CAST(260.00 AS Decimal(10, 2)))
INSERT [dbo].[Training] ([training_id], [participant_id], [trainer_id], [yacht_id], [date], [start_time], [end_time], [cost]) VALUES (78, 6, 6, 6, CAST(N'2023-10-09' AS Date), CAST(N'18:00:00' AS Time), CAST(N'19:30:00' AS Time), CAST(260.00 AS Decimal(10, 2)))
INSERT [dbo].[Training] ([training_id], [participant_id], [trainer_id], [yacht_id], [date], [start_time], [end_time], [cost]) VALUES (79, 6, 6, 6, CAST(N'2023-10-16' AS Date), CAST(N'18:00:00' AS Time), CAST(N'19:30:00' AS Time), CAST(260.00 AS Decimal(10, 2)))
INSERT [dbo].[Training] ([training_id], [participant_id], [trainer_id], [yacht_id], [date], [start_time], [end_time], [cost]) VALUES (80, 6, 6, 6, CAST(N'2023-10-23' AS Date), CAST(N'18:00:00' AS Time), CAST(N'19:30:00' AS Time), CAST(260.00 AS Decimal(10, 2)))
INSERT [dbo].[Training] ([training_id], [participant_id], [trainer_id], [yacht_id], [date], [start_time], [end_time], [cost]) VALUES (81, 6, 6, 6, CAST(N'2023-10-30' AS Date), CAST(N'18:00:00' AS Time), CAST(N'19:30:00' AS Time), CAST(260.00 AS Decimal(10, 2)))
INSERT [dbo].[Training] ([training_id], [participant_id], [trainer_id], [yacht_id], [date], [start_time], [end_time], [cost]) VALUES (82, 6, 6, 6, CAST(N'2023-10-04' AS Date), CAST(N'18:00:00' AS Time), CAST(N'19:30:00' AS Time), CAST(260.00 AS Decimal(10, 2)))
INSERT [dbo].[Training] ([training_id], [participant_id], [trainer_id], [yacht_id], [date], [start_time], [end_time], [cost]) VALUES (83, 6, 6, 6, CAST(N'2023-10-11' AS Date), CAST(N'18:00:00' AS Time), CAST(N'19:30:00' AS Time), CAST(260.00 AS Decimal(10, 2)))
INSERT [dbo].[Training] ([training_id], [participant_id], [trainer_id], [yacht_id], [date], [start_time], [end_time], [cost]) VALUES (84, 6, 6, 6, CAST(N'2023-10-18' AS Date), CAST(N'18:00:00' AS Time), CAST(N'19:30:00' AS Time), CAST(260.00 AS Decimal(10, 2)))
INSERT [dbo].[Training] ([training_id], [participant_id], [trainer_id], [yacht_id], [date], [start_time], [end_time], [cost]) VALUES (85, 6, 6, 6, CAST(N'2023-10-25' AS Date), CAST(N'18:00:00' AS Time), CAST(N'19:30:00' AS Time), CAST(260.00 AS Decimal(10, 2)))
INSERT [dbo].[Training] ([training_id], [participant_id], [trainer_id], [yacht_id], [date], [start_time], [end_time], [cost]) VALUES (86, 6, 6, 6, CAST(N'2023-10-06' AS Date), CAST(N'18:00:00' AS Time), CAST(N'19:30:00' AS Time), CAST(260.00 AS Decimal(10, 2)))
INSERT [dbo].[Training] ([training_id], [participant_id], [trainer_id], [yacht_id], [date], [start_time], [end_time], [cost]) VALUES (87, 6, 6, 6, CAST(N'2023-10-13' AS Date), CAST(N'18:00:00' AS Time), CAST(N'19:30:00' AS Time), CAST(260.00 AS Decimal(10, 2)))
INSERT [dbo].[Training] ([training_id], [participant_id], [trainer_id], [yacht_id], [date], [start_time], [end_time], [cost]) VALUES (88, 6, 6, 6, CAST(N'2023-10-20' AS Date), CAST(N'18:00:00' AS Time), CAST(N'19:30:00' AS Time), CAST(260.00 AS Decimal(10, 2)))
INSERT [dbo].[Training] ([training_id], [participant_id], [trainer_id], [yacht_id], [date], [start_time], [end_time], [cost]) VALUES (89, 7, 7, 7, CAST(N'2023-10-06' AS Date), CAST(N'16:00:00' AS Time), CAST(N'18:00:00' AS Time), CAST(290.00 AS Decimal(10, 2)))
INSERT [dbo].[Training] ([training_id], [participant_id], [trainer_id], [yacht_id], [date], [start_time], [end_time], [cost]) VALUES (90, 7, 7, 7, CAST(N'2023-10-13' AS Date), CAST(N'16:00:00' AS Time), CAST(N'18:00:00' AS Time), CAST(290.00 AS Decimal(10, 2)))
INSERT [dbo].[Training] ([training_id], [participant_id], [trainer_id], [yacht_id], [date], [start_time], [end_time], [cost]) VALUES (91, 7, 7, 7, CAST(N'2023-10-20' AS Date), CAST(N'16:00:00' AS Time), CAST(N'18:00:00' AS Time), CAST(290.00 AS Decimal(10, 2)))
INSERT [dbo].[Training] ([training_id], [participant_id], [trainer_id], [yacht_id], [date], [start_time], [end_time], [cost]) VALUES (92, 7, 7, 7, CAST(N'2023-10-27' AS Date), CAST(N'16:00:00' AS Time), CAST(N'18:00:00' AS Time), CAST(290.00 AS Decimal(10, 2)))
INSERT [dbo].[Training] ([training_id], [participant_id], [trainer_id], [yacht_id], [date], [start_time], [end_time], [cost]) VALUES (93, 8, 8, 8, CAST(N'2023-10-04' AS Date), CAST(N'17:30:00' AS Time), CAST(N'19:00:00' AS Time), CAST(250.00 AS Decimal(10, 2)))
INSERT [dbo].[Training] ([training_id], [participant_id], [trainer_id], [yacht_id], [date], [start_time], [end_time], [cost]) VALUES (94, 8, 8, 8, CAST(N'2023-10-11' AS Date), CAST(N'17:30:00' AS Time), CAST(N'19:00:00' AS Time), CAST(250.00 AS Decimal(10, 2)))
INSERT [dbo].[Training] ([training_id], [participant_id], [trainer_id], [yacht_id], [date], [start_time], [end_time], [cost]) VALUES (95, 8, 8, 8, CAST(N'2023-10-18' AS Date), CAST(N'17:30:00' AS Time), CAST(N'19:00:00' AS Time), CAST(250.00 AS Decimal(10, 2)))
INSERT [dbo].[Training] ([training_id], [participant_id], [trainer_id], [yacht_id], [date], [start_time], [end_time], [cost]) VALUES (96, 8, 8, 8, CAST(N'2023-10-25' AS Date), CAST(N'17:30:00' AS Time), CAST(N'19:00:00' AS Time), CAST(250.00 AS Decimal(10, 2)))
INSERT [dbo].[Training] ([training_id], [participant_id], [trainer_id], [yacht_id], [date], [start_time], [end_time], [cost]) VALUES (97, 8, 8, 8, CAST(N'2023-10-07' AS Date), CAST(N'13:00:00' AS Time), CAST(N'15:00:00' AS Time), CAST(400.00 AS Decimal(10, 2)))
INSERT [dbo].[Training] ([training_id], [participant_id], [trainer_id], [yacht_id], [date], [start_time], [end_time], [cost]) VALUES (98, 8, 8, 8, CAST(N'2023-10-14' AS Date), CAST(N'13:00:00' AS Time), CAST(N'15:00:00' AS Time), CAST(400.00 AS Decimal(10, 2)))
INSERT [dbo].[Training] ([training_id], [participant_id], [trainer_id], [yacht_id], [date], [start_time], [end_time], [cost]) VALUES (99, 8, 8, 8, CAST(N'2023-10-21' AS Date), CAST(N'13:00:00' AS Time), CAST(N'15:00:00' AS Time), CAST(400.00 AS Decimal(10, 2)))
INSERT [dbo].[Training] ([training_id], [participant_id], [trainer_id], [yacht_id], [date], [start_time], [end_time], [cost]) VALUES (100, 8, 8, 8, CAST(N'2023-10-28' AS Date), CAST(N'13:00:00' AS Time), CAST(N'15:00:00' AS Time), CAST(400.00 AS Decimal(10, 2)))
INSERT [dbo].[Training] ([training_id], [participant_id], [trainer_id], [yacht_id], [date], [start_time], [end_time], [cost]) VALUES (101, 9, 9, 9, CAST(N'2023-10-03' AS Date), CAST(N'16:00:00' AS Time), CAST(N'18:30:00' AS Time), CAST(500.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[Training] ([training_id], [participant_id], [trainer_id], [yacht_id], [date], [start_time], [end_time], [cost]) VALUES (102, 9, 9, 9, CAST(N'2023-10-10' AS Date), CAST(N'16:00:00' AS Time), CAST(N'18:30:00' AS Time), CAST(500.00 AS Decimal(10, 2)))
INSERT [dbo].[Training] ([training_id], [participant_id], [trainer_id], [yacht_id], [date], [start_time], [end_time], [cost]) VALUES (103, 9, 9, 9, CAST(N'2023-10-17' AS Date), CAST(N'16:00:00' AS Time), CAST(N'18:30:00' AS Time), CAST(500.00 AS Decimal(10, 2)))
INSERT [dbo].[Training] ([training_id], [participant_id], [trainer_id], [yacht_id], [date], [start_time], [end_time], [cost]) VALUES (104, 9, 9, 9, CAST(N'2023-10-24' AS Date), CAST(N'16:00:00' AS Time), CAST(N'18:30:00' AS Time), CAST(500.00 AS Decimal(10, 2)))
INSERT [dbo].[Training] ([training_id], [participant_id], [trainer_id], [yacht_id], [date], [start_time], [end_time], [cost]) VALUES (105, 9, 9, 9, CAST(N'2023-10-31' AS Date), CAST(N'16:00:00' AS Time), CAST(N'18:30:00' AS Time), CAST(500.00 AS Decimal(10, 2)))
INSERT [dbo].[Training] ([training_id], [participant_id], [trainer_id], [yacht_id], [date], [start_time], [end_time], [cost]) VALUES (106, 9, 9, 9, CAST(N'2023-10-07' AS Date), CAST(N'16:00:00' AS Time), CAST(N'18:30:00' AS Time), CAST(500.00 AS Decimal(10, 2)))
INSERT [dbo].[Training] ([training_id], [participant_id], [trainer_id], [yacht_id], [date], [start_time], [end_time], [cost]) VALUES (107, 9, 9, 9, CAST(N'2023-10-14' AS Date), CAST(N'16:00:00' AS Time), CAST(N'18:30:00' AS Time), CAST(500.00 AS Decimal(10, 2)))
INSERT [dbo].[Training] ([training_id], [participant_id], [trainer_id], [yacht_id], [date], [start_time], [end_time], [cost]) VALUES (108, 9, 9, 9, CAST(N'2023-10-21' AS Date), CAST(N'16:00:00' AS Time), CAST(N'18:30:00' AS Time), CAST(500.00 AS Decimal(10, 2)))
INSERT [dbo].[Training] ([training_id], [participant_id], [trainer_id], [yacht_id], [date], [start_time], [end_time], [cost]) VALUES (109, 9, 9, 9, CAST(N'2023-10-28' AS Date), CAST(N'16:00:00' AS Time), CAST(N'18:30:00' AS Time), CAST(500.00 AS Decimal(10, 2)))
INSERT [dbo].[Training] ([training_id], [participant_id], [trainer_id], [yacht_id], [date], [start_time], [end_time], [cost]) VALUES (110, 9, 9, 9, CAST(N'2023-10-08' AS Date), CAST(N'16:00:00' AS Time), CAST(N'18:30:00' AS Time), CAST(500.00 AS Decimal(10, 2)))
INSERT [dbo].[Training] ([training_id], [participant_id], [trainer_id], [yacht_id], [date], [start_time], [end_time], [cost]) VALUES (111, 9, 9, 9, CAST(N'2023-10-15' AS Date), CAST(N'16:00:00' AS Time), CAST(N'18:30:00' AS Time), CAST(500.00 AS Decimal(10, 2)))
INSERT [dbo].[Training] ([training_id], [participant_id], [trainer_id], [yacht_id], [date], [start_time], [end_time], [cost]) VALUES (112, 9, 9, 9, CAST(N'2023-10-22' AS Date), CAST(N'16:00:00' AS Time), CAST(N'18:30:00' AS Time), CAST(500.00 AS Decimal(10, 2)))
INSERT [dbo].[Training] ([training_id], [participant_id], [trainer_id], [yacht_id], [date], [start_time], [end_time], [cost]) VALUES (113, 10, 10, 10, CAST(N'2023-10-05' AS Date), CAST(N'18:00:00' AS Time), CAST(N'20:00:00' AS Time), CAST(350.00 AS Decimal(10, 2)))
INSERT [dbo].[Training] ([training_id], [participant_id], [trainer_id], [yacht_id], [date], [start_time], [end_time], [cost]) VALUES (114, 10, 10, 10, CAST(N'2023-10-12' AS Date), CAST(N'18:00:00' AS Time), CAST(N'20:00:00' AS Time), CAST(350.00 AS Decimal(10, 2)))
INSERT [dbo].[Training] ([training_id], [participant_id], [trainer_id], [yacht_id], [date], [start_time], [end_time], [cost]) VALUES (115, 10, 10, 10, CAST(N'2023-10-19' AS Date), CAST(N'18:00:00' AS Time), CAST(N'20:00:00' AS Time), CAST(350.00 AS Decimal(10, 2)))
INSERT [dbo].[Training] ([training_id], [participant_id], [trainer_id], [yacht_id], [date], [start_time], [end_time], [cost]) VALUES (116, 10, 10, 10, CAST(N'2023-10-26' AS Date), CAST(N'18:00:00' AS Time), CAST(N'20:00:00' AS Time), CAST(350.00 AS Decimal(10, 2)))
INSERT [dbo].[Training] ([training_id], [participant_id], [trainer_id], [yacht_id], [date], [start_time], [end_time], [cost]) VALUES (117, 11, 11, 11, CAST(N'2023-10-04' AS Date), CAST(N'13:30:00' AS Time), CAST(N'14:30:00' AS Time), CAST(280.00 AS Decimal(10, 2)))
INSERT [dbo].[Training] ([training_id], [participant_id], [trainer_id], [yacht_id], [date], [start_time], [end_time], [cost]) VALUES (118, 11, 11, 11, CAST(N'2023-10-11' AS Date), CAST(N'13:30:00' AS Time), CAST(N'14:30:00' AS Time), CAST(280.00 AS Decimal(10, 2)))
INSERT [dbo].[Training] ([training_id], [participant_id], [trainer_id], [yacht_id], [date], [start_time], [end_time], [cost]) VALUES (119, 11, 11, 11, CAST(N'2023-10-18' AS Date), CAST(N'13:30:00' AS Time), CAST(N'14:30:00' AS Time), CAST(280.00 AS Decimal(10, 2)))
INSERT [dbo].[Training] ([training_id], [participant_id], [trainer_id], [yacht_id], [date], [start_time], [end_time], [cost]) VALUES (120, 11, 11, 11, CAST(N'2023-10-25' AS Date), CAST(N'13:30:00' AS Time), CAST(N'14:30:00' AS Time), CAST(280.00 AS Decimal(10, 2)))
INSERT [dbo].[Training] ([training_id], [participant_id], [trainer_id], [yacht_id], [date], [start_time], [end_time], [cost]) VALUES (121, 11, 11, 11, CAST(N'2023-10-06' AS Date), CAST(N'13:30:00' AS Time), CAST(N'15:00:00' AS Time), CAST(320.00 AS Decimal(10, 2)))
INSERT [dbo].[Training] ([training_id], [participant_id], [trainer_id], [yacht_id], [date], [start_time], [end_time], [cost]) VALUES (122, 11, 11, 11, CAST(N'2023-10-13' AS Date), CAST(N'13:30:00' AS Time), CAST(N'15:00:00' AS Time), CAST(320.00 AS Decimal(10, 2)))
INSERT [dbo].[Training] ([training_id], [participant_id], [trainer_id], [yacht_id], [date], [start_time], [end_time], [cost]) VALUES (123, 11, 11, 11, CAST(N'2023-10-20' AS Date), CAST(N'13:30:00' AS Time), CAST(N'15:00:00' AS Time), CAST(320.00 AS Decimal(10, 2)))
INSERT [dbo].[Training] ([training_id], [participant_id], [trainer_id], [yacht_id], [date], [start_time], [end_time], [cost]) VALUES (124, 11, 11, 11, CAST(N'2023-10-27' AS Date), CAST(N'13:30:00' AS Time), CAST(N'15:00:00' AS Time), CAST(320.00 AS Decimal(10, 2)))
INSERT [dbo].[Training] ([training_id], [participant_id], [trainer_id], [yacht_id], [date], [start_time], [end_time], [cost]) VALUES (125, 12, 12, 12, CAST(N'2023-10-04' AS Date), CAST(N'19:00:00' AS Time), CAST(N'20:30:00' AS Time), CAST(350.00 AS Decimal(10, 2)))
INSERT [dbo].[Training] ([training_id], [participant_id], [trainer_id], [yacht_id], [date], [start_time], [end_time], [cost]) VALUES (126, 12, 12, 12, CAST(N'2023-10-11' AS Date), CAST(N'19:00:00' AS Time), CAST(N'20:30:00' AS Time), CAST(350.00 AS Decimal(10, 2)))
INSERT [dbo].[Training] ([training_id], [participant_id], [trainer_id], [yacht_id], [date], [start_time], [end_time], [cost]) VALUES (127, 12, 12, 12, CAST(N'2023-10-18' AS Date), CAST(N'19:00:00' AS Time), CAST(N'20:30:00' AS Time), CAST(350.00 AS Decimal(10, 2)))
INSERT [dbo].[Training] ([training_id], [participant_id], [trainer_id], [yacht_id], [date], [start_time], [end_time], [cost]) VALUES (128, 12, 12, 12, CAST(N'2023-10-25' AS Date), CAST(N'19:00:00' AS Time), CAST(N'20:30:00' AS Time), CAST(350.00 AS Decimal(10, 2)))
SET IDENTITY_INSERT [dbo].[Training] OFF
GO
SET IDENTITY_INSERT [dbo].[Yacht] ON 

INSERT [dbo].[Yacht] ([yacht_id], [model], [yacht_type], [condition], [manufacturing_year], [rental_cost]) VALUES (1, N'Пегас 31', N'Гоночна', N'готова до використання', 2010, CAST(1800.00 AS Decimal(10, 2)))
INSERT [dbo].[Yacht] ([yacht_id], [model], [yacht_type], [condition], [manufacturing_year], [rental_cost]) VALUES (2, N'Наві', N'Гоночна', N'в ремонті', 2012, CAST(850.00 AS Decimal(10, 2)))
INSERT [dbo].[Yacht] ([yacht_id], [model], [yacht_type], [condition], [manufacturing_year], [rental_cost]) VALUES (3, N'Санторіні', N'Гоночна', N'готова до використання', 2014, CAST(1400.00 AS Decimal(10, 2)))
INSERT [dbo].[Yacht] ([yacht_id], [model], [yacht_type], [condition], [manufacturing_year], [rental_cost]) VALUES (4, N'Королева', N'Гоночна', N'готова до використання', 2016, CAST(700.00 AS Decimal(10, 2)))
INSERT [dbo].[Yacht] ([yacht_id], [model], [yacht_type], [condition], [manufacturing_year], [rental_cost]) VALUES (5, N'Деланта', N'Гоночна', N'готова до використання', 2018, CAST(1000.00 AS Decimal(10, 2)))
INSERT [dbo].[Yacht] ([yacht_id], [model], [yacht_type], [condition], [manufacturing_year], [rental_cost]) VALUES (6, N'Хантер 320', N'Гоночна', N'в ремонті', 2015, CAST(1800.00 AS Decimal(10, 2)))
INSERT [dbo].[Yacht] ([yacht_id], [model], [yacht_type], [condition], [manufacturing_year], [rental_cost]) VALUES (7, N'Баварія Міні', N'Гоночна', N'готова до використання', 2011, CAST(1000.00 AS Decimal(10, 2)))
INSERT [dbo].[Yacht] ([yacht_id], [model], [yacht_type], [condition], [manufacturing_year], [rental_cost]) VALUES (8, N'Октант', N'Гоночна', N'потребує ремонту', 2013, CAST(750.00 AS Decimal(10, 2)))
INSERT [dbo].[Yacht] ([yacht_id], [model], [yacht_type], [condition], [manufacturing_year], [rental_cost]) VALUES (9, N'Астра', N'Гоночна', N'готова до використання', 2017, CAST(700.00 AS Decimal(10, 2)))
INSERT [dbo].[Yacht] ([yacht_id], [model], [yacht_type], [condition], [manufacturing_year], [rental_cost]) VALUES (10, N'СТ28', N'Гоночна', N'готова до використання', 2019, CAST(950.00 AS Decimal(10, 2)))
INSERT [dbo].[Yacht] ([yacht_id], [model], [yacht_type], [condition], [manufacturing_year], [rental_cost]) VALUES (11, N'Ліра', N'Гоночна', N'потребує ремонту', 2009, CAST(1100.00 AS Decimal(10, 2)))
INSERT [dbo].[Yacht] ([yacht_id], [model], [yacht_type], [condition], [manufacturing_year], [rental_cost]) VALUES (12, N'Конрад 25', N'Гоночна', N'готова до використання', 2007, CAST(1200.00 AS Decimal(10, 2)))
INSERT [dbo].[Yacht] ([yacht_id], [model], [yacht_type], [condition], [manufacturing_year], [rental_cost]) VALUES (22, N'Софа', N'Гоночна', N'потребує ремонту', 2005, CAST(600.00 AS Decimal(10, 2)))
INSERT [dbo].[Yacht] ([yacht_id], [model], [yacht_type], [condition], [manufacturing_year], [rental_cost]) VALUES (24, N'Пегас', N'Гоночна', N'в ремонті', 2015, CAST(700.00 AS Decimal(10, 2)))
INSERT [dbo].[Yacht] ([yacht_id], [model], [yacht_type], [condition], [manufacturing_year], [rental_cost]) VALUES (25, N'Розанна', N'Гоночна', N'готова до використання', 2004, CAST(450.00 AS Decimal(10, 2)))
SET IDENTITY_INSERT [dbo].[Yacht] OFF
GO
ALTER TABLE [dbo].[ClubMembership]  WITH CHECK ADD FOREIGN KEY([participant_id])
REFERENCES [dbo].[Participant] ([participant_id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Participation]  WITH CHECK ADD FOREIGN KEY([competition_id])
REFERENCES [dbo].[Competition] ([competition_id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Participation]  WITH CHECK ADD FOREIGN KEY([participant_id])
REFERENCES [dbo].[Participant] ([participant_id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Participation]  WITH CHECK ADD FOREIGN KEY([yacht_id])
REFERENCES [dbo].[Yacht] ([yacht_id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Service]  WITH CHECK ADD FOREIGN KEY([yacht_id])
REFERENCES [dbo].[Yacht] ([yacht_id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Training]  WITH CHECK ADD FOREIGN KEY([participant_id])
REFERENCES [dbo].[Participant] ([participant_id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Training]  WITH CHECK ADD FOREIGN KEY([trainer_id])
REFERENCES [dbo].[Trainer] ([trainer_id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Training]  WITH CHECK ADD FOREIGN KEY([yacht_id])
REFERENCES [dbo].[Yacht] ([yacht_id])
ON DELETE CASCADE
GO
USE [master]
GO
ALTER DATABASE [yacht_club] SET  READ_WRITE 
GO
