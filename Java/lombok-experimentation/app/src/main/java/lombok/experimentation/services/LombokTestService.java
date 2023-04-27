package lombok.experimentation.services;

import lombok.experimentation.models.ConsoleMessage;

public class LombokTestService {
    public ConsoleMessage getGreeting() {
        return new ConsoleMessage("Hello, World!", 0);
    }
}