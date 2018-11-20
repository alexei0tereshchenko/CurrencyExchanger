create table currency
(
  CURRENCY_ID   int auto_increment
    primary key,
  CURRENCY_NAME varchar(3) not null,
  SELL          float      not null,
  PURCHASE      float      not null,
  constraint CURRENCY_NAME
  unique (CURRENCY_NAME)
)
  collate = utf8_unicode_ci;

create table person
(
  PERSON_ID       int auto_increment
    primary key,
  FIRST_NAME      varchar(12) not null,
  LAST_NAME       varchar(12) not null,
  BIRTH_DATE      date        not null,
  PASSPORT_SERIES varchar(2)  not null,
  PASSPORT_ID     int(8)      not null,
  constraint PASSPORT_ID
  unique (PASSPORT_ID)
)
  collate = utf8_unicode_ci;

create table user
(
  USER_ID    int auto_increment
    primary key,
  FIRST_NAME varchar(12)             not null,
  LAST_NAME  varchar(12)             not null,
  LOGIN      varchar(12)             not null,
  PASSWORD   varchar(12)             not null,
  `E-MAIL`   varchar(20)             null,
  BIRTH_DATE date                    null,
  ZIP_CODE   int                     null,
  ADDRESS    varchar(20)             null,
  CITY       varchar(12)             null,
  STATE      varchar(10)             null,
  GENDER     enum ('male', 'female') null
)
  collate = utf8_unicode_ci;

create table report
(
  REPORT_ID      int auto_increment
    primary key,
  USER_ID        int   not null,
  PERSON_ID      int   not null,
  CURRENCY_ID    int   not null,
  INCOM_AMOUNT   float not null,
  OUTCOME_AMOUNT float not null,
  DATE           date  not null,
  constraint REPORT_ibfk_1
  foreign key (PERSON_ID) references person (person_id),
  constraint REPORT_ibfk_2
  foreign key (CURRENCY_ID) references currency (currency_id),
  constraint REPORT_ibfk_3
  foreign key (USER_ID) references user (user_id)
)
  collate = utf8_unicode_ci;

create index CURRENCY_ID
  on report (CURRENCY_ID);

create index PERSON_ID
  on report (PERSON_ID);

create index USER_ID
  on report (USER_ID);


