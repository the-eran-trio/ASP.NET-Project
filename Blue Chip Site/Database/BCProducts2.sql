drop table BlueChipProducts;

create table BlueChipProducts
(
    productID int identity(1,1),
    productName varchar(255) not null,
    productDescription varchar(255) not null,
    productButtonName varchar(255) not null,
    productURL varchar(255) not null,

    constraint pk_BCProducts primary key (productID)
);

insert into BlueChipProducts values ('Our Services', 'From Azure to Windows 10, we''ve got you covered', 'Learn More', 'https://www.bluechip-llc.com/services/');

insert into BlueChipProducts values ('We''re Growing', 'We''re proud to announce our expansion into St. Louis, Missouri.', 'Read More', 'https://www.bluechip-llc.com/st-louis-expansion/');

insert into BlueChipProducts values ('Entrepreneur 360', 'We''ve been named one of the most entrepreneurial companies in America.' , 'Learn More', 'https://www.bluechip-llc.com/entrepreneur-360/');