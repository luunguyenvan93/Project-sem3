Create Database MallManagement
Create Table center
(
	centerID int identity primary key,
	centerName nvarchar(100) unique not null
)
Create Table food
(
	foodID int identity primary key,
	foodName nvarchar(200) not null unique,
	foodDiscription text,
	foodImage varchar(100)not null,
	price float not null,
	centerID int references center(centerID)
)

Create Table [floor]
(
	floorID int identity primary key,
	floorName varchar(100) not null unique,
	centerID int references center(centerID)
)
Create Table shop
(
	shopID int identity primary key,
	shopName varchar(100) not null unique,
	floorID int references [Floor](floorID) not null
)
Create Table category
(
	categoryID int identity primary key,
	categoryName nvarchar(100) not null
)
Create Table product
(
    productID int identity primary key,
    productName nvarchar(100) not null unique,
    productDiscription text,
    price float not null,
    categoryID int references category(categoryID)not null,
    shopID int references Shop(shopID)not null
)

Create Table gallary
(
	imageID int identity primary key,
	imageName varchar(100) not null unique,
	categoryID int references Category(categoryID) not null
)
Create Table movie 
(
	movieID int identity primary key,
	movieName varchar(100) not null unique,
	movieDiscription text,
	showTime datetime not null,
	movieImage varchar(100) not null,
	centerID int references center(centerID)
)
Create Table customer
(
	customerID int identity primary key,
	customerName nvarchar(100)not null unique,
	customerAddress nvarchar(200) not null,
	customerPhone char(20),
	customerEmail varchar(200),
	customerGender bit,
	customerBirthday datetime,
	customerCard char(20) not null
)
Create Table book
(
	movieID int references Movie(movieID),
	customerID int references Customer(customerID),
	bookDate datetime,
	[status] int not null
)
Create Table Faq
(
	faqID int identity primary key,
	faqTitle nvarchar(100) not null unique,
	faqContent nvarchar(500) not null,
	fullName nvarchar(50) not null,
	email varchar(50) not null unique,
    [address] varchar(100) ,
	phoneNumber char(20) not null,
	fax char(50) ,
)
Select * from center