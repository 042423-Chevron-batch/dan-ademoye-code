public static List<int> gradingStudents(List<int> grades)
    {
        // make a new list 
        List<int> grade = new List<int>(){};
        // loop through the grades
        for(int i = 0; i < grades.Count(); i++)
        {
        int multiple = grades[i];
    // if multiple is less than 38 just return grade
        if (multiple >= 38)
        {
            int diff = 5 - (multiple % 5);
            // if the difference b/t grade and multiple is less than 3 round up 
            if (diff < 3)
                grades[i] = multiple + diff;
        }
    }

    return grades;

       
    }