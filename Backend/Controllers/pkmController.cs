using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;


[ApiController]
[Route("pkms")]
public class pkmController : ControllerBase
{
    private readonly pkmRepository _pkmRepository;

    public pkmController()
    {
        _pkmRepository = new pkmRepository();
    }

    [HttpGet]
    public IEnumerable<pkmPlusMoves> GetAllpkmsPlusMoves(int id)
    {
        return _pkmRepository.GetAll_PlusMoves();
    }

    [HttpGet("{id}")]
    public pkmPlusMoves Getpkm(int id)
    {
        return _pkmRepository.GetOne(id);
    }

    [HttpPut("{id}")]
    public pkmPlusMoves UpdatepkmMoveSet(int id, [FromBody] pkmPlusMoves pkmMoves)
    {
        // pkmMoves.pkm_Id = id;
        return _pkmRepository.Update(pkmMoves);
    }

    [HttpPost]
    public pkmPlusMoves Createpkm([FromBody] pkmPlusMoves pkmPlusMoves)
    {
        return _pkmRepository.Insert(pkmPlusMoves);
    }

    [HttpDelete("{id}")]
    public string Deletepkm(int id)
    {
        _pkmRepository.Delete(id);
        return ($"You have deleted the pokemon with Id: {id}");
    }


}

