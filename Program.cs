
using System;
using Observer.Framework;
using Observer.Tradicional.Interfaces;
using ControladorEmail = Observer.Tradicional.ControladorEmail;
using UsuarioA = Observer.Tradicional.UsuarioA;
using UsuarioB = Observer.Tradicional.UsuarioB;
using UsuarioC = Observer.Tradicional.UsuarioC;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n--- MODO TRADICIONAL ---\n\n\n");
            
            ExecutarUsandoModoTradicional();

            Console.WriteLine("\n\n\n--- COM DELEGATES ---\n\n\n");

            ExecutarUsandoDelegates();

            Console.WriteLine("\n\n\n--- COM AS INTERFACES DO NET ---\n\n\n");

            ExecutarUsandoClassesDotNet();

            Console.ReadKey();
        }

        private static void ExecutarUsandoClassesDotNet()
        {
            var email = new Email();

            var controladorEmail = new Framework.ControladorEmail(email);

            Console.WriteLine("Os usuarios A, B e C cadastraram-se para receber as promoções. \n");

            var usuarioA = new Framework.UsuarioA(controladorEmail);
            var usuarioB = new Framework.UsuarioB(controladorEmail);
            var usuarioC = new Framework.UsuarioC(controladorEmail);

            Console.WriteLine("Enviando os emails para os usuários assinados (usuários cadastrados).\n");

            controladorEmail.EnviarEmail();

            Console.WriteLine("\nO usuário A resolveu cancelar a assinatura e não irá receber mais emails.\n");

            usuarioA.Dispose();

            Console.WriteLine("Enviando os emails para os usuários assinados.\n");
            controladorEmail.EnviarEmail();
        }

        private static void ExecutarUsandoDelegates()
        {
            var controlador = new Delegates.ControladorEmail();
            var usuarioA = new Delegates.UsuarioA();
            var usuarioB = new Delegates.UsuarioB();
            var usuarioC = new Delegates.UsuarioC();

            Console.WriteLine("Os usuarios A, B e C cadastraram-se para receber as promoções. \n");
            usuarioA.Assinar(controlador);
            usuarioB.Assinar(controlador);
            usuarioC.Assinar(controlador);

            Console.WriteLine("Enviando os emails para os usuarios assinados (usuários cadastrados).\n");
            controlador.EnviarEmail();

            Console.WriteLine("\nO usuário A resolveu concancelar a assinatura e não irá receber mais emails.\n");
            usuarioA.CancelarAssinatura(controlador);


            Console.WriteLine("Enviando os emails para os usuarios assinados.\n");
            controlador.EnviarEmail();
        }


        private static void ExecutarUsandoModoTradicional()
        {
            ISubject controladorEmail = new ControladorEmail();

            var usuarioA = new UsuarioA();
            var usuarioB = new UsuarioB();
            var usuarioC = new UsuarioC();

            controladorEmail.Registrar(usuarioA);
            controladorEmail.Registrar(usuarioB);
            controladorEmail.Registrar(usuarioC);

            Console.WriteLine("Os usuarios A, B e C cadastraram-se para receber as promoções. \n");

            Console.WriteLine("Enviando os emails para os usuarios assinados (usuários cadastrados).\n");

            controladorEmail.EnviarEmail();

            Console.WriteLine("\nO usuário A resolveu concancelar a assinatura e não irá receber mais emails.\n");
            controladorEmail.Remover(usuarioA);

            Console.WriteLine("Enviando os emails para os usuarios assinados.\n");
            controladorEmail.EnviarEmail();
        }
    }
}
