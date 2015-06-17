using System;

namespace Observer.Delegates
{
    public class ControladorEmail
    {
        public Action ProcessarEmail;

        public void EnviarEmail()
        {
            ProcessarEmail();
        }
    }
}
