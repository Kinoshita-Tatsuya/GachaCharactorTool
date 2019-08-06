create database gachasimulator;

create table gachasimulator.gachatable(
    ID int(11),
    CharacterName varchar(255),
    Probability float,
    Rarity int(11),
    Image varchar(255),
    primary key (ID)
);
