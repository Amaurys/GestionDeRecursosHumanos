using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeRecursosHumanos.Entities
{
    class Employees
    {
        private int id;
        private string cedula;
        private string name;
        private DateTime admissionDate;
        private int idPosition;
        private int idDepartment;
        private double monthlySalary;
        private bool status;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Cedula
        {
            get
            {
                return cedula;
            }

            set
            {
                cedula = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public DateTime AdmissionDate
        {
            get
            {
                return admissionDate;
            }

            set
            {
                admissionDate = value;
            }
        }

        public int IdPosition
        {
            get
            {
                return idPosition;
            }

            set
            {
                idPosition = value;
            }
        }

        public int IdDepartment
        {
            get
            {
                return idDepartment;
            }

            set
            {
                idDepartment = value;
            }
        }

        public double MonthlySalary
        {
            get
            {
                return monthlySalary;
            }

            set
            {
                monthlySalary = value;
            }
        }

        public bool Status
        {
            get
            {
                return status;
            }

            set
            {
                status = value;
            }
        }
    }
}
