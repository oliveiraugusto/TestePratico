CREATE DATABASE testpratico;

CREATE TABLE parametros
(
	id INTEGER NOT NULL PRIMARY KEY IDENTITY(1,1),
	distanciatotal FLOAT NOT NULL,
	distanciapilares FLOAT NOT NULL,
	basereforcada FLOAT NOT NULL
);

CREATE TABLE calculosrealizados
(
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	data DATE NOT NULL,
	distanciatotal FLOAT NOT NULL,
	distanciapilares FLOAT NOT NULL,
	basereforcada FLOAT NOT NULL,
	resultadopilares INTEGER NOT NULL,
	resultadopilaresreforcados INTEGER NOT NULL
);
