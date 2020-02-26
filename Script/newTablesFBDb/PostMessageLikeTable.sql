USE [FBDb]
GO

/****** Object:  Table [dbo].[PostMessageLikes]    Script Date: 26-02-2020 21:05:09 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[PostMessageLikes](
	[PostMessageLikeId] [int] IDENTITY(1,1) NOT NULL,
	[PostMessageId] [int] NOT NULL,
	[UserId] [int] NOT NULL,
 CONSTRAINT [PK_PostMessageLikes] PRIMARY KEY CLUSTERED 
(
	[PostMessageLikeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[PostMessageLikes]  WITH CHECK ADD  CONSTRAINT [FK_PostMessageLikes_FacebookUsers] FOREIGN KEY([UserId])
REFERENCES [dbo].[FacebookUsers] ([UserID])
GO

ALTER TABLE [dbo].[PostMessageLikes] CHECK CONSTRAINT [FK_PostMessageLikes_FacebookUsers]
GO

ALTER TABLE [dbo].[PostMessageLikes]  WITH CHECK ADD  CONSTRAINT [FK_PostMessageLikes_PostMessages] FOREIGN KEY([PostMessageId])
REFERENCES [dbo].[PostMessages] ([PostMessageId])
GO

ALTER TABLE [dbo].[PostMessageLikes] CHECK CONSTRAINT [FK_PostMessageLikes_PostMessages]
GO

