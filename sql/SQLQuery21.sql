
INSERT INTO orders (ord_no, purch_amt, ord_date, customer_id, salesman_id) 
VALUES 
(70001, 150.5, '2012-10-05', 3005, 5002),
(70009, 270.65, '2012-09-10', 3001, 5005),
(70002, 65.26, '2012-10-05', 3002, 5001),
(70004, 110.5, '2012-08-17', 3009, 5003),
(70007, 948.5, '2012-09-10', 3005, 5002),
(70005, 2400.6, '2012-07-27', 3007, 5001),
(70008, 5760, '2012-09-10', 3002, 5001),
(70010, 1983.43, '2012-10-10', 3004, 5006),
(70003, 2480.4, '2012-10-10', 3009, 5003),
(70012, 250.45, '2012-06-27', 3008, 5002),
(70011, 75.29, '2012-08-17', 3003, 5007),
(70013, 3045.6, '2012-04-25', 3002, 5001);

select * from orders
SELECT ord_date, salesman_id, ord_no, purch_amt
FROM orders
WHERE ord_date = '2012-10-10';
SELECT ord_date, salesman_id, ord_no, purch_amt
FROM orders
WHERE salesman_id = 5001 ;

SELECT ord_date, salesman_id, ord_no, purch_amt
FROM orders;
SELECT DISTINCT salesman_id
FROM orders;
SELECT name, city
FROM salespeople
WHERE city = 'Paris';

	CREATE TABLE customers1 (
    customer_id INT PRIMARY KEY,
    cust_name VARCHAR(50),
    city VARCHAR(50),
    grade INT,
    salesman_id INT
);
INSERT INTO customers1 (customer_id, cust_name, city, grade, salesman_id) 
VALUES 
    (3002, 'Nick Rimando', 'New York', 100, 5001),
    (3007, 'Brad Davis', 'New York', 200, 5001),
    (3005, 'Graham Zusi', 'California', 200, 5002),
    (3008, 'Julian Green', 'London', 300, 5002),
    (3004, 'Fabian Johnson', 'Paris', 300, 5006),
    (3009, 'Geoff Cameron', 'Berlin', 100, 5003),
    (3003, 'Jozy Altidor', 'Moscow', 200, 5007),
    (3001, 'Brad Guzan', 'London', NULL, 5005);
	SELECT customer_id, cust_name, city, grade, salesman_id
FROM customers1
WHERE grade = 200;