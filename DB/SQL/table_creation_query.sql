USE master
GO
IF NOT EXISTS (
    SELECT name
FROM sys.databases
WHERE name = N'Antique_shop_DB'
)
CREATE DATABASE Antique_shop_DB
GO

USE Antique_shop_DB
GO

IF OBJECT_ID('shop_users', 'U') IS NOT NULL
DROP TABLE shop_users
GO
IF OBJECT_ID('cashbox', 'U') IS NOT NULL
DROP TABLE cashbox
GO
IF OBJECT_ID('setout', 'U') IS NOT NULL
DROP TABLE setout
GO
IF OBJECT_ID('antiques', 'U') IS NOT NULL
DROP TABLE antiques
GO
IF OBJECT_ID('story_archive', 'U') IS NOT NULL
DROP TABLE story_archive
GO
IF OBJECT_ID('acquirers', 'U') IS NOT NULL
DROP TABLE acquirers
GO

CREATE TABLE shop_users
(
  shop_user_id       INT  NOT NULL IDENTITY,
  shop_user_login    VARCHAR(MAX) NOT NULL,
  shop_user_password VARCHAR(MAX) NOT NULL,
  CONSTRAINT PK_users PRIMARY KEY (shop_user_id)
)
GO
CREATE TABLE cashbox
(
  sale_id                 INT      NOT NULL IDENTITY,
  sale_date               DATETIME NOT NULL,
  sale_setout_position_id INT      NOT NULL,
  sale_acquirer_id        INT      NOT NULL,
  CONSTRAINT PK_cashbox PRIMARY KEY (sale_id)
)
GO
CREATE TABLE setout
(
  setout_position_id      INT NOT NULL IDENTITY,
  setout_position_price   INT NOT NULL,
  setout_antique_thing_id INT NOT NULL,
  CONSTRAINT PK_setout PRIMARY KEY (setout_position_id)
)
GO
CREATE TABLE antiques 
(
  antique_thing_id                 INT  NOT NULL IDENTITY,
  antique_thing_title              VARCHAR(MAX) NOT NULL,
  antique_thing_description        VARCHAR(MAX) NOT NULL DEFAULT '-',
  antique_thing_storage_conditions VARCHAR(MAX) NOT NULL DEFAULT '-',
  antique_thing_story_id           INT  NOT NULL,
  CONSTRAINT PK_antiques  PRIMARY KEY (antique_thing_id)
)
GO
CREATE TABLE story_archive
(
  story_id      INT  NOT NULL IDENTITY,
  story_title   VARCHAR(MAX) NOT NULL,
  story_content VARCHAR(MAX) NOT NULL,
  CONSTRAINT PK_story_archive PRIMARY KEY (story_id)
)
GO
CREATE TABLE acquirers
(
  acquirer_id         INT  NOT NULL IDENTITY,
  acquirer_first_name VARCHAR(MAX) NOT NULL,
  acquirer_last_name  VARCHAR(MAX) NOT NULL,
  CONSTRAINT PK_acquirers PRIMARY KEY (acquirer_id)
)
GO

ALTER TABLE antiques 
  ADD CONSTRAINT FK_story_archive_TO_antiques 
    FOREIGN KEY (antique_thing_story_id)
    REFERENCES story_archive (story_id)
GO
ALTER TABLE setout
  ADD CONSTRAINT FK_antiques_TO_setout
    FOREIGN KEY (setout_antique_thing_id)
    REFERENCES antiques  (antique_thing_id)
GO
ALTER TABLE cashbox
  ADD CONSTRAINT FK_setout_TO_cashbox
    FOREIGN KEY (sale_setout_position_id)
    REFERENCES setout (setout_position_id)
GO
ALTER TABLE cashbox
  ADD CONSTRAINT FK_acquirers_TO_cashbox
    FOREIGN KEY (sale_acquirer_id)
    REFERENCES acquirers (acquirer_id)
GO

INSERT INTO shop_users (shop_user_login,shop_user_password) VALUES ('SenjorAdmin','!2#qWeRtY1@3')
GO
