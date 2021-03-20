using MarcelStudy.Models;
using MarcelStudy.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarcelStudy.Application
{
    public class ContatoApplication
    {
        private ContatoRepository _contatoRepository;
        public ContatoApplication(ContatoRepository contatoRepository)
        {
            _contatoRepository = contatoRepository;
        }

        public List<Contato> Listar()
        {
            //var contatoRepository = new ContatoRepository();
            var contatos = _contatoRepository.Listar();
            return contatos;
        }

        public List<Contato> BuscarPorNome(string nome)
        {
            if (nome == string.Empty)
            {
                throw new InvalidOperationException("O nome não foi preenchido corretamente.");
            }

            var contatos = _contatoRepository.BuscarPorNome(nome);
            return contatos;
        }
    }
}
