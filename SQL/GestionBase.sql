-- Active: 1717465461723@@bfwxwiljwh20ru2hgcyt-mysql.services.clever-cloud.com@3306
CREATE TABLE Proyecto (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Nombre VARCHAR(255) NOT NULL,
    FechaInicio DATE NOT NULL,
    FechaFin DATE,
    Estado ENUM('Activo', 'Inactivo')
);

-- Crear la tabla Departamento
CREATE TABLE Departamento (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Nombre VARCHAR(255) NOT NULL,
    Estado ENUM('Activo', 'Inactivo')
);

-- Crear la tabla Especialidad
CREATE TABLE Especialidad (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Nombre VARCHAR(255) NOT NULL,
    Estado ENUM('Activo', 'Inactivo')
);

-- Crear la tabla Empleado
CREATE TABLE Empleado (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Nombre VARCHAR(255) NOT NULL,
    Correo VARCHAR(255) UNIQUE,
    Estado ENUM('Activo', 'Inactivo'),
    DepartamentoId INT,
    EspecialidadId INT,
    FOREIGN KEY (DepartamentoId) REFERENCES Departamento(Id),
    FOREIGN KEY (EspecialidadId) REFERENCES Especialidad(Id)
);

-- Crear la tabla Tarea
CREATE TABLE Tarea (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Descripcion TEXT NOT NULL,
    FechaAsignacion DATE NOT NULL,
    Estado ENUM('Activo', 'Inactivo'),
    ProyectoId INT,
    EmpleadoId INT,
    FOREIGN KEY (ProyectoId) REFERENCES Proyecto(Id),
    FOREIGN KEY (EmpleadoId) REFERENCES Empleado(Id)
);

---------------------------------Borrar tablas
DROP TABLE Departamento;
DROP TABLE Tarea;
DROP TABLE Especialidad;
DROP TABLE Empleado;
DROP TABLE Proyecto;

----------------------------------Insertar datos


-- Insertar registros en la tabla Proyecto
INSERT INTO Proyectos (Nombre, FechaInicio, FechaFin)
VALUES ('Proyecto Alpha', '2024-01-01', '2024-06-01'),
       ('Proyecto Beta', '2024-02-01', NULL),
       ('Proyecto Gamma', '2024-03-01', '2024-08-01');

-- Insertar registros en la tabla Departamento
INSERT INTO Departamentos (Nombre, Estado)
VALUES ('Desarrollo', 'Activo'), ('Marketing', 'Activo'), ('Recursos Humanos', 'Activo');

-- Insertar registros en la tabla Especialidad
INSERT INTO Especialidades (Nombre, Estado)
VALUES ('Backend Developer', 'Activo'), ('Frontend Developer', 'Activo'), ('Data Analyst', 'Activo');

-- Insertar registros en la tabla Empleado
INSERT INTO Empleados (Nombre, DepartamentoId, EspecialidadId, Correo, Estado)
VALUES ('Alice', 1, 1, 'jaimito@gmail.com', 'Activo'),
       ('Bob', 1, 2, 'kristina@gmail.com', 'Activo'),
       ('Charlie', 2, 3, 'ana.martinez@mail.com', 'Activo'),
       ('David', 3, 3, 'zuramendozavillada@gmail', 'Activo');

-- Insertar registros en la tabla Tarea
INSERT INTO Tareas (ProyectoId, EmpleadoId, Descripcion, FechaAsignacion, Estado)
VALUES (1, 1, 'Desarrollar la API', '2024-01-15', 'Activo'),
       (1, 2, 'Diseñar la interfaz de usuario', '2024-02-01', 'Activo'),
       (2, 3, 'Analizar datos de marketing', '2024-02-15', 'Activo'),
       (3, 1, 'Integrar la API con el frontend', '2024-03-20', 'Activo'),
       (3, 2, 'Implementar la lógica de negocio', '2024-04-01', 'Activo');
    

-- Cambiar el nombre de la tabla Proyecto a Proyectos
RENAME TABLE Proyecto TO Proyectos;

-- Cambiar el nombre de varias tablas en una sola instrucción
RENAME TABLE 
    Proyecto TO Proyectos,
    Departamento TO Departamentos,
    Especialidad TO Especialidades,
    Empleado TO Empleados,
    Tarea TO Tareas;