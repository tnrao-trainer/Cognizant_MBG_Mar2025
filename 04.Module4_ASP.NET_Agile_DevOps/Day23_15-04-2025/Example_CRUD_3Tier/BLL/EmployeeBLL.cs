using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;

namespace WebApplication34
{  

    public class EmployeeBLL
    {
        EmployeeDAL dal = new EmployeeDAL();

        public DataTable GetEmployees()
        {
            return dal.GetEmployees();
        }

        public void AddEmployee(int empno, string ename, string job, decimal sal, int deptno)
        {
            dal.InsertEmployee(empno, ename, job, sal, deptno);
        }

        public void ModifyEmployee(int empno, string ename, string job, decimal sal, int deptno)
        {
            dal.UpdateEmployee(empno, ename, job, sal, deptno);
        }

        public void RemoveEmployee(int empno)
        {
            dal.DeleteEmployee(empno);
        }
    }

}