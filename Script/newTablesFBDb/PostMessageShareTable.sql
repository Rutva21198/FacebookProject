USE [FBDb]
GO

/****** Object:  Table [dbo].[PostMessageShares]    Script Date: 26-02-2020 21:04:44 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[PostMessageShares](
	[PostMessageShareId] [int] IDENTITY(1,1) NOT NULL,
	[PostMessageId] [int] NOT NULL,
	[UserId] [int] NOT NULL,
 CONSTRAINT [PK_PostMessageShares] PRIMARY KEY CLUSTERED 
(
	[PostMessageShareId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[PostMessageShares]  WITH CHECK ADD  CONSTRAINT [FK_PostMessageShares_FacebookUsers] FOREIGN KEY([UserId])
REFERENCES [dbo].[FacebookUsers] ([UserID])
GO

ALTER TABLE [dbo].[PostMessageShares] CHECK CONSTRAINT [FK_PostMessageShares_FacebookUsers]
GO

ALTER TABLE [dbo].[PostMessageShares]  WITH CHECK ADD  CONSTRAINT [FK_PostMessageShares_PostMessages] FOREIGN KEY([PostMessageId])
REFERENCES [dbo].[PostMessages] ([PostMessageId])
GO

ALTER TABLE [dbo].[PostMessageShares] CHECK CONSTRAINT [FK_PostMessageShares_PostMessages]
GO

