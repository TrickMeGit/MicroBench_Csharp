using System.Diagnostics;

// add usings for bench:


class MicroBench {

    // add variables for bench:


    static void Main() {
        // set run repetitions:
        const int RUNS = 65536;

        Stopwatch clock = new Stopwatch();
        TimeSpan first;
        TimeSpan second;
        clock.Start();

        // add local variables for bench:

        int a = 0;


        clock.Start();
        for (int run = 0; run < RUNS; run++) {
            // 1st run

            a++;
            // a += 1;      // reverse test

            //bench functions:
            func1();
            // func2();     // reverse test
        }
        clock.Stop();
        first = clock.Elapsed;

        // reset bench variables:

        a = 0;


        // run garbage collector
        System.GC.Collect();
        System.GC.WaitForPendingFinalizers();

        clock.Start();
        for (int run = 0; run < RUNS; run++) {
            // 2nd run

            a += 1;
            // a++;         // reverse test

            //bench functions:
            func2();
            // func1();     // reverse test
        }
        clock.Stop();
        second = clock.Elapsed;

        // print result nanoseconds
        // Console.WriteLine("1st run: {0:N} ns", first.Ticks / (float)RUNS * 1000.0f);
        // Console.WriteLine("2nd run: {0:N} ns", second.Ticks / (float)RUNS * 1000.0f);

        // print result microseconds
        Console.WriteLine("1st run: {0:N} µs", first.Ticks / (float)RUNS);
        Console.WriteLine("2nd run: {0:N} µs", second.Ticks / (float)RUNS);

        // print result milliseconds
        // Console.WriteLine("1st run: {0:N} ms", (float)first.Ticks / (float)RUNS / 1000.0f);
        // Console.WriteLine("2nd run: {0:N} ms", (float)second.Ticks / (float)RUNS / 1000.0f);

        // print result seconds
        // Console.WriteLine("1st run: {0:N} s", first.Ticks / (float)RUNS / 1.0e6f);
        // Console.WriteLine("2nd run: {0:N} s", second.Ticks / (float)RUNS / 1.0e6f);
    }


    // add functions for bench:

    static void func1() {}      // demo function

    static void func2() {}      // demo function
}
