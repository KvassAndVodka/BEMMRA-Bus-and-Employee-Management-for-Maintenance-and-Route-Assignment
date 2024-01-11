CREATE TABLE EMPLOYEE (
	EmployeeID SERIAL NOT NULL,
	FirstName VARCHAR(50) NOT NULL,
	LastName VARCHAR(50) NOT NULL,
	Gender VARCHAR(6) NOT NULL,
	Birthdate DATE NOT NULL,
	EmployeeAddress VARCHAR(100) NOT NULL,
	EmployeeRole VARCHAR(25) NOT NULL,
	EmploymentDate DATE NOT NULL,
CONSTRAINT Employee_PK PRIMARY KEY (EmployeeID)
);


CREATE TABLE BUS (
	BusID INT NOT NULL,
	BusModel VARCHAR(25) NOT NULL,
	DateInFleet DATE NOT NULL,
	BusStatus VARCHAR(15) NOT NULL,
CONSTRAINT Bus_PK PRIMARY KEY (BusID)
);


CREATE TABLE MAINTENANCE (
	MaintenanceID SERIAL NOT NULL,
	BusID INT,
	MaintenanceDate DATE NOT NULL,
	MaintenanceStatus VARCHAR(25) NOT NULL,
	MaintenanceRemarks VARCHAR(100),
CONSTRAINT Maintenance_PK PRIMARY KEY (MaintenanceID),
CONSTRAINT Maintenance_FK FOREIGN KEY (BusID) REFERENCES BUS (BusID) ON DELETE SET NULL
);


CREATE TABLE ROUTE (
	RouteID SERIAL NOT NULL,
	RouteName VARCHAR(30) NOT NULL,
	BusID INT,
	AssignedDriver INT,
	AssignedConductor INT,
	RouteSchedule TIMESTAMP NOT NULL,
	RouteStatus VARCHAR(10) NOT NULL,
CONSTRAINT ROUTE_PK PRIMARY KEY (RouteID),
CONSTRAINT BusForRoute_FK FOREIGN KEY (BusID) REFERENCES BUS (BusID) ON DELETE CASCADE,
CONSTRAINT BusDriverForRoute_FK FOREIGN KEY (AssignedDriver) REFERENCES EMPLOYEE (EmployeeID) ON DELETE SET NULL,
CONSTRAINT BusConductorForRoute_FK FOREIGN KEY (AssignedConductor) REFERENCES EMPLOYEE (EmployeeID) ON DELETE SET NULL
);

CREATE TABLE USERS (
	UserID SERIAL NOT NULL,
	UserName VARCHAR(100) NOT NULL,
	Password VARCHAR(100) NOT NULL,
	UserRole VARCHAR(30) NOT NULL,
CONSTRAINT USER_PK PRIMARY KEY (UserID)
);

--Execute aboce queries first


INSERT INTO EMPLOYEE (EmployeeID, FirstName, LastName, Gender, Birthdate, EmployeeAddress, EmployeeRole, EmploymentDate)
VALUES
(1001, 'Juan', 'Santos', 'Male', '1990-01-15', '123 Mango Street, Barangay Kauswagan, Cagayan de Oro City', 'Driver', '2015-05-10'),
(1002, 'Pedro', 'Garcia', 'Male', '1988-03-22', '456 Acacia Avenue, Barangay Carmen, Cagayan de Oro City', 'Conductor', '2017-08-22'),
(1003, 'Miguel', 'Reyes', 'Male', '1987-06-17', '789 Laurel Lane, Barangay Macasandig, Cagayan de Oro City', 'Driver', '2018-06-17'),
(1004, 'Angelito', 'Torres', 'Male', '1989-09-30', '101 Pine Street, Barangay Bulua, Cagayan de Oro City', 'Conductor', '2016-03-30'),
(1005, 'Ramon', 'Lopez', 'Male', '1992-11-05', '202 Orchid Road, Barangay Patag, Cagayan de Oro City', 'Driver', '2019-11-05'),
(1006, 'Rafael', 'Hernandez', 'Male', '1991-04-18', '303 Sunflower Street, Barangay Carmen, Cagayan de Oro City', 'Driver', '2017-04-18'),
(1007, 'Luis', 'Dela Cruz', 'Male', '1994-11-30', '404 Lily Lane, Barangay Bulua, Cagayan de Oro City', 'Conductor', '2018-11-30'),
(1008, 'Diego', 'Cruz', 'Male', '1995-06-25', '505 Rose Avenue, Barangay Kauswagan, Cagayan de Oro City', 'Driver', '2019-06-25'),
(1009, 'Jose', 'Gomez', 'Male', '1992-08-12', '606 Tulip Road, Barangay Macasandig, Cagayan de Oro City', 'Conductor', '2016-08-12'),
(1010, 'Gabriel', 'Morales', 'Male', '1997-09-02', '707 Jasmine Street, Barangay Patag, Cagayan de Oro City', 'Driver', '2020-09-02'),
(1011, 'Manuel', 'Perez', 'Male', '1995-02-14', '808 Daisy Lane, Barangay Carmen, Cagayan de Oro City', 'Driver', '2018-02-14'),
(1012, 'Javier', 'Rodriguez', 'Male', '1996-10-20', '909 Marigold Avenue, Barangay Kauswagan, Cagayan de Oro City', 'Conductor', '2019-10-20'),
(1013, 'Emilio', 'Sanchez', 'Male', '1998-05-08', '1010 Sunflower Street, Barangay Macasandig, Cagayan de Oro City', 'Driver', '2020-05-08'),
(1014, 'Fernando', 'Gutierrez', 'Male', '1993-07-02', '1111 Orchid Road, Barangay Carmen, Cagayan de Oro City', 'Conductor', '2017-07-02'),
(1015, 'Raul', 'Romero', 'Male', '1994-09-15', '1212 Lily Lane, Barangay Patag, Cagayan de Oro City', 'Driver', '2016-09-15');




-- Populating BUS table (continued)
INSERT INTO BUS (BusID, BusModel, DateInFleet, BusStatus)
VALUES
(2101, 'Yutong ZK6127HA', '2022-01-15', 'Operational'), -- Valencia - Kibawe
(2102, 'FB4J', '2022-02-20', 'Operational'), -- Valencia - Kadingilan
(2103, 'FB4J', '2022-03-10', 'Operational'), -- Valencia - Wao
(2104, 'FB4J', '2022-04-05', 'Operational'), -- Malaybalay - Kibawe
(2105, 'FB4J', '2022-05-12', 'Operational'), -- Malaybalay - Kalilangan
(2201, 'King Long XMQ6128AYW', '2022-06-18', 'Operational'), -- Cagayan de Oro - Gingoog
(2202, 'King Long XMQ6128AYWO', '2022-07-23', 'Operational'), -- Cagayan de Oro - Kibawe
(2301, 'Yutong ZK6127HA', '2022-08-30', 'Operational'), -- Cagayan de Oro - Damulog
(2302, 'Yutong ZK6858H9', '2022-09-14', 'Operational'), -- Cagayan de Oro - Tacurong
(2401, 'FB4J', '2022-10-02', 'Operational'), -- Cagayan de Oro - Kadingilan
(2402, 'FB4J', '2022-11-19', 'Operational'), -- Cagayan de Oro - Davao
(2501, 'FB4J', '2022-12-25', 'Operational'), -- Cagayan de Oro - Davao
(2502, 'King Long XMQ6129Y5', '2023-01-10', 'Operational'), -- Cagayan de Oro - Maramag
(2601, 'Viking 11', '2023-02-14', 'In Garage'), -- Cagayan de Oro - Maramag
(2602, 'Yutong ZK6119HYG', '2023-03-20', 'In Garage'), -- Cagayan de Oro - Kibawe
(2701, 'Viking 11', '2023-04-25', 'In Garage'), -- Cagayan de Oro - Tacurong
(2702, 'Yutong ZK6119HYG', '2023-05-30', 'In Garage'), -- Cagayan de Oro - General Santos
(2801, 'Viking 11', '2023-06-05', 'Maintenance'), -- Cagayan de Oro - Damulog
(2802, 'Yutong ZK6119HYG', '2023-07-12', 'Maintenance'), -- Cagayan de Oro - Davao
(2901, 'Yutong ZK6858H9', '2023-08-18', 'Maintenance'), -- Cagayan de Oro - General Santos
(2902, 'FB4J', '2023-09-22', 'Maintenance'); -- Cagayan de Oro - Davao


-- Updated MAINTENANCE table with revised BusIDs
INSERT INTO MAINTENANCE (MaintenanceID, BusID, MaintenanceDate, MaintenanceStatus, MaintenanceRemarks)
VALUES
(1, 2601, '2022-10-15', 'Scheduled', 'Routine maintenance'),
(2, 2602, '2022-09-20', 'Scheduled', 'Oil change'),
(3, 2701, '2023-01-05', 'Scheduled', 'Brake inspection'),
(4, 2702, '2023-02-12', 'Scheduled', 'Tire replacement'),
(5, 2801, '2022-12-05', 'Scheduled', 'Routine checkup'),
(6, 2802, '2023-02-20', 'Scheduled', 'Brake inspection'),
(7, 2901, '2023-03-15', 'Scheduled', 'Oil change'),
(8, 2902, '2023-04-10', 'Scheduled', 'Tire replacement'),
(9, 2401, '2022-11-30', 'Scheduled', 'Routine maintenance'),
(10, 2402, '2023-02-25', 'Scheduled', 'Oil change'),
(11, 2501, '2023-03-20', 'Scheduled', 'Tire inspection'),
(12, 2502, '2023-04-15', 'Scheduled', 'Brake repair');
-- ... (add more maintenance records as needed)

-- Populating ROUTE table with RouteSchedule including time
INSERT INTO ROUTE (RouteID, RouteName, BusID, AssignedDriver, AssignedConductor, RouteSchedule, RouteStatus)
VALUES
(101, 'Valencia - Kibawe', 2101, 1001, 1002, '2023-01-01 08:00:00', 'Active'),
(102, 'Valencia - Kadingilan', 2102, 1003, 1004, '2023-01-02 09:30:00', 'Active'),
(103, 'Valencia - Wao', 2103, 1005, 1001, '2023-01-03 11:45:00', 'Active'),
(104, 'Malaybalay - Kibawe', 2104, 1002, 1003, '2023-01-04 13:15:00', 'Active'),
(105, 'Cagayan de Oro - Gingoog', 2201, 1006, 1007, '2023-01-05 15:00:00', 'Active'),
(106, 'Cagayan de Oro - Kibawe', 2202, 1008, 1009, '2023-01-06 16:20:00', 'Active'),
(107, 'Cagayan de Oro - Damulog', 2301, 1010, 1006, '2023-01-07 18:00:00', 'Active'),
(108, 'Cagayan de Oro - Tacurong', 2302, 1007, 1008, '2023-01-08 19:45:00', 'Active'),
(109, 'Cagayan de Oro - Kadingilan', 2401, 1011, 1012, '2023-01-09 21:10:00', 'Active'),
(110, 'Cagayan de Oro - Davao', 2402, 1013, 1014, '2023-01-10 22:30:00', 'Active'),
(111, 'Cagayan de Oro - Davao', 2501, 1015, 1011, '2023-01-11 23:45:00', 'Active'),
(112, 'Cagayan de Oro - Maramag', 2502, 1012, 1013, '2023-01-12 06:00:00', 'Active');


--execute above---------------------------------


SELECT SETVAL('maintenance_maintenanceid_seq', 13);
SELECT SETVAL('employee_employeeid_seq', 1016);
SELECT SETVAL('route_routeid_seq', 113);




