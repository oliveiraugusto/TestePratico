CREATE DATABASE testpratico;

CREATE TABLE calculosrealizados
(
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	data NVARCHAR NOT NULL,
	distanciatotal FLOAT NOT NULL,
	distanciapilares FLOAT NOT NULL,
	basereforcada FLOAT NOT NULL,
	resultadopilares INTEGER NOT NULL,
	resultadopilaresreforcados INTEGER NOT NULL
);

INSERT INTO calculosrealizados (data, distanciatotal, distanciapilares, basereforcada, resultadopilares, resultadopilaresreforcados) VALUES ('0',0,0,0,0,0);