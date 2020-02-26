USE [FBDb]
GO

/****** Object:  Table [dbo].[PostMessageComments]    Script Date: 26-02-2020 21:04:17 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[PostMessageComments](
	[PostMessageCommentId] [int] IDENTITY(1,1) NOT NULL,
	[Comment] [varchar](max) NOT NULL,
	[PostMessageId] [int] NOT NULL,
	[UserId] [int] NOT NULL,
 CONSTRAINT [PK_PostMessageComments] PRIMARY KEY CLUSTERED 
(
	[PostMessageCommentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[PostMessageComments]  WITH CHECK ADD  CONSTRAINT [FK_PostMessageComments_FacebookUsers] FOREIGN KEY([UserId])
REFERENCES [dbo].[FacebookUsers] ([UserID])
GO

ALTER TABLE [dbo].[PostMessageComments] CHECK CONSTRAINT [FK_PostMessageComments_FacebookUsers]
GO

ALTER TABLE [dbo].[PostMessageComments]  WITH CHECK ADD  CONSTRAINT [FK_PostMessageComments_PostMessages] FOREIGN KEY([PostMessageId])
REFERENCES [dbo].[PostMessages] ([PostMessageId])
GO

ALTER TABLE [dbo].[PostMessageComments] CHECK CONSTRAINT [FK_PostMessageComments_PostMessages]
GO

