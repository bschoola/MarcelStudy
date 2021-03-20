using MarcelStudy.Contratos.Repository;
using MarcelStudy.Models;
using MarcelStudy.Repository.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarcelStudy.Repository
{
    public class ContatoRepository : IContatoRepository
    {
        private StudyContext _contexto;
        public ContatoRepository(StudyContext contexto)
        {
            _contexto = contexto;
        }

        public List<Contato> Listar()
        {
            var contatos = _contexto.Contato.ToList();
            return contatos;
        }

        public List<Contato> BuscarPorNome(string nome)
        {
            var nomeLower = nome.ToLower();
            var contatos = _contexto.Contato
                                    //.Where(a => a.Nome == nome)
                                    .Where(a => a.Nome.ToLower().Contains(nomeLower))
                                    //.Where(a => a.Nome.StartsWith(nome))
                                    //.Where(a => a.Nome.EndsWith(nome))
                                    .ToList();
            return contatos;
        }
    }
}
