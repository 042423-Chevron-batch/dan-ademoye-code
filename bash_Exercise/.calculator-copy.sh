#!/bin/bash

while true; do
    read -p "Enter your score (between 0 and 100): " score

        if [[ $score -ge 0 && $score -le 100 ]] 
        then
             
            if [ $score -ge 90 ] 
            then
                grade="A"
            elif [ $score -ge 80 ]
            then
                grade="B"
            elif [ $score -ge 70 ]
            then
                grade="C"
            elif [ $score -ge 60 ]
            then
                grade="D"
            else
                grade="F"
            fi

        echo "Your grade is: $grade"
    else
        echo "Invalid score. Please enter a number between 0 and 100."
    fi

    read -p "Do you want to continue? (y/n): " answer
    case $answer in
        [yY]* ) continue;;
        [nN]* ) exit;;
        * ) echo "Invalid input. Exiting..."; exit;;
    esac
done
