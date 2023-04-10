public class PetRepository
{
public List<Pet> ourAnimals = new List<Pet>();
    
public PetRepository(){
ourAnimals.Add(new Pet
{
    AnimalSpecies = "dog",
    AnimalID = "d1",
    AnimalAge = "2",
    AnimalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 45 pounds. housebroken.",
    AnimalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.",
    AnimalNickname = "lola",
    SuggestedDonation = 85.00m
});

ourAnimals.Add(new Pet
{
    AnimalSpecies = "dog",
    AnimalID = "d2",
    AnimalAge = "9",
    AnimalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.",
    AnimalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.",
    AnimalNickname = "gus",
    SuggestedDonation = 49.99m
});

ourAnimals.Add(new Pet
{
    AnimalSpecies = "cat",
    AnimalID = "c3",
    AnimalAge = "1",
    AnimalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.",
    AnimalPersonalityDescription = "friendly",
    AnimalNickname = "snow",
    SuggestedDonation = 40.00m
});

ourAnimals.Add(new Pet
{
    AnimalSpecies = "cat",
    AnimalID = "c4",
    AnimalAge = "",
    AnimalPhysicalDescription = "",
    AnimalPersonalityDescription = "",
    AnimalNickname = "lion",
    SuggestedDonation = 0m
});
}

}