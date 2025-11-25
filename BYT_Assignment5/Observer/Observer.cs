// In case you need some guidance: https://refactoring.guru/design-patterns/observer

namespace DesignPattern.Observer
{
    public class ConcreteObserver(string userName) : IObserver
    {
        public string UserName { get; set; } = userName;

        // Step 3: Register observer with subject
        public void AddSubscriber(Subject subject)
        {
            subject.RegisterObserver(this);
        }

        // Step 4: Remove observer from the subject
        public void RemoveSubscriber(Subject subject)
        {
            subject.RemoveObserver(this);
        }

        // Step 5: Get updates from subject
        public void Update(string availability)
        {
            Console.WriteLine($"Hello {UserName}, the product you are watching is now {availability}.");
        }
    }
}
