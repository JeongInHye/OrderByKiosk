INSERT INTO Category (cName) VALUES ('에스프레소');
INSERT INTO Category (cName) VALUES ('음료');
INSERT INTO Category (cName) VALUES ('티');
INSERT INTO Category (cName) VALUES ('디저트');
SELECT * FROM Category;

INSERT INTO Manager (passwd) VALUES ('0000');
SELECT * FROM Manager;

INSERT INTO Menu (cNo,mName,mPrice,mImage) VALUES ('1','아메리카노',1500,'url주소');
INSERT INTO Menu (cNo,mName,mPrice,mImage) VALUES ('1','카페 라떼',2000,'url주소');
INSERT INTO Menu (cNo,mName,mPrice,mImage) VALUES ('2','자몽 에이드',2500,'url주소');
INSERT INTO Menu (cNo,mName,mPrice,mImage) VALUES ('2','레몬 에이드',2500,'url주소');
INSERT INTO Menu (cNo,mName,mPrice,mImage) VALUES ('2','키위 바나나 주스',3000,'url주소');
INSERT INTO Menu (cNo,mName,mPrice,mImage) VALUES ('3','밀크티',2500,'url주소');
INSERT INTO Menu (cNo,mName,mPrice,mImage) VALUES ('4','블루베리 마카롱',700,'url주소');
SELECT * FROM Menu;

INSERT INTO Store (sName) VALUES ('A매장');
INSERT INTO Store (sName) VALUES ('B매장');
SELECT * FROM Store;