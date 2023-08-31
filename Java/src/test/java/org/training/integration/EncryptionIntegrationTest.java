package org.training.integration;

import org.assertj.core.api.Assertions;
import org.junit.jupiter.api.Test;

public class EncryptionIntegrationTest {
    private int port = 8081;

    @Test
    public void shouldEncryptInputLetter() {

        // TODO: use REST Assured to call the server
        // - pass the correct json body
        // - read the result and use it for in your assertions
        /*
        var result = RestAssured.given()
                .contentType("application/json")
                .body(myInput)
                .when()
                .post(theUrl)
                .as(MyClass.class);
        */
        // TODO: add your assertion(s)
        // - tip: use either REST Assured or AssertJ to simplify the assertion code
        Assertions.assertThat("this test").isEqualTo("fails");
    }

    private String createURLWithPort(String uri) {
        return "http://localhost:" + port + uri;
    }
}
