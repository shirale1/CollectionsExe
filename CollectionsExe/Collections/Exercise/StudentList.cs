using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CollectionsExe.Collections.Exercise.Models;

namespace CollectionsExe.Collections.Exercise
{
    //StudentList is a class represented by a List of students.

    public class University
    {

        //Targil 1 - write the Property of StudentList called Students
        #region Properties
        
        public List<Student> Students { get; set; }

        #endregion

        //Targil 2 - Write a constructor which initiates the students and calls for Student.FillList()
        #region Constructor
        public University()
        {
            Students = Student.FillList();
        }
        #endregion




        #region Find Student By Name
        //Targil 3- write a method which retrieves a Student By name. 

        public Student FindStudentByName(string name)
        {
            for(int i=0;i<Students.Count; i++)
            {
                if (Students[i].Name == name)
                {
                    return Students[i];
                }
            }
            return null;
        }
        #endregion

        #region retrieving a list
        //Targil 4-  write a method which retrieves a list of Students By Kita
        public List<Student> GetStudentsByKits(string kita)
        {
            List<Student> newlist = new List<Student>();

            for(int i = 0; i < Studdents.Count; i++)
            {
                if(Students[i].Kita == kita)
                {
                    newlist.Add(Students[i]);
                }
            }
            return newlist;
        }
        #endregion



    }
}
