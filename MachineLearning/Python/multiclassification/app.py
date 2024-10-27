import numpy as np
import tensorflow as tf
from sklearn.model_selection import train_test_split
from sklearn.preprocessing import LabelEncoder, OneHotEncoder

from data.generate import generate_data


# Step 1: Generate Synthetic Data

# Encode Labels
fixes = ['restart_service', 'clear_cache', 'scale_servers', 'optimize_db', 'adjust_timeout']

symptom_features, labels = generate_data(fixes)
label_encoder = LabelEncoder()
integer_encoded_labels = label_encoder.fit_transform(labels)
onehot_encoder = OneHotEncoder(sparse_output=False)
target_labels = onehot_encoder.fit_transform(integer_encoded_labels.reshape(-1, 1))

# Step 2: Train-Test Split
X_train, X_test, y_train, y_test = train_test_split(symptom_features, target_labels, test_size=0.2, random_state=42)

# Step 3: Define the Model
model = tf.keras.models.Sequential([
    tf.keras.layers.Dense(32, input_shape=(3,), activation='relu'),
    tf.keras.layers.Dense(64, activation='relu'),
    tf.keras.layers.Dense(5, activation='softmax')
])

# Step 4: Compile the Model
model.compile(optimizer='adam', loss='categorical_crossentropy', metrics=['accuracy'])

# Step 5: Train the Model
model.fit(X_train, y_train, epochs=10, batch_size=8, validation_split=0.2)

# Step 6: Evaluate the Model
loss, accuracy = model.evaluate(X_test, y_test)
print(f"Test Accuracy: {accuracy * 100:.2f}%")

# Step 7: Predict Mitigation Step for a New Symptom Input
new_symptom = np.array([[0.2, 0.8, 0.5]])  # Example input symptoms
predicted_fix = model.predict(new_symptom)
predicted_label = label_encoder.inverse_transform([np.argmax(predicted_fix)])
print("Predicted Mitigation Step:", predicted_label[0])
