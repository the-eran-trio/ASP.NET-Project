drop table BlueChipProducts;

create table BlueChipProducts
(
    productID int identity(1,1),
    productName varchar(255) not null,
    productDescription varchar(255) not null,

    constraint pk_BCProducts primary key (productID)
);

insert into BlueChipProducts values ('Our Services', 'From Azure to Windows 10, we''ve got you covered.');

insert into BlueChipProducts values ('We''re Growing', 'We''re proud to announce our expansion into St. Louis, Missouri.');

insert into BlueChipProducts values ('Entrepreneur 360', 'We''ve been named one of the most entrepreneurial companies in America.' );