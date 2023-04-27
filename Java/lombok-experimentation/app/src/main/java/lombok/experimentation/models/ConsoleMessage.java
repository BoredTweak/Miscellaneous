package lombok.experimentation.models;

import lombok.Data;
import lombok.NonNull;

@Data
public class ConsoleMessage {
    @NonNull
    private final String message;

    private final int exitCode;
}
