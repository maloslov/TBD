
CREATE TRIGGER tr_duty
ON t_duty
INSTEAD OF INSERT AS
INSERT INTO t_duty(f_name,f_salary,f_tax)
VALUES((SELECT f_name FROM inserted)
	,(SELECT f_salary FROM inserted)
	,(SELECT f_salary * 0.43 FROM inserted));
GO
CREATE TRIGGER tr_income
ON t_income
INSTEAD OF INSERT AS
INSERT INTO t_income(f_amount,f_contract,f_date,f_vat)
VALUES((SELECT f_amount FROM inserted)
	,(SELECT f_contract FROM inserted)
	,(SELECT f_date FROM inserted)
	,(SELECT f_amount * 0.2 FROM inserted));
GO
CREATE TRIGGER tr_outcome
ON t_outcome
INSTEAD OF INSERT AS
INSERT INTO t_outcome(f_amount,f_contract,f_date,f_vat)
VALUES((SELECT f_amount FROM inserted)
	,(SELECT f_contract FROM inserted)
	,(SELECT f_date FROM inserted)
	,(SELECT f_amount * 0.2 FROM inserted));
GO