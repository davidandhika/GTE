01--ADMINISTRATOR
GRANT DBA TO DAVID;

DROP USER JIMMY;
DROP USER SISCA;

CREATE USER JIMMY
IDENTIFIED BY JIMMY  
ACCOUNT UNLOCK;

CREATE USER SISCA
IDENTIFIED BY SISCA  
ACCOUNT UNLOCK;

'ROLE USER : 
'BISA LOGIN, INSERT TABLE

02--ADMINISTRATOR
CREATE ROLE FOR_USER; 
GRANT FOR_USER TO JIMMY,SISCA;
GRANT CONNECT TO FOR_USER;
GRANT CONNECT TO JIMMY;
GRANT CONNECT TO SISCA;

03--TIAP USER
CREATE OR REPLACE PUBLIC SYNONYM S_BRAND FOR DAVID.BRAND;
CREATE OR REPLACE PUBLIC SYNONYM S_TIPE FOR DAVID.TIPE;
CREATE OR REPLACE PUBLIC SYNONYM S_BARANG FOR DAVID.BARANG;
CREATE OR REPLACE PUBLIC SYNONYM S_ADMINISTRATOR FOR DAVID.ADMINISTRATOR;
CREATE OR REPLACE PUBLIC SYNONYM S_GUDANG FOR DAVID.GUDANG;
CREATE OR REPLACE PUBLIC SYNONYM S_DETAIL_MASUK FOR DAVID.DETAIL_MASUK;
CREATE OR REPLACE PUBLIC SYNONYM S_TRANS_MASUK FOR DAVID.TRANS_MASUK;
CREATE OR REPLACE PUBLIC SYNONYM S_DETAIL_KELUAR FOR DAVID.DETAIL_KELUAR;
CREATE OR REPLACE PUBLIC SYNONYM S_TRANS_KELUAR FOR DAVID.TRANS_KELUAR;
CREATE OR REPLACE PUBLIC SYNONYM S_RAK FOR DAVID.RAK;
CREATE OR REPLACE PUBLIC SYNONYM S_STOK_OPNAME FOR DAVID.STOK_OPNAME;
CREATE OR REPLACE PUBLIC SYNONYM S_generateDetailMasuk FOR DAVID.generateDetailMasuk;

04--ADMINISTRATOR
GRANT INSERT ON S_BRAND TO FOR_USER;
GRANT INSERT ON S_TIPE TO FOR_USER;
GRANT INSERT ON S_BARANG TO FOR_USER;
GRANT INSERT ON S_GUDANG TO FOR_USER;
GRANT INSERT ON S_DETAIL_MASUK TO FOR_USER;
GRANT INSERT ON S_TRANS_MASUK TO FOR_USER;
GRANT INSERT ON S_DETAIL_KELUAR TO FOR_USER;
GRANT INSERT ON S_TRANS_KELUAR TO FOR_USER;
GRANT INSERT ON S_RAK TO FOR_USER;
GRANT INSERT ON S_STOK_OPNAME TO FOR_USER;

GRANT SELECT ON S_BRAND TO FOR_USER;
GRANT SELECT ON S_TIPE TO FOR_USER;
GRANT SELECT ON S_BARANG TO FOR_USER;
GRANT SELECT ON S_GUDANG TO FOR_USER;
GRANT SELECT ON S_DETAIL_MASUK TO FOR_USER;
GRANT SELECT ON S_TRANS_MASUK TO FOR_USER;
GRANT SELECT ON S_DETAIL_KELUAR TO FOR_USER;
GRANT SELECT ON S_TRANS_KELUAR TO FOR_USER;
GRANT SELECT ON S_RAK TO FOR_USER;
GRANT SELECT ON S_STOK_OPNAME TO FOR_USER;




COMMIT;

