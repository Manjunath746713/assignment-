
INSERT INTO NobelPrizeWinner VALUES(1970, 'Physics', 'Hannes Alfven', 'Sweden', 'Scientist'),
       (1975, 'Physics', 'Louis Neel', 'France', 'Scientist'),
       (1972, 'Chemistry', 'Luis Federico Leloir', 'Argentina', 'Scientist'),
       (1970, 'Physiology', 'Ulf von Euler', 'Sweden', 'Scientist'),
       (1975, 'Physiology', 'Bernard Katz', 'Germany', 'Scientist'),
       (1970, 'Literature', 'Aleksandr Solzhenitsyn', 'Russia', 'Linguist');
	   select *from NobelPrizeWinner

	   SELECT YEAR,SUBJECT, WINNER FROM NobelPrizeWinner WHERE YEAR = 1970
	   SELECT WINNER FROM NobelPrizeWinner WHERE YEAR = 1970 AND SUBJECT = 'Literature'

	   SELECT YEAR, SUBJECT FROM NobelPrizeWinner WHERE WINNER = 'Bernard Katz';
	   SELECT WINNER FROM NobelPrizeWinner WHERE SUBJECT = 'Physics' AND YEAR >= 1975

 SELECT YEAR, SUBJECT, WINNER, COUNTRY FROM NobelPrizeWinner
WHERE YEAR >= 1970 AND YEAR <= 1975 AND SUBJECT = 'Chemistry';

SELECT YEAR, SUBJECT, WINNER, COUNTRY, CATAGORY
FROM NobelPrizeWinner
WHERE YEAR = 1970 AND SUBJECT NOT IN ('Physics', 'Literature');
GO

SELECT * FROM salespeople
SELECT salesman_id, name, city, commission FROM salespeople WHERE city IN( 'PARIS','ROME' )
SELECT *FROM customers1
 
SELECT customer_id, cust_name, city, grade, salesman_iD 
FROM customers1 
WHERE customer_id IN (3007,3008,3009)
 
SELECT * FROM orders
 
SELECT ord_no, purch_amt, ord_date, customer_id,salesman_id FROM orders
WHERE purch_amt BETWEEN 500 AND 4000
AND purch_amt NOT IN (948.50,1983.43)

SELECT * FROM salespeople
 
SELECT salesman_id, name , city,commission FROM salespeople
WHERE NAME NOT LIKE 'A%' AND NAME NOT LIKE 'L%'
SELECT customer_id, cust_name, city, grade, salesman_id FROM customers1
WHERE cust_name LIKE 'B%'


