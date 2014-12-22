BD SC Postgresql

--------------------------------------------------------------------------------TABLAS-------------------------------------------------------------------------------------------------

CREATE TABLE "Facturacion"
(
  id numeric NOT NULL,
  CONSTRAINT "Fact_id" PRIMARY KEY (id)
)
WITH (
  OIDS=FALSE
);
ALTER TABLE "Facturacion"
  OWNER TO postgres;

  
CREATE TABLE "Horario"
(
  id numeric NOT NULL,
  CONSTRAINT "Hora_id" PRIMARY KEY (id)
)
WITH (
  OIDS=FALSE
);
ALTER TABLE "Horario"
  OWNER TO postgres;

  
CREATE TABLE "Inscripcion"
(
  id numeric NOT NULL,
  CONSTRAINT "Insc_id" PRIMARY KEY (id)
)
WITH (
  OIDS=FALSE
);
ALTER TABLE "Inscripcion"
  OWNER TO postgres;

  
CREATE TABLE "Inventario"
(
  id numeric NOT NULL,
  CONSTRAINT "Inve_id" PRIMARY KEY (id)
)
WITH (
  OIDS=FALSE
);
ALTER TABLE "Inventario"
  OWNER TO postgres;

  
CREATE TABLE "ListaEspera"
(
  id numeric NOT NULL,
  CONSTRAINT "List_id" PRIMARY KEY (id)
)
WITH (
  OIDS=FALSE
);
ALTER TABLE "ListaEspera"
  OWNER TO postgres;

  
CREATE TABLE "Mensaje"
(
  id numeric NOT NULL,
  CONSTRAINT "Mens_id" PRIMARY KEY (id)
)
WITH (
  OIDS=FALSE
);
ALTER TABLE "Mensaje"
  OWNER TO postgres;

  
CREATE TABLE "Paciente"
(
  id numeric NOT NULL,
  CONSTRAINT "Paci_id" PRIMARY KEY (id)
)
WITH (
  OIDS=FALSE
);
ALTER TABLE "Paciente"
  OWNER TO postgres;

  
CREATE TABLE "Producto"
(
  id numeric NOT NULL,
  CONSTRAINT "Prod_id" PRIMARY KEY (id)
)
WITH (
  OIDS=FALSE
);
ALTER TABLE "Producto"
  OWNER TO postgres;

  
CREATE TABLE "Representante"
(
  id numeric NOT NULL,
  CONSTRAINT "Repr_id" PRIMARY KEY (id)
)
WITH (
  OIDS=FALSE
);
ALTER TABLE "Representante"
  OWNER TO postgres;

  
CREATE TABLE "Servicio"
(
  id numeric NOT NULL,
  CONSTRAINT "Serv_id" PRIMARY KEY (id)
)
WITH (
  OIDS=FALSE
);
ALTER TABLE "Servicio"
  OWNER TO postgres;


CREATE TABLE "Terapeuta"
(
  id numeric NOT NULL,
  nombre text,
  apellido text,
  cargo text,
  CONSTRAINT "Tera_id" PRIMARY KEY (id)
)
WITH (
  OIDS=FALSE
);
ALTER TABLE "Terapeuta"
  OWNER TO postgres;

  
----------------------------------------------------------------------------FIN TABLAS-------------------------------------------------------------------------------------------------

----------------------------------------------------------------------------INSERT INICIALES-------------------------------------------------------------------------------------------


INSERT INTO "Terapeuta"(
            nombre, apellido, cargo)
    VALUES ('Maria Isabel', 'Sagasti', 'Terapeuta de lenguaje');

INSERT INTO "Terapeuta"(
            nombre, apellido, cargo)
    VALUES ('Liza', 'Barrios', 'Fisioterapeuta');
	
	
----------------------------------------------------------------------------FIN INSERT INICIALES---------------------------------------------------------------------------------------	

----------------------------------------------------------------------------SECUENCIAS-------------------------------------------------------------------------------------------------

CREATE SEQUENCE id_terapeuta
  INCREMENT 1
  MINVALUE 1
  MAXVALUE 9223372036854775807
  START 1
  CACHE 1;
ALTER TABLE id_terapeuta
  OWNER TO postgres;
  
----------------------------------------------------------------------------FIN SECUENCIAS---------------------------------------------------------------------------------------------

