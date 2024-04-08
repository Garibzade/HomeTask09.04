using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task08._04.Extension;

namespace Task08._04.Models
{
    internal class Student:ICodeAcademy
    {
        public static int Count=0;
		private int _id;

		public int Id
		{
			get { return _id; }
			set { _id = value; }
		}
		private string _name;

		public string Name
		{
			get;
			set; 
			
		}
		private string _surname;

		public string Surname
		{
			get;
			set;
		
			
		}

        public string CodeEmail { get ; set ; }

        public Student(string name,string surname)
        {
            Name = name.Capitalize();

            Surname = surname.Capitalize();
			Id=++Count;
			GenarateEmail();

        }
		public static bool CheckName(string name)
		{
			foreach ( char item in name)
			{
				if (char.IsLetter(item)) {  return true; }

			}
            return false;

        }
        

        public void GenarateEmail()
        {

            string emailName = $"{Surname.ToLower()}.{Name.ToLower()}{Id}@code.edu.az";
            CodeEmail = emailName;
        }
    }
}
