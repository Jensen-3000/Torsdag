using Logic;

namespace UI
{
    public class EFUI
    {
        private readonly PersonService _personService;

        private const ConsoleColor MenuColor = ConsoleColor.Yellow;
        private const ConsoleColor SuccessColor = ConsoleColor.Green;
        private const ConsoleColor ErrorColor = ConsoleColor.Red;
        private const ConsoleColor InfoColor = ConsoleColor.Cyan;

        private const string PromptFirstName = "Indtast personens fornavn: ";
        private const string PromptLastName = "Indtast personens efternavn: ";
        private const string PromptAge = "Indtast personens alder: ";
        private const string PromptId = "Indtast personens ID: ";

        private const string SuccessCreate = "Success! Person oprettet.";
        private const string SuccessDelete = "Success! Person er gonzo!";
        private const string NotFound = "Person ikke fundet...";
        private const string InvalidInput = "Ugyldigt input, prøv igen...";

        private const string PressToContinueMessage = "Tryk på en tast for at fortsætte...";

        public EFUI()
        {
            _personService = new PersonService();
        }

        public void Run()
        {
            while (true)
            {
                DisplayMenuOptions();

                var key = Console.ReadKey(true).KeyChar;

                Console.WriteLine();

                switch (key)
                {
                    case '1':
                        CreatePerson();
                        break;
                    case '2':
                        DeletePerson();
                        break;
                    case '3':
                        ReadPersonById();
                        break;
                    case '4':
                        ReadPersonByName();
                        break;
                    case '5':
                        ReadPersonByAge();
                        break;
                    case '6':
                        ReadAllPersons();
                        break;
                    case '0':
                        return;
                    default:
                        DisplayError(InvalidInput);
                        break;
                }
            }
        }

        private void DisplayMenuOptions()
        {
            Console.Clear();
            Console.ForegroundColor = MenuColor;

            Console.WriteLine("Vælg en mulighed:");
            Console.WriteLine("1. Opret en ny person");
            Console.WriteLine("2. Slet en person");
            Console.WriteLine("3. Vis en person via ID");
            Console.WriteLine("4. Vis en person via navn");
            Console.WriteLine("5. Vis en person via alder");
            Console.WriteLine("6. Vis alle personer");
            Console.WriteLine("0. Afslut");

            Console.ResetColor();
        }

        private void CreatePerson()
        {
            Console.Write(PromptFirstName);
            string firstName = Console.ReadLine();
            Console.Write(PromptLastName);
            string lastName = Console.ReadLine();
            int age = ReadInt(PromptAge);

            Person person = new Person { FirstName = firstName, LastName = lastName, Age = age };

            try
            {
                _personService.Create(person);
                DisplaySuccess(SuccessCreate);
            }
            catch (Exception ex)
            {
                DisplayError("Fejl ved oprettelse af person: " + ex.Message);
            }

            PressToContinue();
        }

        private void DeletePerson()
        {
            int id = ReadInt(PromptId);

            try
            {
                bool isDeleted = _personService.Delete(id);
                DisplayMessage(isDeleted ? SuccessDelete : NotFound, isDeleted ? SuccessColor : ErrorColor);
            }
            catch (Exception ex)
            {
                DisplayError("Fejl ved sletning af person: " + ex.Message);
            }

            PressToContinue();
        }

        private void ReadPersonById()
        {
            int id = ReadInt(PromptId);

            try
            {
                DisplayPerson(_personService.Read(id));
            }
            catch (Exception ex)
            {
                DisplayError("Fejl ved læsning af person: " + ex.Message);
            }

            PressToContinue();
        }

        private void ReadPersonByName()
        {
            Console.Write(PromptFirstName);
            string firstName = Console.ReadLine();
            Console.Write(PromptLastName);
            string lastName = Console.ReadLine();

            try
            {
                DisplayPerson(_personService.Read(firstName, lastName));
            }
            catch (Exception ex)
            {
                DisplayError("Fejl ved læsning af person: " + ex.Message);
            }

            PressToContinue();
        }

        private void ReadPersonByAge()
        {
            int age = ReadInt(PromptAge);

            try
            {
                DisplayPerson(_personService.ReadByAge(age));
            }
            catch (Exception ex)
            {
                DisplayError("Fejl ved læsning af person: " + ex.Message);
            }

            PressToContinue();
        }

        private void ReadAllPersons()
        {
            try
            {
                Console.ForegroundColor = InfoColor;
                var people = _personService.ReadAll();
                foreach (var person in people)
                {
                    Console.WriteLine($"ID: {person.Id}, Navn: {person.FirstName} {person.LastName}, Alder: {person.Age}");
                }
                Console.ResetColor();
            }
            catch (Exception ex)
            {
                DisplayError("Fejl ved læsning af personer: " + ex.Message);
            }

            PressToContinue();
        }

        private void DisplayPerson(Person person)
        {
            if (person != null)
            {
                Console.ForegroundColor = InfoColor;
                Console.WriteLine($"ID: {person.Id}, Navn: {person.FirstName} {person.LastName}, Alder: {person.Age}");
                Console.ResetColor();
            }
            else
            {
                DisplayError(NotFound);
            }
        }

        private int ReadInt(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();

                if (int.TryParse(input, out int result))
                {
                    return result;
                }

                DisplayError(InvalidInput);
            }
        }

        private void DisplayMessage(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        private void DisplaySuccess(string message)
        {
            DisplayMessage(message, SuccessColor);
        }

        private void DisplayError(string message)
        {
            DisplayMessage(message, ErrorColor);
        }

        private void PressToContinue()
        {
            Console.WriteLine(PressToContinueMessage);
            Console.ReadKey();
        }
    }
}
