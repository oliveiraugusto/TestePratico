CREATE TABLE calculosrealizados
(
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	data VARCHAR(100) NOT NULL,
	distanciatotal VARCHAR(10) NOT NULL,
	distanciapilares VARCHAR(10) NOT NULL,
	basereforcada VARCHAR(10) NOT NULL,
	resultadopilares VARCHAR(10) NOT NULL,
	resultadopilaresreforcados VARCHAR(10) NOT NULL
);

INSERT INTO calculosrealizados (data, distanciatotal, distanciapilares, basereforcada, resultadopilares, resultadopilaresreforcados) VALUES ('0',0,0,0,0,0);

SELECT TOP 1 * FROM calculosrealizados ORDER BY id DESC;