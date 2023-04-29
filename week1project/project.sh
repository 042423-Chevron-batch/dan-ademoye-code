#!/bin/bash

# an array of options for the game
options=("rock" "paper" "scissors")

# function to generate a random choice for the computer
function get_computer_choice {
    computer_choice=${options[$((RANDOM % 3))]}
    echo $computer_choice
}

# function to compare the choices and determine the winner
function get_winner {
    if [[ $1 == $2 ]]; then
        echo "It's a tie!"
    elif [[ $1 == "rock" && $2 == "scissors" ]] || [[ $1 == "paper" && $2 == "rock" ]] || [[ $1 == "scissors" && $2 == "paper" ]]; then
        echo "You win!"
    else
        echo "Computer wins!"
    fi
}

# function to ask the user if they want to play again
function ask_play_again {
    read -p "Do you want to play again? (yes/no): " answer
    if [[ $answer == "yes" ]]; then
        return 0
    else
        return 1
    fi
}

# main game loop
while true; do
    echo "Let's play Rock Paper Scissors!"
    read -p "Enter your choice (rock/paper/scissors): " user_choice
    user_choice=$(echo $user_choice | tr '[:upper:]' '[:lower:]')
    
    