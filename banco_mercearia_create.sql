create database db_api_mercearia;
#drop database db_api_mercearia;

use db_api_mercearia;

CREATE TABLE Clientes (
    ID int(11) not null PRIMARY KEY auto_increment,
    nome VARCHAR(150) not null,
    dataNascimento datetime, 
    rua VARCHAR(50) not null,
    numero int(11),
    bairro VARCHAR(30)not null,
    cidade VARCHAR(30) not null, 
    UF varchar(2) not null
);


CREATE TABLE Produtos (
    ID int(11) not null PRIMARY KEY auto_increment,
    nome VARCHAR(50) not null,
    marca VARCHAR(50) not null,
    dataVencimento datetime,
    preco double not null, 
    unid VARCHAR(5) not null, 
    quantEstoque int not null
);




