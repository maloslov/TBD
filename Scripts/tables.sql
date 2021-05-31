
CREATE TABLE t_department (
	f_id INT IDENTITY(1,1) NOT NULL
	,f_name NVARCHAR(50) NOT NULL
	,CONSTRAINT pk_department PRIMARY KEY CLUSTERED(f_id)
);
GO
CREATE TABLE t_duty (
	f_id INT IDENTITY(1,1) NOT NULL
	,f_name NVARCHAR(50) NOT NULL
	,f_salary MONEY NOT NULL
	,f_tax MONEY NOT NULL
	,CONSTRAINT pk_duty PRIMARY KEY CLUSTERED(f_id)
);
GO
CREATE TABLE t_employee (
	f_id INT IDENTITY(1,1) NOT NULL
	,f_firstname NVARCHAR(50) NOT NULL
	,f_secondname NVARCHAR(50) NOT NULL
	,f_thirdname NVARCHAR(50) NULL
	,f_pass INT NOT NULL
	,f_duty INT NOT NULL
	,f_department INT NOT NULL
	,f_date DATE NOT NULL
	,f_iswork BIT NOT NULL
	,CONSTRAINT pk_employee PRIMARY KEY CLUSTERED(f_id)
	,CONSTRAINT fk_employee_duty FOREIGN KEY (f_duty) REFERENCES t_duty(f_id)
	,CONSTRAINT fk_employee_department FOREIGN KEY(f_department) REFERENCES t_department(f_id)
);
GO
CREATE TABLE t_counterpart (
	f_id INT IDENTITY(1,1) NOT NULL
	,f_name NVARCHAR(50) NOT NULL
	,f_fullname NVARCHAR(100) NULL
	,CONSTRAINT pk_counterpart PRIMARY KEY CLUSTERED(f_id)
);
GO
CREATE TABLE t_content_type(
	f_id INT IDENTITY(1,1) NOT NULL
	,f_name NVARCHAR(50) NOT NULL
	,CONSTRAINT pk_content_type PRIMARY KEY CLUSTERED(F_ID)
);
GO
CREATE TABLE t_contract_type(
	f_id INT IDENTITY NOT NULL
	,f_name NVARCHAR(50) NOT NULL
	,CONSTRAINT pk_contract_type PRIMARY KEY CLUSTERED(f_id)
);
GO
CREATE TABLE t_producer (
	f_id INT IDENTITY NOT NULL
	,f_name NVARCHAR(50) NOT NULL
	,CONSTRAINT pk_producer PRIMARY KEY CLUSTERED(f_id)
);
GO
CREATE TABLE t_content (
	f_id INT IDENTITY NOT NULL
	,f_name NVARCHAR(50) NOT NULL
	,f_chrono INT NOT NULL
	,f_type INT NOT NULL
	,f_producer INT NOT NULL
	,f_commentary NVARCHAR(100) NULL
	,CONSTRAINT pk_content PRIMARY KEY CLUSTERED(f_id)
	,CONSTRAINT fk_content_type FOREIGN KEY (f_type) REFERENCES t_content_type(f_id)
	,CONSTRAINT fk_content_producer FOREIGN KEY (f_producer) REFERENCES t_producer(f_id)
);
GO
CREATE TABLE t_contract (
	f_id INT IDENTITY NOT NULL
	,f_name NVARCHAR(50) NOT NULL
	,f_type INT NOT NULL
	,f_counterpart INT NOT NULL
	,f_content INT NOT NULL
	,f_date DATE NOT NULL
	,f_commentary NVARCHAR(50) NULL
	,CONSTRAINT pk_contract PRIMARY KEY CLUSTERED(f_id)
	,CONSTRAINT fk_contract_type FOREIGN KEY (f_type) REFERENCES t_contract_type(f_id)
	,CONSTRAINT fk_contract_counterpart FOREIGN KEY (f_counterpart) REFERENCES t_counterpart(f_id)
	,CONSTRAINT fk_contract_content FOREIGN KEY (f_content) REFERENCES t_content(f_id)
);
GO
CREATE TABLE t_income (
	f_id INT IDENTITY NOT NULL
	,f_amount MONEY NOT NULL
	,f_contract INT NOT NULL
	,f_date DATE NOT NULL
	,f_vat MONEY NOT NULL
	,CONSTRAINT pk_income PRIMARY KEY CLUSTERED(f_id)
	,CONSTRAINT fk_income_contract FOREIGN KEY (f_contract) REFERENCES t_contract(f_id)
);
CREATE TABLE t_outcome (
	f_id INT IDENTITY NOT NULL
	,f_amount MONEY NOT NULL
	,f_contract INT NOT NULL
	,f_date DATE NOT NULL
	,f_vat MONEY NOT NULL
	,CONSTRAINT pk_outcome PRIMARY KEY CLUSTERED(f_id)
	,CONSTRAINT fk_outcome_contract FOREIGN KEY (f_contract) REFERENCES t_contract(f_id)
);
