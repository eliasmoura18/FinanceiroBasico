/** Antes de executar os SQLs abaixo, � necess�rio primeiramente criar a database FinanceiroBasico.
a implementa��o foi feita em SQLServer. Os comandos j� est�o na sequencia correta para execu��o. **/

/** DDL **/

USE FinanceiroBasico
CREATE TABLE CONTA (
	id int IDENTITY(1,1) PRIMARY KEY,
    nome varchar(100) not null,
	valorOriginal decimal(6,2) not null,
	valorCorrigido decimal(6,2) not null,
	dataVencimento DateTime not null,
	dataPagamento DateTime not null,
	qtdeDiasAtraso integer not null
)



/** DML **/


USE FinanceiroBasico
INSERT INTO CONTA (nome, valorOriginal, valorCorrigido, dataVencimento, dataPagamento, qtdeDiasAtraso) VALUES
('Pagou antes de vencer', 100, 100, '20210103 11:59:59 PM', '20210103 02:30:09 PM', 0),
('Vencido 1 dia facil', 100, 102.1, '20210103 11:59:59 PM', '20210104 01:00:00 PM', 1),
('Vencido 4 dias facil', 100, 103.8, '20210103 11:59:59 PM', '20210107 02:17:00 PM', 4),
('Vencido 10 dias facil', 100, 108, '20210103 11:59:59 PM', '20210113 09:08:19 AM', 10),
('Vencido 2 dias quebrado', 234.55, 239.7101, '20210103 11:59:59 PM', '20210105 11:00:55 AM', 2),
('Vencido 5 dias quebrado', 57.99, 60.3096, '20210103 11:59:59 PM', '20210108 04:27:52 PM', 5),
('Vencido 20 dias quebrado', 500.87, 555.9657, '20210103 11:59:59 PM', '20210123 03:13:42 PM', 20)







