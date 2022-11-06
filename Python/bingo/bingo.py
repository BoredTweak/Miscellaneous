# Bingo number generator

import os
import random
import pyttsx3

engine = pyttsx3.init()
engine.setProperty('rate', 150)
engine.setProperty('volume', 0.9)

def main():
    # Create a list of numbers already drawn
    drawn = []

    # Press enter to draw or Ctrl+C to quit
    try:
        while True:
            input("Press enter to draw a number")
            number = generate_number(drawn)
            drawn.append(number)
            # Text to speech of parsed bingo number
            bingo_number = parse_number(number)
            text_to_speech(bingo_number)
            print(bingo_number)

    except KeyboardInterrupt:
        print("\nGoodbye")

# Runs text to speech for input bingo number
def text_to_speech(bingo_number):
    engine.say(bingo_number)
    engine.runAndWait()

# Takes number and converts to bingo string
def parse_number(number):
    bingo = str(number)
    if number < 16:
        bingo = "B" + bingo
    elif number < 31:
        bingo = "I" + bingo
    elif number < 46:
        bingo = "N" + bingo
    elif number < 61:
        bingo = "G" + bingo
    if number >= 61:
        bingo = "0" + bingo
    return bingo

# A method to generate a random number that isn't in the drawn list
def generate_number(drawn):
    number = random.randint(1, 75)

    # If the drawn list is full then exit the program
    if len(drawn) == 75:
        print("All numbers have been drawn")
        exit()

    # If the number is in the drawn list, generate a new number
    while number in drawn:
        number = random.randint(1, 75)
    
    return number

# Call the main function
if(__name__ == "__main__"):
    main()
