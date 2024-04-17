using ISP.Avant;

namespace ISP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BirdAvant bird = new BirdAvant();
            DogAvant dog = new DogAvant();

            bird.Eat();
            bird.Sleep();
            bird.Fly(); 

            dog.Eat();
            dog.Sleep();
            dog.Fly();

            // In this scenario, both BirdAvant and DogAvant classes fail to properly implement the Fly method,
            // leading to NotImplementedExceptions when attempting to call the method.
            // This violation of LSP results in unexpected behavior and undermines the substitutability of subclasses.
            // Clients relying on the IAnimalAvant interface cannot trust that all animals can fly, as indicated by the interface.
        }
    }
}
