create database DomaciBaze
use DomaciBaze

create table ulica
(
id int identity(1,1),
naziv nvarchar(20),
opstina nvarchar(20),
sprat int,
brojevi_od int,
brojevi_do int
)

insert into Ulica
values ('Naziv','opstina',5,2,7)

update  ulica set naziv='ala', brojevi_od=5, brojevi_do=15 where id=3
