package test;

import main.java.test.resources.*;
import main.java.test.core.*;
import main.java.test.health.*;

import io.dropwizard.Application;
import io.dropwizard.setup.Bootstrap;
import io.dropwizard.setup.Environment;

public class testApplication extends Application<testConfiguration> {

    public static void main(final String[] args) throws Exception {
        new testApplication().run(args);
    }

    @Override
    public String getName() {
        return "test";
    }

    @Override
    public void initialize(final Bootstrap<testConfiguration> bootstrap) {
        // TODO: application initialization
    }

    @Override
    public void run(final testConfiguration configuration,
                    final Environment environment) {
        final HelloWorldResource resource = new HelloWorldResource(
            configuration.getTemplate(),
            configuration.getDefaultName()
        );
        final TemplateHealthCheck healthCheck =
            new TemplateHealthCheck(configuration.getTemplate());
        environment.healthChecks().register("template", healthCheck);
        environment.jersey().register(resource);
    }

}
