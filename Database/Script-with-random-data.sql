

--SELECT TOP (1000) [Id]
--      ,[UserName]
--      ,[Adress_A]
--      ,[Adress_A_Latitude]
--      ,[Adress_A_Longitude]
--  FROM [dbo].[Customer]

  INSERT INTO [dbo].[Customer] 
  VALUES (1, 'jc_sync_user', 'Œródmieœcie Pó³nocne, Warsaw, 00-863 Warsaw',52.230952, 21.006715)

  --SELECT TOP (1000) [Id]
  --    ,[LogoLink]
  --    ,[SpecificItemURL]
  --    ,[CustomerId]
  --    ,[Radius]
  --    ,[BasicInfo]
  --    ,[DetailInfo]
  --    ,[RedirectionURL]
  --FROM [dbo].[Promotions]

  INSERT INTO [dbo].[Promotions]
  VALUES (
			1,
			'https://searchlogovector.com/wp-content/uploads/2020/03/reebok-logo-vector.png',
			'https://www.pngfind.com/pngs/m/587-5870909_free-reebok-png-reebok-transparent-png.png',
			1,
			30,
			'This is the promotion of today some boots!',
			'We got a 40 % on some boots - remember to use Millennium debit or credit card!',
			null
			)
