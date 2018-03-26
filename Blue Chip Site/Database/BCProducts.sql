drop table BCProducts;

create table BCProducts
(
    productID int identity(1,1),
    productName varchar(255) not null,
    productDescription varchar(255) not null,

    constraint pk_BCProducts primary key (productID)
);

insert into BCProducts values ('Test', 'This is a test');