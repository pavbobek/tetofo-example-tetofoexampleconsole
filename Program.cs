using tetofo.EventBus.Impl;
using tetofo.Stem;
using tetofo.Stem.Impl;

namespace tetofo;

public static class Program
{
    public static void Main(string[] args)
    {
        using IStem eventPayloadLoggerStem = new EventPayloadLoggerStem();
        using IStem consoleReaderStem = new ConsoleReaderStem();
        consoleReaderStem.Subscribe(eventPayloadLoggerStem);
        consoleReaderStem.Event(new StartReadingConsoleEvent());
        while(true) {}
    }
}
