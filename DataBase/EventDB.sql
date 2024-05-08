if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ADMIN') and o.name = 'FK_ADMIN_ADM_CREAT_EVENT')
alter table ADMIN
   drop constraint FK_ADMIN_ADM_CREAT_EVENT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CUSTOMER') and o.name = 'FK_CUSTOMER_HAS1_TICKET')
alter table CUSTOMER
   drop constraint FK_CUSTOMER_HAS1_TICKET
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CUSTOMER') and o.name = 'FK_CUSTOMER_REFERENCE_EVENT')
alter table CUSTOMER
   drop constraint FK_CUSTOMER_REFERENCE_EVENT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('EVENT_ORGANIZER') and o.name = 'FK_EVENT_OR_ORG_CREAT_EVENT')
alter table EVENT_ORGANIZER
   drop constraint FK_EVENT_OR_ORG_CREAT_EVENT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('SPONSOR') and o.name = 'FK_SPONSOR_SHOW_EVENT')
alter table SPONSOR
   drop constraint FK_SPONSOR_SHOW_EVENT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TICKET') and o.name = 'FK_TICKET_HAS2_CUSTOMER')
alter table TICKET
   drop constraint FK_TICKET_HAS2_CUSTOMER
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('ADMIN')
            and   name  = 'ADM_CREATE_FK'
            and   indid > 0
            and   indid < 255)
   drop index ADMIN.ADM_CREATE_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ADMIN')
            and   type = 'U')
   drop table ADMIN
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CUSTOMER')
            and   name  = 'HAS1_FK'
            and   indid > 0
            and   indid < 255)
   drop index CUSTOMER.HAS1_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CUSTOMER')
            and   type = 'U')
   drop table CUSTOMER
go

if exists (select 1
            from  sysobjects
           where  id = object_id('EVENT')
            and   type = 'U')
   drop table EVENT
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('EVENT_ORGANIZER')
            and   name  = 'ORG_CREATE_FK'
            and   indid > 0
            and   indid < 255)
   drop index EVENT_ORGANIZER.ORG_CREATE_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('EVENT_ORGANIZER')
            and   type = 'U')
   drop table EVENT_ORGANIZER
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('SPONSOR')
            and   name  = 'SHOW_FK'
            and   indid > 0
            and   indid < 255)
   drop index SPONSOR.SHOW_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('SPONSOR')
            and   type = 'U')
   drop table SPONSOR
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('TICKET')
            and   name  = 'HAS2_FK'
            and   indid > 0
            and   indid < 255)
   drop index TICKET.HAS2_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TICKET')
            and   type = 'U')
   drop table TICKET
go

/*==============================================================*/
/* Table: ADMIN                                                 */
/*==============================================================*/
create table ADMIN (
   ID                   varchar(8)           not null,
   FULLNAME             varchar(30)          not null,
   EMAIL                varchar(40)          not null,
   PASSWORD             varchar(10)          not null,
   EVENTID              varchar(8)           null,
   constraint PK_ADMIN primary key (ID)
)
go

/*==============================================================*/
/* Index: ADM_CREATE_FK                                         */
/*==============================================================*/
create index ADM_CREATE_FK on ADMIN (
EVENTID ASC
)
go

/*==============================================================*/
/* Table: CUSTOMER                                              */
/*==============================================================*/
create table CUSTOMER (
   ID                   varchar(8)           not null,
   FULL_NAME            varchar(30)          not null,
   EMAIL                varchar(40)          not null,
   PASSWORD             varchar(10)          not null,
   EVENTID              varchar(8)           null,
   TICKETID             varchar(8)           null,
   constraint PK_CUSTOMER primary key (ID)
)
go

/*==============================================================*/
/* Index: HAS1_FK                                               */
/*==============================================================*/
create index HAS1_FK on CUSTOMER (
TICKETID ASC
)
go

/*==============================================================*/
/* Table: EVENT                                                 */
/*==============================================================*/
create table EVENT (
   ID                   varchar(8)           not null,
   NAME                 varchar(15)          not null,
   TYPE                 varchar(10)          not null,
   LOCATION             varchar(15)          not null,
   DATE                 datetime             not null,
   constraint PK_EVENT primary key nonclustered (ID)
)
go

/*==============================================================*/
/* Table: EVENT_ORGANIZER                                       */
/*==============================================================*/
create table EVENT_ORGANIZER (
   ID                   varchar(8)           not null,
   FULLNAME             varchar(30)          not null,
   EMAIL                varchar(40)          not null,
   PASSWORD             varchar(10)          not null,
   EVENTID              varchar(8)           not null,
   constraint PK_EVENT_ORGANIZER primary key (ID)
)
go

/*==============================================================*/
/* Index: ORG_CREATE_FK                                         */
/*==============================================================*/
create index ORG_CREATE_FK on EVENT_ORGANIZER (
EVENTID ASC
)
go

/*==============================================================*/
/* Table: SPONSOR                                               */
/*==============================================================*/
create table SPONSOR (
   ID                   numeric(8)           not null,
   EVENTID              varchar(8)           not null,
   NAME                 varchar(15)          not null,
   DESCRIPTION          text                 null,
   constraint PK_SPONSOR primary key nonclustered (EVENTID, ID)
)
go

/*==============================================================*/
/* Index: SHOW_FK                                               */
/*==============================================================*/
create index SHOW_FK on SPONSOR (
EVENTID ASC
)
go

/*==============================================================*/
/* Table: TICKET                                                */
/*==============================================================*/
create table TICKET (
   ID                   varchar(8)           not null,
   TYPE                 varchar(10)          not null,
   PRICE                numeric(5)           not null,
   DATE                 datetime             not null,
   ISAVALIABLE          bit                  not null,
   CUSTID               varchar(8)           null,
   constraint PK_TICKET primary key nonclustered (ID)
)
go

/*==============================================================*/
/* Index: HAS2_FK                                               */
/*==============================================================*/
create index HAS2_FK on TICKET (
CUSTID ASC
)
go

alter table ADMIN
   add constraint FK_ADMIN_ADM_CREAT_EVENT foreign key (EVENTID)
      references EVENT (ID)
go

alter table CUSTOMER
   add constraint FK_CUSTOMER_HAS1_TICKET foreign key (TICKETID)
      references TICKET (ID)
go

alter table CUSTOMER
   add constraint FK_CUSTOMER_REFERENCE_EVENT foreign key (EVENTID)
      references EVENT (ID)
go

alter table EVENT_ORGANIZER
   add constraint FK_EVENT_OR_ORG_CREAT_EVENT foreign key (EVENTID)
      references EVENT (ID)
go

alter table SPONSOR
   add constraint FK_SPONSOR_SHOW_EVENT foreign key (EVENTID)
      references EVENT (ID)
go

alter table TICKET
   add constraint FK_TICKET_HAS2_CUSTOMER foreign key (CUSTID)
      references CUSTOMER (ID)
go
