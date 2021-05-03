-- Commands to insert values to Table

-- Users
INSERT INTO users ( username, password ) VALUES ('miguel', 'secret');
INSERT INTO users ( username, password ) VALUES ('vegueta', 'vegano');
INSERT INTO users ( username, password ) VALUES ('jirafales', 'prof');

-- Sensitive Information
-- Insert Values
INSERT INTO sensitive_information ( type, information_name, container_name,notes,username,password,urls_list,card_name,card_entity,card_number,card_expiration_date,card_security_number,contact_name,contact_lastname,business_name,emails_list,phone_numbers_list,addresses_list,postal_code,country,state,birthday,tags_list,favorite,content_key) 
VALUES ('credential','credentials company','folder','confidential credentials','micky','secret123','["facebook.com","google.com","instagram.com"]','visa debit','visa','002-5486-12542-4512','2022-05-21',1548,'miguel','aguilar paredes','banco','["miguel@gmail.com","micky@gmail.com","aguilar@gmail.com"]','["78452135","64857515"]','["av.bgalindokm8","av.villazonkm3"]',462,'bolivia','cochabamba','1994-05-21','["@banco","@bancovisa","@bancounion"]',1,'windows');
INSERT INTO sensitive_information ( type, information_name, container_name,notes,username,password,urls_list,card_name,card_entity,card_number,card_expiration_date,card_security_number,contact_name,contact_lastname,business_name,emails_list,phone_numbers_list,addresses_list,postal_code,country,state,birthday,tags_list,favorite,content_key) 
VALUES ('contact','contact of toy company','folder 2','personal contacs','oscar','oscarfuentes','["youtube.com","facebook.com"]','visa debit','visa','0321-457-845-2154','2023-10-15',5541,'oscar','fuentes vera','cafe','["oscar@gmail.com","os@hotmail.com"]','["67857421"]','["av.villazonkm1"]',120,'bolivia','cochabamba','1980-06-11','["@contact"]',0,'linux');
INSERT INTO sensitive_information ( type, information_name, container_name,notes,username,password,urls_list,card_name,card_entity,card_number,card_expiration_date,card_security_number,contact_name,contact_lastname,business_name,emails_list,phone_numbers_list,addresses_list,postal_code,country,state,birthday,tags_list,favorite,content_key) 
VALUES ('creditcard','card information','cards','personal card','ivo','surco','["twiter.com","facebook.com"]','black card','card','6254-1123-1547-5142','2021-12-01',2231,'ivo','surco guzman','internet room','["surco@gmail.com","guzman@hotmail.com"]','["77752421"]','["av.petrolera"]',5551,'bolivia','cochabamba','1993-10-11','["@card","@visa"]',1,'windows');
INSERT INTO sensitive_information ( type, information_name, container_name,notes,username,password,urls_list,card_name,card_entity,card_number,card_expiration_date,card_security_number,contact_name,contact_lastname,business_name,emails_list,phone_numbers_list,addresses_list,postal_code,country,state,birthday,tags_list,favorite,content_key) 
VALUES ('note','sensitive notes','notes','notes of passwords','romeo','medrano','["tiktok.com","facebook.com","twiter.com","whatsapp.com"]','card','visa debit','6544-0223-0007-5042','2022-12-15',3371,'romeo','garcia medrano','pool room','["romeo@gmail.com","garc@hotmail.com"]','["71765481"]','["4toanillo"]',5551,'bolivia','santa cruz','1884-10-10','["@note1","@note2","@note3"]',1,'linux');
