
from typing import List
import numpy as np


def generate_data(fixes: List[str], n_samples=1000, seed=0) -> tuple:
    """
    Generate synthetic data for multiclass classification.
    Each sample has 3 features (symptoms) and a target label (mitigation step).

    :param n_samples: Number of samples to generate
    :param seed: Random seed for reproducibility
    :return: Tuple containing symptom features and target labels
    """

    # Symptoms (as features)
    np.random.seed(seed)
    symptom_features = np.random.rand(n_samples, 3)  # 3 symptoms per sample

    # Target Labels (mitigation steps/fixes)
    labels = np.random.choice(fixes, n_samples)
    return symptom_features, labels