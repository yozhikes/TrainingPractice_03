--USE master
--DROP DATABASE BD_GasStation
--CREATE DATABASE BD_GasStation

USE BD_GasStation

CREATE TABLE supplierdir
(
	sup_id int IDENTITY(1,1) NOT NULL,
	sup_name char(50),
	PRIMARY KEY(sup_id)
)
CREATE TABLE fuel
(
	fuel_id int IDENTITY(1,1) NOT NULL,
	fuel_name char(50),
	price DECIMAL(10,2),
	sup_id INT NOT NULL,
	FOREIGN KEY (sup_id) REFERENCES supplierdir(sup_id),
	PRIMARY KEY(fuel_id)
)
CREATE TABLE remains
(
	remain_id int IDENTITY(1,1) NOT NULL,
	fuel_id INT NOT NULL,
	FOREIGN KEY (fuel_id) REFERENCES fuel(fuel_id),
	remain_date date,
	vol_init DECIMAL(10,2),
	vol_sold DECIMAL(10,2),
	PRIMARY KEY(remain_id)
)

INSERT INTO supplierdir(sup_name) VALUES
('Yozhik&CO.'),
('Газпром'),
('РосНефть')

INSERT INTO fuel(fuel_name,price,sup_id) VALUES
('95',47.95,2),
('92',42.90,2),
('Дизель',49.70,1),
('98',61.5,3)

INSERT INTO remains(fuel_id,remain_date,vol_init,vol_sold) VALUES
(1,'26-04-2023',50000,20000),
(2,'26-04-2023',45000,15000),
(3,'26-04-2023',60000,30000),
(4,'26-04-2023',20000,5000),
(2,'27-04-2023',30000,12000)
