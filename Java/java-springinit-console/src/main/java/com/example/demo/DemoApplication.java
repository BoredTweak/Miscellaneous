package com.example.demo;

import org.springframework.boot.CommandLineRunner;
import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;

@SpringBootApplication
public class DemoApplication implements CommandLineRunner {

	public static void main(String[] args) {
		SpringApplication.run(DemoApplication.class, args);
	}

    @Override
    public void run(String... args) {
        System.out.println("Executing CommandLineRunner");
 
        for (int i = 0; i < args.length; ++i) {
            System.out.println(String.format("args[%s]: %s", i, args[i]));
        }
    }
}
