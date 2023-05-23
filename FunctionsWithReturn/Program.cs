string[] movies = { "The Sound of Music", "The Godfather", "10 Things I Hate About You", "Titanic", "Space Jam" };
string[] drinks = { "Coca Cola", "lemonade", "milkshake", "Mountain Dew", "tea" };
string[] food = { "fries", "salad", "chicken wrap", "lasagna", "popcorn" };

string randomMovie = PickRandom(movies);
string randomDrink = PickRandom(drinks);
string randomFood = PickRandom(food);

Console.WriteLine($"I recommend you to watch {randomMovie} tonight.");
Console.WriteLine($"And also to drink {randomDrink} and eat {randomFood}.");

static string PickRandom(string[] someArray)
{
    Random rnd = new Random();
    int randomIndex = rnd.Next(0, someArray.Length);
    string randomElement = someArray[randomIndex];
    return randomElement;
}