create database VideoRentalDB;

use VideoRentalDB;

create table CustomerTable(
	CustomerNum varchar(20) primary key,
	CustomerName nvarchar(10),
	ResidentNum char(13),
	CustomerType nchar(10),
	Gender char(2),
	Phone char(13),
	CellPhone char(13),
	Mail varchar(20),
	Address nvarchar(20)
);

create table VideoTable(
	VideoCode varchar(20) primary key,
	Genre nvarchar(10),
	Title nvarchar(10),
	Actor nvarchar(4),
	Director nvarchar(4),
	Production nvarchar(20),
	ReleaseDate date
);

create table SettingTable (
    TransPeriod int,
    NewRentalFee int,
    NewRentalPeriod int,
    NewLateFee int,
    OldRentalPeriod int,
    OldRentalFee int,
    OldLateFee int
);

create table RentalTable(
	RentalNum int IDENTITY(1,1) PRIMARY KEY,
	CustomerNum varchar(20),
    VideoCode varchar(20),
    RentalDate date,
    DueDate date,
    ReturnDate date,
    RentalFee int,
    LateFee int
);

select * from CustomerTable;
select * from VideoTable;
select * from SettingTable;
select * from RentalTable;

alter table RentalTable
add constraint fk_rental_customer
foreign key (CustomerNum)
references CustomerTable(CustomerNum);

alter table RentalTable
add constraint fk_rental_video
foreign key (VideoCode)
references VideoTable(VideoCode);

insert into CustomerTable
values ('c001','홍길동','9910232314823','성인','남','051-012-1123','010-1111-1111','12345','부산시 북구');

insert into VideoTable
values ('v001','코미디','영화1','배우1','감독1','제작사1','2025-10-24');

insert into RentalTable
(CustomerNum, VideoCode, RentalDate, DueDate, ReturnDate, RentalFee, LateFee)
values ('C001','V001','2026-06-01','2026-06-08',null,2000,500);



-- 고객 정보 화면
create proc Customer_Select
as
begin
	set nocount on
	select * from CustomerTable
end

create proc Customer_Insert
	@CustomerNum varchar(20),
	@CustomerName nvarchar(10),
	@ResidentNum char(13),
	@CustomerType nchar(10),
	@Gender char(2),
	@Phone char(13),
	@CellPhone char(13),
	@Mail varchar(20),
	@Address nvarchar(20)
as
begin
	set nocount on
	insert into CustomerTable(CustomerNum, CustomerName, ResidentNum, 
							  CustomerType,Gender,Phone,CellPhone,Mail,Address)
	values(@CustomerNum, @CustomerName, @ResidentNum, @CustomerType,
	       @Gender,@Phone,@CellPhone,@Mail,@Address)
end

create proc Customer_Update
	@CustomerNum varchar(20),
	@CustomerName nvarchar(10),
	@ResidentNum char(13),
	@CustomerType nchar(10),
	@Gender char(2),
	@Phone char(13),
	@CellPhone char(13),
	@Mail varchar(20),
	@Address nvarchar(20)
as
begin
	set nocount on
	update CustomerTable
	set
		CustomerName = @CustomerName, 
		ResidentNum = @ResidentNum, 
		CustomerType = @CustomerType,
		Gender = @Gender,
		Phone = @Phone,
		CellPhone = @CellPhone,
		Mail = @Mail,
		Address = @Address
	where CustomerNum = @CustomerNum
end

create proc Customer_Delete
	@CustomerNum varchar(20)
as
begin
	set nocount on
	delete CustomerTable
	where CustomerNum = @CustomerNum
end



-- 비디오 정보 화면
create proc Video_Select
	
as
begin
	set nocount on
	select * from VideoTable
end



create proc Video_Insert
	@VideoCode varchar(20),
	@Genre nvarchar(10),
	@Title nvarchar(10),
	@Actor nvarchar(4),
	@Director nvarchar(4),
	@Production nvarchar(20),
	@ReleaseDate date
as
begin
	set nocount on
	insert into VideoTable(VideoCode,Genre,Title,Actor,Director,Production,ReleaseDate)
	values(@VideoCode,@Genre,@Title,@Actor,@Director,@Production,@ReleaseDate)
end


create proc Video_Update
	@VideoCode varchar(20),
	@Genre nvarchar(10),
	@Title nvarchar(10),
	@Actor nvarchar(4),
	@Director nvarchar(4),
	@Production nvarchar(20),
	@ReleaseDate date
as
begin
	set nocount on
	update VideoTable
	set 
		Genre = @Genre,
		Title = @Title,
		Actor = @Actor,
		Director = @Director,
		Production = @Production,
		ReleaseDate = @ReleaseDate
	where VideoCode = @VideoCode
end


create proc Video_Delete
	@VideoCode varchar(20)
as
begin
	set nocount on
	delete VideoTable
	where VideoCode = @VideoCode
end




-- 환경설정
create proc Setting_Select
as
begin
	set nocount on
	select * from SettingTable
end



create proc Setting_Insert
    @TransPeriod int,
    @NewRentalFee int,
    @NewRentalPeriod int,
    @NewLateFee int,
    @OldRentalPeriod int,
    @OldRentalFee int,
    @OldLateFee int
as
begin
    set nocount on

    insert into SettingTable
    values (
        @TransPeriod,
        @NewRentalFee,
        @NewRentalPeriod,
        @NewLateFee,
        @OldRentalPeriod,
        @OldRentalFee,
        @OldLateFee
    )
end




create proc Setting_Update
    @TransPeriod int,
    @NewRentalFee int,
    @NewRentalPeriod int,
    @NewLateFee int,
    @OldRentalPeriod int,
    @OldRentalFee int,
    @OldLateFee int
as
begin
    set nocount on
    update SettingTable
    set
        TransPeriod = @TransPeriod,
        NewRentalFee = @NewRentalFee,
        NewRentalPeriod = @NewRentalPeriod,
        NewLateFee = @NewLateFee,
        OldRentalPeriod = @OldRentalPeriod,
        OldRentalFee = @OldRentalFee,
        OldLateFee = @OldLateFee
end



create proc Video_Genre_Select
as
begin
	set nocount on
	select distinct Genre from VideoTable
end


-- 대여관리 화면

create proc Customer_Find
as
begin
	set nocount on
	select CustomerName, CustomerNum, Phone, CellPhone 
	from CustomerTable
end

create proc Video_Find
as
begin
	set nocount on
	select VideoCode, Title from VideoTable
end


create proc Rental_FindByCustomer
    @CustomerNum varchar(20)
as
begin
    set nocount on

    select
        v.VideoCode,
        v.Title,
        r.RentalFee,
        r.LateFee
    from RentalTable r
    join VideoTable v
        on r.VideoCode = v.VideoCode
    where r.CustomerNum = @CustomerNum
end


create proc Rental_Insert
    @CustomerNum varchar(20),
    @VideoCode varchar(20),
    @RentalDate date,
    @DueDate date,
    @RentalFee int,
    @LateFee int
as
begin
    set nocount on
    insert RentalTable
    (CustomerNum,VideoCode,RentalDate,DueDate,ReturnDate,RentalFee,LateFee)
    values
    (@CustomerNum,@VideoCode,@RentalDate,@DueDate,null,@RentalFee,@LateFee)
end



create proc Rental_Return
    @RentalNum int
as
begin
    set nocount on
    delete RentalTable
    where RentalNum = @RentalNum
end



--index


CREATE NONCLUSTERED INDEX NCL_CustomerTable_CustomerName
ON CustomerTable(CustomerName)



CREATE NONCLUSTERED INDEX NCL_VideoTable_Title
ON VideoTable(Title)



CREATE NONCLUSTERED INDEX NCL_VideoTable_Genre
ON VideoTable(Genre)



CREATE NONCLUSTERED INDEX NCL_RentalTable_RentalDate
ON RentalTable(RentalDate)