using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EntityCodeFirst.Entities;

namespace EntityCodeFirst {
    public class Program {
         static void Main(string[] args) {
            
            using var dbContext = new AppDbContext();
            
            //dbContext.Database.Exists();
            
            var teachers = GetAllTeachersByStudent("გიორგი", dbContext);


        }
        public static Teacher[] GetAllTeachersByStudent(string studentName, AppDbContext dbContext) {
            var gstuds = dbContext.Pupils.Where(t => t.firstname.Equals(studentName)).ToList();
            var conn = new List<Connect>();
            foreach(Pupil p in gstuds) {
                conn.AddRange(dbContext.Connects.Where(t => t.stud_id == p.stud_id).ToList());
            }
            var res = new List<Teacher>();
            foreach (Connect c in conn) {
                res.AddRange(dbContext.Teachers.Where(t => t.teach_id == c.teach_id).ToList());                
            }
            return res.ToArray();
        }
    }
}