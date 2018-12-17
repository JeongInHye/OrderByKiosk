INSERT INTO Category (cName) VALUES ('에스프레소');
INSERT INTO Category (cName) VALUES ('음료');
INSERT INTO Category (cName) VALUES ('티');
INSERT INTO Category (cName) VALUES ('디저트');
SELECT * FROM Category;

INSERT INTO Admin (aName,passwd) VALUES ('구디','0000');
SELECT * FROM Admin;

INSERT INTO Menu (cNo,mName,mPrice,mImage,DegreeYn,SizeYn,ShotYn,CreamYn) VALUES ('1','아메리카노',1500,'url주소',1,1,1,1);
INSERT INTO Menu (cNo,mName,mPrice,mImage,DegreeYn,SizeYn,ShotYn,CreamYn) VALUES ('1','카페 라떼',2000,'url주소',1,1,1,1);
INSERT INTO Menu (cNo,mName,mPrice,mImage,DegreeYn,SizeYn,ShotYn,CreamYn) VALUES ('2','자몽 에이드',2500,'url주소',1,1,1,1);
INSERT INTO Menu (cNo,mName,mPrice,mImage,DegreeYn,SizeYn,ShotYn,CreamYn) VALUES ('2','레몬 에이드',2500,'url주소',1,1,1,1);
INSERT INTO Menu (cNo,mName,mPrice,mImage,DegreeYn,SizeYn,ShotYn,CreamYn) VALUES ('2','키위 바나나 주스',3000,'url주소',1,1,1,1);
INSERT INTO Menu (cNo,mName,mPrice,mImage,DegreeYn,SizeYn,ShotYn,CreamYn) VALUES ('3','밀크티',2500,'url주소',1,1,1,1);
INSERT INTO Menu (cNo,mName,mPrice,mImage,DegreeYn,SizeYn,ShotYn,CreamYn) VALUES ('4','블루베리 마카롱',700,'url주소',1,1,1,1);
SELECT * FROM Menu;

INSERT INTO Store (sName,sCity,sGu) VALUES ('A매장','서울특별시','금천구');
INSERT INTO Store (sName,sCity,sGu) VALUES ('B매장','서울특별시','관악구');

insert into Orderlist (mNo,sNo,oCount,oDegree,oSize,oShot,oCream) 
					values (1,1,1,1,0,0,0);
insert into Orderlist (mNo,sNo,oCount,oDegree,oSize,oShot,oCream) 
					values (1,1,1,1,0,0,0);

SELECT * FROM Store;