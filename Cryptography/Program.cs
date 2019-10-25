using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cryptography
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] pass = Encoding.UTF8.GetBytes("caffeinex2019");
            byte[] E = Aes256.AES_Encrypt(Encoding.UTF8.GetBytes("It's a only test! Enjoy the code."), pass);
            byte[] D = Aes256.AES_Decrypt(E, pass);
            Console.WriteLine(Encoding.UTF8.GetString(E));
            Console.WriteLine(Encoding.UTF8.GetString(D));
            Pause();
        }
        static void Pause()
        {
            Console.Write("Pressione uma tecla para continuar. . .");
            Console.ReadKey();
        }
    }
}
