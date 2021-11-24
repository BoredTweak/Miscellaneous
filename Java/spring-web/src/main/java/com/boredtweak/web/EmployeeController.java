package com.boredtweak.web;

import java.util.ArrayList;
import java.util.List;
import java.util.Set;
import java.util.concurrent.ConcurrentHashMap;

import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RestController;

@RestController
public class EmployeeController {
    private Set<Employee> _employees = ConcurrentHashMap.newKeySet();

    EmployeeController() {
    }

    @GetMapping("/employees")
    Set<Employee> all() {
        return _employees;
    }

    @PostMapping("/employees")
    Employee create(@RequestBody Employee input) {
        _employees.add(input);
        return input;
    }
}
