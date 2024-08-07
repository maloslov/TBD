CREATE OR REPLACE TRIGGER TR_TITLE_UPDATE 
    INSTEAD OF UPDATE
        ON V_CUSTOMER_PURCHASES 
        FOR EACH ROW 
    BEGIN 
        IF :NEW.F_TITLE = :OLD.F_TITLE THEN 
             BEGIN
                DBMS_OUTPUT.PUT_LINE('TITLE ALREADY EXISTS'); 
                RETURN; 
             END;
        END IF; 
        UPDATE T_WORK SET F_TITLE = :NEW.F_TITLE WHERE F_TITLE = :OLD.F_TITLE; 
    END; 
 /
UPDATE V_CUSTOMER_PURCHASES SET F_TITLE = 'ODESSA PORT1' WHERE F_TITLE = 'ODESSA PORT'; 
UPDATE V_CUSTOMER_PURCHASES SET F_TITLE = 'ODESSA PORT' WHERE F_TITLE = 'ODESSA PORT1'; 
UPDATE V_CUSTOMER_PURCHASES SET F_TITLE = 'ODESSA PORT' WHERE F_TITLE = 'ODESSA PORT'; 