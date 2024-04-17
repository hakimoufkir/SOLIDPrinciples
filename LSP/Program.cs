using LSP.Avant;

namespace LSP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DogAvant dogAvant = new DogAvant();
            BirdAvant birdAvant = new BirdAvant();

            dogAvant.Eat();
            dogAvant.Fly();
            dogAvant.Sleep();

            birdAvant.Sleep();
            birdAvant.Eat();
            birdAvant.Fly();



        }
    }
}
