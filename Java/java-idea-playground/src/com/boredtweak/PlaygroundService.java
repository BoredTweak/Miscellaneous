package com.boredtweak;

public class PlaygroundService {
    public void Play(){
        var maxBananas = 25;
        var output = String.format("%s: %d", "The maximum number of bananas", maxBananas);
        System.out.println(output);

        PlayWithNulls(null);
        PlayWithNulls("banana");
    }

    private void PlayWithNulls(String input) {
        if(input != null){
            System.out.println(input);
        }
    }
}
