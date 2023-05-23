string[] movies = { "The Sound of Music", "The Godfather", "10 Things I Hate About You", "Titanic", "Space Jam"};
string[] drinks = { "Coca Cola", "lemonade", "milkshake", "Mountain Dew", "tea" };
string[] food = { "fries", "salad", "chicken wrap", "lasagna", "popcorn" };

PickRandomFromArray(movies);
PickRandomFromArray(drinks);
PickRandomFromArray(food);

static void PickRandomFromArray(string[] someArray)
{
    Random rnd = new Random();
    int randomIndex = rnd.Next(0, someArray.Length);
    string randomElement = someArray[randomIndex];
    Console.WriteLine(randomElement);
}
