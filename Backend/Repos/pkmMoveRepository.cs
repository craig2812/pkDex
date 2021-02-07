using System.Collections.Generic;
using Dapper;
using System;
public class pkmMoveRepository : BaseRepository
{

    //ALL BELOW ARE UNEDITED and copied from pkmRepository//

//     public IEnumerable<pkm> GetAll() // Working but not connected to GET Method// 
//     {
//         using var connection = CreateConnection();
//         return connection.Query<pkm>("SELECT * FROM pkm2s;");
//     }

//      public IEnumerable<pkmPlusMoves> GetAll_PlusMoves() //WORKING shows pokemon and 4 moves//
//     {
//         using var connection = CreateConnection();
//         return connection.Query<pkmPlusMoves>("SELECT * FROM pkm2s INNER JOIN pkmMoveSet ON pkm_Id = Id ORDER BY Id;");
//     }


//     public pkmPlusMoves GetOne(long InputId) // WORKING //
//     {
//         using var connection = CreateConnection();
//         return connection.QuerySingle<pkmPlusMoves>("SELECT * FROM pkm2s INNER JOIN pkmMoveSet ON pkm_Id = Id WHERE Id = @ObjectId", new {ObjectId = InputId});
//     }

//     public pkmPlusMoves Update(pkmPlusMoves pkmMoves) //WORKING//
//     {
//         using var connection = CreateConnection();
//         return connection.QuerySingle<pkmPlusMoves>("UPDATE pkmMoveSet SET Move1 = @Move1, Move2 = @Move2, Move3 = @Move3, Move4 = @Move4 WHERE pkm_Id = @pkm_Id; SELECT * FROM pkm2s INNER JOIN pkmMoveSet ON pkm_Id = Id WHERE Id = @Id;", pkmMoves);
//         // new{Name=pkm.Name,Cat=pkm.CatchPhrase,Id=pkm.Id});
//     }
//     public void Delete(long id)
//     {
//         using var connection = CreateConnection();
//         connection.Execute("DELETE FROM pkm2s WHERE Id = @Bob;", new { Bob = id });
//     }

//     public pkm Insert(pkm pkm)
//     {
//         using var connection = CreateConnection();
//         return connection.QuerySingle<pkm>("INSERT INTO pkm2s (Name, CatchPhrase) VALUES (@Name, @CatchPhrase);", pkm);
//     }

}

