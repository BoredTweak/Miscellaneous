package com.boredtweak;

import java.util.concurrent.ExecutorService;
import java.util.concurrent.Executors;

public class Main {
    private static final int MAX_THREADS = 10;

    public static void main(String[] args) {
        // Assumption: Order of numbers in output does not matter
        // Spin up 10 threads
        var executerService = Executors.newFixedThreadPool(MAX_THREADS);

        // Each thread iterates on printing a number
        // Requirement: Number can't repeat
        // Add Thread verification
        for(int i = 0; i < 100; i++) {
            executerService.submit(printNumber(i));
        }

        executerService.shutdown();
    }

    private static Runnable printNumber(int printableNumber) {
        return () -> {
            System.out.println(Thread.currentThread().getName() + " - " + printableNumber);
        };
    }
}
