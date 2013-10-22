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
	floorName nvarchar(100) not null unique,
	centerID int references center(centerID)
)
Create Table shop
(
	shopID int identity primary key,
	shopName nvarchar(100) not null unique,
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

Create Table gallery
(
	imageID int identity primary key,
	imageName varchar(100) not null unique,
	categoryID int references Category(categoryID) not null
)
Create Table movie 
(
	movieID int identity primary key,
	movieName nvarchar(100) not null unique,
	movieDiscription text,
	showTime datetime not null,
	movieImage varchar(100) not null,
	centerID int references center(centerID)
)
Create Table customer
(
	customerID int identity primary key,
	customerName nvarchar(100)not null unique,
	customerAddress text not null,
	customerPhone char(20),
	customerEmail varchar(50),
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
	faqContent text not null,
	fullName nvarchar(100) not null,
	email varchar(50) not null unique,
    [address] text ,
	phoneNumber char(20) not null,
	fax char(50) ,
)
---Select data-------
create proc selectCenter
as
begin
		Select * from center
end

create proc selectFood
as
begin
		Select * from food
end

create proc selectFloor
as
begin
		Select * from [floor]
end

create proc selectShop
as
begin
		Select * from shop
end

create proc selectCenter
as
begin
		Select * from center
end

create proc selectCategory
as
begin
		Select * from category
end

create proc selectProduct
as
begin
		Select * from product
end

create proc selectgallery
as
begin
		Select * from gallery
end

create proc selectMovie
as
begin
		Select * from movie
end

create proc selectCustomer
as
begin
		Select * from customer
end

create proc selectBook
as
begin
		Select * from book
end

create proc selectFaq
as
begin
		Select * from Faq
end




--Add data-------
create proc addCenter(@centerName nvarchar(100))
as
begin
	insert into center values(@centerName)
end

create proc addFood(@foodName nvarchar(200),@foodDiscription text,@foodImage varchar(100),@price float,@centerID int )
as
begin
	insert into food values(@foodName,@foodDiscription,@foodImage,@price,@centerID)
end

create proc addFloor(@floorName nvarchar(100),centerID int)
as
begin
	insert into [floor] values(@floorName,@centerID)
end

create proc addShop(@shopName nvarchar(100),@floorID int)
as
begin
	insert into shop values(@shopName,@floorID)
end

create proc addCategory(@categoryName nvarchar(100))
as
begin
	insert into category values(@categoryName)
end

create proc addProduct(@productName nvarchar(100),@productDiscription text,@price float,@categoryID int,@shopID int )
as
begin
	insert into product values(@productName,@productDiscription,@price,@categoryID,@shopID)
end

create proc addGallery(@galleryName nvarchar(100),categoryID int)
as
begin
	insert into gallery values(@galleryName,@categoryID)
end

create proc addMovie(@movieName nvarchar(100),@movieDiscription text,@showTime datetime,@movieImage varchar(100),@centerID int )
as
begin
	insert into movie values(@movieName,@movieDiscription,@showTime,@movieImage,@centerID)
end

create proc addCustomer(@customerName nvarchar(100),@customerAddress text,@customerPhone char(20),@customerEmail varchar(50),@customerGender bit,customerBirthday datetime,customerCard char(20) )
as
begin
	insert into customer values(@customerName,@customerAddress,@customerPhone,@customerEmail,@customerGender,@customerBirthday,@customerCard)
end

create proc addBook(@movieID int,@customerID int,@bookDate datetime,@status int)
as
begin
	insert into book values(@movieID,@customerID,@bookDate,@status)
end

create proc addFaq(@faqTitle nvarchar(100),@faqContent text,@fullName nvarchar(100),@email varchar(50),@address text,phoneNumber char(20),fax char(50) )
as
begin
	insert into Faq values(@faqTiltle,@faqContent,@fullName,@email,@address,@phoneNumber,@fax)
end

--- update data ----------------
create proc updateCenter(@centerID int,@centerName nvarchar(100))
as
begin
	update center set centerName = @centerName where centerID = @centerID
end

create proc updateFood(@foodID int,@foodName nvarchar(200),@foodDiscription text,@foodImage varchar(100),@price float,@centerID int )
as
begin
	update food set foodName = @foodName,foodDiscription = @foodDiscription,foodImage = @foodImage,price = @price,centerID = @centerID where foodID = @foodID
end

create proc updateFloor(@floorID int,@floorName nvarchar(100),centerID int)
as
begin
	update [floor] set floorName = @floorName,centerID = @centerID where floorID = @floorID
end

create proc updateShop(@shopID int,@shopName nvarchar(100),@floorID int)
as
begin
	update shop set shopName = @shopName,floorID = @floorID where shopID = @shopID
end

create proc updateCategory(@categoryID int,@categoryName nvarchar(100))
as
begin
	update category set categoryName = @categoryName where categoryID = @categoryID
end

create proc updateProduct(@productID int,@productName nvarchar(100),@productDiscription text,@price float,@categoryID int,@shopID int )
as
begin
	update product set productName = @productName,productDiscription=@productDiscription,price=@price,categoryID=@categoryID,shopID = @shopID where productID = @productID
end

create proc updateGallery(@galleryID int , @galleryName nvarchar(100),categoryID int)
as
begin
	update gallery set galleryName=@galleryName,categoryID = @categoryID where galleryID = @galleryID
end

create proc updateMovie(@movieID int ,@movieName nvarchar(100),@movieDiscription text,@showTime datetime,@movieImage varchar(100),@centerID int )
as
begin
	update movie set movieName=@movieName,movieDiscription=@movieDiscription,showTime=@showTime,movieImage=@movieImage,centerID=@centerID where movieID = @movieID
end

create proc updateCustomer(@customerID int,@customerName nvarchar(100),@customerAddress text,@customerPhone char(20),@customerEmail varchar(50),@customerGender bit,customerBirthday datetime,customerCard char(20) )
as
begin
	update customer set customerName=@customerName,customerAddress=@customerAddress,customerPhone=@customerPhone,customerEmail=@customerEmail,customerGender=@customerGender,customerBirthday=@customerBirthday,customerCard=@customerCard where customerID = @customerID
end

create proc updateBook(@movieID int,@customerID int,@bookDate datetime,@status int)
as
begin
	update  book set movieID = @movieID,customerID=@customerID,bookDate=@bookDate,[status]=@status where movieID = @movieID and customerID = @customerID
end

create proc updateFaq(@faqID int,@faqTitle nvarchar(100),@faqContent text,@fullName nvarchar(100),@email varchar(50),@address text,phoneNumber char(20),fax char(50) )
as
begin
	update Faq set faqTitle=@faqTiltle,faqContent=@faqContent,fullName=@fullName,email=@email,[address]=@address,phoneNumber=@phoneNumber,fax=@fax where faqID =@faqID
end

---delete data ---------------
create proc deleteCenter(@centerID int)
as
begin
	delete center where centerID = @centerID
end

create proc deleteFood(@foodID int)
as
begin
	delete food where foodID = @foodID
end

create proc deletefloor(@floorID int)
as
begin
	delete [floor] where floorID = @floorID
end

create proc deleteShop(@shopID int)
as
begin
	delete shop where shopID = @shopID
end

create proc deleteCategory(@categoryID int)
as
begin
	delete category where categoryID = @categoryID
end

create proc deleteProduct(@productID int)
as
begin
	delete product where productID = @productID
end

create proc deleteGallery(@galleryID int)
as
begin
	delete gallery where galleryID = @galleryID
end

create proc deleteMovie(@movieID int)
as
begin
	delete movie where movieID = @movieID
end

create proc deleteCustomer(@customerID int)
as
begin
	delete customer where customerID = @customerID
end

create proc deleteBook(@movieID int,@customerID)
as
begin
	delete book where movieID = @movieID and customerID = @customerID
end

create proc deleteFaq(@faqID int)
as
begin
	delete Faq where faqID = @faqID
end

---search data --------------------
create proc searchCenter(@centerName nvarchar(100))
as
begin
	select * from center where centerName like  '%' + @centerName + '%'
end

create proc searchFood(@foodName nvarchar(100))
as
begin
	select * from food where foodName like  '%' + @foodName + '%'
end

create proc searchFloor(@floorName nvarchar(100))
as
begin
	select * from [floor] where floorName like  '%' + @floorName + '%'
end

create proc searchShop(@shopName nvarchar(100))
as
begin
	select * from shop where shopName like  '%' + @shopName + '%'
end

create proc searchCategory(@categoryName nvarchar(100))
as
begin
	select * from category where categoryName like  '%' + @categoryName + '%'
end

create proc searchProduct(@productName nvarchar(100))
as
begin
	select * from product where productName like  '%' + @productName + '%'
end


create proc searchGallery(@galleryName nvarchar(100))
as
begin
	select * from gallery where galleryName like  '%' + @galleryName + '%'
end


create proc searchMovie(@movieName nvarchar(100))
as
begin
	select * from movie where movieName like  '%' + @movieName + '%'
end

create proc searchCustomer(@customerName nvarchar(100))
as
begin
	select * from customer where customerName like  '%' + @customerName + '%'
end

create proc searchBook(@customerID int,@movieID int)
as
begin
	select * from book where customerID = @customerID and movieID=@movieID
end

create proc searchFaq(@faqTitle nvarchar(100))
as
begin
	select * from Faq where faqTitle like  '%' + @faqTitle + '%'
end