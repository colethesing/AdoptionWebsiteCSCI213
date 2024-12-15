SET IDENTITY_INSERT [dbo].[DOG] ON
INSERT INTO [dbo].[DOG] ([id], [dogName], [dogAge], [dogBreed], [dogDescription], [dogPhoto]) VALUES 
(1, N'Daisy', 1, N'Poodle', N'Loveable and ready for a new home', 1234),
(2, N'Mutton', 4, N'Golden Retriever', N'The perfect dog for new dog owners', 1234),
(3, N'Toast', 2, N'Pitbull', N'A rescue who is easily excited. Already trained!', 1234),
(4, N'Finn', 1, N'Golden Poodle', N'Newlyborn puppy! Excited to experience the world with you!', 1234),
(5, N'Nova', 6, N'Black Lab', N'Hoping to meet their forever family. Already trained!', 1234),
(6, N'Scout', 3, N'Maltese', N'This is a test to see if the text wraps properly abcdefghijklmnopqrstuvwxyza;sdlkfjalksjdfbasjdnfkasndfa;sdkjfnlan', 1234)
SET IDENTITY_INSERT [dbo].[DOG] OFF
