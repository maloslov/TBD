CREATE VIEW v_department AS SELECT
	f_name "Название"
	FROM t_department;
GO
CREATE VIEW v_duty AS SELECT
	f_name "Название должности"
	,f_salary "Оклад"
	,f_tax "Налоги"
	FROM t_duty;
GO
CREATE VIEW v_employee AS SELECT
	f_firstname "Имя сотрудника"
	,f_secondname "Фамилия"
	,f_thirdname "Отчество"
	,f_pass "Номер документа"
	,f_duty "Должность"
	,f_department "Отдел"
	,f_iswork "Действующий"
	,f_salary "Оклад"
	,f_tax "Налоги"
	,f_date "Дата приема"
	FROM t_employee,t_duty,t_department;
GO
CREATE VIEW v_contract_type AS SELECT
	f_name "Название типа договора"
	FROM t_contract_type;
GO
CREATE VIEW v_content_type AS SELECT
	f_name "Название типа контента"
	FROM t_content_type;
GO
CREATE VIEW v_producer AS SELECT
	f_name "Название"
	FROM t_producer;
GO
CREATE VIEW v_content AS SELECT
	t_content.f_name "Название контента"
	,f_chrono "Хронометраж"
	,t_content_type.f_name "Тип"
	,t_producer.f_name "Производитель"
	,f_commentary "Комментарий"
	FROM t_content,t_producer,t_content_type;
GO
CREATE VIEW v_counterpart AS SELECT
	f_name "Название контрагента"
	,f_fullname "Полное название"
	FROM t_counterpart;
GO
CREATE VIEW v_contract AS SELECT
	t_contract.f_name "Название договора"
	,t_contract_type.f_name "Тип"
	,t_counterpart.f_name "Контрагент"
	,t_content.f_name "Контент"
	,f_date "Дата заключение"
	,t_contract.f_commentary "Комментарий"
	FROM t_contract,t_contract_type,t_counterpart,t_content;
GO
CREATE VIEW v_outcome AS SELECT
	t_outcome.f_date "Дата покупки"
	,t_contract.f_name "Договор"
	,f_amount "Сумма"
	,f_vat "НДС"
	FROM t_outcome,t_contract;
GO
CREATE VIEW v_income AS SELECT
	t_income.f_date "Дата поступления"
	,t_contract.f_name "Договор"
	,f_amount "Сумма"
	,f_vat "НДС"
	FROM t_income,t_contract;
GO
