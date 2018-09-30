
use NHUB




select *from AspNetUsers

select *from AspNetUserRoles

select *from AspNetRoles
update AspNetRoles set name='Super Admin' where id=1
insert into AspNetRoles( Id ,Name) values(1,'Super Admin')
insert into AspNetUserRoles( UserId ,RoleId) values('3a579858-b266-456b-b35f-c1d7ccfcd512',1)

insert into source(name) values('SalesForce')
insert into source(name) values('SalesForce1')
select * from source
create table Source
(
	Id int identity(1,1) primary key,
	Name varchar(50) not null,
)

create table Event
(
	Id int identity(1,1) primary key,
	Name varchar(50) not null,
	SourceId int foreign key references Source(id),
	Mandatory bit
)

create table Channel
(
	Id int identity(1,1) primary key,
	Name varchar(50) not null
)

create table EventChannel
(
	EventId int foreign key references Event(id),
	ChannelId int foreign key references Channel(id)
)



create table Datatype
(
	Id int identity(1,1) primary key,
	Name varchar(50)
)

create table EventSourceFields
(
	EventId int foreign key references Event(id),
	SourceFieldName varchar(50) not null,
	dataTypeId int foreign key references Datatype(Id),
	UniqueAlias varchar(50)
)

Create table ServiceLine
(
	Id int primary key identity(1,1),
	Name nvarchar(50)
)

Create table ServiceLineManager
(
	Id int primary key identity(1,1), 
	ServiceLineId int foreign key references ServiceLine(Id),
	UserId nvarchar(128) foreign key references AspNetUsers(Id)
) 

Create table Event_slm_subscribe
(	Id int primary key identity(1,1), 
	EventId int foreign key references Event(Id),
	ServiceLineId int foreign key references ServiceLine(Id),
	ServiceLineManagerId int foreign key references ServiceLineManager(Id),
	Confidential bit ,Mandatory bit  
)

Create table Event_slm_subscribe_users
 (		
	Event_slm_subscribe_Id int foreign key references Event_slm_subscribe(Id),
	UserId nvarchar(128) foreign key references AspNetUsers(Id) 
)

Create table Event_slm_subscribe_channel
(
	Event_slm_subscribe_Id int foreign key references Event_slm_subscribe(Id),
	ChannelId int foreign key references Channel(Id)  
)

Create table OperationManager
(  
	OperationManagerId nvarchar(128) foreign key references AspNetUsers(Id),
	ServicelineId int foreign key references ServiceLine(Id) 
)	

Create table Template
( 
	Id int  identity(1,1) primary key,
	Name nvarchar(50),
	OperationManagerId nvarchar(128) foreign key references AspNetUsers(Id),
	ServiceLineId int foreign key references ServiceLine(Id),
	EventId int foreign key references Event(Id)
)

 Create table ApprovalStatus
( 
	Id int  identity(1,1) primary key, 
	Name nvarchar(50) 
)

Create table TemplateChannel
( 
	TemplateId int  foreign key references Template(Id), 
	ChannelId int foreign key references channel(Id),
	Url nvarchar(500),
	ApprovalStatusId int foreign key references ApprovalStatus(Id)
)

create table MyEvents
(
	UserId nvarchar(128) foreign key references AspNetUsers(Id),
	EventId int foreign key references Event(Id),
	Subscribed bit
)

Create table MyEventsChannel
(	
	UserId nvarchar(128) foreign key references AspNetUsers(Id),
	EvenetId int foreign key references Event(Id),
	Channelid int foreign key references Channel(Id) 
)

---------------------------------------------------------------------------procccc

alter procedure SourceProc 

(@Action VARCHAR(10))
as begin
set nocount on;
--select
if @Action= 'SELECT'
begin
select * from Source
end
end

---Insert

----Update

 Create procedure EditProc
 (@Id int, @Name Nvarchar(50),@Action VARCHAR(10))
  as
 begin
 set nocount on;
if @Action='EDIT'
begin
Update Source set Name =@Name where Id= @Id
end
end
--delete
--if @Action='DELETE'
--begin
-- DELETE FROM Products WHERE ProductId = @ProductId
-- end
 end

 -------------------------------------------------------------------------
 Create procedure delproc
 (@Id int,@Action VARCHAR(10))
 as
 begin
 set nocount on;
 if @Action='DELETE'

 begin
DELETE FROM Source WHERE Id = @Id
 
 end
 end

 ----------------------------------------------------------------------------------
 Create procedure insertproc


 (@Name nvarchar(50),@Action VARCHAR(10))

 as
 begin
 set nocount on;
 if @Action= 'INSERT'
begin
insert into Source (Name) values(@Name)
--insert into Products values(@PName,@Price,@ImageUrl,@Description,@BrandId)
end
 end

























