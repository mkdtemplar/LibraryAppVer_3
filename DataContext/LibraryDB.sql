--
-- File generated with SQLiteStudio v3.3.3 on Thu Sep 30 16:59:26 2021
--
-- Text encoding used: System
--
PRAGMA foreign_keys = off;
BEGIN TRANSACTION;

-- Table: book
DROP TABLE IF EXISTS book;

CREATE TABLE book (
    BookName         VARCHAR,
    Author           VARCHAR,
    YearOfPublishing INTEGER,
    id               INTEGER PRIMARY KEY AUTOINCREMENT
                             NOT NULL
);


-- Table: Client
DROP TABLE IF EXISTS Client;

CREATE TABLE Client (
    NameOfClient VARCHAR,
    Age          INTEGER,
    LibraryID    INTEGER,
    id           INTEGER PRIMARY KEY AUTOINCREMENT
                         NOT NULL,
    RentedBook   VARCHAR,
    Photo        BLOB
);


COMMIT TRANSACTION;
PRAGMA foreign_keys = on;
