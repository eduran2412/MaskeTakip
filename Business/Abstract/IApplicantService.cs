using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract 
    // interface bağlı olduğu class ların referansını tutar. parametre olarak new PersonManager veya new ForeignerManager
    // interface ler new lenemez
{
    public interface IApplicantService
    {
        void ApplyForMask(Person person);


        List<Person> GetList();

        bool CheckPerson(Person person);
        
    }
}
