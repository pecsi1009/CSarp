/* -----------------------------------------------------------------------
1.We are given a school. In the school there are Classes1 of students. Each class has a set of teachers.
Each teacher teaches a set of disciplines. Students have name and unique class number. Classes have unique
text identifier. Teachers have name. Disciplines have name, number of lectures and number of exercises. Both
teachers and students are people. Students, Classes1, teachers and disciplines could have optional comments 
 (free text block).
    Your task is to identify the Classes1 (in terms of  OOP) and their attributes and operations, encapsulate
 their fields, define the class hierarchy and create a class diagram with Visual Studio.
-----------------------------------------------------------------------*/

namespace ObjectOrientedPrinciplesHome
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class School
    {
        private int classesCount;
        private string name;

        public School()
        {
            throw new System.NotImplementedException();
        }

        public int Classes
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public int ClassesCount
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public string Name
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public void AddClass()
        {
            throw new System.NotImplementedException();
        }

        public void RemoveClass()
        {
            throw new System.NotImplementedException();
        }
    }
}
