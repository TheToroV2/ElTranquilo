CREATE DATABASE ElTranquiloDB;
USE ElTranquiloDB;

CREATE TABLE Proveedores (
    ProveedorID INT PRIMARY KEY IDENTITY(1,1),
    Nombre VARCHAR(50) NOT NULL,
    Direccion VARCHAR(100),
    Telefono VARCHAR(20),
    Email VARCHAR(100)
);
GO

CREATE TABLE Productos (
    ProductoID INT IDENTITY(1,1),
    Nombre VARCHAR(50) NOT NULL UNIQUE,
    Precio MONEY,
    Stock INT,
    ProveedorID INT,
    FOREIGN KEY (ProveedorID) REFERENCES Proveedores(ProveedorID),
	PRIMARY KEY (ProductoID,Nombre)
);
GO

CREATE TABLE Usuarios (
    UsuarioID INT PRIMARY KEY IDENTITY(1,1),
    Username VARCHAR(50) NOT NULL UNIQUE,
    Passwordh VARCHAR(50) NOT NULL,
    Rol VARCHAR(50) NOT NULL,
    FechaCreacion DATETIME DEFAULT GETDATE()
);
GO

ALTER TABLE Productos
ADD CONSTRAINT UQ_Productos UNIQUE (ProductoID, Nombre);

INSERT INTO Proveedores (Nombre, Direccion, Telefono, Email) VALUES 
('Sony', '1 Microsoft Way, Redmond, WA 98052', '123456789', 'email1@proveedor.com'),
('Postobon', '15720 NE 39th St, Redmond, WA 98052', '987654321', 'email2@proveedor.com'),
('Mondelez','Caldas','987643793','emailmondelez@proveedor.com');
GO

INSERT INTO Usuarios (Username, PasswordH, Rol) VALUES 
('Robert', 'sapoperro10', 'Administrador')
('Juan', 'ostiatio', 'Gerente'),
('Wilson', 'gokugod', 'Empleado');
GO

USE ElTranquiloDB;
SELECT * FROM Proveedores;
SELECT * FROM Productos;
SELECT * FROM Usuarios;
