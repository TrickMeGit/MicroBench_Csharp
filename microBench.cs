// using System;
using System.Diagnostics;
using static System.Console;

// set run repetitions
// const int RUNS = 65536;

class Program {

    // set run repetitions
    const int RUNS = 65536;

    static void Main() {
        Stopwatch clock = new Stopwatch();
        // start;
        // end;
        TimeSpan first;
        TimeSpan second;

        // bench setup
        int a = 0;
        // /bench setup

        // start = now();
        clock.Start();
        for (int run = 0; run < RUNS; run++) {
            // 1st run

            a++;
            // a += 1;          // reverse test

            // bench function
            // func1();
            // func2();          // reverse test

        }   // /1st run
        // end = now();
        // first = (end - start).count();
        clock.Stop();
        first = clock.Elapsed;

        // reset bench setup
        a = 0;
        // /reset bench setup

        // start = now();
        clock.Start();
        for (int run = 0; run < RUNS; run++) {
            // 2nd run

            a += 1;
            // a++;             // reverse test

            // bench function
            // func2();
            // func1();          // reverse test

        }   // /2nd run
        // end = now();
        // second = (end - start).count();
        clock.Stop();
        second = clock.Elapsed;

        // var testTYPE = first.Milliseconds;       // test


        // Console.WriteLine("");
        // WriteLine("1st run:", (float)first / (float)RUNS);
        // WriteLine("2nd run:", (float)second / (float)RUNS);


        // Console.WriteLine("1st run: {}", first.Nanoseconds / (float)RUNS);
        // Console.WriteLine("2nd run: {}", second.Nanoseconds / (float)RUNS);

        // Console.WriteLine("1st run: {}", first.Microseconds / (float)RUNS);
        // Console.WriteLine("2nd run: {}", second.Microseconds / (float)RUNS);

        WriteLine("1st run: {}", first.Milliseconds / (float)RUNS);
        WriteLine("2nd run: {}", second.Milliseconds / (float)RUNS);

        // Console.WriteLine("1st run: {}", first.Seconds / (float)RUNS);
        // Console.WriteLine("2nd run: {}", second.Seconds / (float)RUNS);
    }

    void func1() {}

    void func2() {}

}
