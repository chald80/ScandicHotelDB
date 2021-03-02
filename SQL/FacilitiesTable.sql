CREATE TABLE Facilities( Facilities_No int NOT NULL, Hotel_No int NOT NULL, Types CHAR(1) DEFAULT 'S', Price FLOAT, CONSTRAINT facilitiesType CHECK (Types IN ('Spa','RoomService','Massage') OR Types IS NULL), CONSTRAINT facilitiesPrice CHECK (price BETWEEN 0 AND 9999), FOREIGN KEY (Hotel_No) REFERENCES Hotel (Hotel_No) ON UPDATE CASCADE ON DELETE NO ACTION, Primary KEY (Facilities_No, Hotel_No) );