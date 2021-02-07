// using System.Collections.Generic;
// using Microsoft.AspNetCore.Mvc;

// [ApiController]
// [Route("pkmMoves")]
// public class pkmMoveController : ControllerBase
// {
//     private readonly pkmRepository _pkmRepository;


// //ALL BELOW ARE UNEDITED and copied from pkmController//
//     public pkmController()
//     {
//         _pkmRepository = new pkmRepository();
//     }

//     [HttpGet]
//     public IEnumerable<pkmPlusMoves> GetAllpkmsPlusMoves(int id)
//     {
//         return _pkmRepository.GetAll_PlusMoves();
//     }

//     [HttpGet("{id}")]
//     public pkmPlusMoves Getpkm(int id)
//     {
//         return _pkmRepository.GetOne(id);
//     }

//     [HttpPut("{id}")]
//     public pkmPlusMoves UpdatepkmMoveSet(int id, [FromBody] pkmPlusMoves pkmMoves)
//     {
//         // pkmMoves.pkm_Id = id;
//         return _pkmRepository.Update(pkmMoves);
//     }

//     [HttpPost]
//     public pkm Createpkm([FromBody] pkm pkm)
//     {
//         return _pkmRepository.Insert(pkm);
//     }

//     [HttpDelete("{id}")]
//     public void Deletepkm(int id)
//     {
//         _pkmRepository.Delete(id);
//     }


// }
