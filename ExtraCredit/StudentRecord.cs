using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraCredit
{
    class StudentRecord
    {
        private int quiz1 { get; set; }
        private int quiz2 { get; set; }
        private int quiz3 { get; set; }
        private int midterm { get; set; }
        private int final { get; set; }

        // constructor 
        public StudentRecord(int q1, int q2, int q3, int mt, int final)
        {
            midterm = mt;
            this.final = final;
            quiz1 = q1;
            quiz2 = q2;
            quiz3 = q3;
            midterm = mt;
        }

        // calculating the quiz grade
        public double getQuizGrade()
        {
            return ((quiz1 + quiz2 + quiz3) / 3) * 0.25;
        }

        // calculating the midterm
        public double getMidterm()
        {
            return midterm * 0.35;
        }
        // calculating the final grade
        public double getFinal()
        {
            return final * 0.4;
        }

        // the conbination all all grades
        public double finalWeightedGrade()
        {

            return getQuizGrade() + getMidterm() + getFinal();
        }

        public String letterGrade(double score)
        {
            if (score >= 90)
            {
                return "A";
            }
            else if (score < 90 && score >= 80)
            {
                return "B";
            }
            else if (score < 80 && score >= 70)
            {
                return "C";
            }
            else if (score < 70 && score >= 60)
            {
                return "D";
            }
            else
            {
                return "F";
            }

        }

        // equals method 
        public override bool Equals(object obj)
        {
            return obj is StudentRecord record &&
                   quiz1 == record.quiz1 &&
                   quiz2 == record.quiz2 &&
                   quiz3 == record.quiz3 &&
                   midterm == record.midterm &&
                   final == record.final;
        }

        // toString method 
        public override string ToString()
        {
            return "Quiz 1 " + quiz1 + " |Quiz 2 " + quiz2 + " |Quiz 3 " + quiz3 + " |Mideterm " + midterm + " |Final " + final + "\nGrade Score : " + finalWeightedGrade() + "\nLetter Grade " + letterGrade(finalWeightedGrade());
        }


    } // end of class
    
}
