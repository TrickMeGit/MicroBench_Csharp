using System.Diagnostics;
using static System.Console;

class Program {

    // set run repetitions
    const int RUNS = 65536;

    static void Main() {
        Stopwatch clock = new Stopwatch();
        Funcs funcs = new Funcs();
        TimeSpan first;
        TimeSpan second;

        // bench setup

        int a = 0;

        // /bench setup

        clock.Start();
        for (int run = 0; run < RUNS; run++) {
            // 1st run

            a++;
            // a += 1;          // reverse test

            // bench function
            // funcs.func1();
            // funcs.func2();   // reverse test

        }   // /1st run
        clock.Stop();
        first = clock.Elapsed;

        // reset bench setup

        a = 0;

        // /reset bench setup

        clock.Start();
        for (int run = 0; run < RUNS; run++) {
            // 2nd run

            a += 1;
            // a++;             // reverse test

            // bench function
            // func2();
            // funcs.func2();
            // funcs.func1();   // reverse test

        }   // /2nd run
        clock.Stop();
        second = clock.Elapsed;

        // print result nanoseconds
        // WriteLine("1st run: {0:N} ns", first.Ticks / (float)RUNS * 1000.0f);
        // WriteLine("2nd run: {0:N} ns", second.Ticks / (float)RUNS * 1000.0f);

        // print result microseconds
        WriteLine("1st run: {0:N} µs", first.Ticks / (float)RUNS);
        WriteLine("2nd run: {0:N} µs", second.Ticks / (float)RUNS);

        // print result milliseconds
        // WriteLine("1st run: {0:N} ms", (float)first.Ticks / (float)RUNS / 1000.0f);
        // WriteLine("2nd run: {0:N} ms", (float)second.Ticks / (float)RUNS / 1000.0f);

        // print result seconds
        // WriteLine("1st run: {0:N} s", first.Ticks / (float)RUNS / 1.0e6f);
        // WriteLine("2nd run: {0:N} s", second.Ticks / (float)RUNS / 1.0e6f);
    }

}

class Funcs {

    public void func1() {}      // demo function

    public void func2() {}      // demo function

}
