# SimpleApi

## Setup
- Clone the repo
- Start Web project
- Try with /api/students. If it can return some result, everything is ready to go!

## Team activity
- Each team has 2-3 people to complete the following requirement in 15 minutes. You have 5 minutes for design session
- Create a GET request /api/students/{studentId}/grade
- Return the following model
{
  student: Student;
  grade: {
    subject: Subject;
    value: int;
  }
  rank: RankLevels;
}

- RankLevels enum
{
  Excellent: 1, // Avg grade: 8 - 10
  Good: 2, // Avg grade: 7 - 8
  Fair: 3, // Avg grade: 5 - 7
  Weak: 4, // Avg grade: <5
}
