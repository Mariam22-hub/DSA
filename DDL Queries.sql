--------------- TABLE CREATIONS ---------------

create table BANK (
   BANK_ID numeric(5) IDENTITY(1,1) primary key,
   BANK_NAME varchar(10) not null,
   BANK_ADDRESS varchar(20),
);
go


create table BANK_BRANCH (
   BRANCH_NO             numeric(5)			IDENTITY(1,1)           primary key,
   BB_ADDRESS           varchar(20)          not null,
   BANK_ID				numeric(5)

   --constraint branch_bank_fk FOREIGN KEY (BANK_ID) references BANK(BANK_ID)
);
go


create table CUSTOMER (
   SSN                  numeric(10)  primary key,
   CUSTOMER_ADDRESS		varchar(80)			null,
   CUSTOMER_NAME		varchar(100)	not null,
   PHONE_NO				varchar(15)		not null,
);
go


create table CUSTOMER_BANK(
	SSN                  numeric(10),
	BANK_ID				 numeric(5),

	constraint pk_customer_bank primary key (SSN, BANK_ID),
	--constraint customer_customerBank_fk foreign key (SSN) references CUSTOMER(SSN),
	--constraint bank_customerBank_fk foreign key (BANK_ID) references BANK(BANK_ID)
);
GO


create table ACCOUNT (
   ACCOUNTNO            numeric(5)			IDENTITY(1,1)          primary key,
   A_TYPE               varchar(15)          not null,
   SSN					numeric(10)  		 not null,
   BALANCE				numeric(38)		     null,

   --constraint account_customer_fk foreign key (SSN) REFERENCES CUSTOMER(SSN)
);
go


create table EMPLOYEES (
   EMPID                numeric(8)			IDENTITY(1,1)           not null,
   BRANCH_NO            numeric(5),
   FIRSTNAME			varchar(15),
   LASTNAME				varchar(15),
   
   constraint PK_EMPLOYES primary key (EMPID),
   --constraint branch_employee_FK foreign key(BRANCH_NO) REFERENCES BANK_BRANCH(BRANCH_NO)
);
go


create table LOANS (
   LOANSNO              numeric(5)			IDENTITY(1,1)           primary key,
   AMOUNT               NUMERIC(22,5)       not null,
   LOAN_TYPE            varchar(15)         not null,
   ACCOUNTNO            numeric(5)          not null,
   EMPID				numeric(8)          not null,

   --constraint loans_customer_fk foreign key (ACCOUNTNO) REFERENCES ACCOUNT (ACCOUNTNO)
)
go

create table TRANSACTIONS(
	TRANSACTION_ID		 numeric(10)			IDENTITY(1,1)			primary key,
	SSN                  numeric(10),
	EMPID                numeric(8),
	BRANCH_NO            numeric(5),
	
	--constraint transaction_customer foreign key (SSN) references CUSTOMER(SSN),
	--constraint transaction_employee foreign key (EMPID) references EMPLOYEES(EMPID), 
	--constraint transaction_branch foreign key (BRANCH_NO) references BANK_BRANCH(BRANCH_NO),
);
go


--------------- FOREIGN KEYS ---------------

alter table TRANSACTIONS
add constraint transaction_customer foreign key (SSN) references CUSTOMER(SSN);
alter table TRANSACTIONS
add constraint transaction_employee foreign key (EMPID) references EMPLOYEES(EMPID);
alter table TRANSACTIONS
add constraint transaction_branch foreign key (BRANCH_NO) references BANK_BRANCH(BRANCH_NO);


alter table LOANS
add constraint loans_customer_fk foreign key (ACCOUNTNO) REFERENCES ACCOUNT (ACCOUNTNO);
alter table LOANS
add constraint loans_employee foreign key (EMPID) references EMPLOYEES(EMPID);


alter table EMPLOYEES
add constraint branch_employee_FK foreign key(BRANCH_NO) REFERENCES BANK_BRANCH(BRANCH_NO);


alter table ACCOUNT
add constraint account_customer_fk foreign key (SSN) REFERENCES CUSTOMER(SSN);


alter table CUSTOMER_BANK
add constraint customer_customerBank_fk foreign key (SSN) references CUSTOMER(SSN);
alter table CUSTOMER_BANK
add constraint bank_customerBank_fk foreign key (BANK_ID) references BANK(BANK_ID);


alter table BANK_BRANCH
add constraint branch_bank_fk FOREIGN KEY (BANK_ID) references BANK(BANK_ID);
