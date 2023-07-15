using System;
using System.DirectoryServices;

namespace DesbloqueioUsuariosAD
{
    class Program
    {
        static void Main(string[] args)
        {
            string domainPath = "LDAP://DC=mydomain,DC=com"; // substitua pelo caminho do seu domínio

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
                    // obtém o objeto do usuário
                    DirectoryEntry userEntry = result.GetDirectoryEntry();

                    // verifica se o usuário está bloqueado
                    if (userEntry.Properties["lockoutTime"].Value is long lockoutTime && lockoutTime != 0)
                    {
                        // modifica o atributo "lockoutTime"
                        userEntry.Properties["lockoutTime"].Value = 0;

                        // salva as alterações no Active Directory
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
