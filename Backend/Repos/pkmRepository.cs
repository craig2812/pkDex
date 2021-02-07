using System.Collections.Generic;
using Dapper;
using System;
public class pkmRepository : BaseRepository
{
    public IEnumerable<pkm> GetAll() // Working but not connected to GET Method// 
    {
        using var connection = CreateConnection();
        return connection.Query<pkm>("SELECT * FROM pkm2s;");
    }

     public IEnumerable<pkmPlusMoves> GetAll_PlusMoves() //WORKING shows pokemon and 4 moves//
    {
        using var connection = CreateConnection();
        return connection.Query<pkmPlusMoves>("SELECT * FROM pkm2s INNER JOIN pkmMoveSet ON pkm_Id = Id ORDER BY Id;");
    }


    public pkmPlusMoves GetOne(long InputId) // WORKING //
    {
        using var connection = CreateConnection();
        return connection.QuerySingle<pkmPlusMoves>("SELECT * FROM pkm2s INNER JOIN pkmMoveSet ON pkm_Id = Id WHERE Id = @ObjectId", new {ObjectId = InputId});
    }

    public pkmPlusMoves Update(pkmPlusMoves pkmMoves) //WORKING//
    {
        using var connection = CreateConnection();
        return connection.QuerySingle<pkmPlusMoves>("UPDATE pkmMoveSet SET Move1 = @Move1, Move2 = @Move2, Move3 = @Move3, Move4 = @Move4 WHERE pkm_Id = @pkm_Id; SELECT * FROM pkm2s INNER JOIN pkmMoveSet ON pkm_Id = Id WHERE Id = @Id;", pkmMoves);
        // new{Name=pkm.Name,Cat=pkm.CatchPhrase,Id=pkm.Id});
    }
    public void Delete(long id) //WORKING with deletion message//
    {
        using var connection = CreateConnection();
        connection.Execute("DELETE FROM pkmMoveSet WHERE pkm_Id = @Bob; DELETE FROM pkm2s WHERE Id = @Bob;", new { Bob = id });
        
    }

    public pkmPlusMoves Insert(pkmPlusMoves pkmPlusMoves) //WORKING??
    {
        using var connection = CreateConnection();
        return connection.QuerySingle<pkmPlusMoves>("INSERT INTO pkm2s (Name, Level, Type, Gender) VALUES (@Name,@Level,@Type,@Gender); INSERT INTO pkmMoveSet (pkm_Id, Move1, Move2, Move3, Move4) VALUES ((SELECT MAX(Id) FROM pkm2s), @Move1,@Move2,@Move3,@Move4); SELECT * FROM pkm2s INNER JOIN pkmMoveSet ON pkm_Id = Id WHERE Id = (SELECT MAX(Id) FROM pkm2s);", pkmPlusMoves);
    }

}

