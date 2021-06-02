CREATE OR ALTER VIEW v_department AS SELECT
	f_name "��������"
	FROM t_department;
GO
CREATE OR ALTER VIEW v_duty AS SELECT
	f_name "�������� ���������"
	,f_salary "�����"
	,f_tax "������"
	FROM t_duty;
GO
CREATE OR ALTER VIEW v_employee AS SELECT
	f_firstname "��� ����������"
	,f_secondname "�������"
	,f_thirdname "��������"
	,f_pass "����� ���������"
	,t_duty.f_name "���������"
	,t_department.f_name "�����"
	,f_iswork "�����������"
	,f_salary "�����"
	,f_tax "������"
	,t_employee.f_date "���� ������"
	FROM t_employee,t_duty,t_department
	WHERE t_employee.f_duty = t_duty.f_id 
	AND t_employee.f_department = t_department.f_id;
GO
CREATE OR ALTER VIEW v_contract_type AS SELECT
	f_name "�������� ���� ��������"
	FROM t_contract_type;
GO
CREATE OR ALTER VIEW v_content_type AS SELECT
	f_name "�������� ���� ��������"
	FROM t_content_type;
GO
CREATE OR ALTER VIEW v_producer AS SELECT
	f_name "��������"
	FROM t_producer;
GO
CREATE OR ALTER VIEW v_content AS SELECT
	t_content.f_name "�������� ��������"
	,f_chrono "�����������"
	,t_content_type.f_name "���"
	,t_producer.f_name "�������������"
	,f_commentary "�����������"
	FROM t_content,t_producer,t_content_type
	WHERE t_content.f_type = t_content_type.f_id
	AND t_content.f_producer = t_producer.f_id;
GO
CREATE OR ALTER VIEW v_counterpart AS SELECT
	f_name "�������� �����������"
	,f_fullname "������ ��������"
	FROM t_counterpart;
GO
CREATE OR ALTER VIEW v_contract AS SELECT
	t_contract.f_name "�������� ��������"
	,t_contract_type.f_name "���"
	,t_counterpart.f_name "����������"
	,t_content.f_name "�������"
	,f_date "���� ����������"
	,t_contract.f_commentary "�����������"
	FROM t_contract,t_contract_type,t_counterpart,t_content
	WHERE t_contract.f_type = t_contract_type.f_id 
	AND t_contract.f_counterpart = t_counterpart.f_id
	AND t_contract.f_content = t_content.f_id;
GO
CREATE OR ALTER VIEW v_outcome AS SELECT
	t_outcome.f_date "���� �������"
	,t_contract.f_name "�������"
	,f_amount "�����"
	,f_vat "���"
	FROM t_outcome,t_contract
	WHERE f_contract = t_contract.f_id;
GO
CREATE OR ALTER VIEW v_income AS SELECT
	t_income.f_date "���� �����������"
	,t_contract.f_name "�������"
	,f_amount "�����"
	,f_vat "���"
	FROM t_income,t_contract
	WHERE f_contract = t_contract.f_id;
GO
