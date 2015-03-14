REATE TABLE "Horario"
(
  id numeric NOT NULL DEFAULT nextval('id_horario'::regclass),
  fechacita timestamp without time zone NOT NULL,
  fk_pac_tera numeric NOT NULL,
  CONSTRAINT "Hora_id" PRIMARY KEY (id),
  CONSTRAINT "Horario_fk_pac_tera_fkey" FOREIGN KEY (fk_pac_tera)
      REFERENCES "Paciente_Terapeuta" (id) MATCH SIMPLE
      ON UPDATE NO ACTION ON DELETE NO ACTION
)
WITH (
  OIDS=FALSE
);
ALTER TABLE "Horario"
  OWNER TO postgres;
  
  
  
  CREATE TABLE "Paciente"
(
  id integer NOT NULL DEFAULT nextval('id_paciente'::regclass),
  nombre text NOT NULL,
  apellido text NOT NULL,
  sexo text NOT NULL,
  "fechaNacimiento" date NOT NULL,
  CONSTRAINT "Paci_id" PRIMARY KEY (id)
)
WITH (
  OIDS=FALSE
);
ALTER TABLE "Paciente"
  OWNER TO postgres;

  
  CREATE TABLE "Paciente_Terapeuta"
(
  id numeric NOT NULL DEFAULT nextval('id_pac_ter'::regclass),
  fk_paciente integer,
  fk_terapeuta integer,
  CONSTRAINT "Paciente_Terapeuta_pkey" PRIMARY KEY (id),
  CONSTRAINT "Paciente_Terapeuta_fk_paciente_fkey" FOREIGN KEY (fk_paciente)
      REFERENCES "Paciente" (id) MATCH SIMPLE
      ON UPDATE NO ACTION ON DELETE NO ACTION,
  CONSTRAINT "Paciente_Terapeuta_fk_terapeuta_fkey" FOREIGN KEY (fk_terapeuta)
      REFERENCES "Terapeuta" (id) MATCH SIMPLE
      ON UPDATE NO ACTION ON DELETE NO ACTION
)
WITH (
  OIDS=FALSE
);
ALTER TABLE "Paciente_Terapeuta"
  OWNER TO postgres;

-- Index: fk_pac_ter

-- DROP INDEX fk_pac_ter;

CREATE INDEX fk_pac_ter
  ON "Paciente_Terapeuta"
  USING btree
  (fk_paciente);

-- Index: fk_ter_pac

-- DROP INDEX fk_ter_pac;

CREATE INDEX fk_ter_pac
  ON "Paciente_Terapeuta"
  USING btree
  (fk_terapeuta);


  
  
  
  CREATE TABLE "Representante"
(
  id numeric NOT NULL,
  nombre text,
  apellido text,
  fk_hijo integer,
  "numeroTlfPrincipal" numeric,
  "numeroTlfSecundario" numeric,
  correo text,
  cedula text,
  tipo text,
  CONSTRAINT "Repr_id" PRIMARY KEY (id),
  CONSTRAINT "Representante_fk_hijo_fkey" FOREIGN KEY (fk_hijo)
      REFERENCES "Paciente" (id) MATCH SIMPLE
      ON UPDATE NO ACTION ON DELETE NO ACTION
)
WITH (
  OIDS=FALSE
);
ALTER TABLE "Representante"
  OWNER TO postgres;

-- Index: fk_paciente

-- DROP INDEX fk_paciente;

CREATE INDEX fk_paciente
  ON "Representante"
  USING btree
  (fk_hijo);
