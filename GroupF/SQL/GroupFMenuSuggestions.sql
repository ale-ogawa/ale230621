--menuテーブル
create table menu(
men_number integer primary key auto_increment,
men_name varchar(100) not null,
men_kcal integer,
men_time integer,
men_genre varchar(1),
men_item varchar(200),
men_recipe varchar(2000),
men_pic varchar(200)
);

--itemテーブル作成
create table item(
ite_number integer primary key auto_increment,
ite_name varchar(100) not null,
ite_date date
);

--食材から作成できるメニューを検索する
SELECT *
FROM    menu
WHERE   men_item Like '%鶏肉%';

--
SELECT * FROM Menu;

INSERT INTO Item(ite_name,ite_date) VALUES('ラディッシュ','2023-10-23');

--
UPDATE Menu SET men_pic='C:\\Users\\user\\Desktop\\men_pic\\curry.png' WHERE men_name = 'カレーライス';

select men_pic from menu;

UPDATE Menu SET men_pic='C:\\temp\\hamburg.png' WHERE men_name = 'カレーライス';
