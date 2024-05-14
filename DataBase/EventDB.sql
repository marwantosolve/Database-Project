/*==============================================================*/
/* Table: EVENT                                                 */
/*==============================================================*/
create table EVENT (
   ID varchar(8) not null,
   NAME varchar(15) not null,
   TYPE varchar(10) not null,
   LOCATION varchar(15) not null,
   DATE date not null,
   constraint PK_EVENT primary key nonclustered (ID)
)
go
   /*==============================================================*/
   /* Table: SPONSOR                                               */
   /*==============================================================*/
   create table SPONSOR (
      ID varchar(8) not null,
      EVENTID varchar(8) not null,
      NAME varchar(15) not null,
      DESCRIPTION text null,
      constraint PK_SPONSOR primary key nonclustered (ID)
   )
go
   /*==============================================================*/
   /* Index: SHOW_FK                                               */
   /*==============================================================*/
   create index SHOW_FK on SPONSOR (EVENTID ASC)
go
   /*==============================================================*/
   /* Table: TICKET                                                */
   /*==============================================================*/
   create table TICKET (
      ID varchar(8) not null,
      EVENTID varchar(8) not null,
      TYPE varchar(10) not null,
      PRICE numeric(5) not null,
      DATE date not null,
      ISAVALIABLE bit not null,
      CUSTID varchar(8),
      constraint PK_TICKET primary key nonclustered (ID)
   )
go
   /*==============================================================*/
   /* Index: HAS2_FK                                               */
   /*==============================================================*/
   create index HAS2_FK on TICKET (CUSTID ASC)
go
   /*==============================================================*/
   /* Table: "USER"                                                */
   /*==============================================================*/
   create table "USER" (
      ID varchar(8) not null,
      FULLNAME varchar(30) not null,
      EMAIL varchar(40) not null,
      PASSWORD varchar(10) not null,
      ROLE varchar(10) not null,
      constraint PK_USER primary key (ID)
   )
go
alter table SPONSOR
add constraint FK_SPONSOR_SUPPORTS_EVENT foreign key (EVENTID) references EVENT (ID)
go
alter table TICKET
add constraint FK_TICKET_FOLLOWS_EVENT foreign key (EVENTID) references EVENT (ID)
go
alter table TICKET
add constraint FK_TICKET_HAS_USER foreign key (CUSTID) references "USER" (ID)
go