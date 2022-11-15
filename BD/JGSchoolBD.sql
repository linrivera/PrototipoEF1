CREATE DATABASE JGSchool;
USE JGSchool;

CREATE TABLE Profesor(
id int NOT NULL AUTO_INCREMENT primary key,
nombre varchar(255),
dni int,
fechaNac DateTime,
telefono int,
correo varchar(255)
);

CREATE TABLE Curso(
id int NOT NULL AUTO_INCREMENT primary key,
nombre varchar(255)
);
CREATE TABLE Estudiante(
id int NOT NULL AUTO_INCREMENT primary key,
nombre varchar(255),
dni int,
fechaNac DateTime,
telefono int,
correo varchar(255),
nivel varchar(80),
grado int
);

CREATE TABLE Evaluacion(
id int NOT NULL AUTO_INCREMENT primary key,
descripcion varchar(255)
);

CREATE TABLE Registro(
id int NOT NULL AUTO_INCREMENT primary key,
idProfesor int,
idCurso int,
fechaInicio DateTime,
fechaTermino DateTime
);

CREATE TABLE Notas(
id int NOT NULL AUTO_INCREMENT primary key,
idEstudiante int,
idEvaluacion int,
idRegistro int,
nota float
);

ALTER TABLE Registro
ADD FOREIGN KEY (idProfesor) REFERENCES Profesor(id);


ALTER TABLE Registro
ADD FOREIGN KEY (idCurso) REFERENCES Curso(id);

ALTER TABLE Notas
ADD FOREIGN KEY (idEstudiante) REFERENCES Estudiante(id);


ALTER TABLE Notas
ADD FOREIGN KEY (idEvaluacion) REFERENCES Evaluacion(id);

ALTER TABLE Notas
ADD FOREIGN KEY (idRegistro) REFERENCES Registro(id);