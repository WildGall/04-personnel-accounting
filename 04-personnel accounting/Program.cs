using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_personnel_accounting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int AddDossier = 1;
            const int OutputAllDossiers = 2;
            const int DeleteDossier = 3;
            const int Exit = 4;
            bool isWorkProgram = true;
            Dictionary<string, string> dossiers = new Dictionary<string, string>();

            while (isWorkProgram)
            {
                Console.Write("\n1) Добавить досье. \n2) Вывести всё досье. \n3) Удалить Досье. \n4) Выход");
                Console.Write("\nВведите номер команды: ");
                int userInput = Convert.ToInt32(Console.ReadLine());

                switch (userInput)
                {
                    case AddDossier:
                        AddData(dossiers);
                        break;
                    case OutputAllDossiers:
                        OutputData(dossiers);
                        break;
                    case DeleteDossier:
                        DeleteData(dossiers);
                        break;
                    case Exit:
                        isWorkProgram = false;
                        break;
                }
            }
        }

        static void AddData(Dictionary<string, string> dossiers)
        {
            Console.Write("Введите ФИО: ");
            string userInputSurname = Console.ReadLine();
            Console.Write("Введите Должность: ");
            string userInputPosition = Console.ReadLine();
            dossiers.Add(userInputSurname, userInputPosition);
            Console.Write("Досье Добавлено!");
        }

        static void OutputData(Dictionary<string, string> dossiers)
        {
            foreach (var allDossiers in dossiers)
            {
                Console.WriteLine($"{allDossiers.Key} - {allDossiers.Value}");
            }
        }

        static void DeleteData(Dictionary<string, string> dossiers)
        {
            Console.Write("Введите ФИО, чтобы удалить досье:");
            string userInputDeletDossier = Console.ReadLine();

            if (dossiers.ContainsKey(userInputDeletDossier))
            {
                dossiers.Remove(userInputDeletDossier);
                Console.Write("Досье удалено");
            }
        }
    }
}
