package lombok.experimentation;

import lombok.experimentation.services.LombokTestService;

public class App {

    public static void main(String[] args) {
        System.out.println(new LombokTestService().getGreeting());
    }
}
