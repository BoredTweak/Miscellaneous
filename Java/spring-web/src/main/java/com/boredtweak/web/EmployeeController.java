package com.boredtweak.web;

import java.util.ArrayList;
import java.util.List;

import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RestController;

@RestController
public class EmployeeController {
    EmployeeController() {
    }

    @GetMapping("/employees")
    List<Employee> all() {
        return new ArrayList<Employee>() {
            {
                add(new Employee("bob", "staff"));
            }
        };
    }
}
