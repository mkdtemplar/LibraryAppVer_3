PRAGMA foreign_keys=OFF;
BEGIN TRANSACTION;
CREATE TABLE book (
    BookName         VARCHAR,
    Author           VARCHAR,
    YearOfPublishing INTEGER,
    id               INTEGER PRIMARY KEY AUTOINCREMENT
                             NOT NULL
);
INSERT INTO book VALUES('Art Of War','Sun Tzu',1521,1);
CREATE TABLE Client (
    NameOfClient VARCHAR,
    Age          INTEGER,
    LibraryID    INTEGER,
    id           INTEGER PRIMARY KEY AUTOINCREMENT
                         NOT NULL,
    RentedBook   VARCHAR,
    Photo        BLOB
);
INSERT INTO Client VALUES('Ivan',46,1,1,'Art Of War',NULL);
INSERT INTO Client VALUES('Nikolaj',17,3,3,'C++',NULL);
INSERT INTO Client VALUES('Jas',46,7,5,'Web API',NULL);
INSERT INTO Client VALUES('Jasna',46,8,6,'Gotvac',NULL);
INSERT INTO Client VALUES(NULL,NULL,NULL,7,NULL,NULL);
INSERT INTO Client VALUES(NULL,NULL,NULL,8,NULL,NULL);
DELETE FROM sqlite_sequence;
INSERT INTO sqlite_sequence VALUES('book',1);
INSERT INTO sqlite_sequence VALUES('Client',8);
COMMIT;
