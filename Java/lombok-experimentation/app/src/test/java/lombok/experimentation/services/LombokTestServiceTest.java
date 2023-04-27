package lombok.experimentation.services;

import org.junit.jupiter.api.Test;
import static org.junit.jupiter.api.Assertions.*;

public class LombokTestServiceTest {
    @Test void returns_greeting() {
        // Arrange
        final var expectedMessage = "Hello, World!";
        LombokTestService classUnderTest = new LombokTestService();
        
        // Act
        final var actualMessage = classUnderTest.getGreeting().getMessage();
        
        // Assert
        assertNotNull(actualMessage, "LombokTestService should have a greeting");
        assertEquals(expectedMessage, actualMessage, "LombokTestService should have the expected greeting");
    }
    
}

