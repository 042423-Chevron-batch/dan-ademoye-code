do {
    $score = Read-Host "Enter your score (between 0 and 100): " score
    
    if ($score -ge 0 -and $score -le 100) {
        if ($score -ge 90) {
            $grade = "A"
        }
        elseif ($score -ge 80) {
            $grade = "B"
        }
        elseif ($score -ge 70) {
            $grade = "C"
        }
        elseif ($score -ge 60) {
            $grade = "D"
        }
        else {
            $grade = "F"
        }

        Write-Host "Your grade is: $grade"
    }
    else {
        Write-Host "Invalid score. Please enter a number between 0 and 100."
    }

    $answer = Read-Host "Do you want to continue? (y/n): "
}   until ($answer.ToLower() -eq "n")
