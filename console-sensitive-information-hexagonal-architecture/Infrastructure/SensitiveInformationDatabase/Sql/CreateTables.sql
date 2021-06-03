--Create Tables

-- Users
CREATE TABLE users (
    id int IDENTITY(1,1),
    uuid UNIQUEIDENTIFIER DEFAULT NEWID(),
    username text,
    password text,
    PRIMARY KEY (id)
);

-- Sensitive Information
CREATE TABLE sensitive_information (
    id int IDENTITY(1,1),
    uuid UNIQUEIDENTIFIER DEFAULT NEWID(),
    type TEXT,
    information_name TEXT,
    container_name TEXT,
    notes TEXT,
    username TEXT,
    password TEXT,
    urls_list TEXT,
    card_name TEXT,
    card_entity TEXT,
    card_number TEXT,
    card_expiration_date DATE,
    card_security_number INT,
    contact_name TEXT,
    contact_lastname TEXT,
    business_name TEXT,
    emails_list TEXT,
    phone_numbers_list TEXT,
    addresses_list TEXT,
    postal_code INT,
    country TEXT,
    state TEXT,
    birthday DATE,
    tags_list TEXT,    
    favorite BIT,
    content_key TEXT,
    PRIMARY KEY (id)
);
