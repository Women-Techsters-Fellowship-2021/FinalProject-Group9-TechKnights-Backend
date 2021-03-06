USE [SchoolManagementSystemPTA]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 2021/09/17 08:55:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AddressData]    Script Date: 2021/09/17 08:55:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AddressData](
	[AddressId] [int] IDENTITY(1,1) NOT NULL,
	[PhysicalCountry] [nvarchar](50) NULL,
	[PhysicalProvince] [nvarchar](50) NULL,
	[PhysicalRegion] [nvarchar](50) NULL,
	[PhysicalCity] [nvarchar](50) NULL,
	[PhysicalAddress] [nvarchar](max) NULL,
	[PhysicalAddressLine2] [nvarchar](50) NULL,
	[PhysicalAddressLine3] [nvarchar](50) NULL,
	[PhysicalOther] [nvarchar](50) NULL,
	[PhysicalPostalCode] [nvarchar](50) NULL,
	[IsPostalSameAsPhysical] [bit] NULL,
	[PostalCountry] [nvarchar](50) NULL,
	[PostalProvince] [nvarchar](50) NULL,
	[PostalRegion] [nvarchar](50) NULL,
	[PostalCity] [nvarchar](50) NULL,
	[PostalAddress] [nvarchar](max) NULL,
	[PostalOther] [nvarchar](50) NULL,
	[PostalPostalCode] [nvarchar](50) NULL,
	[PostalAddressLine2] [nvarchar](50) NULL,
	[PostalAddressLine3] [nvarchar](50) NULL,
 CONSTRAINT [PK_AddressData] PRIMARY KEY CLUSTERED 
(
	[AddressId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetRoleClaims]    Script Date: 2021/09/17 08:55:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoleClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 2021/09/17 08:55:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](256) NULL,
	[NormalizedName] [nvarchar](256) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 2021/09/17 08:55:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 2021/09/17 08:55:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](128) NOT NULL,
	[ProviderKey] [nvarchar](128) NOT NULL,
	[ProviderDisplayName] [nvarchar](max) NULL,
	[UserId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 2021/09/17 08:55:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [nvarchar](450) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 2021/09/17 08:55:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [nvarchar](450) NOT NULL,
	[UserName] [nvarchar](256) NULL,
	[NormalizedUserName] [nvarchar](256) NULL,
	[Email] [nvarchar](256) NULL,
	[NormalizedEmail] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEnd] [datetimeoffset](7) NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
 CONSTRAINT [PK_AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUserTokens]    Script Date: 2021/09/17 08:55:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserTokens](
	[UserId] [nvarchar](450) NOT NULL,
	[LoginProvider] [nvarchar](128) NOT NULL,
	[Name] [nvarchar](128) NOT NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[LoginProvider] ASC,
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[EmailAuditData]    Script Date: 2021/09/17 08:55:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmailAuditData](
	[EmailAuditId] [int] IDENTITY(1,1) NOT NULL,
	[Mailto] [nvarchar](100) NULL,
	[MailFrom] [nvarchar](100) NULL,
	[EmailSubject] [nvarchar](50) NULL,
	[Body] [nvarchar](max) NULL,
	[DearName] [nvarchar](100) NULL,
	[SentToSystemRole] [nvarchar](50) NULL,
	[Id] [int] NULL,
	[DateCreated] [datetime] NULL,
	[CreatedBy] [nvarchar](50) NOT NULL,
	[DateModified] [datetime] NULL,
	[ModifiedBy] [nvarchar](50) NULL,
 CONSTRAINT [PK_EmailAuditData] PRIMARY KEY CLUSTERED 
(
	[EmailAuditId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ExamData]    Script Date: 2021/09/17 08:55:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ExamData](
	[ExamId] [int] NOT NULL,
	[Name] [nvarchar](150) NULL,
	[Date] [nvarchar](150) NULL,
	[Comment] [nvarchar](150) NULL,
 CONSTRAINT [PK_ExamData] PRIMARY KEY CLUSTERED 
(
	[ExamId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[GradeData]    Script Date: 2021/09/17 08:55:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GradeData](
	[GradeId] [int] IDENTITY(1,1) NOT NULL,
	[Grade] [nvarchar](50) NOT NULL,
	[GradePoint] [nvarchar](50) NOT NULL,
	[TotalFees] [numeric](18, 0) NOT NULL,
	[GradeDescrption] [nvarchar](max) NULL,
	[DateCreated] [datetime] NULL,
	[CreatedBy] [nvarchar](50) NOT NULL,
	[DateModified] [datetime] NULL,
	[ModifiedBy] [nvarchar](50) NULL,
 CONSTRAINT [PK_GradeData] PRIMARY KEY CLUSTERED 
(
	[GradeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[InvoiceData]    Script Date: 2021/09/17 08:55:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InvoiceData](
	[InvoiceId] [int] IDENTITY(1,1) NOT NULL,
	[StudentId] [int] NULL,
	[Title] [nvarchar](50) NULL,
	[Description] [nvarchar](50) NULL,
	[Amount] [float] NULL,
	[AmountPaid] [float] NULL,
	[Due] [float] NULL,
	[Status] [nvarchar](50) NULL,
	[PaymentMethod] [nvarchar](50) NULL,
	[DatePaid] [nvarchar](50) NULL,
 CONSTRAINT [PK_InvoiceData] PRIMARY KEY CLUSTERED 
(
	[InvoiceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[MarkData]    Script Date: 2021/09/17 08:55:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MarkData](
	[MarkId] [int] NULL,
	[StudentId] [int] NULL,
	[SubjectId] [int] NULL,
	[ExamId] [int] NULL,
	[MarkObtained] [int] NULL,
	[MarkTotal] [int] NULL,
	[Comment] [nvarchar](150) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ModuleData]    Script Date: 2021/09/17 08:55:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ModuleData](
	[ModuleId] [int] IDENTITY(1,1) NOT NULL,
	[GradeId] [int] NULL,
	[TeacherId] [int] NULL,
	[Module] [nvarchar](50) NULL,
	[PassPoint] [nvarchar](50) NULL,
	[Description] [nvarchar](max) NULL,
	[DateCreated] [datetime] NULL,
	[CreatedBy] [nvarchar](50) NOT NULL,
	[DateModified] [datetime] NULL,
	[ModifiedBy] [nvarchar](50) NULL,
 CONSTRAINT [PK_ModuleData] PRIMARY KEY CLUSTERED 
(
	[ModuleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ParentData]    Script Date: 2021/09/17 08:55:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ParentData](
	[ParentId] [int] IDENTITY(1,1) NOT NULL,
	[Firstname] [nvarchar](50) NOT NULL,
	[Midname] [nvarchar](50) NULL,
	[Surname] [nvarchar](50) NOT NULL,
	[Title] [nchar](10) NULL,
	[Gender] [nchar](10) NULL,
	[MaritalStatus] [nvarchar](20) NULL,
	[IsSouthAfrican] [bit] NULL,
	[DateOfBirth] [date] NULL,
	[IdOrPassport] [nvarchar](50) NULL,
	[HomeLanguage] [nvarchar](50) NULL,
	[PersonalEmailAddress] [nvarchar](100) NULL,
	[WorkTelNumber] [nvarchar](20) NULL,
	[HomeTelNumber] [nvarchar](20) NULL,
	[FaxNumber] [nvarchar](20) NULL,
	[CelPhoneNumber] [nvarchar](20) NULL,
	[CommunicationMethod] [nvarchar](20) NULL,
	[PreferedLanguage] [nvarchar](50) NULL,
	[IsActive] [bit] NULL,
	[CountryOfBirth] [nvarchar](50) NULL,
	[Token] [uniqueidentifier] NULL,
	[DateCreated] [datetime] NULL,
	[CreatedBy] [nvarchar](128) NULL,
	[DateModified] [datetime] NULL,
	[ModifiedBy] [nvarchar](128) NULL,
	[UserId] [nvarchar](128) NULL,
 CONSTRAINT [PK_ParentData] PRIMARY KEY CLUSTERED 
(
	[ParentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[StudentAddressData]    Script Date: 2021/09/17 08:55:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StudentAddressData](
	[StudentAddressId] [int] IDENTITY(1,1) NOT NULL,
	[StudentId] [int] NOT NULL,
	[AddressId] [int] NOT NULL,
 CONSTRAINT [PK_StudentAddressData] PRIMARY KEY CLUSTERED 
(
	[StudentAddressId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[StudentData]    Script Date: 2021/09/17 08:55:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StudentData](
	[StudentId] [int] IDENTITY(1,1) NOT NULL,
	[StudentNumber] [nvarchar](50) NOT NULL,
	[Firstname] [nvarchar](50) NOT NULL,
	[Midname] [nvarchar](50) NULL,
	[Surname] [nvarchar](50) NOT NULL,
	[Title] [nvarchar](50) NULL,
	[Gender] [nvarchar](50) NULL,
	[IsDisable] [nvarchar](20) NULL,
	[IsSouthAfrican] [bit] NULL,
	[DateOfBirth] [datetime] NULL,
	[IsActive] [bit] NOT NULL,
	[IdOrPassport] [nvarchar](50) NOT NULL,
	[HomeLanguage] [nvarchar](50) NULL,
	[CountryOfBirth] [nvarchar](50) NULL,
	[PersonalEmailAddress] [nvarchar](100) NULL,
	[WorkTelNumber] [nvarchar](20) NULL,
	[HomeTelNumber] [nvarchar](20) NULL,
	[FaxNumber] [nvarchar](20) NULL,
	[CelPhoneNumber] [nvarchar](20) NULL,
	[DateCreated] [datetime] NULL,
	[CreatedBy] [nvarchar](128) NULL,
	[DateModified] [datetime] NULL,
	[ModifiedBy] [nvarchar](128) NULL,
	[PreferedLanguage] [nvarchar](50) NULL,
	[CommunicationMethod] [nvarchar](20) NULL,
	[StudentPhoto] [nvarchar](max) NULL,
	[ApplicationStatus] [nvarchar](50) NULL,
	[Token] [uniqueidentifier] NULL,
	[UserId] [nvarchar](128) NULL,
	[GradeId] [int] NULL,
	[ParentId] [int] NULL,
 CONSTRAINT [PK_StudentData] PRIMARY KEY CLUSTERED 
(
	[StudentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TeacherData]    Script Date: 2021/09/17 08:55:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TeacherData](
	[TeacherId] [int] IDENTITY(1,1) NOT NULL,
	[Firstname] [nvarchar](50) NOT NULL,
	[Midname] [nvarchar](50) NULL,
	[Surname] [nvarchar](50) NULL,
	[Title] [nchar](10) NULL,
	[Gender] [nchar](10) NULL,
	[MaritalStatus] [nvarchar](20) NULL,
	[IsSouthAfrican] [bit] NULL,
	[DateOfBirth] [date] NULL,
	[IdOrPassport] [nvarchar](50) NULL,
	[HomeLanguage] [nvarchar](50) NULL,
	[PersonalEmailAddress] [nvarchar](100) NULL,
	[WorkTelNumber] [nvarchar](20) NULL,
	[HomeTelNumber] [nvarchar](20) NULL,
	[FaxNumber] [nvarchar](20) NULL,
	[CelPhoneNumber] [nvarchar](20) NULL,
	[PreferedLanguage] [nvarchar](50) NULL,
	[CountryOfBirth] [nvarchar](50) NULL,
	[CommunicationMethod] [nvarchar](20) NULL,
	[IsActive] [bit] NOT NULL,
	[DateCreated] [datetime] NULL,
	[CreatedBy] [nvarchar](128) NULL,
	[DateModified] [datetime] NULL,
	[ModifiedBy] [nvarchar](50) NULL,
	[UserId] [nvarchar](128) NULL,
 CONSTRAINT [PK_TeacherData] PRIMARY KEY CLUSTERED 
(
	[TeacherId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'00000000000000_CreateIdentitySchema', N'5.0.9')
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'ab1f8214-5b81-44e4-bbb5-852f1573f2c9', N'SystemAdmin', N'SYSTEMADMIN', N'ab1f8214-5b81-44e4-bbb5-852f1573f2c9')
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'ab1f8214-5b81-44e4-bbb5-852f1573fPar', N'Parent', N'PARENT', N'ab1f8214-5b81-44e4-bbb5-852f1573fPar')
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'ab1f8214-5b81-44e4-bbb5-852f1573fStu', N'Student', N'STUDENT', N'ab1f8214-5b81-44e4-bbb5-852f1573fStu')
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'ab1f8214-5b81-44e4-bbb5-852f1573fTea', N'Teacher', N'TEACHER', N'ab1f8214-5b81-44e4-bbb5-852f1573fTea')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'ab1f8214-5b81-44e4-bbb5-852f1573f2c9', N'ab1f8214-5b81-44e4-bbb5-852f1573f2c9')
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'ab1f8214-5b81-44e4-bbb5-852f1573f2c9', N'tech.knights9@yahoo.com', N'tech.knights9@yahoo.com', N'tech.knights9@yahoo.com', N'tech.knights9@yahoo.com', 1, N'AQAAAAEAACcQAAAAEPngKqdt5bInkAU/+kB/tDEc4dCmm1spi++F6A+FMhomiIQwAk7FZV/vrW9IiSPZ6w==', N'U37N6K3VLCGTXQH67UA6YPNNZZEBR7GE', N'a74e0f92-7667-4469-bf4e-83234e6779e9', N'0736681604', 0, 0, NULL, 1, 0)
ALTER TABLE [dbo].[EmailAuditData] ADD  CONSTRAINT [DF_EmailAuditData_DateCreated]  DEFAULT (getdate()) FOR [DateCreated]
GO
ALTER TABLE [dbo].[GradeData] ADD  CONSTRAINT [DF_GradeData_DateCreated]  DEFAULT (getdate()) FOR [DateCreated]
GO
ALTER TABLE [dbo].[ModuleData] ADD  CONSTRAINT [DF_ModuleData_DateCreated]  DEFAULT (getdate()) FOR [DateCreated]
GO
ALTER TABLE [dbo].[AspNetRoleClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetRoleClaims] CHECK CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserTokens]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserTokens] CHECK CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId]
GO
/****** Object:  StoredProcedure [dbo].[spActiveStudent]    Script Date: 2021/09/17 08:55:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spActiveStudent]
	
AS
BEGIN

  UPDATE [SchoolManagementSystemPTA].[dbo].[StudentData]
  SET IsActive =1
END

GO
