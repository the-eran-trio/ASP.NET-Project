drop table BlueChipProducts;

create table BlueChipProducts
(
    productID int identity(1,1),
    productName varchar(255) not null,
    productDescription varchar(255) not null,

    constraint pk_BCProducts primary key (productID)
);

insert into BlueChipProducts values ('Test', 'This is a test');

insert into BlueChipProducts values ('Testy', 'This is the second test');