/*==============================================================*/
/* Table: ADMIN                                                 */
/*==============================================================*/
create table ADMIN (
   ID varchar(8) not null,
   FULLNAME varchar(30) not null,
   EMAIL varchar(40) not null,
   PASSWORD varchar(10) not null,
   constraint PK_ADMIN primary key (ID)
)
go
   /*==============================================================*/
   /* Table: CUSTOMER                                              */
   /*==============================================================*/
   create table CUSTOMER (
      ID varchar(8) not null,
      FULL_NAME varchar(30) not null,
      EMAIL varchar(40) not null,
      PASSWORD varchar(10) not null,
      constraint PK_CUSTOMER primary key (ID)
   )
go
   /*==============================================================*/
   /* Table: EVENT                                                 */
   /*==============================================================*/
   create table EVENT (
      ID varchar(8) not null,
      NAME varchar(15) not null,
      TYPE varchar(10) not null,
      LOCATION varchar(15) not null,
      DATE datetime not null,
      constraint PK_EVENT primary key nonclustered (ID)
   )
go
   /*==============================================================*/
   /* Table: EVENT_ORGANIZER                                       */
   /*==============================================================*/
   create table EVENT_ORGANIZER (
      ID varchar(8) not null,
      FULLNAME varchar(30) not null,
      EMAIL varchar(40) not null,
      PASSWORD varchar(10) not null,
      constraint PK_EVENT_ORGANIZER primary key (ID)
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
      DATE datetime not null,
      ISAVALIABLE bit not null,
      CUSTID varchar(8) null,
      constraint PK_TICKET primary key nonclustered (ID)
   )
go
   /*==============================================================*/
   /* Index: HAS2_FK                                               */
   /*==============================================================*/
   create index HAS2_FK on TICKET (CUSTID ASC)
go
alter table SPONSOR
add constraint FK_SPONSOR_SHOW_EVENT foreign key (EVENTID) references EVENT (ID)
go
alter table TICKET
add constraint FK_TICKET_HAS2_CUSTOMER foreign key (CUSTID) references CUSTOMER (ID)
go
alter table TICKET
add constraint FK_TICKET_REFERENCE_EVENT foreign key (EVENTID) references EVENT (ID)
go