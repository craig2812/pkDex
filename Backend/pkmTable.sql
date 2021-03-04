CREATE TABLE pkm2s (
    Id SERIAL PRIMARY KEY,
    Name TEXT,
    Level INT,
    Type TEXT,
    Gender TEXT
);

INSERT INTO
    pkm2s (Name, Level, Type, Gender)
VALUES
    ('Snom', 12, 'Ice', 'Male'),
    ('Blaziken', 50, 'Fire', 'Female'),
    ('Sceptile', 37, 'Grass', 'Male'),
    ('Hydreigon', 47, 'Dark', 'Male'),
    ('Flygon', 80, 'Ground', 'Neutral'),
    ('Corviknight', 17, 'Flying', 'Male'),
    ('Lycanroc', 11, 'Rock', 'Female'),
    ('Zoroark', 2, 'Dark', 'Female'),
    ('Decidueye', 76, 'Grass', 'Neutral'),
    ('Luxray', 67, 'Electric', 'Female'),
    ('Eevee', 45, 'Normal', 'Male'),
    ('Pikachu', 50, 'Electric', 'Male'),
    ('Chandelure', 54, 'Ghost', 'Female'),
    ('Aegislash', 31, 'Steel', 'Neutral'),
    ('Rowlet', 22, 'Flying', 'Neutral'),
    ('Lugia', 7, 'Legendary', 'Male'),
    ('Toxtricity', 69, 'Electric', 'Female'),
    ('Bulbasaur', 57, 'Grass', 'Female'),
    ('Tyranitar', 80, 'Rock', 'Male'),
    ('Dragapult', 70, 'Dragon', 'Male'),
    ('Gengar', 62, 'Ghost', 'Neutral'),
    ('Gardevoir', 52, 'Psychic', 'Female'),
    ('Rayquaza', 29, 'Legendary', 'Male'),
    ('Garchomp', 40, 'Ground', 'Female'),
    ('Sylveon', 29, 'Fairy', 'Neutral'),
    ('Umbreon', 32, 'Dark', 'Male'),
    ('Charizard', 85, 'Fire', 'Male'),
    ('Mimikyu', 91, 'Ghost', 'Female'),
    ('Lucario', 43, 'Fighting', 'Male'),
    ('Greninja', 100, 'Dark', 'Neutral');