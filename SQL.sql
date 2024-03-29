USE [MASTER]
GO
CREATE Database Attendance_System[(Sharp)]
GO
USE [Attendance_System(Sharp)]
GO
/****** Object:  Table [dbo].[Attendance]    Script Date: 12/23/2018 6:19:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Attendance](
	[SR_No] [int] NOT NULL,
	[Date] [date] NOT NULL,
	[Status] [varchar](50) NOT NULL,
	[Comment] [text] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Guards]    Script Date: 12/23/2018 6:19:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Guards](
	[SR_No] [int] NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[CNIC_No] [varchar](50) NOT NULL,
	[Location] [varchar](500) NULL,
	[Shift] [varchar](50) NULL,
 CONSTRAINT [PK_Guards] PRIMARY KEY CLUSTERED 
(
	[SR_No] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Attendance] ([SR_No], [Date], [Status], [Comment]) VALUES (3, CAST(N'2018-09-25' AS Date), N'P', N'')
INSERT [dbo].[Attendance] ([SR_No], [Date], [Status], [Comment]) VALUES (4, CAST(N'2018-09-25' AS Date), N'P', N'')
INSERT [dbo].[Attendance] ([SR_No], [Date], [Status], [Comment]) VALUES (3, CAST(N'2018-08-06' AS Date), N'L', N'')
INSERT [dbo].[Attendance] ([SR_No], [Date], [Status], [Comment]) VALUES (5, CAST(N'2018-09-25' AS Date), N'A', N'')
INSERT [dbo].[Attendance] ([SR_No], [Date], [Status], [Comment]) VALUES (3, CAST(N'2018-08-07' AS Date), N'P', N'')
INSERT [dbo].[Attendance] ([SR_No], [Date], [Status], [Comment]) VALUES (6, CAST(N'2018-09-25' AS Date), N'A', N'')
INSERT [dbo].[Attendance] ([SR_No], [Date], [Status], [Comment]) VALUES (3, CAST(N'2018-08-05' AS Date), N'P', N'')
INSERT [dbo].[Attendance] ([SR_No], [Date], [Status], [Comment]) VALUES (4, CAST(N'2018-08-01' AS Date), N'A', N'')
INSERT [dbo].[Attendance] ([SR_No], [Date], [Status], [Comment]) VALUES (4, CAST(N'2018-08-07' AS Date), N'P', N'')
INSERT [dbo].[Attendance] ([SR_No], [Date], [Status], [Comment]) VALUES (4, CAST(N'2018-08-05' AS Date), N'P', N'')
INSERT [dbo].[Attendance] ([SR_No], [Date], [Status], [Comment]) VALUES (5, CAST(N'2018-08-07' AS Date), N'A', N'')
INSERT [dbo].[Attendance] ([SR_No], [Date], [Status], [Comment]) VALUES (6, CAST(N'2018-08-07' AS Date), N'A', N'')
INSERT [dbo].[Attendance] ([SR_No], [Date], [Status], [Comment]) VALUES (7, CAST(N'2018-08-07' AS Date), N'P', N'')
INSERT [dbo].[Attendance] ([SR_No], [Date], [Status], [Comment]) VALUES (8, CAST(N'2018-08-07' AS Date), N'L', N'')
INSERT [dbo].[Attendance] ([SR_No], [Date], [Status], [Comment]) VALUES (9, CAST(N'2018-08-07' AS Date), N'L', N'')
INSERT [dbo].[Attendance] ([SR_No], [Date], [Status], [Comment]) VALUES (10, CAST(N'2018-08-07' AS Date), N'L', N'')
INSERT [dbo].[Attendance] ([SR_No], [Date], [Status], [Comment]) VALUES (90, CAST(N'2018-08-07' AS Date), N'P', N'')
INSERT [dbo].[Attendance] ([SR_No], [Date], [Status], [Comment]) VALUES (7, CAST(N'2018-09-25' AS Date), N'L', N'')
INSERT [dbo].[Attendance] ([SR_No], [Date], [Status], [Comment]) VALUES (3, CAST(N'2018-08-15' AS Date), N'L', N'ppppp')
INSERT [dbo].[Attendance] ([SR_No], [Date], [Status], [Comment]) VALUES (5, CAST(N'2018-08-05' AS Date), N'A', N'')
INSERT [dbo].[Attendance] ([SR_No], [Date], [Status], [Comment]) VALUES (6, CAST(N'2018-08-05' AS Date), N'A', N'')
INSERT [dbo].[Attendance] ([SR_No], [Date], [Status], [Comment]) VALUES (7, CAST(N'2018-08-05' AS Date), N'A', N'')
INSERT [dbo].[Attendance] ([SR_No], [Date], [Status], [Comment]) VALUES (8, CAST(N'2018-08-05' AS Date), N'L', N'')
INSERT [dbo].[Attendance] ([SR_No], [Date], [Status], [Comment]) VALUES (9, CAST(N'2018-08-05' AS Date), N'L', N'')
INSERT [dbo].[Attendance] ([SR_No], [Date], [Status], [Comment]) VALUES (10, CAST(N'2018-08-05' AS Date), N'P', N'')
INSERT [dbo].[Attendance] ([SR_No], [Date], [Status], [Comment]) VALUES (90, CAST(N'2018-08-05' AS Date), N'P', N'')
INSERT [dbo].[Attendance] ([SR_No], [Date], [Status], [Comment]) VALUES (4, CAST(N'2018-08-15' AS Date), N'P', N'')
INSERT [dbo].[Attendance] ([SR_No], [Date], [Status], [Comment]) VALUES (6, CAST(N'2018-08-15' AS Date), N'P', N'')
INSERT [dbo].[Attendance] ([SR_No], [Date], [Status], [Comment]) VALUES (7, CAST(N'2018-08-15' AS Date), N'A', N'')
INSERT [dbo].[Attendance] ([SR_No], [Date], [Status], [Comment]) VALUES (9, CAST(N'2018-08-15' AS Date), N'P', N'')
INSERT [dbo].[Attendance] ([SR_No], [Date], [Status], [Comment]) VALUES (10, CAST(N'2018-08-15' AS Date), N'L', N'')
INSERT [dbo].[Attendance] ([SR_No], [Date], [Status], [Comment]) VALUES (90, CAST(N'2018-08-15' AS Date), N'A', N'')
INSERT [dbo].[Attendance] ([SR_No], [Date], [Status], [Comment]) VALUES (5, CAST(N'2018-08-01' AS Date), N'P', N'')
INSERT [dbo].[Attendance] ([SR_No], [Date], [Status], [Comment]) VALUES (6, CAST(N'2018-08-01' AS Date), N'P', N'')
INSERT [dbo].[Attendance] ([SR_No], [Date], [Status], [Comment]) VALUES (4, CAST(N'2018-08-06' AS Date), N'L', N'')
INSERT [dbo].[Attendance] ([SR_No], [Date], [Status], [Comment]) VALUES (5, CAST(N'2018-08-06' AS Date), N'L', N'')
INSERT [dbo].[Attendance] ([SR_No], [Date], [Status], [Comment]) VALUES (6, CAST(N'2018-08-06' AS Date), N'A', N'')
INSERT [dbo].[Attendance] ([SR_No], [Date], [Status], [Comment]) VALUES (7, CAST(N'2018-08-06' AS Date), N'P', N'')
INSERT [dbo].[Attendance] ([SR_No], [Date], [Status], [Comment]) VALUES (8, CAST(N'2018-08-06' AS Date), N'P', N'')
INSERT [dbo].[Attendance] ([SR_No], [Date], [Status], [Comment]) VALUES (9, CAST(N'2018-08-06' AS Date), N'P', N'')
INSERT [dbo].[Attendance] ([SR_No], [Date], [Status], [Comment]) VALUES (10, CAST(N'2018-08-06' AS Date), N'A', N'')
INSERT [dbo].[Attendance] ([SR_No], [Date], [Status], [Comment]) VALUES (90, CAST(N'2018-08-06' AS Date), N'A', N'')
INSERT [dbo].[Attendance] ([SR_No], [Date], [Status], [Comment]) VALUES (8, CAST(N'2018-09-25' AS Date), N'L', N'')
INSERT [dbo].[Attendance] ([SR_No], [Date], [Status], [Comment]) VALUES (3, CAST(N'2018-09-24' AS Date), N'P', N'')
INSERT [dbo].[Attendance] ([SR_No], [Date], [Status], [Comment]) VALUES (4, CAST(N'2018-09-24' AS Date), N'P', N'')
INSERT [dbo].[Attendance] ([SR_No], [Date], [Status], [Comment]) VALUES (5, CAST(N'2018-09-24' AS Date), N'A', N'')
INSERT [dbo].[Attendance] ([SR_No], [Date], [Status], [Comment]) VALUES (6, CAST(N'2018-09-24' AS Date), N'A', N'')
INSERT [dbo].[Attendance] ([SR_No], [Date], [Status], [Comment]) VALUES (7, CAST(N'2018-09-24' AS Date), N'P', N'')
INSERT [dbo].[Attendance] ([SR_No], [Date], [Status], [Comment]) VALUES (8, CAST(N'2018-09-24' AS Date), N'A', N'')
INSERT [dbo].[Attendance] ([SR_No], [Date], [Status], [Comment]) VALUES (9, CAST(N'2018-09-24' AS Date), N'P', N'')
INSERT [dbo].[Attendance] ([SR_No], [Date], [Status], [Comment]) VALUES (10, CAST(N'2018-09-24' AS Date), N'P', N'')
INSERT [dbo].[Attendance] ([SR_No], [Date], [Status], [Comment]) VALUES (90, CAST(N'2018-09-24' AS Date), N'P', N'')
INSERT [dbo].[Attendance] ([SR_No], [Date], [Status], [Comment]) VALUES (9, CAST(N'2018-09-25' AS Date), N'P', N'')
INSERT [dbo].[Attendance] ([SR_No], [Date], [Status], [Comment]) VALUES (10, CAST(N'2018-09-25' AS Date), N'P', N'')
INSERT [dbo].[Attendance] ([SR_No], [Date], [Status], [Comment]) VALUES (90, CAST(N'2018-09-25' AS Date), N'P', N'')
INSERT [dbo].[Guards] ([SR_No], [Name], [CNIC_No], [Location], [Shift]) VALUES (1, N'Arslan', N'32824-8129810-9', N'PTV', N'Night')
INSERT [dbo].[Guards] ([SR_No], [Name], [CNIC_No], [Location], [Shift]) VALUES (3, N'Hamza Sikandar', N'44203-0747481-7', N'CAA', N'Morning')
INSERT [dbo].[Guards] ([SR_No], [Name], [CNIC_No], [Location], [Shift]) VALUES (4, N'Ali', N'44203-0747482-3', N'asd', N'Night')
INSERT [dbo].[Guards] ([SR_No], [Name], [CNIC_No], [Location], [Shift]) VALUES (5, N'Ahmed', N'44203-0747482-1', N'sad', N'Night')
INSERT [dbo].[Guards] ([SR_No], [Name], [CNIC_No], [Location], [Shift]) VALUES (6, N'Onais', N'44203-0747481-1', N'ons', N'Morning')
INSERT [dbo].[Guards] ([SR_No], [Name], [CNIC_No], [Location], [Shift]) VALUES (7, N'Uzair', N'44201-0747482-7', N'awe', N'Night')
INSERT [dbo].[Guards] ([SR_No], [Name], [CNIC_No], [Location], [Shift]) VALUES (8, N'Ahmed', N'11111-1111111-1', N'qwas', N'Night')
INSERT [dbo].[Guards] ([SR_No], [Name], [CNIC_No], [Location], [Shift]) VALUES (9, N'qwertyu', N'11111-1111111-3', N'as', N'Morning')
INSERT [dbo].[Guards] ([SR_No], [Name], [CNIC_No], [Location], [Shift]) VALUES (10, N'hamza', N'12345-1234533-2', N'abc', N'Morning')
INSERT [dbo].[Guards] ([SR_No], [Name], [CNIC_No], [Location], [Shift]) VALUES (11, N'sigs', N'67125-2873612-9', N'sdas', N'Night')
INSERT [dbo].[Guards] ([SR_No], [Name], [CNIC_No], [Location], [Shift]) VALUES (90, N'ahsan', N'44205-0508185-7', N'karachi', N'Night')
INSERT [dbo].[Guards] ([SR_No], [Name], [CNIC_No], [Location], [Shift]) VALUES (100, N'zshfk', N'84723-8472398-4', N'lkasl', N'Morning')
/****** Object:  StoredProcedure [dbo].[SP_AttendenceSummary]    Script Date: 12/23/2018 6:19:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_AttendenceSummary]
	@year int,
	@month int
AS
BEGIN
	select SR_No,Name,CNIC_No,Count(TotalDays) Total_Days,Count(Present_Status) Present,Count(Absent_Status) Absent,Count(Leave_Status) Leave from (
	select g.SR_No,g.Name,g.CNIC_No,
	case when a.Status = 'P' OR a.Status = 'A' OR a.Status = 'L'  Then 'Days' End TotalDays,
	case when a.Status = 'P' Then 'Present' End Present_Status,
	case when a.Status = 'A' Then 'Absent' End Absent_Status,
	case when a.Status = 'L' Then 'Leave' End Leave_Status
	from Guards g 
	INNER JOIN Attendance a 
	ON g.SR_No = a.SR_No AND YEAR(a.Date)=@year AND MONTH(a.Date)=@month
	) as aa
	group by SR_No,Name,CNIC_No

END


GO
