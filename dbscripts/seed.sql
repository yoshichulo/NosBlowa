\connect usersdb
CREATE TABLE user
(
 id serial PRIMARY KEY,
 username VARCHAR (16) NOT NULL,
 password VARCHAR (32) NOT NULL
);
ALTER TABLE "user" OWNER TO nosblowa;
