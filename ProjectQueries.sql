-------------- QUERIES --------------

-- QUERY A
-- What was the branch that has no customers?

SELECT BRANCH_NO, BB_ADDRESS
FROM BANK_BRANCH
WHERE BRANCH_NO NOT IN (SELECT BRANCH_NO
						FROM TRANSACTIONS)
----------------------------------------------------

-- QUERY B
-- What was the branch that has no employees?

SELECT BRANCH_NO, BB_ADDRESS
FROM BANK_BRANCH
WHERE BRANCH_NO NOT IN (SELECT BRANCH_NO
						FROM EMPLOYEES)
----------------------------------------------------

-- QUERY C
-- Who was the employee with the maximum number of loans added?

SELECT EMPLOYEES.EMPID, EMPLOYEES.FIRSTNAME, EMPLOYEES.LASTNAME
FROM EMPLOYEES 
WHERE EMPLOYEES.EMPID IN(SELECT EMPID
			FROM (SELECT EMPID, COUNT(*) AS LOANCOUNT
			FROM LOANS
			GROUP BY EMPID

			HAVING COUNT(*) = (SELECT MAX(c) AS [MAX VALUE]
								FROM
								(
								SELECT EMPID, COUNT(EMPID) AS c
								FROM LOANS
								GROUP BY EMPID
								) LOANS)) Y)

----------------------------------------------------

-- QUERY D
-- Who were the customer(s) who has the max number of loans?

SELECT SSN, CUSTOMER_NAME AS FIRSTNAME, CUSTOMER_LNAME AS LASTNAME
FROM CUSTOMER
WHERE SSN IN (  SELECT SSN
				FROM ACCOUNT
				WHERE ACCOUNTNO IN ( SELECT ACCOUNTNO 
									FROM (
									SELECT ACCOUNTNO, COUNT(*) AS LOANCOUNT
									FROM LOANS
									GROUP BY ACCOUNTNO
									HAVING COUNT(*) = (SELECT MAX(c) AS [MAX VALUE]
													   FROM
													   (
													   SELECT ACCOUNTNO, COUNT(LOANSNO) AS c
													   FROM LOANS
													   GROUP BY ACCOUNTNO
													   )LOANS))X))

----------------------------------------------------

-- QUERY E
-- Who were the customer(s) who did not take any loans?

SELECT SSN, CUSTOMER_NAME, CUSTOMER_LNAME
FROM CUSTOMER
WHERE SSN NOT IN( SELECT SSN
				  FROM ACCOUNT
				  WHERE ACCOUNTNO IN( SELECT ACCOUNTNO
										  FROM LOANS))

----------------------------------------------------

-- QUERY F
-- For each customer, retrieve all his/her information and the number of employees he deals with

SELECT CUSTOMER.SSN, CUSTOMER.CUSTOMER_NAME AS FIRSTNAME, CUSTOMER.CUSTOMER_LNAME AS LASTNAME, CUSTOMER.CUSTOMER_ADDRESS AS ADDRESS, CUSTOMER.PHONE_NO, 
       count(DISTINCT TRANSACTIONS.EMPID) AS EMPLOYEE_COUNT
FROM CUSTOMER, TRANSACTIONS
WHERE CUSTOMER.SSN = TRANSACTIONS.SSN
GROUP BY TRANSACTIONS.SSN, CUSTOMER.SSN, CUSTOMER.CUSTOMER_NAME, CUSTOMER.CUSTOMER_LNAME, CUSTOMER.CUSTOMER_ADDRESS, CUSTOMER.PHONE_NO
ORDER BY EMPLOYEE_COUNT DESC