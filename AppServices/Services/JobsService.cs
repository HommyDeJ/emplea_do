﻿using System;
using System.Collections.Generic;
using System.Linq;
using Domain;

namespace AppServices.Services
{
    public class JobsService : BaseService<Job>, IJobsService
    {
        public override List<Job> GetAll()
        {
            return new List<Job>
            {
                new Job
                {
                    Id=1,
                    Title = "Trabajo de prueba",
                    Description="Esto es un lorem ipsum",
                    HowToApply="Para aplicar mandame un correo plz",

                    Company= new Company
                    {
                        Url="https://megsoftconsulting.com/",
                        LogoUrl = "https://localhost:5001/img/logo.png"
                    }
                },
                new Job
                {
                    Id=2,
                    Title = "Trabajo de prueba 2",
                    Description="Esto es un lorem ipsum",
                    HowToApply="Para aplicar mandame un correo plz",

                    Company= new Company
                    {
                        Url="https://megsoftconsulting.com/",
                        LogoUrl = "https://localhost:5001/img/logo.png"
                    }
                },
                new Job
                {
                    Id=14,
                    Title = "Trabajo de prueba 4",
                    Description="Esto es un lorem ipsum",
                    HowToApply="Para aplicar mandame un correo plz",

                    Company= new Company
                    {
                        Url="https://megsoftconsulting.com/",
                        LogoUrl = "https://localhost:5001/img/logo.png"
                    }
                },
                new Job
                {
                    Id=7,
                    Title = "Trabajo de prueba 55",
                    Description="Esto es un lorem ipsum",
                    HowToApply="Para aplicar mandame un correo plz",

                    Company= new Company
                    {
                        Url="https://megsoftconsulting.com/",
                        LogoUrl = "https://localhost:5001/img/logo.png"
                    }
                },
                new Job
                {
                    Id=16,
                    Title = "Trabajo de prueba",
                    Description="Esto es un lorem ipsum",
                    HowToApply="Para aplicar mandame un correo plz",

                    Company= new Company
                    {
                        Url="https://megsoftconsulting.com/",
                        LogoUrl = "https://localhost:5001/img/logo.png"
                    }
                },
            };
        }

         public IEnumerable<Job> GetRecentJobs()
        {
            List<Job> jobsList = new List<Job>
            {
                new Job
                {
                    Id=1,
                    Title = "No hay trabajo",
                    Description="Esta no es una descripción para un trabajo",
                    HowToApply="No apliquen por favor",

                    Company= new Company
                    {
                        Url="https://megsoftconsulting.com/",
                        LogoUrl = "https://localhost:5001/img/logo.png"
                    }
                },
                new Job
                {
                    Id=2,
                    Title = "No entienden que no hay trabajo?",
                    Description="Esto es un lorem ipsum",
                    HowToApply="Ni lo intenten",

                    Company= new Company
                    {
                        Url="https://megsoftconsulting.com/",
                        LogoUrl = "https://localhost:5001/img/logo.png"
                    }
                },
                new Job
                {
                    Id=14,
                    Title = "Trabajo de prueba 4",
                    Description="Esto es un lorem ipsum",
                    HowToApply="Para aplicar mandame un correo plz",

                    Company= new Company
                    {
                        Url="https://megsoftconsulting.com/",
                        LogoUrl = "https://localhost:5001/img/logo.png"
                    }
                }
            };

            var recentJobs = jobsList.OrderByDescending(x => x.CreatedAt).Take(10);

            return recentJobs;
        }
    }

    public interface IJobsService : IBaseService<Job>
    {
        IEnumerable<Job> GetRecentJobs();
    }
}
