using System;

namespace ExemploApiCatalogoJogos.Exceptions
{
    public class JogoJaCadastradoException : Exception
    {
        public JogoJaCadastradoException()
            : base("Este jogo ja está cadastrado em nosso sistema")
        { }
    }
}
