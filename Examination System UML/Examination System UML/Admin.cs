﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System_UML
{
    public class Admin : Instructor
    {
        #region CUD operations
        public void AddStudent(Student student)
        {
            throw new NotImplementedException();
        }

        public void AddDepartment(Department department)
        {
            throw new NotImplementedException();
        }

        public void AddQuestion(Question question)
        {
            throw new NotImplementedException();
        }

        public void AddInstructor(Instructor instructor)
        {
            throw new NotImplementedException();
        }

        public void AddCourse(Course course)
        {
            throw new NotImplementedException();
        }

        public void AddTopic(Topic topic)
        {
            throw new NotImplementedException();
        }


        public void UpdateStudent(int id, Student student)
        {
            throw new NotImplementedException();
        }

        public void UpdateDepartment(int id, Department department)
        {
            throw new NotImplementedException();
        }

        public void UpdateQuestion(int id, Question question)
        {
            throw new NotImplementedException();
        }

        public void UpdateInstructor(int id, Instructor instructor)
        {
            throw new NotImplementedException();
        }

        public void UpdateCourse(int id, Course course)
        {
            throw new NotImplementedException();
        }

        public void UpdateTopic(int id, Topic topic)
        {
            throw new NotImplementedException();
        }


        public void DeleteStudent(int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteDepartment(int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteQuestion(int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteInstructor(int id)
        {
            throw new NotImplementedException();
        }


        public void DeleteCourse(int id)
        {
            throw new NotImplementedException();
        }


        public void DeleteTopic(int id)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Assign
        public void AssignAdmin(int instructorId) 
        {
            throw new NotImplementedException(); 
        }

        public void AssignInstrucor(int instructorId, int courseId)
        {
            throw new NotImplementedException();
        }

        public void AssignStudent(int studentId, int courseId)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Reports
        public void GenerateReportInstructorCourses(int instructorId)
        {
            var instructor = Program.Instructors.Where((i) => i.Id == instructorId).SingleOrDefault();

            if(instructor != null)
                instructor.Courses.ForEach(delegate (Course course) { Console.WriteLine(course.ToString()); });

            else
                Console.WriteLine("ID doesn't exist");
        }

        public void GenerateReportCourseInstructors(int courseId)
        {
            var course = Program.Courses.Where((i) => i.Id == courseId).SingleOrDefault();

            if (course != null)
            {
                var result = Program.Instructors.Where((i) => i.Courses.Contains(course)).ToList();
                
                if(result != null)
                    result.ForEach(delegate (Instructor instructor) { Console.WriteLine(instructor.ToString()); });
                else
                    Console.WriteLine("No instructors for this course");
            }

            else
                Console.WriteLine("ID doesn't exist");
        }

        public void GenerateReportStudentCourses(int studentId)
        {
            var student = Program.Students.Where((s)=>s.Id == studentId).SingleOrDefault();

            if(student != null)
                student.Courses.ForEach(delegate (Course course) { Console.WriteLine(course.ToString()); });
            
            else
                Console.WriteLine("ID doesn't exist");
        }

        public void GenerateReportCourseStudents(int courseId)
        {
            var course = Program.Courses.Where((i) => i.Id == courseId).SingleOrDefault();

            if(course != null)
            {
                var result = Program.Students.Where((i) => i.Courses.Contains(course)).ToList();

                if (result != null)
                    result.ForEach(delegate (Student student) { Console.WriteLine(student.ToString()); });
                else
                    Console.WriteLine("No students for this course");
            }

            else
                Console.WriteLine("ID doesn't exist");
        }

        public void GenerateReportCourseTopics(int courseId)
        {
            var course = Program.Courses.Where((c)=>c.Id == courseId).SingleOrDefault();

            if(course != null) 
                course.Topics.ForEach(delegate (Topic topic) { Console.WriteLine(topic.ToString()); });
            else
                Console.WriteLine("ID doesn't exist");
        }

        public void GenerateReportStudentExamsGrades(int studentId)
        {
            var student = Program.Students.Where((s) => s.Id == studentId).SingleOrDefault();

            if (student != null)
            {
                student.Exams.ForEach(delegate (StudentExam studentExam) { Console.WriteLine(studentExam.ToString()); });
            }

            else
                Console.WriteLine("ID doesn't exist");
        }
        #endregion
    }
}