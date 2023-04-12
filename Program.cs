using System;
using System.Threading;

class Program
{
	static void Main(string[] args)
	{
		PetRepository petRepository = new PetRepository();
		var ourAnimals = petRepository.ourAnimals;
		
		do
		{
			Console.Clear();

			Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
			Console.WriteLine(" 1. List all of our current pet information");
			Console.WriteLine(" 2. Display all dogs with a specified characteristic");
			Console.WriteLine();
			Console.WriteLine("Enter your selection number (or type Exit to exit the program)");

			string menuSelection = Console.ReadLine()?.ToLower();

			switch (menuSelection)
			{
				case "1":
				  foreach (var pet in ourAnimals)
					{
						Console.WriteLine();
						Console.WriteLine($"ID #: {pet.AnimalID}");
						Console.WriteLine($"Species: {pet.AnimalSpecies}");
						Console.WriteLine($"Age: {pet.AnimalAge}");
						Console.WriteLine($"Nickname: {pet.AnimalNickname}");
						Console.WriteLine($"Physical description: {pet.AnimalPhysicalDescription}");
						Console.WriteLine($"Personality: {pet.AnimalPersonalityDescription}");
						Console.WriteLine($"Suggested Donation: {pet.SuggestedDonation:C2}");
					}

					Console.WriteLine("\r\nPress the Enter key to continue");
					Console.ReadLine();
					break;

				case "2":
					string dogCharacteristics = "";

					while (string.IsNullOrEmpty(dogCharacteristics))
					{
						Console.WriteLine("Please enter the characteristics you are looking for in a dog:");
						dogCharacteristics = Console.ReadLine();

						if (string.IsNullOrEmpty(dogCharacteristics))
						{
							Console.WriteLine("You must enter at least one characteristic. Please try again.");
						}
					}

					string[] dogSearches = dogCharacteristics.ToLower().Split(',');
		 			string[] searchingIcons = {" |", " /", "--", " \\", " *"};
					bool foundDog = false;

					foreach (var pet in ourAnimals)
					{
						foreach (string term in dogSearches)
					{
						for (int j = 2; j > -1 ; j--)
					{
						foreach (string icon in searchingIcons)
						{
							Console.Write($"\rsearching our dog {pet.AnimalNickname} for {term.Trim()} {icon} {j.ToString()}");
							Thread.Sleep(100);
						}

						Console.Write($"\r{new String(' ', Console.BufferWidth)}");
					}
					}
						if (pet.AnimalSpecies.ToLower().Contains("dog") && CheckDogCharacteristics(pet, dogSearches))
						{
							string animalInfo = $"{pet.AnimalSpecies} | {pet.AnimalAge} | {pet.AnimalNickname} | {pet.AnimalPhysicalDescription}";
							Console.WriteLine(animalInfo);
							foundDog = true;
						}
					}

					if (!foundDog)
					{
						Console.WriteLine("No dogs found with the specified characteristics.");
					}

					Console.WriteLine("\r\nPress the Enter key to continue");
					Console.ReadLine();
					break;

				case "exit":
					return;

				default:
					Console.WriteLine("Invalid selection. Please try again.");
					Console.WriteLine("\r\nPress the Enter key to continue");
					Console.ReadLine();
					break;
			}
		} while (true);
	}

	 static bool CheckDogCharacteristics(Pet pet, string[] searchTerms)
	{
		foreach (var term in searchTerms)
		{
			if (pet.AnimalPersonalityDescription.ToLower().Contains(term.ToLower()) || pet.AnimalPhysicalDescription.ToLower().Contains(term.ToLower()))
			{
				
				return true;
			}
		}
		return false;
	}
}


  