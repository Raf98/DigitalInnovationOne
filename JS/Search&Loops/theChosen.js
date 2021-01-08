class Student {
  constructor(id, grade) {
    this.id = id;
    this.grade = grade;
  }
}

let numStudents = parseInt(gets());

const students = [];
for (let i = 0; i < numStudents; ++i) {
  let line = gets().split(' ');
  let id = line[0]
  let grade = parseFloat(line[1]);

  const student = new Student(id, grade);
  students.push(student);
}


let bestStudent = students[0];
for (let i = 1; i < numStudents; ++i) {
  if (students[i].grade > bestStudent.grade) {
    bestStudent = students[i];
  }
}

if (bestStudent.grade >= 8.0) {
  console.log(bestStudent.id);
}
else {
  console.log("Minimum note not reached");
}
