-- Database: "ConsultorioMedicoChuao"

-- DROP DATABASE "ConsultorioMedicoChuao";

CREATE DATABASE "ConsultorioMedicoChuao"
  WITH OWNER = postgres
       ENCODING = 'LATIN1'
       TABLESPACE = pg_default
       LC_COLLATE = 'English_United States.1252'
       LC_CTYPE = 'English_United States.1252'
       CONNECTION LIMIT = -1;
	   
---------------------------------------------------------------------------------secuencias--------------------------------------------------------------------------------------------	   
CREATE SEQUENCE id_listaespera
  INCREMENT 1
  MINVALUE 1
  MAXVALUE 9223372036854775807
  START 45
  CACHE 1;
ALTER TABLE id_listaespera
  OWNER TO postgres;
  
CREATE SEQUENCE id_mensajes
  INCREMENT 1
  MINVALUE 1
  MAXVALUE 9223372036854775807
  START 46
  CACHE 1;
ALTER TABLE id_mensajes
  OWNER TO postgres;


CREATE SEQUENCE id_producto
  INCREMENT 1
  MINVALUE 1
  MAXVALUE 9223372036854775807
  START 16
  CACHE 1;
ALTER TABLE id_producto
  OWNER TO postgres;

CREATE SEQUENCE id_terapeuta
  INCREMENT 1
  MINVALUE 1
  MAXVALUE 9223372036854775807
  START 2
  CACHE 1;
ALTER TABLE id_terapeuta
  OWNER TO postgres;

---------------------------------------------------------------------------------secuencias--------------------------------------------------------------------------------------------	   

---------------------------------------------------------------------------------tablas--------------------------------------------------------------------------------------------	   

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
  id integer NOT NULL DEFAULT nextval('id_producto'::regclass),
  nombre text NOT NULL,
  cantidad integer NOT NULL,
  CONSTRAINT "Inve_id" PRIMARY KEY (id)
)
WITH (
  OIDS=FALSE
);
ALTER TABLE "Inventario"
  OWNER TO postgres;

CREATE TABLE "ListaEspera"
(
  id integer NOT NULL DEFAULT nextval('id_listaespera'::regclass),
  fk_terapeuta integer NOT NULL,
  "nombreApellidoPaciente" text,
  "nombreApellidoRepresentante" text,
  "referidoPor" text,
  "detallesReferencia" text,
  "numeroTelefono" text,
  "numeroOpcional" text,
  CONSTRAINT "List_id" PRIMARY KEY (id),
  CONSTRAINT "ListaEspera_fk_terapeuta_fkey" FOREIGN KEY (fk_terapeuta)
      REFERENCES "Terapeuta" (id) MATCH SIMPLE
      ON UPDATE NO ACTION ON DELETE NO ACTION
)
WITH (
  OIDS=FALSE
);
ALTER TABLE "ListaEspera"
  OWNER TO postgres;

CREATE TABLE "Mensaje"
(
  id integer NOT NULL DEFAULT nextval('id_mensajes'::regclass),
  titulo text NOT NULL,
  detalles text NOT NULL,
  fk_terapeuta integer NOT NULL,
  "fechaCreacion" timestamp with time zone NOT NULL,
  dia integer NOT NULL,
  CONSTRAINT "Mens_id" PRIMARY KEY (id),
  CONSTRAINT fk_mensaje_terapeuta FOREIGN KEY (fk_terapeuta)
      REFERENCES "Terapeuta" (id) MATCH SIMPLE
      ON UPDATE NO ACTION ON DELETE NO ACTION
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

REATE TABLE "Servicio"
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
  id integer NOT NULL DEFAULT nextval('id_terapeuta'::regclass),
  nombre text NOT NULL,
  apellido text NOT NULL,
  cargo text NOT NULL,
  CONSTRAINT "Tera_id" PRIMARY KEY (id)
)
WITH (
  OIDS=FALSE
);
ALTER TABLE "Terapeuta"
  OWNER TO postgres;
  
---------------------------------------------------------------------------------tablas--------------------------------------------------------------------------------------------	

----------------------------------------------------------------------------insert iniciales----------------------------------------------------------------------------------------


INSERT INTO "Terapeuta"(
            nombre, apellido, cargo)
    VALUES ('Maria Isabel', 'Sagasti', 'Terapeuta de lenguaje');

INSERT INTO "Terapeuta"(
            nombre, apellido, cargo)
    VALUES ('Liza', 'Barrios', 'Fisioterapeuta');
	
-----------------------------------------------------------------------------insert iniciales---------------------------------------------------------------------------------------	
   