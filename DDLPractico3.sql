CREATE DATABASE practico3;

USE practico3

CREATE TABLE persona(
    id  INT NOT NULL AUTO_INCREMENT,
    nombre VARCHAR(20) NOT NULL,
    apellido VARCHAR(20) NOT NULL,
    mail VARCHAR(50) UNIQUE,
    fecha_hora_creacion TIMESTAMP NOT NULL,
    activo BOOLEAN NOT NULL,
    PRIMARY KEY(id)
);

CREATE TABLE persona_tel(
    id_persona INT NOT NULL,
    telefono INT NOT NULL,
    PRIMARY KEY(id_persona, telefono),
    CONSTRAINT id_persona_p_fk FOREIGN KEY id_persona REFERENCES persona(id)
);

CREATE TABLE servicio(
    id INT NOT NULL AUTO_INCREMENT,
    nombre VARCHAR(20) NOT NULL,
    costo_mensual INT NOT NULL,
    tipo VARCHAR(50) NOT NULL,
    fecha_hora_creacion TIMESTAMP NOT NULL,
    activo BOOLEAN NOT NULL,
    PRIMARY KEY(id)
);

CREATE TABLE contrata(
    id_persona INT NOT NULL,
    id_servicio INT NOT NULL,
    fecha_creacion DATE NOT NULL,
    fecha_contratacion DATE NOT NULL,
    fecha_fin_contrato DATE NOT NULL,
    PRIMARY KEY(id_persona, id_servicio, fecha_creacion),
    CONSTRAINT id_persona_c_fk FOREIGN KEY id_persona REFERENCES persona(id),
    CONSTRAINT id_servicio_c_fk FOREIGN KEY id_servicio REFERENCES servicio(id)
);
