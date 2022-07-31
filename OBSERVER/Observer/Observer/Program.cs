
// OBSERVER ********* C#

using System;
using System.Collections.Generic;
using System.Threading;

namespace RefactoringGuru.DesignPatterns.Observer.Conceptual
{
    public interface IObserver
    {
        void Update(ISubject subject);
    }
    public interface ISubject
    {
        void Attach (IObserver observer);
        void Detach (IObserver observer);
        void Notify();
    }
}
public class Subject: ISubject
{
    public int State { get; set; } = -0;
    private List<IObserver> _observers = new List<IObserver>();
    public void
}
