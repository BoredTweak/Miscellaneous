from locust import HttpUser, task, constant

class FlaskAppUser(HttpUser):
    wait_time = constant(0.5)

    @task
    def retrieves_string(self):
        '''Retrieves a string from the server and asserts that it is not empty'''
        response = self.client.get("/")
        assert response.text != "", "Response text is empty"