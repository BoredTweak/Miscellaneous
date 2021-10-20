package com.boredtweak;

public class PlaygroundService {
    public void Play(){
        var maxBananas = 25;
        var output = String.format("%s: %d", "The maximum number of bananas", maxBananas);
        System.out.println(output);

        PlayWithNulls(null);
        PlayWithNulls("banana");
        PlayWithConditionalAssignment(1);
        PlayWithConditionalAssignment(-1);
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
}
