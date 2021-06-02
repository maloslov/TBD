
CREATE OR ALTER TRIGGER tr_duty
ON t_duty
INSTEAD OF INSERT AS
INSERT INTO t_duty(f_name,f_salary,f_tax)
VALUES((SELECT f_name FROM inserted)
	,(SELECT f_salary FROM inserted)
	,(SELECT f_salary * 0.43 FROM inserted));
GO
CREATE OR ALTER TRIGGER tr_income
ON t_income
INSTEAD OF INSERT AS
INSERT INTO t_income(f_amount,f_contract,f_date,f_vat)
VALUES((SELECT f_amount FROM inserted)
	,(SELECT f_contract FROM inserted)
	,(SELECT f_date FROM inserted)
	,(SELECT f_amount * 0.2 FROM inserted));
GO
CREATE OR ALTER TRIGGER tr_outcome
ON t_outcome
INSTEAD OF INSERT AS
INSERT INTO t_outcome(f_amount,f_contract,f_date,f_vat)
VALUES((SELECT f_amount FROM inserted)
	,(SELECT f_contract FROM inserted)
	,(SELECT f_date FROM inserted)
	,(SELECT f_amount * 0.2 FROM inserted));
GO
CREATE OR ALTER TRIGGER tr_employee 
ON t_employee
INSTEAD OF INSERT AS
IF EXISTS((SELECT * FROM t_employee AS t
	JOIN inserted AS i ON i.f_pass = t.f_pass
	WHERE t.f_firstname=i.f_firstname 
	AND t.f_secondname = i.f_secondname))
BEGIN
	RAISERROR ('Сотрудник уже есть в базе данных!', 16, 1);
	ROLLBACK TRANSACTION;
	RETURN
END
ELSE BEGIN
INSERT INTO t_employee(f_firstname,f_secondname,f_thirdname,f_pass,f_duty,f_department,f_date,f_iswork)
VALUES((SELECT f_firstname FROM inserted),(SELECT f_secondname FROM inserted)
	,(SELECT f_thirdname FROM inserted), (SELECT f_pass FROM inserted)
	,(SELECT f_duty FROM inserted), (SELECT f_department FROM inserted)
	,(SELECT f_date FROM inserted), (SELECT f_iswork FROM inserted))
END;