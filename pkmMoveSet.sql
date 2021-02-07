CREATE TABLE pkmMoveSet (
    pkm_Id INT,
    Move1 TEXT,
    Move2 TEXT,
    Move3 TEXT,
    Move4 TEXT,
    FOREIGN KEY (pkm_Id) REFERENCES pkm2s(Id)
);

INSERT INTO
    pkmMoveSet (pkm_Id,Move1,Move2,Move3,Move4)
VALUES
    (1,'Scratch', 'FireBlast', 'IceBeam', 'Melee'),
    (2,'Scratch', 'FireBlast', 'IceBeam', 'Melee'),
    (3,'Scratch', 'FireBlast', 'IceBeam', 'Melee'),
    (4,'Scratch', 'FireBlast', 'IceBeam', 'Melee'),
    (5,'Scratch', 'FireBlast', 'IceBeam', 'Melee'),
    (6,'Scratch', 'FireBlast', 'IceBeam', 'Melee'),
    (7,'Scratch', 'FireBlast', 'IceBeam', 'Melee'),
    (8,'Scratch', 'FireBlast', 'IceBeam', 'Melee'),
    (9,'Scratch', 'FireBlast', 'IceBeam', 'Melee'),
    (10,'Scratch', 'FireBlast', 'IceBeam', 'Melee'),
    (11,'Scratch', 'FireBlast', 'IceBeam', 'Melee'),
    (12,'Scratch', 'FireBlast', 'IceBeam', 'Melee'),
    (13,'Unlucky Punch', 'FireBlast', 'IceBeam', 'Melee'),
    (14,'Scratch', 'FireBlast', 'IceBeam', 'Melee'),
    (15,'Scratch', 'FireBlast', 'IceBeam', 'Melee'),
    (16,'Scratch', 'FireBlast', 'IceBeam', 'Melee'),
    (17,'Scratch', 'FireBlast', 'IceBeam', 'Melee'),
    (18,'Scratch', 'FireBlast', 'IceBeam', 'Melee'),
    (19,'Scratch', 'FireBlast', 'IceBeam', 'Melee'),
    (20,'Scratch', 'FireBlast', 'IceBeam', 'Melee'),
    (21,'Scratch', 'FireBlast', 'IceBeam', 'Melee'),
    (22,'Scratch', 'FireBlast', 'IceBeam', 'Melee'),
    (23,'Scratch', 'FireBlast', 'IceBeam', 'Melee'),
    (24,'Scratch', 'FireBlast', 'IceBeam', 'Melee'),
    (25,'Scratch', 'FireBlast', 'IceBeam', 'Melee'),
    (26,'Scratch', 'FireBlast', 'IceBeam', 'Melee'),
    (27,'Scratch', 'FireBlast', 'IceBeam', 'Melee'),
    (28,'Scratch', 'FireBlast', 'IceBeam', 'Melee'),
    (29,'Scratch', 'FireBlast', 'IceBeam', 'Melee'),
    (30,'Scratch', 'FireBlast', 'IceBeam', 'Melee');