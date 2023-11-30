using System;
using System.DirectoryServices;

namespace DesbloqueioUsuariosAD
{
    class Program
    {
        static void Main(string[] args)
        {
            string domainPath = "LDAP://DC=mydomain,DC=com"; 

            while (true)
            {
                Console.Write("Digite o nome de usuário a ser desbloqueado (ou digite 'sair' para encerrar o programa): ");
                string username = Console.ReadLine();

                if (username.ToLower() == "sair")
                {
                    break;
                }

                DirectoryEntry directoryEntry = new DirectoryEntry(domainPath);
                DirectorySearcher searcher = new DirectorySearcher(directoryEntry);

                searcher.Filter = $"(sAMAccountName={username})";
                searcher.PropertiesToLoad.Add("lockoutTime");
                SearchResult result = searcher.FindOne();

                if (result != null)
                {
                    DirectoryEntry userEntry = result.GetDirectoryEntry();
                    if (userEntry.Properties["lockoutTime"].Value is long lockoutTime && lockoutTime != 0)
                    {
                        userEntry.Properties["lockoutTime"].Value = 0;
                        userEntry.CommitChanges();
                        Console.WriteLine($"Usuário {username} desbloqueado com sucesso.");
                    }
                    else
                    {
                        Console.WriteLine($"Usuário {username} não está bloqueado.");
                    }
                }
                else
                {
                    Console.WriteLine($"Usuário {username} não encontrado.");
                }
            }
        }
    }
}
