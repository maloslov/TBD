CREATE USER username IDENTIFIED BY userid DEFAULT TABLESPACE USERS;
grant create session, create table, create procedure, create trigger, create view, create sequence to MILLER;
GRANT DELETE ANY TABLE TO usename;
GRANT DROP ANY TABLE TO usename;
GRANT DROP ANY PROCEDURE TO usename;
GRANT DROP ANY TRIGGER TO usename;
GRANT DROP ANY TABLE TO username;
GRANT ALTER ANY TABLE TO usename;
GRANT ALTER ANY PROCEDURE TO usename;
GRANT ALTER ANY TRIGGER TO username;
--COMMIT;