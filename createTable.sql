CREATE TABLE [dbo].[User](
	[UserId]	INT		NOT NULL,
	[Username]	VARCHAR (20) NOT NULL,
	[Password]	VARCHAR (10) NOT NULL,
	[Email]		VARCHAR (30) NULL,
	[Country]	VARCHAR (20) NULL,
	[Language]	VARCHAR (20) NULL,
	[FoodPref]	VARCHAR (50) NULL,
	CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED ([UserId] ASC),
);
CREATE TABLE [dbo].[Itinerary](
	[ItinId]	INT		NOT NULL,
	[PlaceId]	INT		NOT NULL,
	[IName]		VARCHAR (20) 	NOT NULL,
	[selectTime]	datetime	NULL,
	[selectDate]	datetime	NULL,
	[UserId]	INT		NOT NULL,
	CONSTRAINT [PK_Itinerary] PRIMARY KEY CLUSTERED ([ItinId] ASC),
);
CREATE TABLE [dbo].[Place](
	[PlaceId]	INT		NOT NULL,
	[PName]		VARCHAR (20)	NOT NULL,
	[PDesc]		VARCHAR (50)	NOT NULL,
	[AvgRating]	INT		DEFAULT 0,
	[Image]		IMAGE 		NULL,
	[Location]	VARCHAR (50) 	NOT NULL,
	[CatId]		INT		NOT NULL,
	[MapId]		INT		NOT NULL,
	CONSTRAINT [PK_Place] PRIMARY KEY CLUSTERED ([PlaceId] ASC),
);
CREATE TABLE [dbo].[Category](
	[CatId]		INT		NOT NULL,
	[CatName]	VARCHAR (20)	NOT NULL,
	[UserId]	INT		NOT NULL,
	CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED ([CatId] ASC),
);
CREATE TABLE [dbo].[Faq](
	[FaqId]		INT		NOT NULL,
	[UserId]	INT		NOT NULL,
	[Qns]		VARCHAR (200)	NOT NULL,
	[Ans]		VARCHAR (200)	NOT NULL,
	CONSTRAINT [PK_Faq] PRIMARY KEY CLUSTERED ([FaqId] ASC),
);
CREATE TABLE [dbo].[Cart](
	[CkoutId]	INT		NOT NULL,
	[UserId]	INT		NOT NULL,
	[CCard]		VARCHAR (20)	NOT NULL,
	[Totalprice]	DECIMAL(5, 2)	DEFAULT 0.00,
	CONSTRAINT [PK_Cart] PRIMARY KEY CLUSTERED ([CkoutId] ASC),
);
CREATE TABLE [dbo].[Review](
	[UserId]	INT		NOT NULL,
	[PlaceId]	INT		NOT NULL,
	[Rating]	INT		NOT NULL,
	[Review]	VARCHAR (100)	NOT NULL,
	CONSTRAINT [PK_Review] PRIMARY KEY ([UserId],[PlaceId]),
);
CREATE TABLE [dbo].[Favourite](
	[UserId]	INT		NOT NULL,
	[PlaceId]	INT		NOT NULL,
	CONSTRAINT [PK_Favourite] PRIMARY KEY ([UserId], PlaceId),
);
CREATE TABLE [dbo].[Recommendation](
	[RecId]		INT		NOT NULL,
	[UserId]	INT		NOT NULL,
	[PoR]		VARCHAR (20)	NOT NULL,
	[Reason]	VARCHAR (100)	NOT NULL,
	CONSTRAINT [PK_Recommendation] PRIMARY KEY CLUSTERED ([RecId] ASC),
);
CREATE TABLE [dbo].[Map](
	[PlaceId]	INT		NOT NULL,
	[MapId]		INT		NOT NULL,
	[Lantitude]	VARCHAR (20)	NOT NULL,
	[Longtitude]	VARCHAR (100)	NOT NULL,
	[Region]	VARCHAR (30)	NOT NULL,
	CONSTRAINT [PK_Map] PRIMARY KEY CLUSTERED ([MapId] ASC),
);
CREATE TABLE [dbo].[Event](
	[EventId]	INT		NOT NULL,
	[EName]		VARCHAR (50)	NOT NULL,
	[Location]	VARCHAR (50)	NOT NULL,
	[Time]		datetime	NOT NULL,
	[PlaceId]	INT		NOT NULL,
	[Price]		DECIMAL(4, 2)	NULL,
	CONSTRAINT [PK_Event] PRIMARY KEY CLUSTERED ([EventId] ASC),
);
CREATE TABLE [dbo].[Activity](
	[ActId]		INT		NOT NULL,
	[ActName]	VARCHAR (50)	NOT NULL,
	[Location]	VARCHAR (50)	NOT NULL,
	[Time]		datetime	NOT NULL,
	[PlaceId]	INT		NOT NULL,
	[ActDesc]	VARCHAR (50)	NOT NULL,
	[ActLang]	VARCHAR (50)	NOT NULL,
	[ActPpl]	VARCHAR (50)	NOT NULL,
	[ActProvided]	VARCHAR (50)	NOT NULL,
	[ActToBring]	VARCHAR (50)	NOT NULL,
	[CatId]		INT		NOT NULL,
	[Price]		DECIMAL(4, 2)	NULL,
	CONSTRAINT [PK_Activity] PRIMARY KEY CLUSTERED ([ActId] ASC),
);
CREATE TABLE [dbo].[Host](
	[HostId]	INT		NOT NULL,
	[HName]		VARCHAR (20)	NOT NULL,
	[Password]	VARCHAR (20)	NOT NULL,
	[Email]		VARCHAR (30)	NULL,
	[UserId]	INT		NOT NULL,
	[ActId]		INT		NULL,
	[HDesc]	VARCHAR (30) 	NULL,
	CONSTRAINT [PK_Host] PRIMARY KEY CLUSTERED ([HostId] ASC),
);