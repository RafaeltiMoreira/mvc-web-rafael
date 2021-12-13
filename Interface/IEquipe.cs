using E_JOGOS.Models;
using System.Collections.Generic;

namespace E_JOGOS.Interface
{
    //Contrato da classe
    public interface IEquipe
    {
        //CREATE
        //READALL
        //UPDATE
        //DELETE

        void Create(Equipe nova_equipe);

        List<Equipe> ReadAll();

        void Update(Equipe equipe);

        void Delete(int idEquipe);
    }
}
