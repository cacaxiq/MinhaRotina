/* lugares cadastrados pelo usuário: casa da minha mãe, ufmg, academia */
CREATE TABLE minharotina.lugar
(
   id KEY PRIMARY KEY(id),
   descricao TEXT,
   localizacao TEXT (coordenadas)
);

/* Rotina criada pelo usuário */
CREATE TABLE minharotina.objetivo_pessoal
(
	id KEY PRIMARY KEY(id),
	id_lugar INT,
	qtd_horas_minima_dia INT,
	qtd_horas_maxima_dia INT
);

/* mapeamento da localização do usuário: */
CREATE TABLE minharotina.rotina_pessoal
(
	id KEY PRIMARY KEY(id),
	datahora TEXT,
	localizacao TEXT
);
