/** Antes de executar os SQLs abaixo, é necessário primeiramente criar a database FinanceiroBasico.
a implementação foi feita em SQLServer. Os comandos já estão na sequencia correta para execução. **/

/** DDL **/

USE FinanceiroBasico
CREATE TABLE CONTA (
	id int IDENTITY(1,1) PRIMARY KEY,
    nome varchar(100) not null,
	valorOriginal decimal(6,2) not null,
	dataVencimento DateTime not null,
	dataPagamento DateTime not null,
)


/** DML **/

USE FinanceiroBasico
INSERT INTO CONTA (nome, valorOriginal, dataVencimento, dataPagamento) VALUES ('Pagou antes de vencer', 100, '20210103 11:59:59 PM', '20210103 02:30:09 PM')
INSERT INTO CONTA (nome, valorOriginal, dataVencimento, dataPagamento) VALUES ('Vencido 1 dia facil', 100, '20210103 11:59:59 PM', '20210104 01:00:00 PM')
INSERT INTO CONTA (nome, valorOriginal, dataVencimento, dataPagamento) VALUES ('Vencido 4 dias facil', 100, '20210103 11:59:59 PM', '20210107 02:17:00 PM')
INSERT INTO CONTA (nome, valorOriginal, dataVencimento, dataPagamento) VALUES ('Vencido 10 dias facil', 100, '20210103 11:59:59 PM', '20210113 09:08:19 AM')
INSERT INTO CONTA (nome, valorOriginal, dataVencimento, dataPagamento) VALUES ('Vencido 2 dias quebrado', 234.55, '20210103 11:59:59 PM', '20210105 11:00:55 AM')
INSERT INTO CONTA (nome, valorOriginal, dataVencimento, dataPagamento) VALUES ('Vencido 5 dias quebrado', 57.99, '20210103 11:59:59 PM', '20210108 04:27:52 PM')
INSERT INTO CONTA (nome, valorOriginal, dataVencimento, dataPagamento) VALUES ('Vencido 20 dias quebrado', 500.87, '20210103 11:59:59 PM', '20210123 03:13:42 PM')





