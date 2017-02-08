using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
namespace mvcdiappnew.Models
{
    public class actualemployee:IEmployee
    {
        mydatabaseEntities obj = new mydatabaseEntities();
        public void addemp(empmodel  e)
        {
            //emp1 ee = new emp1 { empno = e.empno, ename = e.ename };
            Mapper.CreateMap<empmodel, emp1>();
            emp1 ee = Mapper.Map<emp1>(e);
            
            obj.emp1.Add(ee);
            obj.SaveChanges();

        }
        public List<empmodel> display()
        {
            //List<empmodel> es =( obj.emp1.ToList();
            //List<empmodel> es = new List<empmodel>();

            //foreach(var e in obj.emp1)
            //{
              //  es.Add(new empmodel { empno = e.empno, ename = e.ename });
            //}
            Mapper.CreateMap<emp1, empmodel>();
            List<empmodel> es = Mapper.Map<List<empmodel>>(obj.emp1.ToList());
            return (es);
        }
    }
}