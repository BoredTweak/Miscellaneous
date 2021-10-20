package com.boredtweak;

import java.util.Arrays;
import java.util.stream.Collectors;

import static java.util.stream.Collectors.toList;

public class PlaygroundService {
    public void Play(){
        var maxBananas = 25;
        var output = String.format("%s: %d", "The maximum number of bananas", maxBananas);
        System.out.println(output);

        PlayWithNulls(null);
        PlayWithNulls("banana");
        PlayWithConditionalAssignment(1);
        PlayWithConditionalAssignment(-1);
        PlayWithStreams();
    }

    private void PlayWithNulls(String input) {
        if(input != null){
            System.out.println(input);
        }
    }

    private void PlayWithConditionalAssignment(int input) {
        var result = 0 <= input ? "Greater Than Zero" : "Less than Zero";
        System.out.println(String.format("%d is %s", input, result));
    }

    private void PlayWithStreams() {
        String[] names = {"Lewis Carrol", "H.G. Wells", "Michael Ende"};

        // First First
        System.out.println(Arrays.stream(names).findFirst());

        // Filter
        var namesWithL = Arrays.stream(names).filter((name) -> name.contains("L")).collect(toList());
        for(String item: namesWithL){
            System.out.println(item);
        }

        // Reduce
        var charactersInNames = Arrays.stream(names).reduce(0, (subtotal, name) -> subtotal + name.length(), Integer::sum);
        System.out.println(String.format("%d characters in names", charactersInNames));
    }
}
