using Observer_Pattern.Observers.Abstractions;

namespace Observer_Pattern.Subjects.Abstractons
{
    internal interface ISubject
    {
        void RegisterObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
        void NotifyObserver();
    }
}
